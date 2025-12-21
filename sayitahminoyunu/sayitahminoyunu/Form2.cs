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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //static string connectionstring = "Server=ORCUN\\SQLEXPRESS;Initial Catalog=visual;Integrated Security=True; TrustServerCertificate=True";
        //SqlConnection conn = new SqlConnection(connectionstring);

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnNormal_Click(object sender, EventArgs e)
        {
            //conn.Open();
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            string passwordEncoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        }
    }
}
