using Bai01_GhiVaDocFile;
using Bai02_DocThongTinMotFileTXT;
using Bai03_DocVaGhiFileVipPro;
using Bai04_DocVaGhiFileSuDungBinaryFormatter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bai3 b3 = new bai3();
            b3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bai1 b1 = new bai1();
            b1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bai2 b2 = new bai2();
            b2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bai4 b4 = new bai4();
            b4.Show();
        }
    }
}
