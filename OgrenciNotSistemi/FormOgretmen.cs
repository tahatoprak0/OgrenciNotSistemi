using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotSistemi
{
    public partial class FormOgretmen: Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private int ogrenciID;
        public string ogretmenKullaniciAdi;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        //Access Database Connection String
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\OgrenciNotSistemiDB.mdb";
        public FormOgretmen()
        {
            InitializeComponent();
        }

        private void GetStudents() 
        {
            try
            {
                using (OleDbConnection connect = new OleDbConnection(connectionString))
                {
                    connect.Open();
                    string queryOgrencileriGetir = "SELECT * FROM Ogrenciler";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(queryOgrencileriGetir, connect);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_TumOgrenciler.DataSource = dataTable;
                    label_Bilgi.Text = "Tüm Öğrenciler";
                    

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata: {ex.Message}","Hata",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            

        }

        private void UpdateGrades()
        {
            using (OleDbConnection connect = new OleDbConnection(connectionString))
            {
                
                string queryOgrencileriGetir = "SELECT * FROM Ogrenciler";
                OleDbDataAdapter adapter = new OleDbDataAdapter(queryOgrencileriGetir, connect);
                DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    comboBox_OgrenciNumarasi.DisplayMember = "Numara";
                    comboBox_OgrenciNumarasi.ValueMember = "Id";
                    comboBox_OgrenciNumarasi.DataSource = dataTable;
                
               
            }
        }

        private void ListData() 
        {
            if (comboBox_OgrenciNumarasi.SelectedItem != null)
            {
                DataRowView row = (DataRowView)comboBox_OgrenciNumarasi.SelectedItem;

                if (row != null)
                {
                    ogrenciID = Convert.ToInt32(row["Id"]);
                    label_OgrenciId.Text = row["Id"].ToString();
                    label_OgrenciAd.Text = row["Ad"].ToString();
                    label_OgrenciSoyad.Text = row["Soyad"].ToString();
                    label_OgrenciNumara.Text = row["Numara"].ToString();
                    textBoxMatNot.Text = row["MatematikNot"].ToString();
                    textBox_FzkNot.Text = row["FizikNot"].ToString();
                    textBox_KimyaNot.Text = row["KimyaNot"].ToString();
                    textBox_BioNot.Text = row["BiyolojiNot"].ToString();
                    textBox_EdbNot.Text = row["EdebiyatNot"].ToString();
                    textBox_GeoNot.Text = row["GeometriNot"].ToString();
                    textBox_MatGuncelle.Text = row["MatematikNot"].ToString();
                    textBox_FzkGuncelle.Text = row["FizikNot"].ToString();
                    textBox_KimGuncelle.Text = row["KimyaNot"].ToString();
                    textBox_BioGuncelle.Text = row["BiyolojiNot"].ToString();
                    textBox_EdbGuncelle.Text = row["EdebiyatNot"].ToString();
                    textBox_GeoGuncelle.Text = row["GeometriNot"].ToString();

                    label_Ort.Text = (
                        (Convert.ToDouble(row["MatematikNot"]) +
                        Convert.ToDouble(row["FizikNot"]) +
                        Convert.ToDouble(row["KimyaNot"]) +
                        Convert.ToDouble(row["BiyolojiNot"]) +
                        Convert.ToDouble(row["EdebiyatNot"]) +
                        Convert.ToDouble(row["GeometriNot"])) / 6).ToString("0.00");
                    



                }

            }
        }

        private int GetReport(string query, OleDbConnection connection) { 
            OleDbCommand command = new OleDbCommand(query, connection);
            return Convert.ToInt32(command.ExecuteScalar());
        }
        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FormOgretmen_Load(object sender, EventArgs e)
        {
            label_KullaniciAdi.Text = ogretmenKullaniciAdi;
        }

        private void button_GirisYap_Click(object sender, EventArgs e)
        {
            panel_OgrencileriGoruntule.Visible = true;
        }

        private void button_OgrencileriGoruntule_Click(object sender, EventArgs e)
        {
            panel_NotGuncelle.Visible = false;
            panel_Rapor.Visible = false;
            panel_OgrencileriGoruntule.Visible = true;
            GetStudents();
           
        }

        private void FormOgretmen_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void button_NotGuncelle_Click(object sender, EventArgs e)
        {

            panel_OgrencileriGoruntule.Visible = false;
            panel_Rapor.Visible = false;
            panel_NotGuncelle.Visible = true;
            label_Bilgi.Text = "Not Güncelle";
            UpdateGrades();
        }

        private void comboBox_OgrenciNumarasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListData();
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            int matematikNot = Convert.ToInt32(textBox_MatGuncelle.Text);
            int fizikNot = Convert.ToInt32(textBox_FzkGuncelle.Text);
            int kimyaNot = Convert.ToInt32(textBox_KimGuncelle.Text);
            int biyolojiNot = Convert.ToInt32(textBox_BioGuncelle.Text);
            int edebiyatNot = Convert.ToInt32(textBox_EdbGuncelle.Text);
            int geometriNot = Convert.ToInt32(textBox_GeoGuncelle.Text);

            using (OleDbConnection connect = new OleDbConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    string queryGuncelle = "UPDATE Ogrenciler SET MatematikNot = @matNot, FizikNot = @fzkNot, KimyaNot = @kimNot, BiyolojiNot = @bioNot, EdebiyatNot = @edbNot, GeometriNot = @geoNot WHERE Id = @ogrenciId";

                    using (OleDbCommand command = new OleDbCommand(queryGuncelle,connect))
                    {
                        command.Parameters.AddWithValue("@matNot", matematikNot);
                        command.Parameters.AddWithValue("@fzkNot", fizikNot);
                        command.Parameters.AddWithValue("@kimNot", kimyaNot);
                        command.Parameters.AddWithValue("@bioNot", biyolojiNot);
                        command.Parameters.AddWithValue("@edbNot", edebiyatNot);
                        command.Parameters.AddWithValue("@geoNot", geometriNot);
                        command.Parameters.AddWithValue("@ogrenciId", ogrenciID);

                       int rowAffected = command.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Güncelleme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetStudents();
                            UpdateGrades();
                            ListData();
                            

                        }
                        else 
                        {
                            MessageBox.Show("Güncellenecek Kayıt Bulunamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                
            }
        }

        private void button_Raporlar_Click(object sender, EventArgs e)
        {
            panel_NotGuncelle.Visible = false;
            panel_OgrencileriGoruntule.Visible = false;
            panel_Rapor.Visible = true;
            label_Bilgi.Text = "Raporlar";

            using (OleDbConnection connect = new OleDbConnection(connectionString)) 
            {
                connect.Open();
                int toplamOgrenci = GetReport("SELECT COUNT(*) FROM Ogrenciler", connect);
                int toplamOgretmen = GetReport("SELECT COUNT(*) FROM Ogretmenler", connect);
                int toplamDers = GetReport("SELECT COUNT(*) FROM Dersler", connect);
                int matGecen = GetReport("SELECT COUNT(*) FROM Ogrenciler WHERE MatematikNot >= 50", connect);
                int matKalan = GetReport("SELECT COUNT(*) FROM Ogrenciler WHERE MatematikNot < 50", connect);


                label_ToplamOgrenci.Text = toplamOgrenci.ToString();
                label_ToplamOgretmen.Text = toplamOgretmen.ToString();
                label_ToplamDers.Text = toplamDers.ToString();
                label_MatGecen.Text = matGecen.ToString();
                label_MatKalan.Text = matKalan.ToString();
            }
        }
    }
}
