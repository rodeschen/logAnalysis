/* ---------------------------------------------------------------------------
 *
 * Copyright (c) Routrek Networks, Inc.    All Rights Reserved..
 * 
 * This file is a part of the Granados SSH Client Library that is subject to
 * the license included in the distributed package.
 * You may not use this file except in compliance with the license.
 * 
 * ---------------------------------------------------------------------------
 */
using System;
using System.Text;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

using Routrek.SSHC;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Tw.Com.Iisi.LogAnalysis;

namespace Tw.Com.Iisi.Routrek.SSHC
{

    public class Reader : ISSHConnectionEventReceiver, ISSHChannelEventReceiver
    {
        delegate void SetTextCallback(Dictionary<TextBox, StringBuilder> textTmp, TextBox textBox, string text);
        public SSHConnection _conn { set; get; }
        private Dictionary<TextBox, StringBuilder> _objTmp;
        public bool consoleVisible { set; private get; } 

        private int _port;
        public Object Port
        {
            set
            {
                _port = Convert.ToInt32(value);
            }
        }
        public String ip { set; get; }
        public String userName { set; get; }
        public String passwordWord { set; get; }
        public MyForm form { set; get; }
        private bool _needTrimANSI = false;
        public bool needTrimANSI { set { _needTrimANSI = value; } get { return _needTrimANSI; } }
        private StringBuilder _readBuffer = new StringBuilder();
        private List<string> _linePool;
        public List<string> readLine
        {
            get
            {
                int count = 0;
                if ( _linePool != null && (count = _linePool.Count) > 0)
                {
                    List<String> tLine = new List<String>(_linePool.GetRange(0, count));
                    _linePool.RemoveRange(0, count);
                    return tLine;
                }
                else
                {
                    return null;
                }
            }
        }


        public void OnData(byte[] data, int offset, int length)
        {
            string wLine = "";
            //§PÂ_¬O§_»Ý­nTrim ANSI½X
           // if (_needTrimANSI)
           // {
            //    wLine =  Regex.Replace(Encoding.GetEncoding(950).GetString(data, offset, length), "[[0-9;]*m", "");
            //}
            //else
            //{
                wLine =  Encoding.GetEncoding(950).GetString(data, offset, length);
           // }

            String[] lineData = (_readBuffer + wLine).Split('\n');
            _readBuffer.Length = 0;
            for (int i = 0; i < lineData.Length - 1; i++)
            {
                _linePool.Add(lineData[i]);
            }

            if (_linePool.Count > 2000)
            {
                _linePool.RemoveRange(0, 100);
            }


            if (lineData.Length > 0 && lineData[lineData.Length - 1] != "")
            {
                _readBuffer.Append(lineData[lineData.Length - 1]);
            }

            //©ñ¤Jµe­±
            if (consoleVisible)
            {
                SetText(_objTmp, form.consoleBox, wLine);
            }
        }
        public void OnDebugMessage(bool always_display, byte[] data)
        {
            Debug.WriteLine("DEBUG: " + Encoding.ASCII.GetString(data));
        }
        public void OnIgnoreMessage(byte[] data)
        {
            Debug.WriteLine("Ignore: " + Encoding.ASCII.GetString(data));
        }
        public void OnAuthenticationPrompt(string[] msg)
        {
            Debug.WriteLine("Auth Prompt " + msg[0]);
        }

        public void OnError(Exception error, string msg)
        {
            Debug.WriteLine("ERROR: " + msg);
        }
        public void OnChannelClosed()
        {
            Debug.WriteLine("Channel closed");
            _conn.Disconnect("");
            //_conn.AsyncReceive(this);
        }
        public void OnChannelEOF()
        {
            _pf.Close();
            Debug.WriteLine("Channel EOF");
        }
        public void OnExtendedData(int type, byte[] data)
        {
            Debug.WriteLine("EXTENDED DATA");
        }
        public void OnConnectionClosed()
        {
            Debug.WriteLine("Connection closed");
        }
        public void OnUnknownMessage(byte type, byte[] data)
        {
            Debug.WriteLine("Unknown Message " + type);
        }
        public void OnChannelReady()
        {
            // _ready = true;
        }
        public void OnChannelError(Exception error, string msg)
        {
            Debug.WriteLine("Channel ERROR: " + msg);
        }
        public void OnMiscPacket(byte type, byte[] data, int offset, int length)
        {
        }

        public PortForwardingCheckResult CheckPortForwardingRequest(string host, int port, string originator_host, int originator_port)
        {
            PortForwardingCheckResult r = new PortForwardingCheckResult();
            r.allowed = true;
            r.channel = this;
            return r;
        }
        public void EstablishPortforwarding(ISSHChannelEventReceiver rec, SSHChannel channel)
        {
            _pf = channel;
        }

        public SSHChannel _pf;



        public void start()
        {
            try
            {
                SSHConnectionParameter f = new SSHConnectionParameter();
                f.UserName = userName;

                f.Password = passwordWord;
                f.Protocol = SSHProtocol.SSH2;
                f.AuthenticationType = AuthenticationType.Password;
                f.WindowSize = 0x1000;
                _objTmp = new Dictionary<TextBox, StringBuilder>();
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //s.Blocking = false;
                s.Connect(new IPEndPoint(IPAddress.Parse(ip), _port));

                _conn = SSHConnection.Connect(f, this, s);


                this._conn = _conn;

                SSHChannel ch = _conn.OpenShell(this);
                this._pf = ch;
                _linePool = new List<string>();
                SSHConnectionInfo ci = _conn.ConnectionInfo;
            }
            catch (Exception e1)
            {
                SetText(_objTmp, form.consoleBox, e1.Message);
            }
        }

        public void sendCommand(String command)
        {
            this._pf.Transmit(System.Text.Encoding.ASCII.GetBytes(command));
        }




        private void SetText(Dictionary<TextBox, StringBuilder> textTmp, TextBox textBox, String str)
        {
            if (textBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { textTmp, textBox, str });
            }
            else
            {
                StringBuilder strb;
                if (!textTmp.ContainsKey(textBox))
                {
                    strb = new StringBuilder();
                    textTmp.Add(textBox, strb);
                }
                else
                {
                    strb = (StringBuilder)textTmp[textBox];
                }
                strb.Append(str);
                if (strb.Length > 50000)
                {
                    strb.Remove(0, 10000);
                    textBox.Text = strb.ToString();
                }
                else
                {
                    textBox.AppendText(str);
                }

                textBox.SelectionStart = textBox.Text.Length;
                textBox.ScrollToCaret();
            }

        }


    }


}
