namespace sayitahminoyunu
{
    partial class Form3
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
            lblHak = new Label();
            flpGecmis = new FlowLayoutPanel();
            btnYeniOyun = new Button();
            btnTahmin = new Button();
            txtTahmin = new TextBox();
            lblBilgi = new Label();
            SuspendLayout();
            // 
            // lblHak
            // 
            lblHak.AutoSize = true;
            lblHak.Font = new Font("Segoe UI", 15F);
            lblHak.Location = new Point(0, 62);
            lblHak.Name = "lblHak";
            lblHak.Size = new Size(108, 28);
            lblHak.TabIndex = 12;
            lblHak.Text = "Kalan Hak: ";
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
            flpGecmis.TabIndex = 11;
            flpGecmis.WrapContents = false;
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Location = new Point(293, 96);
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.Size = new Size(101, 23);
            btnYeniOyun.TabIndex = 10;
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.UseVisualStyleBackColor = true;
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // btnTahmin
            // 
            btnTahmin.Location = new Point(186, 96);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(101, 23);
            btnTahmin.TabIndex = 9;
            btnTahmin.Text = "Tahmin Et";
            btnTahmin.UseVisualStyleBackColor = true;
            btnTahmin.Click += btnTahmin_Click;
            // 
            // txtTahmin
            // 
            txtTahmin.Location = new Point(186, 67);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(208, 23);
            txtTahmin.TabIndex = 8;
            txtTahmin.KeyDown += txtTahmin_KeyDown;
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.Font = new Font("Segoe UI", 20F);
            lblBilgi.ForeColor = SystemColors.ActiveCaptionText;
            lblBilgi.Location = new Point(79, 27);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(467, 37);
            lblBilgi.TabIndex = 7;
            lblBilgi.Text = "4 Basamaklı bir sayı tuttum, tahmin et.";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 801);
            Controls.Add(lblHak);
            Controls.Add(flpGecmis);
            Controls.Add(btnYeniOyun);
            Controls.Add(btnTahmin);
            Controls.Add(txtTahmin);
            Controls.Add(lblBilgi);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHak;
        private FlowLayoutPanel flpGecmis;
        private Button btnYeniOyun;
        private Button btnTahmin;
        private TextBox txtTahmin;
        private Label lblBilgi;
    }
}