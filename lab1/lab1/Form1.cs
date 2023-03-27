namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bai1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai1 Bai1 = new Bai1();
            Bai1.MdiParent = this;
            Bai1.Show();

        }

        private void bai2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai2 Bai2 = new Bai2();
            Bai2.MdiParent = this;
            Bai2.Show();
        }

        private void bai3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai3 Bai3 = new Bai3();
            Bai3.MdiParent = this;
            Bai3.Show();
        }

        private void bai4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai4 Bai4 = new Bai4();
            Bai4.MdiParent = this;
            Bai4.Show();
        }

        private void bai5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai5 Bai5 = new Bai5();
            Bai5.MdiParent = this;
            Bai5.Show();
        }

        private void arrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void arrangeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
    }
}