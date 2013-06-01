using System.Windows.Forms;
namespace Tw.Com.Iisi.LogAnalysis
{
    partial class MyForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ConsoleBox = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ConsoleTab = new System.Windows.Forms.TabPage();
            this.ConsoleVisible = new System.Windows.Forms.CheckBox();
            this.CommandText = new System.Windows.Forms.ComboBox();
            this.ErrLevel1Tab = new System.Windows.Forms.TabPage();
            this.ErrorBoxLv1 = new System.Windows.Forms.TextBox();
            this.ErrLevel2Tab = new System.Windows.Forms.TabPage();
            this.ErrorBoxLv2 = new System.Windows.Forms.TextBox();
            this.ErrLevel3Tab = new System.Windows.Forms.TabPage();
            this.ErrorBoxLv3 = new System.Windows.Forms.TextBox();
            this.nFinishTab = new System.Windows.Forms.TabPage();
            this.NonFinishBox = new System.Windows.Forms.TextBox();
            this.InfoTab = new System.Windows.Forms.TabPage();
            this.InfoGrid = new System.Windows.Forms.DataGridView();
            this.TxnCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostAvgTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostMaxTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostMaxHappenTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etabsAvgTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etabsMaxTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtabsMaxHappenTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageTab = new System.Windows.Forms.TabPage();
            this._MessageBox = new System.Windows.Forms.TextBox();
            this.ErrorTimeLV1 = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ErrorTimeLV2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ErrorTimeLV3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tRefreshTime = new System.Windows.Forms.TextBox();
            this.NonFinishListButton = new System.Windows.Forms.Button();
            this.TestLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ConsoleTab.SuspendLayout();
            this.ErrLevel1Tab.SuspendLayout();
            this.ErrLevel2Tab.SuspendLayout();
            this.ErrLevel3Tab.SuspendLayout();
            this.nFinishTab.SuspendLayout();
            this.InfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).BeginInit();
            this.MessageTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(694, 11);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 21);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "連線";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsoleBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ConsoleBox.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ConsoleBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ConsoleBox.Location = new System.Drawing.Point(0, 0);
            this.ConsoleBox.MaxLength = 5000;
            this.ConsoleBox.Multiline = true;
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ConsoleBox.Size = new System.Drawing.Size(797, 352);
            this.ConsoleBox.TabIndex = 1;
            // 
            // IP
            // 
            this.IP.BackColor = System.Drawing.Color.White;
            this.IP.FormattingEnabled = true;
            this.IP.Items.AddRange(new object[] {
            "88.8.173.155",
            "88.8.173.165",
            "88.8.139.155"});
            this.IP.Location = new System.Drawing.Point(426, 10);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(121, 20);
            this.IP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(399, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.White;
            this.UserName.Location = new System.Drawing.Point(92, 10);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 22);
            this.UserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(213, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(286, 10);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 22);
            this.Password.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.ConsoleTab);
            this.tabControl1.Controls.Add(this.ErrLevel1Tab);
            this.tabControl1.Controls.Add(this.ErrLevel2Tab);
            this.tabControl1.Controls.Add(this.ErrLevel3Tab);
            this.tabControl1.Controls.Add(this.nFinishTab);
            this.tabControl1.Controls.Add(this.InfoTab);
            this.tabControl1.Controls.Add(this.MessageTab);
            this.tabControl1.Location = new System.Drawing.Point(11, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 407);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDoubleClick);
            // 
            // ConsoleTab
            // 
            this.ConsoleTab.BackColor = System.Drawing.Color.Transparent;
            this.ConsoleTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ConsoleTab.Controls.Add(this.ConsoleVisible);
            this.ConsoleTab.Controls.Add(this.CommandText);
            this.ConsoleTab.Controls.Add(this.ConsoleBox);
            this.ConsoleTab.Location = new System.Drawing.Point(4, 21);
            this.ConsoleTab.Name = "ConsoleTab";
            this.ConsoleTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConsoleTab.Size = new System.Drawing.Size(797, 382);
            this.ConsoleTab.TabIndex = 0;
            this.ConsoleTab.Text = "Console";
            this.ConsoleTab.UseVisualStyleBackColor = true;
            // 
            // ConsoleVisible
            // 
            this.ConsoleVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsoleVisible.AutoSize = true;
            this.ConsoleVisible.Checked = true;
            this.ConsoleVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConsoleVisible.Location = new System.Drawing.Point(733, 362);
            this.ConsoleVisible.Name = "ConsoleVisible";
            this.ConsoleVisible.Size = new System.Drawing.Size(48, 16);
            this.ConsoleVisible.TabIndex = 2;
            this.ConsoleVisible.Text = "顯示";
            this.ConsoleVisible.UseVisualStyleBackColor = true;
            this.ConsoleVisible.CheckedChanged += new System.EventHandler(this.Visible_CheckedChanged);
            // 
            // CommandText
            // 
            this.CommandText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandText.Location = new System.Drawing.Point(0, 360);
            this.CommandText.Name = "CommandText";
            this.CommandText.Size = new System.Drawing.Size(714, 20);
            this.CommandText.TabIndex = 1;
            this.CommandText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CommandText_KeyPress);
            // 
            // ErrLevel1Tab
            // 
            this.ErrLevel1Tab.BackColor = System.Drawing.Color.Red;
            this.ErrLevel1Tab.Controls.Add(this.ErrorBoxLv1);
            this.ErrLevel1Tab.Location = new System.Drawing.Point(4, 21);
            this.ErrLevel1Tab.Name = "ErrLevel1Tab";
            this.ErrLevel1Tab.Padding = new System.Windows.Forms.Padding(3);
            this.ErrLevel1Tab.Size = new System.Drawing.Size(797, 382);
            this.ErrLevel1Tab.TabIndex = 1;
            this.ErrLevel1Tab.Text = "LV 1(L)";
            this.ErrLevel1Tab.UseVisualStyleBackColor = true;
            // 
            // ErrorBoxLv1
            // 
            this.ErrorBoxLv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorBoxLv1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ErrorBoxLv1.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ErrorBoxLv1.ForeColor = System.Drawing.SystemColors.Window;
            this.ErrorBoxLv1.Location = new System.Drawing.Point(0, 0);
            this.ErrorBoxLv1.Multiline = true;
            this.ErrorBoxLv1.Name = "ErrorBoxLv1";
            this.ErrorBoxLv1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ErrorBoxLv1.Size = new System.Drawing.Size(797, 382);
            this.ErrorBoxLv1.TabIndex = 2;
            // 
            // ErrLevel2Tab
            // 
            this.ErrLevel2Tab.Controls.Add(this.ErrorBoxLv2);
            this.ErrLevel2Tab.Location = new System.Drawing.Point(4, 21);
            this.ErrLevel2Tab.Name = "ErrLevel2Tab";
            this.ErrLevel2Tab.Padding = new System.Windows.Forms.Padding(3);
            this.ErrLevel2Tab.Size = new System.Drawing.Size(797, 382);
            this.ErrLevel2Tab.TabIndex = 2;
            this.ErrLevel2Tab.Text = "LV 2(M)";
            this.ErrLevel2Tab.UseVisualStyleBackColor = true;
            // 
            // ErrorBoxLv2
            // 
            this.ErrorBoxLv2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorBoxLv2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ErrorBoxLv2.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ErrorBoxLv2.ForeColor = System.Drawing.SystemColors.Window;
            this.ErrorBoxLv2.Location = new System.Drawing.Point(0, 0);
            this.ErrorBoxLv2.Multiline = true;
            this.ErrorBoxLv2.Name = "ErrorBoxLv2";
            this.ErrorBoxLv2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ErrorBoxLv2.Size = new System.Drawing.Size(797, 382);
            this.ErrorBoxLv2.TabIndex = 3;
            // 
            // ErrLevel3Tab
            // 
            this.ErrLevel3Tab.Controls.Add(this.ErrorBoxLv3);
            this.ErrLevel3Tab.Location = new System.Drawing.Point(4, 21);
            this.ErrLevel3Tab.Name = "ErrLevel3Tab";
            this.ErrLevel3Tab.Padding = new System.Windows.Forms.Padding(3);
            this.ErrLevel3Tab.Size = new System.Drawing.Size(797, 382);
            this.ErrLevel3Tab.TabIndex = 3;
            this.ErrLevel3Tab.Text = "LV 3(H)";
            this.ErrLevel3Tab.UseVisualStyleBackColor = true;
            // 
            // ErrorBoxLv3
            // 
            this.ErrorBoxLv3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorBoxLv3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ErrorBoxLv3.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ErrorBoxLv3.ForeColor = System.Drawing.SystemColors.Window;
            this.ErrorBoxLv3.Location = new System.Drawing.Point(0, 0);
            this.ErrorBoxLv3.Multiline = true;
            this.ErrorBoxLv3.Name = "ErrorBoxLv3";
            this.ErrorBoxLv3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ErrorBoxLv3.Size = new System.Drawing.Size(797, 382);
            this.ErrorBoxLv3.TabIndex = 4;
            // 
            // nFinishTab
            // 
            this.nFinishTab.Controls.Add(this.NonFinishBox);
            this.nFinishTab.Location = new System.Drawing.Point(4, 21);
            this.nFinishTab.Name = "nFinishTab";
            this.nFinishTab.Padding = new System.Windows.Forms.Padding(3);
            this.nFinishTab.Size = new System.Drawing.Size(797, 382);
            this.nFinishTab.TabIndex = 4;
            this.nFinishTab.Text = "Non-Finish";
            this.nFinishTab.UseVisualStyleBackColor = true;
            // 
            // NonFinishBox
            // 
            this.NonFinishBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NonFinishBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NonFinishBox.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NonFinishBox.ForeColor = System.Drawing.SystemColors.Window;
            this.NonFinishBox.Location = new System.Drawing.Point(0, 0);
            this.NonFinishBox.Multiline = true;
            this.NonFinishBox.Name = "NonFinishBox";
            this.NonFinishBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.NonFinishBox.Size = new System.Drawing.Size(797, 382);
            this.NonFinishBox.TabIndex = 5;
            // 
            // InfoTab
            // 
            this.InfoTab.Controls.Add(this.InfoGrid);
            this.InfoTab.Location = new System.Drawing.Point(4, 21);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.Size = new System.Drawing.Size(797, 382);
            this.InfoTab.TabIndex = 6;
            this.InfoTab.Text = "Info";
            this.InfoTab.UseVisualStyleBackColor = true;
            // 
            // InfoGrid
            // 
            this.InfoGrid.AllowUserToAddRows = false;
            this.InfoGrid.AllowUserToDeleteRows = false;
            this.InfoGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TxnCD,
            this.HostAvgTime,
            this.HostMaxTime,
            this.HostMaxHappenTime,
            this.etabsAvgTime,
            this.etabsMaxTime,
            this.EtabsMaxHappenTime,
            this.Count});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InfoGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.InfoGrid.Location = new System.Drawing.Point(0, 0);
            this.InfoGrid.Name = "InfoGrid";
            this.InfoGrid.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.InfoGrid.RowHeadersWidth = 25;
            this.InfoGrid.RowTemplate.Height = 24;
            this.InfoGrid.Size = new System.Drawing.Size(797, 382);
            this.InfoGrid.TabIndex = 0;
            // 
            // TxnCD
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TxnCD.DefaultCellStyle = dataGridViewCellStyle2;
            this.TxnCD.FillWeight = 113.9086F;
            this.TxnCD.HeaderText = "TxnCD(SQL_ID)";
            this.TxnCD.Name = "TxnCD";
            this.TxnCD.ReadOnly = true;
            // 
            // HostAvgTime
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0.0";
            this.HostAvgTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.HostAvgTime.FillWeight = 113.9086F;
            this.HostAvgTime.HeaderText = "HostAvg(ms)";
            this.HostAvgTime.Name = "HostAvgTime";
            this.HostAvgTime.ReadOnly = true;
            // 
            // HostMaxTime
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0.0";
            this.HostMaxTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.HostMaxTime.FillWeight = 113.9086F;
            this.HostMaxTime.HeaderText = "HostMax(ms)";
            this.HostMaxTime.Name = "HostMaxTime";
            this.HostMaxTime.ReadOnly = true;
            // 
            // HostMaxHappenTime
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HostMaxHappenTime.DefaultCellStyle = dataGridViewCellStyle5;
            this.HostMaxHappenTime.HeaderText = "HostMaxTime";
            this.HostMaxHappenTime.Name = "HostMaxHappenTime";
            this.HostMaxHappenTime.ReadOnly = true;
            // 
            // etabsAvgTime
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0.0";
            this.etabsAvgTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.etabsAvgTime.FillWeight = 113.9086F;
            this.etabsAvgTime.HeaderText = "EtabsAvg(ms)";
            this.etabsAvgTime.Name = "etabsAvgTime";
            this.etabsAvgTime.ReadOnly = true;
            // 
            // etabsMaxTime
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0.0";
            this.etabsMaxTime.DefaultCellStyle = dataGridViewCellStyle7;
            this.etabsMaxTime.FillWeight = 113.9086F;
            this.etabsMaxTime.HeaderText = "EtabsMax(ms)";
            this.etabsMaxTime.Name = "etabsMaxTime";
            this.etabsMaxTime.ReadOnly = true;
            // 
            // EtabsMaxHappenTime
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.EtabsMaxHappenTime.DefaultCellStyle = dataGridViewCellStyle8;
            this.EtabsMaxHappenTime.HeaderText = "EtabsMaxTime";
            this.EtabsMaxHappenTime.Name = "EtabsMaxHappenTime";
            this.EtabsMaxHappenTime.ReadOnly = true;
            // 
            // Count
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "0.0";
            this.Count.DefaultCellStyle = dataGridViewCellStyle9;
            this.Count.FillWeight = 90F;
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // MessageTab
            // 
            this.MessageTab.Controls.Add(this._MessageBox);
            this.MessageTab.Location = new System.Drawing.Point(4, 21);
            this.MessageTab.Name = "MessageTab";
            this.MessageTab.Size = new System.Drawing.Size(797, 382);
            this.MessageTab.TabIndex = 5;
            this.MessageTab.Text = "Msg";
            this.MessageTab.UseVisualStyleBackColor = true;
            // 
            // _MessageBox
            // 
            this._MessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._MessageBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this._MessageBox.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._MessageBox.ForeColor = System.Drawing.SystemColors.Window;
            this._MessageBox.Location = new System.Drawing.Point(0, 0);
            this._MessageBox.Multiline = true;
            this._MessageBox.Name = "_MessageBox";
            this._MessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._MessageBox.Size = new System.Drawing.Size(797, 382);
            this._MessageBox.TabIndex = 6;
            // 
            // ErrorTimeLV1
            // 
            this.ErrorTimeLV1.BackColor = System.Drawing.Color.White;
            this.ErrorTimeLV1.Location = new System.Drawing.Point(81, 25);
            this.ErrorTimeLV1.MaxLength = 5;
            this.ErrorTimeLV1.Name = "ErrorTimeLV1";
            this.ErrorTimeLV1.Size = new System.Drawing.Size(44, 22);
            this.ErrorTimeLV1.TabIndex = 6;
            this.ErrorTimeLV1.Text = "15000";
            this.ErrorTimeLV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ErrorTimeLV1.Leave += new System.EventHandler(this.ImproperTime_setIime);
            // 
            // Port
            // 
            this.Port.BackColor = System.Drawing.Color.White;
            this.Port.Location = new System.Drawing.Point(625, 10);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(38, 22);
            this.Port.TabIndex = 4;
            this.Port.Text = "22";
            this.Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F);
            this.label5.Location = new System.Drawing.Point(576, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "LV 1(L)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(127, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "LV 2(M)";
            // 
            // ErrorTimeLV2
            // 
            this.ErrorTimeLV2.BackColor = System.Drawing.Color.White;
            this.ErrorTimeLV2.Location = new System.Drawing.Point(194, 25);
            this.ErrorTimeLV2.MaxLength = 5;
            this.ErrorTimeLV2.Name = "ErrorTimeLV2";
            this.ErrorTimeLV2.Size = new System.Drawing.Size(44, 22);
            this.ErrorTimeLV2.TabIndex = 13;
            this.ErrorTimeLV2.Text = "30000";
            this.ErrorTimeLV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ErrorTimeLV2.Leave += new System.EventHandler(this.ImproperTime_setIime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(240, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "LV 3(H)";
            // 
            // ErrorTimeLV3
            // 
            this.ErrorTimeLV3.BackColor = System.Drawing.Color.White;
            this.ErrorTimeLV3.Location = new System.Drawing.Point(307, 25);
            this.ErrorTimeLV3.MaxLength = 5;
            this.ErrorTimeLV3.Name = "ErrorTimeLV3";
            this.ErrorTimeLV3.Size = new System.Drawing.Size(44, 22);
            this.ErrorTimeLV3.TabIndex = 15;
            this.ErrorTimeLV3.Text = "46000";
            this.ErrorTimeLV3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ErrorTimeLV3.Leave += new System.EventHandler(this.ImproperTime_setIime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ErrorTimeLV3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ErrorTimeLV1);
            this.groupBox1.Controls.Add(this.ErrorTimeLV2);
            this.groupBox1.Location = new System.Drawing.Point(22, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 60);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "警告時間(ms)";
            // 
            // tRefreshTime
            // 
            this.tRefreshTime.BackColor = System.Drawing.Color.White;
            this.tRefreshTime.Location = new System.Drawing.Point(57, 25);
            this.tRefreshTime.Name = "tRefreshTime";
            this.tRefreshTime.Size = new System.Drawing.Size(39, 22);
            this.tRefreshTime.TabIndex = 18;
            this.tRefreshTime.Text = "60000";
            this.tRefreshTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tRefreshTime.TextChanged += new System.EventHandler(this.tRefreshTime_TextChanged);
            // 
            // NonFinishListButton
            // 
            this.NonFinishListButton.Location = new System.Drawing.Point(102, 25);
            this.NonFinishListButton.Name = "NonFinishListButton";
            this.NonFinishListButton.Size = new System.Drawing.Size(48, 23);
            this.NonFinishListButton.TabIndex = 17;
            this.NonFinishListButton.Text = "顯示";
            this.NonFinishListButton.UseVisualStyleBackColor = true;
            this.NonFinishListButton.Click += new System.EventHandler(this.NonFinishListButton_Click);
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.Location = new System.Drawing.Point(556, 14);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(14, 12);
            this.TestLabel.TabIndex = 18;
            this.TestLabel.Text = "   ";
            this.TestLabel.Click += new System.EventHandler(this.TestLabel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tRefreshTime);
            this.groupBox2.Controls.Add(this.NonFinishListButton);
            this.groupBox2.Location = new System.Drawing.Point(426, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 60);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "末完成交易更新時間(ms)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Timer";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TestLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.ConnectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyForm";
            this.Text = "LogAnalysis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.ConsoleTab.ResumeLayout(false);
            this.ConsoleTab.PerformLayout();
            this.ErrLevel1Tab.ResumeLayout(false);
            this.ErrLevel1Tab.PerformLayout();
            this.ErrLevel2Tab.ResumeLayout(false);
            this.ErrLevel2Tab.PerformLayout();
            this.ErrLevel3Tab.ResumeLayout(false);
            this.ErrLevel3Tab.PerformLayout();
            this.nFinishTab.ResumeLayout(false);
            this.nFinishTab.PerformLayout();
            this.InfoTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).EndInit();
            this.MessageTab.ResumeLayout(false);
            this.MessageTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ConnectButton;
        private TextBox ConsoleBox;
        private ComboBox IP;
        private Label label1;
        private TextBox UserName;
        private Label label2;
        private Label label3;
        private TextBox Password;
        private TabControl tabControl1;
        private TabPage ConsoleTab;
        private TabPage ErrLevel1Tab;
        private ComboBox CommandText;
        private TextBox ErrorBoxLv1;
        private TextBox ErrorTimeLV1;
        private TextBox Port;
        private Label label5;
        private TabPage ErrLevel2Tab;
        private TabPage ErrLevel3Tab;
        private TabPage nFinishTab;
        private TextBox ErrorBoxLv2;
        private Label label6;
        private Label label7;
        private TextBox ErrorTimeLV2;
        private Label label8;
        private TextBox ErrorTimeLV3;
        private TextBox ErrorBoxLv3;
        private GroupBox groupBox1;
        private Button NonFinishListButton;
        private TextBox NonFinishBox;
        private TabPage MessageTab;
        private TextBox _MessageBox;
        private Label TestLabel;
        private TabPage InfoTab;
        private DataGridView InfoGrid;
        private TextBox tRefreshTime;
        private GroupBox groupBox2;
        private Label label9;
        private DataGridViewTextBoxColumn TxnCD;
        private DataGridViewTextBoxColumn HostAvgTime;
        private DataGridViewTextBoxColumn HostMaxTime;
        private DataGridViewTextBoxColumn HostMaxHappenTime;
        private DataGridViewTextBoxColumn etabsAvgTime;
        private DataGridViewTextBoxColumn etabsMaxTime;
        private DataGridViewTextBoxColumn EtabsMaxHappenTime;
        private DataGridViewTextBoxColumn Count;
        private CheckBox ConsoleVisible;

        public TextBox errorBoxLv1 { get { return ErrorBoxLv1; } }
        public TextBox errorBoxLv2 { get { return ErrorBoxLv2; } }
        public TextBox errorBoxLv3 { get { return ErrorBoxLv3; } }
        public TextBox consoleBox { get { return ConsoleBox; } }
        public TextBox nonFinishBox { get { return NonFinishBox; } }
        public TextBox messageBox { get { return _MessageBox; } }
        public DataGridView infoGrid { get { return InfoGrid; } }
        public CheckBox consoleVisible { get { return ConsoleVisible; } }
    }
}

