namespace Bai03_DocVaGhiFileVipPro
{
    partial class bai3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtHienthi = new RichTextBox();
            btnDoc = new Button();
            btnTinh = new Button();
            btnGhi = new Button();
            SuspendLayout();
            // 
            // txtHienthi
            // 
            txtHienthi.Location = new Point(12, 13);
            txtHienthi.Margin = new Padding(3, 4, 3, 4);
            txtHienthi.Name = "txtHienthi";
            txtHienthi.Size = new Size(671, 406);
            txtHienthi.TabIndex = 0;
            txtHienthi.Text = "";
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(701, 13);
            btnDoc.Margin = new Padding(3, 4, 3, 4);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(75, 29);
            btnDoc.TabIndex = 1;
            btnDoc.Text = "Đọc";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(701, 50);
            btnTinh.Margin = new Padding(3, 4, 3, 4);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(75, 29);
            btnTinh.TabIndex = 2;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(701, 87);
            btnGhi.Margin = new Padding(3, 4, 3, 4);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(75, 29);
            btnGhi.TabIndex = 3;
            btnGhi.Text = "Ghi";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGhi);
            Controls.Add(btnTinh);
            Controls.Add(btnDoc);
            Controls.Add(txtHienthi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "bai3";
            Text = "bai3";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox txtHienthi;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnGhi;
    }
}

