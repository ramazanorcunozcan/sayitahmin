namespace sayitahminoyunu
{
    partial class Form2
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
            label1 = new Label();
            btnNormal = new Button();
            btnZor = new Button();
            btnCokzor = new Button();
            label2 = new Label();
            label3 = new Label();
            this.txtUsername = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(184, 201);
            label1.Name = "label1";
            label1.Size = new Size(426, 37);
            label1.TabIndex = 0;
            label1.Text = "Oynamak istediğiniz zorluğu seçin.";
            // 
            // btnNormal
            // 
            btnNormal.Font = new Font("Segoe UI", 15F);
            btnNormal.Location = new Point(235, 241);
            btnNormal.Name = "btnNormal";
            btnNormal.Size = new Size(103, 43);
            btnNormal.TabIndex = 1;
            btnNormal.Text = "Normal";
            btnNormal.UseVisualStyleBackColor = true;
            btnNormal.Click += btnNormal_Click;
            // 
            // btnZor
            // 
            btnZor.Font = new Font("Segoe UI", 15F);
            btnZor.Location = new Point(344, 241);
            btnZor.Name = "btnZor";
            btnZor.Size = new Size(103, 43);
            btnZor.TabIndex = 2;
            btnZor.Text = "Zor";
            btnZor.UseVisualStyleBackColor = true;
            // 
            // btnCokzor
            // 
            btnCokzor.Font = new Font("Segoe UI", 15F);
            btnCokzor.Location = new Point(453, 241);
            btnCokzor.Name = "btnCokzor";
            btnCokzor.Size = new Size(103, 43);
            btnCokzor.TabIndex = 3;
            btnCokzor.Text = "Çok Zor";
            btnCokzor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(249, 130);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(318, 160);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 5;
            label3.Text = "Şifre:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new Point(379, 135);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(100, 23);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TextChanged += this.txtAd_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(379, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(this.txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCokzor);
            Controls.Add(btnZor);
            Controls.Add(btnNormal);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNormal;
        private Button btnZor;
        private Button btnCokzor;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtAd;
        private TextBox txtPassword;
    }
}