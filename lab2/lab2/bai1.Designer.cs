namespace Bai01_GhiVaDocFile
{
    partial class bai1
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
            btnDoc = new Button();
            btnGhi = new Button();
            txtHienThi = new RichTextBox();
            SuspendLayout();
            // 
            // btnDoc
            // 
            btnDoc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoc.Location = new Point(650, 16);
            btnDoc.Margin = new Padding(3, 4, 3, 4);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(117, 37);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "ĐỌC FILE";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnGhi
            // 
            btnGhi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGhi.Location = new Point(650, 61);
            btnGhi.Margin = new Padding(3, 4, 3, 4);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(117, 37);
            btnGhi.TabIndex = 1;
            btnGhi.Text = "GHI FILE";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // txtHienThi
            // 
            txtHienThi.Location = new Point(12, 13);
            txtHienThi.Margin = new Padding(3, 4, 3, 4);
            txtHienThi.Name = "txtHienThi";
            txtHienThi.Size = new Size(617, 333);
            txtHienThi.TabIndex = 2;
            txtHienThi.Text = "";
            txtHienThi.TextChanged += txtHienThi_TextChanged;
            // 
            // bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 377);
            Controls.Add(txtHienThi);
            Controls.Add(btnGhi);
            Controls.Add(btnDoc);
            Margin = new Padding(3, 4, 3, 4);
            Name = "bai1";
            Text = "bai1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.RichTextBox txtHienThi;
    }
}

