using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04_DocVaGhiFileSuDungBinaryFormatter
{
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }
        private List<string> ds = new List<string>();
        private int vitri = 0;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(richTextBox1.Text);
            sw.Close();
            MessageBox.Show(sfd.FileName + " has been saved");
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            ds.Clear();
            vitri = 0;
            richTextBox1.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string text = sr.ReadToEnd();
            string[] lines = text.Split(Environment.NewLine.ToCharArray());
            foreach (string line in lines) richTextBox1.AppendText(line + "\n");
            fs.Close();
            string[] sinhvien = richTextBox1.Text.TrimEnd().Split("\n\n".ToCharArray());

            for (int i = 0; i < sinhvien.Length; i++)
            {
                ds.Add(sinhvien[i]);
            }

            xuat(ds, 0);
        }

        public void xuat(List<string> ds, int x)
        {
            bool check = true;
            string[] sv = ds[x].Split("\n".ToCharArray());
            for (int i = 3; i < 6; i++)

            {
                if (Convert.ToInt16(sv[i]) > 10 && Convert.ToInt16(sv[i]) < 0) check = false;

            }
            if (sv[1].Length != 8) MessageBox.Show("mssv phai co 8 chu so");
            else if (sv[2].Length != 10 && Convert.ToInt64(sv[2]) > 999999999) MessageBox.Show("sdt co 10 chu so va bat dau boi so 0");
            else if (!check) MessageBox.Show("diem sv tu 0 den 10");
            else
            {
                txtNames.Text = sv[0];
                txtIDs.Text = sv[1];
                txtPhones.Text = sv[2];
                txtCourse1s.Text = sv[3];
                txtCourse2s.Text = sv[4];
                txtCourse3s.Text = sv[5];
                txtAverages.Text = ((Convert.ToDouble(sv[3]) + Convert.ToDouble(sv[4]) + Convert.ToDouble(sv[5])) / 3).ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (vitri - 1 >= 0)
            {
                xuat(ds, vitri - 1);
                vitri--;
                txtChithi.Text = (vitri + 1).ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (vitri + 1 < ds.Count)
            {
                xuat(ds, vitri + 1);
                vitri++;
                txtChithi.Text = (vitri + 1).ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string svadd = txtName.Text + "\n" + txtID.Text + "\n" + txtPhone.Text + "\n" + txtCourse1.Text + "\n" + txtCourse2.Text + "\n" + txtCourse3.Text;
            richTextBox1.AppendText(svadd);
            ds.Add(svadd);
            txtName.Clear();
            txtID.Clear();
            txtPhone.Clear();
            txtCourse1.Clear();
            txtCourse2.Clear();
            txtCourse3.Clear();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
