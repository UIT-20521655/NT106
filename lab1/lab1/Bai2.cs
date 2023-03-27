using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void tx_st1_TextChanged(object sender, EventArgs e)
        {
            double n;
            if (double.TryParse(tx_st1.Text, out n))
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

        private void tx_st2_TextChanged(object sender, EventArgs e)
        {
            double n;
            if (double.TryParse(tx_st2.Text, out n))
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

        private void tx_st3_TextChanged(object sender, EventArgs e)
        {
            double n;
            if (double.TryParse(tx_st3.Text, out n))
            {
                label6.Text = "Số hợp lệ";
                label6.ForeColor = Color.Green;
            }
            else
            {
                label6.Text = "Không hợp lệ";
                label6.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Không hợp lệ" || label3.Text == "Không hợp lệ" || label6.Text == "Không hợp lệ" || tx_st1.Text == "" || tx_st2.Text == "" || tx_st3.Text == "")
            {
                MessageBox.Show("Không thể thực hiện. Hãy kiểm tra lại", "Thông báo");
                return;
            }
            double a = Convert.ToDouble(tx_st1.Text);
            double b = Convert.ToDouble(tx_st2.Text);
            double c = Convert.ToDouble(tx_st3.Text);

            if (a >= b && a >= c)
            {
                big.Text = a.ToString();
            }
            if (b >= a && b >= c)
            {
                big.Text = b.ToString();
            }
            if (c >= a && c >= b)
            {
                big.Text = c.ToString();
            }
            if (a <= b && a <= c)
            {
                small.Text = a.ToString();
            }
            if (b <= a && b <= c)
            {
                small.Text = b.ToString();
            }
            if (c <= a && c <= b)
            {
                small.Text = c.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_st1.Text = "";
            tx_st2.Text = "";
            tx_st3.Text = "";
            big.Text = "";
            small.Text = "";
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void tx_st1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tx_st2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tx_st3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void big_TextChanged(object sender, EventArgs e)
        {

        }

        private void small_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn thoát Bài 2", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }

}
