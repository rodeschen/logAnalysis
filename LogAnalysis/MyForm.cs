using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Routrek.SSHC;
using Tw.Com.Iisi.Routrek.SSHC;
using System.Reflection;
using System.Diagnostics;

namespace Tw.Com.Iisi.LogAnalysis
{
    public partial class MyForm : Form
    {
        protected SSHConnectionParameter _param;
        public static SSHConnection _conn;
        private Reader reader;
        private Analysis analysis;
        private Thread analysisThread;
        private System.Windows.Forms.Timer refreshTimer;

        public MyForm()
        {
            InitializeComponent();
            reader = new Reader();
            analysis = new Analysis(reader, this);
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Tick += new EventHandler(NonFinishListButton_Click);

        }


       

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if ("".Equals(IP.Text) || "".Equals(UserName.Text) || "".Equals(Password.Text))
            {
                return;
            }
            try
            {
                try
                {
                    reader._conn.Close();
                }
                catch (Exception e1)
                {
                    _MessageBox.AppendText(e1.Message);
                }
                this.Text = IP.Text + " - LogAnalysis ";// + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion.ToString();

                reader.ip = IP.Text;
                reader.Port = Port.Text;
                reader.userName = UserName.Text;
                reader.passwordWord = Password.Text;
                reader.form = this;
                reader.consoleVisible = true;

                reader.start();
                analysis.AlertLevel1 = Convert.ToInt32(ErrorTimeLV1.Text);
                analysis.AlertLevel2 = Convert.ToInt32(ErrorTimeLV2.Text);
                analysis.AlertLevel3 = Convert.ToInt32(ErrorTimeLV3.Text);

                if (analysisThread == null  || !analysisThread.IsAlive)
                {
                    (analysisThread = new Thread(new ThreadStart(analysis.start))).Start();
                }
                FolderBrowserDialog openFolderDialog1 = new FolderBrowserDialog();
                openFolderDialog1.SelectedPath = Environment.CurrentDirectory;
                openFolderDialog1.Description = "請選擇錯誤檔案輸出資料夾";
                openFolderDialog1.ShowDialog();
                Constants.LOG_FILE_PATH = openFolderDialog1.SelectedPath;
                refreshTimer.Interval = Convert.ToInt32(tRefreshTime.Text);
                refreshTimer.Start();
                CommandText.Focus();
                
            }
            catch (Exception ec)
            {
                _MessageBox.AppendText(ec.Message);
            }
        }

        

        private void CommandText_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                if (CommandText.Text.IndexOf("tail") > -1)
                {
                    this.Text = IP.Text + " - LogAnalysis - [" + CommandText.Text + "]";
                }
                else
                {
                    //this.Text = IP.Text + " - LogAnalysis ";
                }
                byte[] sb = System.Text.Encoding.Default.GetBytes(CommandText.Text + " \n");
                reader._pf.Transmit(sb);
                addComboBoxList((ComboBox)sender, CommandText.Text);
                CommandText.SelectAll();

            }
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Cancel)))
            {
                this.Text = IP.Text + " - LogAnalysis ";
                reader._pf.Transmit(new byte[] { Convert.ToByte(Keys.Cancel) });
            }
        }


        private void addComboBoxList(ComboBox comboBox, String str)
        {
            comboBox.Items.Remove(str);
            if (str.Trim() != "")
            {
                comboBox.Items.Insert(0, str);
            }
            if (comboBox.Items.Count > 20)
            {
                comboBox.Items.RemoveAt(21);
            }
        }

        private void ImproperTime_setIime(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string id = textBox.Name;
            if (id == ErrorTimeLV1.Name)
            {
                analysis.AlertLevel1 = Convert.ToInt32(textBox.Text);
            }
            else if (id == ErrorTimeLV2.Name)
            {
                analysis.AlertLevel2 = Convert.ToInt32(textBox.Text);
            }
            else if (id == ErrorTimeLV3.Name)
            {
                analysis.AlertLevel3 = Convert.ToInt32(textBox.Text);
            }
        }

        private void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            try
            {
                if (analysisThread != null && analysisThread.ThreadState != System.Threading.ThreadState.Stopped)
                {
                    analysis.Running = false;
                    analysisThread.Join();
                }
                refreshTimer.Stop();
            }
            catch (Exception e2) { messageBox.AppendText(e2.StackTrace); }
        }


        private  void NonFinishListButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> msgPool = analysis.MsgPool;
           
            if (msgPool != null && msgPool.Count > 0)
            {
                StringBuilder poolData = new StringBuilder();
                int count = 0;
                foreach (string key in msgPool.Keys)
                {
                    poolData.Append(++count).Append(Constants.COLON_NOTATION).Append("key : ").Append(key).Append(" ------ ").Append(msgPool[key]).Append(Constants.LINE_NOTATION);
                }
                nonFinishBox.Text = poolData.ToString();
            }
            else
            {
                nonFinishBox.Clear();
            }
            if (NonFinishListButton.Equals(sender))
            {
                tabControl1.SelectTab(4);
            }
        }

        private void TestLabel_Click(object sender, EventArgs e)
        {
            StringBuilder testText = new StringBuilder();
            if (analysisThread != null)
            {
                testText.Append("Ana status: ").Append(analysisThread.ThreadState).Append(" isLive: ").Append(analysisThread.IsAlive).Append(" running: ").Append(analysis.Running).Append(Constants.LINE_NOTATION);
            }
            
            MessageBox.Show(testText.ToString());
        }

        private void tRefreshTime_TextChanged(object sender, EventArgs e)
        {
            int ii = Convert.ToInt32(((TextBox)sender).Text);
            if (ii > 0)
            {
                refreshTimer.Interval = ii;
            }
        }

        private void tabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //((TabControl)sender).SelectedTab.Dispose();
        }

        private void Visible_CheckedChanged(object sender, EventArgs e)
        {
            reader.consoleVisible = ((CheckBox)sender).Checked;
        }
    }
}
