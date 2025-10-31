namespace sayitahminoyunu
{
    public partial class Form1 : Form
    {
        int tutulansayi; //rastgele oluşturulan sayı
        string tutulanstr; //sayıyı string olarak saklama
        int kalanHak;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yenioyunbaslat();
        }

        private void yenioyunbaslat()
        {
            Random rnd = new Random();
            tutulansayi = rnd.Next(100, 1000);
            tutulanstr = tutulansayi.ToString();

            kalanHak = 10;
            lblHak.Text = $"Kalan Hak: {kalanHak}";

            lblBilgi.Text = "3 Basamaklı bir sayı tuttum, tahmin et.";
            flpGecmis.Controls.Clear();

            txtTahmin.Clear();
            txtTahmin.Focus();
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            yenioyunbaslat();
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            string tahminStr = txtTahmin.Text.Trim();

            if (tahminStr.Length != 3 || !int.TryParse(tahminStr, out int tahmin))
            {
                MessageBox.Show("Lütfen 3 basamaklı bir sayı gir!");
                return;
            }

            kalanHak--;
            lblHak.Text = $"Kalan Hak: {kalanHak}";

            // Her tahmin için küçük bir panel oluşturma
            FlowLayoutPanel tahminSatiri = new FlowLayoutPanel();
            tahminSatiri.FlowDirection = FlowDirection.LeftToRight;
            tahminSatiri.WrapContents = false;
            tahminSatiri.Height = 50;
            tahminSatiri.Width = 200;
            tahminSatiri.Margin = new Padding(0, 5, 0, 5);

            // Renkli kutucuklar oluşturma kısmı
            for (int i = 0; i < 3; i++)
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
                    lbl.BackColor = Color.LightGreen; // doğru yerde
                }
                else if (tutulanstr.Contains(tahminStr[i]))
                {
                    lbl.BackColor = Color.Gold; // yanlış yerde
                }
                else
                {
                    lbl.BackColor = Color.LightGray; // yok
                }

                tahminSatiri.Controls.Add(lbl);
            }

            // Tahmin satırının başına tahmin numarası ekleme
            Label lblTahminNo = new Label();
            lblTahminNo.Text = $"{flpGecmis.Controls.Count + 1}.";
            lblTahminNo.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lblTahminNo.Width = 30;
            lblTahminNo.TextAlign = ContentAlignment.MiddleRight;
            lblTahminNo.Margin = new Padding(5, 10, 5, 0);

            // Her satırı bir alt panelde birleştirme
            FlowLayoutPanel satirPanel = new FlowLayoutPanel();
            satirPanel.Controls.Add(lblTahminNo);
            satirPanel.Controls.Add(tahminSatiri);

            // Ana panele ekleme
            flpGecmis.Controls.Add(satirPanel);

            // Eğer doğruysa tebrik mesajı gösterme
            if (tahminStr == tutulanstr)
            {
                MessageBox.Show($" Tebrikler! Sayı {tutulansayi} idi!");
                OyunBitti();
                return;
            }
            if (kalanHak <= 0) 
            {
                MessageBox.Show($"Hakkın Bitti! Sayı {tutulansayi}");
                OyunBitti();
                return;
            }

            txtTahmin.Clear();
            txtTahmin.Focus();

        }

        private void OyunBitti()
        {
            txtTahmin.Enabled = false;
            btnTahmin.Enabled = false;
        }

        private void txtTahmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnTahmin.PerformClick();
        }
    }
}


















