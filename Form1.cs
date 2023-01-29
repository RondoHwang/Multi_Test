using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace Multi_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        string[] lines;
        Form2 f2 = new Form2();
        SerialPort powerCom = new SerialPort();
        SerialPort relayCom = new SerialPort();


        private void Form1_Load(object sender, EventArgs e)
        {
            BtnSelect.PerformClick();
            try
            {
                string[] setting = System.IO.File.ReadAllLines(System.Windows.Forms.Application.StartupPath + "\\setting\\setting.txt");
                string[] powerSetting = setting[0].Split(':')[1].Trim().Split(',');
                powerCom.PortName = powerSetting[0].Trim();
                powerCom.BaudRate = Convert.ToInt32(powerSetting[1].Trim());
                powerCom.DataBits = Convert.ToInt32(powerSetting[2].Trim());
                powerCom.StopBits = (StopBits)Convert.ToInt32(powerSetting[3].Trim());
                powerCom.Parity = (Parity)Convert.ToInt32(powerSetting[4].Trim()=="NONE"?"0": powerSetting[4].Trim());
                string[] relaySetting = setting[1].Split(':')[1].Trim().Split(',');
                relayCom.PortName = relaySetting[0].Trim();
                relayCom.BaudRate = Convert.ToInt32(relaySetting[1].Trim());
                relayCom.DataBits = Convert.ToInt32(relaySetting[2].Trim());
                relayCom.StopBits = (StopBits)Convert.ToInt32(relaySetting[3].Trim());
                relayCom.Parity = (Parity)Convert.ToInt32(relaySetting[4].Trim() == "NONE" ? "0" : powerSetting[4].Trim());

                //打开串口
                powerCom.Open();
                relayCom.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "未能成功开启串口", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            powerCom.DataReceived += new SerialDataReceivedEventHandler(PowerCom_DataReceived);
            relayCom.DataReceived += new SerialDataReceivedEventHandler(RelayCom_DataReceived);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter="test file(*.txt)|*.txt"
            };
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LblModel.Text = openFileDialog.SafeFileName;
                lines = System.IO.File.ReadAllLines(openFileDialog.FileName);
                foreach (string line in lines)
                {
                    if (line.IndexOf('#') != 0)
                    {
                        LstStep.Items.Add(line);
                    }                    
                }
                LstStep.SelectedIndex = 0;
                BtnStart.Focus();
            }

        }

        private void LstStep_SelectedIndexChanged(object sender, EventArgs e)
        {            
            int index = LstStep.SelectedIndex;
            
            string[] selectedArray = LstStep.Text.Split('&');
            LblStep.Text = selectedArray[0].Split('#')[1];
            TxtShow.Text = "";
            PicShow.Image = null;
            BtnStart.Enabled = true;
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
           
            f2.Hide();
            //f2.ShowDialog();
            f2.Show();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            BtnStart.Enabled = false;
            BtnPass.Enabled = false;
            string[] selectedArray = LstStep.Text.Split('&');
            TxtShow.Text = selectedArray[1];
            string imgPath = System.Windows.Forms.Application.StartupPath + "\\img\\" + selectedArray[0].Split(' ')[0] + ".jpg";
            PicShow.Image = new Bitmap(imgPath);
            string sourceCode = selectedArray[2].Trim();
            string[] relayCommand = selectedArray[3].Split(';');
            int delayTime = Convert.ToInt32(selectedArray[4]);
            Send_Data(powerCom, "01 57 11 00 00 00 00 69", "byte");  //power off
            Thread.Sleep(200);
            Send_Data(relayCom, "$ALL OFF;", "");    //relay all off
            Thread.Sleep(200);
            Send_Data(powerCom, sourceCode, "byte");
            Thread.Sleep(200);
            foreach (string command in relayCommand)
            {
                Send_Data(relayCom, command+';', "");  //relay action
                Thread.Sleep(200);
            }
            Thread.Sleep(delayTime);
            Send_Data(powerCom, "01 57 11 03 00 00 00 6C", "byte");  //power on

            BtnPass.Enabled = true;
            BtnPass.Focus();
        }

        private void BtnPass_Click(object sender, EventArgs e)
        {
            if(LstStep.SelectedIndex == LstStep.Items.Count - 1)
            {
                MessageBox.Show("PASS");
                LstStep.SelectedIndex = 0;
                TxtReceived.Text = "";
                return;
            }
            LstStep.SelectedIndex++;
            BtnStart.PerformClick();
        }

        private void BtnRetry_Click(object sender, EventArgs e)
        {
            BtnStart.PerformClick();
            BtnPass.Focus();
        }

        private void BtnAbort_Click(object sender, EventArgs e)
        {
            LstStep.SelectedIndex = 0;
            //Power and Relay 初始化
            Send_Data(relayCom, "$ALL OFF;", "");
            Thread.Sleep(500);
            Send_Data(powerCom, "01 57 11 00 00 00 00 69", "byte");
            BtnStart.Enabled = true;
            BtnStart.Focus();
        }

        /// <summary>
        /// 串口发送数据
        /// </summary>
        /// <param name="comDevice">串口 SerialPort</param>
        /// <param name="data">要发送的数据</param>
        /// <param name="type">发送数据的格式</param>
        /// <returns></returns>
        private Boolean Send_Data(SerialPort comDevice, string data, string type) 
        {
            byte[] sendData = null;
            if (type == "byte")
            {
                sendData = StrToHexByte(data);
            }
            else
            {
                sendData = Encoding.ASCII.GetBytes(data);
            }
            if (comDevice.IsOpen)
            {
                try
                {
                    comDevice.Write(sendData, 0, sendData.Length);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "发送失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("串口未开启", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        /// <summary>
        /// 16进制编码
        /// </summary>
        /// <param name="hexStr"></param>
        /// <returns></returns>
        private byte[] StrToHexByte(string hexStr)
        {
            hexStr = hexStr.Replace(" ", "");
            if (hexStr.Length % 2 != 0) hexStr += " ";
            byte[] returnBytes = new byte[hexStr.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
            {
                returnBytes[i] = Convert.ToByte(hexStr.Substring(i * 2, 2).Replace(" ", ""), 16);
            }
            return returnBytes;
        }


        /// <summary>
        /// 当powerCom.DataReceived事件发生时，就将从串口接收到的数据显示到接收端窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PowerCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //开辟接收缓冲区
            byte[] reDatas = new byte[powerCom.BytesToRead];
            //从串口读取数据
            powerCom.Read(reDatas, 0, reDatas.Length);
            //实现数据的解码与显示            
            AddContent("power: "+new ASCIIEncoding().GetString(reDatas));
        }

        private void RelayCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //开辟接收缓冲区
            byte[] reDatas = new byte[relayCom.BytesToRead];
            //从串口读取数据
            relayCom.Read(reDatas, 0, reDatas.Length);
            //实现数据的解码与显示            
            AddContent("relay: "+new ASCIIEncoding().GetString(reDatas));
        }


        /// <summary>
        /// 接收端对话框显示信息
        /// </summary>
        /// <param name="content"></param>
        private void AddContent(string content)
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                TxtReceived.AppendText(content);
            }));
        }

    }
}
