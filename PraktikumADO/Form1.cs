using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;

        private void koneksi()
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection("Server=127.0.0.1; database=dbakademikado; UID=root; Password=;");
        }
        public Form1()
        {
            InitializeComponent();
        }

       private void btnHitungMhs_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi();
                conn.Open();
                string query = "select count(*) from mahasiswa"; // Pastikan huruf kecil sesuai database
                cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
            }
    }
}
