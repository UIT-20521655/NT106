using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void A_TextChanged(object sender, EventArgs e)
        {
            long n;
            if (long.TryParse(A.Text, out n))
            {
                check1.Text = "Số hợp lệ";
                check1.ForeColor = Color.Green;
            }
            else
            {
                check1.Text = "Không hợp lệ";
                check1.ForeColor = Color.Red;
            }
        }

        private void B_TextChanged(object sender, EventArgs e)
        {
            long n;
            if (long.TryParse(B.Text, out n))
            {
                check2.Text = "Số hợp lệ";
                check2.ForeColor = Color.Green;
            }
            else
            {
                check2.Text = "Không hợp lệ";
                check2.ForeColor = Color.Red;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calc_Click(object sender, EventArgs e)
        {
            if (A.Text == "" || B.Text == "")
            {
                MessageBox.Show("Hãy nhập số", "Lỗi");
                return;
            }
            if (check1.Text == "Không hợp lệ" || check2.Text == "Không hợp lệ")
            {
                MessageBox.Show("Không thể tính toán", "Lỗi");
                return;
            }
            long a = Convert.ToInt32(A.Text);
            long b = Convert.ToInt32(B.Text);
            long abs_a = Math.Abs(a);
            long abs_b = Math.Abs(b);
            if (abs_a > 20 || abs_b > 20)
            {
                MessageBox.Show("Số quá lớn, không thể tính toán chính xác tất cả. Nên nhập A và B nhỏ hơn 20.", "Cảnh báo");

            }
            if (a >= 0)
            {
                label9.Text = "1 + 2 + 3 +...+ A = ";
                label12.Text = "+";
            }
            else
            {
                label9.Text = "(-1) + (-2) + (-3) +...+ A = ";
                label12.Text = "-";
            }
            if (b >= 0)
            {
                label10.Text = "1 + 2 + 3 +...+ B = ";
                label13.Text = "+";
                label11.Text = "A^1 + A^2 + A^3 +...+ A^B =";
            }
            else
            {
                label10.Text = "(-1) + (-2) + (-3) +...+ B = ";
                label13.Text = "-";
                label11.Text = "A^(-1) + A^(-2) + A^(-3) +...+ A^B";
            }

            long kq_a = 1;
            long kq_b = 1;
            for (int i = 1; i <= abs_a; i++)
            {
                kq_a = kq_a * i;
            }
            for (int i = 1; i <= abs_b; i++)
            {
                kq_b = kq_b * i;
            }

            kqA.Text = kq_a.ToString();
            kqB.Text = kq_b.ToString();
            long s1 = 0;
            long s2 = 0;
            long s3 = 0;
            if (a >= 0)
            {
                for (int i = 0; i <= a; i++)
                {
                    s1 = s1 + i;
                }
                kq_s1.Text = s1.ToString();
            }
            else
            {

                for (int i = 0; i >= a; i--)
                {
                    s1 = s1 + i;
                }
                kq_s1.Text = s1.ToString();
            }
            if (b >= 0)
            {
                for (int i = 0; i <= b; i++)
                {
                    s2 = s2 + i;
                }
                kq_s2.Text = s2.ToString();
            }
            else
            {

                for (int i = 0; i >= b; i--)
                {
                    s2 = s2 + i;
                }
                kq_s2.Text = s2.ToString();
            }
            if (b >= 0)
            {
                for (int i = 1; i <= b; i++)
                {
                    s3 = s3 + a ^ i;
                }
                kq_s3.Text = s3.ToString();
            }
            else
            {

                for (int i = -1; i >= b; i--)
                {
                    s3 = s3 + a ^ i;
                }
                kq_s3.Text = s3.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {
            A.Text = "";
            B.Text = "";
            kqA.Text = "";
            kqB.Text = "";
            kq_s1.Text = "";
            kq_s2.Text = "";
            kq_s3.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn thoát Bài 5", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
