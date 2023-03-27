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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Sotien_TextChanged(object sender, EventArgs e)
        {
            ulong n;
            if (ulong.TryParse(Sotien.Text, out n))
            {
                label8.Text = "Số tiền hợp lệ";
                label8.ForeColor = Color.Green;
            }
            else
            {
                label8.Text = "Số tiền không hợp lệ";
                label8.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label8.Text == "Số tiền không hợp lệ" || Sotien.Text == "")
            {
                MessageBox.Show("Không thể thực hiện. Hãy nhập đúng số tiền cần đổi", "Lỗi");
                return;
            }

            uint usd = 22772;
            uint eur = 28132;
            uint gbp = 31538;
            uint sgd = 17286;
            uint jpy = 214;
            ulong n;
            ulong a = Convert.ToUInt32(Sotien.Text);
            if (loaitien.Text == "USD")
            {
                n = a * usd;
                vnd.Text = n.ToString();
                label7.Text = "1 USD = "; label9.Text = usd.ToString();
            }
            if (loaitien.Text == "EUR")
            {
                n = a * eur;
                vnd.Text = n.ToString();
                label7.Text = "1 EUR = "; label9.Text = eur.ToString();
            }
            if (loaitien.Text == "GBP")
            {
                n = a * gbp;
                vnd.Text = n.ToString();
                label7.Text = "1 GBP = "; label9.Text = gbp.ToString();
            }
            if (loaitien.Text == "SGD")
            {
                n = a * sgd;
                vnd.Text = n.ToString();
                label7.Text = "1 SGD = "; label9.Text = sgd.ToString();
            }
            if (loaitien.Text == "JPY")
            {
                n = a * jpy;
                vnd.Text = n.ToString();
                label7.Text = "1 JPY = "; label9.Text = jpy.ToString();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn thoát Bài 4", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
