namespace lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            baiTapToolStripMenuItem = new ToolStripMenuItem();
            bai1ToolStripMenuItem = new ToolStripMenuItem();
            bai2ToolStripMenuItem = new ToolStripMenuItem();
            bai3ToolStripMenuItem = new ToolStripMenuItem();
            bai4ToolStripMenuItem = new ToolStripMenuItem();
            bai5ToolStripMenuItem = new ToolStripMenuItem();
            sapXepToolStripMenuItem = new ToolStripMenuItem();
            arrangeToolStripMenuItem = new ToolStripMenuItem();
            arrangeToolStripMenuItem1 = new ToolStripMenuItem();
            arrangeToolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { baiTapToolStripMenuItem, sapXepToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1042, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // baiTapToolStripMenuItem
            // 
            baiTapToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bai1ToolStripMenuItem, bai2ToolStripMenuItem, bai3ToolStripMenuItem, bai4ToolStripMenuItem, bai5ToolStripMenuItem });
            baiTapToolStripMenuItem.Name = "baiTapToolStripMenuItem";
            baiTapToolStripMenuItem.Size = new Size(67, 24);
            baiTapToolStripMenuItem.Text = "BaiTap";
            // 
            // bai1ToolStripMenuItem
            // 
            bai1ToolStripMenuItem.Name = "bai1ToolStripMenuItem";
            bai1ToolStripMenuItem.Size = new Size(121, 26);
            bai1ToolStripMenuItem.Text = "Bai1";
            bai1ToolStripMenuItem.Click += bai1ToolStripMenuItem_Click;
            // 
            // bai2ToolStripMenuItem
            // 
            bai2ToolStripMenuItem.Name = "bai2ToolStripMenuItem";
            bai2ToolStripMenuItem.Size = new Size(121, 26);
            bai2ToolStripMenuItem.Text = "Bai2";
            bai2ToolStripMenuItem.Click += bai2ToolStripMenuItem_Click;
            // 
            // bai3ToolStripMenuItem
            // 
            bai3ToolStripMenuItem.Name = "bai3ToolStripMenuItem";
            bai3ToolStripMenuItem.Size = new Size(121, 26);
            bai3ToolStripMenuItem.Text = "Bai3";
            bai3ToolStripMenuItem.Click += bai3ToolStripMenuItem_Click;
            // 
            // bai4ToolStripMenuItem
            // 
            bai4ToolStripMenuItem.Name = "bai4ToolStripMenuItem";
            bai4ToolStripMenuItem.Size = new Size(121, 26);
            bai4ToolStripMenuItem.Text = "Bai4";
            bai4ToolStripMenuItem.Click += bai4ToolStripMenuItem_Click;
            // 
            // bai5ToolStripMenuItem
            // 
            bai5ToolStripMenuItem.Name = "bai5ToolStripMenuItem";
            bai5ToolStripMenuItem.Size = new Size(121, 26);
            bai5ToolStripMenuItem.Text = "Bai5";
            bai5ToolStripMenuItem.Click += bai5ToolStripMenuItem_Click;
            // 
            // sapXepToolStripMenuItem
            // 
            sapXepToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arrangeToolStripMenuItem, arrangeToolStripMenuItem1, arrangeToolStripMenuItem2 });
            sapXepToolStripMenuItem.Name = "sapXepToolStripMenuItem";
            sapXepToolStripMenuItem.Size = new Size(74, 24);
            sapXepToolStripMenuItem.Text = "SapXep";
            // 
            // arrangeToolStripMenuItem
            // 
            arrangeToolStripMenuItem.Name = "arrangeToolStripMenuItem";
            arrangeToolStripMenuItem.Size = new Size(182, 26);
            arrangeToolStripMenuItem.Text = "ArrangeIcon";
            arrangeToolStripMenuItem.Click += arrangeToolStripMenuItem_Click;
            // 
            // arrangeToolStripMenuItem1
            // 
            arrangeToolStripMenuItem1.Name = "arrangeToolStripMenuItem1";
            arrangeToolStripMenuItem1.Size = new Size(182, 26);
            arrangeToolStripMenuItem1.Text = "Cascade";
            arrangeToolStripMenuItem1.Click += arrangeToolStripMenuItem1_Click;
            // 
            // arrangeToolStripMenuItem2
            // 
            arrangeToolStripMenuItem2.Name = "arrangeToolStripMenuItem2";
            arrangeToolStripMenuItem2.Size = new Size(182, 26);
            arrangeToolStripMenuItem2.Text = "Tilehonzontal";
            arrangeToolStripMenuItem2.Click += arrangeToolStripMenuItem2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 533);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem baiTapToolStripMenuItem;
        private ToolStripMenuItem bai1ToolStripMenuItem;
        private ToolStripMenuItem bai2ToolStripMenuItem;
        private ToolStripMenuItem bai3ToolStripMenuItem;
        private ToolStripMenuItem bai4ToolStripMenuItem;
        private ToolStripMenuItem bai5ToolStripMenuItem;
        private ToolStripMenuItem sapXepToolStripMenuItem;
        private ToolStripMenuItem arrangeToolStripMenuItem;
        private ToolStripMenuItem arrangeToolStripMenuItem1;
        private ToolStripMenuItem arrangeToolStripMenuItem2;
    }
}