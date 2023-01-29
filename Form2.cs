using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Multi_Test
{
    public partial class Form2 : Form
    {
        //定义端口类
        private SerialPort ComDevice = new SerialPort();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Hide();            
            string[] setting= System.IO.File.ReadAllLines(System.Windows.Forms.Application.StartupPath + "\\setting\\setting.txt");
            TxtPowerSetting.Text = setting[0].Split(':')[1].Trim();
            TxtRelaySetting.Text = setting[1].Split(':')[1].Trim();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtPowerSetting.Text == TxtRelaySetting.Text)
            {
                MessageBox.Show("Error. COM ports can not be equal.");
                return;
            }
            string path = System.Windows.Forms.Application.StartupPath + "\\setting\\setting.txt";
            string[] setting = { "Power: " + TxtPowerSetting.Text, "Relay: " + TxtRelaySetting.Text };
            System.IO.File.WriteAllLines(path,setting);
            this.Hide();
        }
    }
}
