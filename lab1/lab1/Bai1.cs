using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lab1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            long n;
            if (long.TryParse(ST1.Text, out n))
            {
                label2.Text = "Số hợp lệ";
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = "Không hợp lệ";
                label2.ForeColor = Color.Red;
            }
        }



        private void Bai1_Load(object sender, EventArgs e)
        {

        }

        private void bt_Sum_Click(object sender, EventArgs e)
        {
            if (ST1.Text.Length == 0 || ST2.Text.Length == 0 || label2.Text == "Không hợp lệ" || label3.Text == "Không hợp lệ")
            {
                MessageBox.Show("Không có dữ liệu hoặc không đúng định dạng.", "Lỗi");
                return;
            }
            long st1 = Convert.ToInt32(ST1.Text);
            long st2 = Convert.ToInt32(ST2.Text);
            long kq = st1 + st2;
            Ketqua.Text = kq.ToString();
        }

        private void ST2_TextChanged(object sender, EventArgs e)
        {
            long n;
            if (long.TryParse(ST2.Text, out n))
            {
                label3.Text = "Số hợp lệ";
                label3.ForeColor = Color.Green;
            }
            else
            {
                label3.Text = "Không hợp lệ";
                label3.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn thoát Bài 1", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ST1.Text = "";
            ST2.Text = "";
            Ketqua.Text = "";
        }
    }
}
