using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.IO;
using Tw.Com.Iisi.Routrek.SSHC;
using System.Runtime.CompilerServices;

namespace Tw.Com.Iisi.LogAnalysis
{


    public class Analysis
    {
        delegate void SetTextCallback(Dictionary<TextBox, StringBuilder> textTmp, TextBox textBox, string text);
        delegate void AddRowCallback(DataGridView grid, Dictionary<string, DataGridViewRow> rowTmp, string input, double servCost, double hostCost,string time);


        private MyForm _form;
        private Reader _reader;
        public Dictionary<string, DataGridViewRow> DataPool { get; private set; }
        private Dictionary<string, string> msgPool;
        public Dictionary<string, string> MsgPool { get {
            return (Dictionary<string, string>)dictionaryAction(msgPool, "getAll", null, null);
        }}
        private Dictionary<String, TextWriter> logIOPool;
        private Dictionary<TextBox, StringBuilder> objTmp;

        public int AlertLevel1 { set; get; }
        public int AlertLevel2 { set; get; }
        public int AlertLevel3 { set; get; }
        public bool Running { set; get; }



        public Analysis(Reader reader, MyForm form)
        {
            this._form = form;
            this._reader = reader;
            msgPool =  new Dictionary<string, string>();
            DataPool = new Dictionary<string, DataGridViewRow>();
            logIOPool = new Dictionary<String, TextWriter>();
            objTmp = new Dictionary<TextBox, StringBuilder>();
        }
        private void startAnalysis()
        {
            while (Running)
            {
                List<string> tLine;
                string line = "";
                try
                {
                    tLine = _reader.readLine;
                    if (tLine != null)
                    {
                        for (int i = 0; i < tLine.Count; i++)
                        {
                            line = tLine[i];
                            string sid = Regex.Match(line, Constants.REG_GET_SID).Value;
                            //因結束標籤與資料同一行則先判斷是否為最後行再判斷資料
                            if (line.LastIndexOf(Constants.REG_SESSION_END_KEY) > 0)
                            {
                                if (!(bool)dictionaryAction(msgPool, "remove", sid, line))
                                {
                                    SetText(null, _form.messageBox, "remove Error sid=" + sid + " line=" + line);
                                }
                                GroupCollection regGroup = Regex.Match(line, Constants.REGEX).Groups;
                                string input = regGroup["input"].Value;
                                string time = regGroup["time"].Value;
                                double srvCost = 0.0;
                                try
                                {
                                    string tmp;
                                    if ((tmp = regGroup["srvCost"].Value) != "")
                                    {
                                        srvCost = Convert.ToDouble(tmp);
                                    }
                                }
                                catch (Exception e1) { }
                                double hostCost = 0.0;
                                try
                                {
                                    //hostCost = Convert.ToDouble(Regex.Match(line, Constants.REG_GET_HOST_COST).Value);
                                    string tmp;
                                    if ((tmp = regGroup["hostCost"].Value) != "")
                                    {
                                        hostCost = Convert.ToDouble(tmp);
                                    }
                                }
                                catch (Exception e1) { }
                                if (srvCost > AlertLevel1)
                                {
                                    TextBox tmpTextBox = null;
                                    if (srvCost > AlertLevel3)
                                    {
                                        tmpTextBox = _form.errorBoxLv3;
                                    }
                                    else if (srvCost > AlertLevel2)
                                    {
                                        tmpTextBox = _form.errorBoxLv2;
                                    }
                                    else
                                    {
                                        tmpTextBox = _form.errorBoxLv1;
                                    }
                                    SetText(objTmp, tmpTextBox, line);
                                    writterLog(tmpTextBox.Name, line);
                                }
                                computeData(_form.infoGrid, DataPool, input, srvCost, hostCost, time);
                                
                            }//keep start session
                            else if (sid != null && sid != "")
                            {
                                dictionaryAction(msgPool, "add", sid, line);
                                //if (!MsgPool.ContainsKey(sid))
                                //{
                               //     MsgPool.Add(sid, line);
                               // }
                                //else
                                //{
                                //    MsgPool[sid] = line;
                               // }
                            }
                            else
                            {
                                SetText(objTmp, _form.messageBox, line);
                            }
                        }
                       
                    }
                    else
                    {
                        Thread.Sleep(500);
                    }
                }
                catch (Exception e)
                {
                    // MessageBox.Show(e.StackTrace);
                    SetText(objTmp, _form.messageBox, e.StackTrace);
                    if (_reader == null)
                    {
                        Running = false;
                    }
                }
            }
            //關閉資料流
            if (logIOPool != null)
            {
                foreach (String key in logIOPool.Keys)
                {
                    logIOPool[key].Close();
                }
            }
        }
        
        [MethodImpl(MethodImplOptions.Synchronized)]
        private object dictionaryAction(Dictionary<string, string> dic, string action, string sid, string line)
        {
            if (action == "remove")
            {
                return dic.Remove(sid);
            }
            else if (action == "getAll")
            {
                return new Dictionary<string, string>(dic);
            }
            else if (action == "add")
            {
                if (!dic.ContainsKey(sid))
                {
                    dic.Add(sid, line);
                }
                else
                {
                    dic[sid] = line;
                }
            }
            return null;
        }

        public void start()
        {
            Running = true;
            startAnalysis();

        }

        private void writterLog(String fileName, String line)
        {
            TextWriter tw;
            if (logIOPool.ContainsKey(fileName))
            {
                tw = logIOPool[fileName];
            }
            else
            {
                tw = new StreamWriter(Constants.LOG_FILE_PATH + @"\" + fileName + ".txt", true);
                logIOPool.Add(fileName, tw);
            }
            tw.WriteLine(line);
            tw.Flush();

        }
        

        private void computeData(DataGridView grid, Dictionary<string, DataGridViewRow> dataPool, string input, double servCost, double hostCost, string time)
        {
            if (_form.infoGrid.InvokeRequired)
            {
                AddRowCallback d = new AddRowCallback(computeData);
                _form.Invoke(d, new object[] { grid, dataPool, input, servCost, hostCost,time });
            }
            else
            {

                DataGridViewRow row;
                if (dataPool.ContainsKey(input))
                {
                    row = dataPool[input];
                }
                else
                {
                    row = grid.Rows[grid.Rows.Add(new object[] { input, (double)0.0, hostCost, hostCost != 0.0?time:"", (double)0.0, servCost, time, (double)0.0 })];
                    dataPool.Add(input, row);
                    
                }
                double count = (double)row.Cells[7].Value;
                double newCount = count + 1;

                double hostAvg = (double)row.Cells[1].Value;
                double newHostAvg = ((count / (newCount)) * hostAvg) + (hostCost / (newCount));
                double hostMaxCost = (double)row.Cells[2].Value;
                string hostMaxCostTime = (string)row.Cells[3].Value;

                double servAvg = (double)row.Cells[4].Value;
                double newServAvg = ((count / (newCount)) * servAvg) + (servCost / (newCount));
                double servMaxCost = (double)row.Cells[5].Value;
                string servMaxCostTime = (string)row.Cells[6].Value;

                if (hostCost > hostMaxCost)
                {
                    hostMaxCost = hostCost;
                    hostMaxCostTime = time;
                }

                if (servCost > servMaxCost)
                {
                    servMaxCost = servCost;
                    servMaxCostTime = time;
                }


                row.SetValues(new object[] { input, newHostAvg, hostMaxCost, hostMaxCostTime, newServAvg, servMaxCost, servMaxCostTime, newCount });

            }
        }

        private void SetText(Dictionary<TextBox, StringBuilder> textTmp, TextBox textBox, String str)
        {
            if (textBox.InvokeRequired)
            {
                _form.Invoke(new SetTextCallback(SetText), new object[] { textTmp, textBox, str });
            }
            else
            {

                StringBuilder strb;
                if (textTmp != null)
                {
                    if (!textTmp.ContainsKey(textBox))
                    {
                        strb = new StringBuilder();
                        textTmp.Add(textBox, strb);
                    }
                    else
                    {
                        strb = textTmp[textBox];
                    }
                    strb.Append(str).Append(Constants.LINE_NOTATION);
                    if (strb.Length > 50000)
                    {
                        strb.Remove(0, 10000);
                        textBox.Text = strb.ToString();
                    }
                    else
                    {
                        textBox.AppendText(str);
                        textBox.AppendText(Constants.LINE_NOTATION);
                    }
                }
                else
                {
                    textBox.AppendText(str);
                    textBox.AppendText(Constants.LINE_NOTATION);
                }

                textBox.SelectionStart = textBox.Text.Length;
                textBox.ScrollToCaret();
            }

        }
    }
}
