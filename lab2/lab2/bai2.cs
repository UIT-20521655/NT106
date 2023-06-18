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

namespace Bai02_DocThongTinMotFileTXT
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtHienthi.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            FileInfo filename = new FileInfo(ofd.FileName);

            txtFilename.Text = filename.Name;
            txtSize.Text = filename.Length + " bytes";
            txtUrl.Text = filename.FullName;

            string text = sr.ReadToEnd();
            string[] lines = text.Split(Environment.NewLine.ToCharArray());
            foreach (string line in lines) txtHienthi.AppendText(line);
            txtLine.Text = lines.Length.ToString();

            string[] word = text.Split(" ".ToCharArray());
            txtWords.Text = word.Length.ToString();

            int count = 0;
            foreach (char c in text) count++;
            txtCharacter.Text = count.ToString();
            fs.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng chương trình", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
