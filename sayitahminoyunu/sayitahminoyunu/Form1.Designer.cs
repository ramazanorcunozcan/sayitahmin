namespace sayitahminoyunu
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
            lblBilgi = new Label();
            txtTahmin = new TextBox();
            btnTahmin = new Button();
            btnYeniOyun = new Button();
            flpGecmis = new FlowLayoutPanel();
            lblHak = new Label();
            SuspendLayout();
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.Font = new Font("Segoe UI", 20F);
            lblBilgi.ForeColor = SystemColors.ActiveCaptionText;
            lblBilgi.Location = new Point(79, 27);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(467, 37);
            lblBilgi.TabIndex = 0;
            lblBilgi.Text = "3 Basamaklı bir sayı tuttum, tahmin et.";
            // 
            // txtTahmin
            // 
            txtTahmin.Location = new Point(186, 67);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(208, 23);
            txtTahmin.TabIndex = 1;
            txtTahmin.KeyDown += txtTahmin_KeyDown;
            // 
            // btnTahmin
            // 
            btnTahmin.Location = new Point(186, 96);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(101, 23);
            btnTahmin.TabIndex = 2;
            btnTahmin.Text = "Tahmin Et";
            btnTahmin.UseVisualStyleBackColor = true;
            btnTahmin.Click += btnTahmin_Click;
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Location = new Point(293, 96);
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.Size = new Size(101, 23);
            btnYeniOyun.TabIndex = 3;
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.UseVisualStyleBackColor = true;
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // flpGecmis
            // 
            flpGecmis.Anchor = AnchorStyles.Top;
            flpGecmis.AutoScroll = true;
            flpGecmis.AutoSize = true;
            flpGecmis.FlowDirection = FlowDirection.TopDown;
            flpGecmis.Location = new Point(187, 125);
            flpGecmis.Name = "flpGecmis";
            flpGecmis.Size = new Size(208, 373);
            flpGecmis.TabIndex = 4;
            flpGecmis.WrapContents = false;
            // 
            // lblHak
            // 
            lblHak.AutoSize = true;
            lblHak.Font = new Font("Segoe UI", 15F);
            lblHak.Location = new Point(0, 62);
            lblHak.Name = "lblHak";
            lblHak.Size = new Size(108, 28);
            lblHak.TabIndex = 6;
            lblHak.Text = "Kalan Hak: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(614, 801);
            Controls.Add(lblHak);
            Controls.Add(flpGecmis);
            Controls.Add(btnYeniOyun);
            Controls.Add(btnTahmin);
            Controls.Add(txtTahmin);
            Controls.Add(lblBilgi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBilgi;
        private TextBox txtTahmin;
        private Button btnTahmin;
        private Button btnYeniOyun;
        private FlowLayoutPanel flpGecmis;
        private Label lblHak;
    }
}
