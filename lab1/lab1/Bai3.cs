using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }
        private void nhapso_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(nhapso.Text) != true)
            {
                MessageBox.Show("Kí tự không hợp lệ. Xin hãy nhập lại.", "Message");
                nhapso.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nhapso.Text == "")
            {
                MessageBox.Show("Chỉ có thể đọc các số từ 0 đến 9.", "Message");
                return;
            }
            int a = Convert.ToInt32(nhapso.Text);
            if (a < 0 || a > 9)
            {
                MessageBox.Show("Chỉ có thể đọc các số từ 0 đến 9.", "Message");
                nhapso.Text = "";
            }
            switch (a)
            {
                case 1:
                    kq.Text = "Một";
                    break;

                case 2:
                    kq.Text = "Hai";
                    break;
                case 3:
                    kq.Text = "Ba";
                    break;
                case 4:
                    kq.Text = "Bốn";
                    break;
                case 5:
                    kq.Text = "Năm";
                    break;
                case 0:
                    kq.Text = "Không";
                    break;
                case 6:
                    kq.Text = "Sáu";
                    break;
                case 7:
                    kq.Text = "Bảy";
                    break;
                case 8:
                    kq.Text = "Tám";
                    break;
                case 9:
                    kq.Text = "Chín";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nhapso.Text = "";
            kq.Text = "";
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn thoát Bài 3", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}