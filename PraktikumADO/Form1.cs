using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd:

        private void koneksi()
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection("Server=127.0.0.1; database=dbakademikado; UID=root; Password=;");
        }
        public Form1()
        {
            InitializeComponent():
        }

        private void btnHitungMhs_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi();
                conn.Open();
                string query = "select count(*) from mahasiswa"; // Pastikan huruf kecil sesuai database
                cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);

                // Gunakan Convert.ToInt64 agar bisa menampung angka dari database
                long jumlah = Convert.ToInt64(cmd.ExecuteScalar());
                txtHasil.Text = jumlah.ToSyring();

                // Tambahkan ini untuk memastikan tombolnya bekerja
                MessageBox.Show("Berhasil mengambil data mahasiswa: " + jumlah, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Clos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHitungMk_Click(object sender EventArgs e)
        {
            try
            {
                koneksi();
                conn.Open();

                string query = "select count(*) from matakuliah";
                cmd = new MySqlCommand(query, coonn);

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
        private void label1_Click(object sender, EventArgs e),
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi():
                conn.Open();

                string query = "update mahasiswa set Alamat = 'Yogyakarta' where NIM = '23110100001'";

                cmd = new MySqlCommand(query, conn);

                int hasil = cmd.ExccuteNonQuery();

                // Ganti bagian akhir dari Informatika menjadi Information
                MessageBox.Show("Jumlah baris terpengaruh : " + hasil, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex),
            {
                MessageBox.Show("Message", ex.Message, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e),
        {

        }

        private void btnConnect_Click_1(object sender, EventArgs e,)
        {
            try
            {
                koneksi();
                conn.Open();

                MessageBox.Show("Message", "Koneksi ke Database Berhasil", MessageBoxButtons.OK
                    MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Message", ex.Message, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
