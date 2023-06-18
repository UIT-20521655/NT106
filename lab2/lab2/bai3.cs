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

namespace Bai03_DocVaGhiFileVipPro
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }
        private List<string> listPhanTu = new List<string>();
        bool chosefile = false;

        private void btnDoc_Click(object sender, EventArgs e)
        {
            chosefile = true;
            txtHienthi.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string text = sr.ReadToEnd();
            string[] lines = text.Split(Environment.NewLine.ToCharArray());
            foreach (string line in lines) txtHienthi.AppendText(line + "\n");
            fs.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (!chosefile) MessageBox.Show("Bạn vui lòng chọn file trước");
            else
            {
                string[] bieuthuc = txtHienthi.Text.TrimEnd().Split("\n".ToCharArray());
                txtHienthi.Clear();
                foreach (string bt in bieuthuc)
                {
                    txtHienthi.AppendText(bt);

                    string[] phantu = bt.Split(' ');
                    for (int i = 0; i < phantu.Length; i++)
                    {
                        listPhanTu.Add(phantu[i]);
                    }
                    Tinh1(0);
                    txtHienthi.AppendText(" = " + listPhanTu[0].ToString() + "\n");
                    listPhanTu.Clear();
                }
                chosefile = false;
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(txtHienthi.Text);
            sw.Close();
            MessageBox.Show(sfd.FileName + " has been saved");
        }
        public void Tinh1(int x)
        {

            for (int i = x; i < listPhanTu.Count; i++)
            {
                if (listPhanTu[i] == "(")
                {
                    for (int j = i + 1; j < listPhanTu.Count; j++)
                    {
                        if (listPhanTu[j] == "(")
                        {
                            Tinh1(j + 1);
                        }
                        if (listPhanTu[j] == ")")
                        {
                            listPhanTu.RemoveAt(i);
                            listPhanTu.RemoveAt(j - 1);
                            Tinh2(i, j - 1);
                            if (x != 0) return;
                        }
                    }
                }
            }
            Tinh2(0, listPhanTu.Count);
        }

        public void Tinh2(int x, int y)
        {


            int z = y;
            for (int i = x; i < z; i++)
            {
                if (listPhanTu[i] == "*")
                {
                    listPhanTu.Insert(i - 1, (Convert.ToDouble(listPhanTu[i - 1]) * Convert.ToDouble(listPhanTu[i + 1])).ToString());
                    listPhanTu.RemoveRange(i, 3);
                    z -= 2;
                    i = x;
                }

                if (listPhanTu[i] == "/")
                {
                    listPhanTu.Insert(i - 1, (Convert.ToDouble(listPhanTu[i - 1]) / Convert.ToDouble(listPhanTu[i + 1])).ToString());
                    listPhanTu.RemoveRange(i, 3);
                    z -= 2;
                    i = x;
                }
            }

            for (int i = x; i < z; i++)
            {
                if (listPhanTu[i] == "+")
                {
                    listPhanTu.Insert(i - 1, (Convert.ToDouble(listPhanTu[i - 1]) + Convert.ToDouble(listPhanTu[i + 1])).ToString());
                    listPhanTu.RemoveRange(i, 3);
                    z -= 2;
                    i = x;
                }
                if (listPhanTu[i] == "-")
                {
                    listPhanTu.Insert(i - 1, (Convert.ToDouble(listPhanTu[i - 1]) - Convert.ToDouble(listPhanTu[i + 1])).ToString());
                    listPhanTu.RemoveRange(i, 3);
                    z -= 2;
                    i = x;
                }
            }
        }



    }
}



