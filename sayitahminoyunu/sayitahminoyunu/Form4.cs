using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayitahminoyunu
{
    public partial class Form4 : Form
    {
        int tutulansayi;
        string tutulanstr;
        int kalanHak;

        int toplamPuan = 0;
        Label lblPuan;
        public Form4()
        {
            InitializeComponent();
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            string tahminStr = txtTahmin.Text.Trim();

            if (tahminStr.Length != 5 || !int.TryParse(tahminStr, out int tahmin))
            {
                MessageBox.Show("Lütfen 5 basamaklı bir sayı gir!");
                return;
            }

            kalanHak--;
            lblHak.Text = $"Kalan Hak: {kalanHak}";

            FlowLayoutPanel tahminSatiri = new FlowLayoutPanel();
            tahminSatiri.FlowDirection = FlowDirection.LeftToRight;
            tahminSatiri.WrapContents = false;
            tahminSatiri.Height = 50;
            tahminSatiri.Width = 200;
            tahminSatiri.Margin = new Padding(0, 5, 0, 5);

            for (int i = 0; i < 5; i++)
            {
                Label lbl = new Label();
                lbl.Text = tahminStr[i].ToString();
                lbl.Width = 40;
                lbl.Height = 40;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                lbl.Margin = new Padding(5);

                if (tahminStr[i] == tutulanstr[i])
                {
                    lbl.BackColor = Color.LightGreen;
                }
                else if (tutulanstr.Contains(tahminStr[i]))
                {
                    lbl.BackColor = Color.Gold;
                }
                else
                {
                    lbl.BackColor = Color.Red;
                }

                tahminSatiri.Controls.Add(lbl);
            }

            Label lblTahminNo = new Label();
            lblTahminNo.Text = $"{flpGecmis.Controls.Count + 1}.";
            lblTahminNo.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lblTahminNo.Width = 30;
            lblTahminNo.TextAlign = ContentAlignment.MiddleRight;
            lblTahminNo.Margin = new Padding(5, 10, 5, 0);

            FlowLayoutPanel satirPanel = new FlowLayoutPanel();
            satirPanel.Controls.Add(lblTahminNo);
            satirPanel.Controls.Add(tahminSatiri);

            flpGecmis.Controls.Add(satirPanel);

            // otomatik kaydırma
            flpGecmis.ScrollControlIntoView(satirPanel);

            if (tahminStr == tutulanstr)
            {
                // puan hesap
                int kazanilanPuan = ((kalanHak * 100) * 3);
                toplamPuan += kazanilanPuan;
                lblPuan.Text = $"Toplam Puan: {toplamPuan}";

                MessageBox.Show($"Tebrikler! Sayı {tutulansayi} idi!\nBu turdan {kazanilanPuan} puan kazandın.\nToplam Puanın: {toplamPuan}");
                OyunBitti();
                return;
            }

            if (kalanHak <= 0)
            {
                MessageBox.Show($"Hakkın Bitti! Sayı {tutulansayi} idi.\nMaalesef puan kazanamadın.");
                OyunBitti();
                return;
            }

            txtTahmin.Clear();
            txtTahmin.Focus();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SanalKlavyeOlustur();
            PuanLabeli(); // puan göstergesi
            yenioyunbaslat();
        }
        private void PuanLabeli()
        {
            lblPuan = new Label();
            lblPuan.AutoSize = true;
            lblPuan.Location = new Point(00, 89);
            lblPuan.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblPuan.ForeColor = Color.DarkGreen;
            lblPuan.Text = "Toplam Puan: 0";
            this.Controls.Add(lblPuan);
        }
        private void SanalKlavyeOlustur()
        {
            FlowLayoutPanel pnlKlavye = new FlowLayoutPanel();
            pnlKlavye.Name = "pnlKlavye";
            pnlKlavye.Size = new Size(160, 220);
            pnlKlavye.Location = new Point(txtTahmin.Location.X + txtTahmin.Width + 20, txtTahmin.Location.Y);
            pnlKlavye.FlowDirection = FlowDirection.LeftToRight;

            for (int i = 1; i <= 9; i++)
            {
                pnlKlavye.Controls.Add(RakamButonOlustur(i.ToString()));
            }

            Button btnSil = new Button();
            btnSil.Text = "←";
            btnSil.Size = new Size(45, 45);
            btnSil.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnSil.Click += (s, e) =>
            {
                if (txtTahmin.Text.Length > 0)
                    txtTahmin.Text = txtTahmin.Text.Substring(0, txtTahmin.Text.Length - 1);
            };
            pnlKlavye.Controls.Add(btnSil);

            pnlKlavye.Controls.Add(RakamButonOlustur("0"));

            Button btnOnay = new Button();
            btnOnay.Text = "✓";
            btnOnay.Size = new Size(45, 45);
            btnOnay.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnOnay.BackColor = Color.LightGreen;
            btnOnay.Click += (s, e) => btnTahmin.PerformClick();
            pnlKlavye.Controls.Add(btnOnay);

            this.Controls.Add(pnlKlavye);
        }
        private Button RakamButonOlustur(string rakam)
        {
            Button btn = new Button();
            btn.Text = rakam;
            btn.Size = new Size(45, 45);
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn.Click += (s, e) =>
            {
                if (txtTahmin.Text.Length < 5)
                    txtTahmin.Text += rakam;
            };
            return btn;
        }
        private void yenioyunbaslat()
        {
            Random rnd = new Random();
            tutulansayi = rnd.Next(10000, 100000);
            tutulanstr = tutulansayi.ToString();

            kalanHak = 10;
            lblHak.Text = $"Kalan Hak: {kalanHak}";

            lblBilgi.Text = "5 Basamaklı bir sayı tuttum, tahmin et.";
            flpGecmis.Controls.Clear();

            txtTahmin.Clear();
            txtTahmin.Focus();
            txtTahmin.Enabled = true;
            btnTahmin.Enabled = true;

            // klavyeyi tekrar aktif et
            Control[] klavye = this.Controls.Find("pnlKlavye", true);
            if (klavye.Length > 0) klavye[0].Enabled = true;
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            yenioyunbaslat();
        }
        private void OyunBitti()
        {
            txtTahmin.Enabled = false;
            btnTahmin.Enabled = false;

            Control[] klavye = this.Controls.Find("pnlKlavye", true);
            if (klavye.Length > 0) klavye[0].Enabled = false;
        }

        private void txtTahmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTahmin.PerformClick();
        }
    }
}
