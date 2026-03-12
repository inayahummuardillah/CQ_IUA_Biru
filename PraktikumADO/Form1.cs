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
            try {
                koneksi();
                conn.Open();
                string query = "select count(*) from mahasiswa"; // Pastikan huruf kecil sesuai database
                cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
        
                int jumlah = Convert.ToInt32(cmd.ExecuteScalar());
                txtHasil.Text = jumlah.ToString();
        
                // Tambahkan ini untuk memastikan tombolnya bekerja
                MessageBox.Show("Berhasil mengambil data mahasiswa: " + jumlah, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
                conn.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHitungMk_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi();
                conn.Open();

                string query = "select count(*) from matakuliah";
                cmd = new MySqlCommand(query, conn);

                // Langsung tampilkan ke TextBox tanpa harus lewat variabel int
                txtHasil.Text = cmd.ExecuteScalar().ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                // Urutan MessageBox: (Pesan, Judul, Tombol, Ikon)
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi();
                conn.Open();

                { 
    }
}
