using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotSistemi
{
    public partial class FormOgrenci: Form
    {

        //Access Database Connection String
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\OgrenciNotSistemiDB.mdb";

        public int ogrenciNo;
        public FormOgrenci()
        {
            InitializeComponent();
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FormOgrenci_Load(object sender, EventArgs e)
        {

            using (OleDbConnection connect = new OleDbConnection(connectionString)) {
                connect.Open();
                
                string queryOgrenciler = "SELECT * FROM Ogrenciler WHERE Numara = @ogrenciNo";
                
                using (OleDbCommand command = new OleDbCommand(queryOgrenciler,connect)) {
                    
                    command.Parameters.AddWithValue("@ogrenciNo", ogrenciNo);
                    
                    using (OleDbDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            label_KullaniciAdi.Text = reader["Numara"].ToString();
                            label_OgrenciId.Text = reader["Id"].ToString();
                            label_OgrenciAd.Text = reader["Ad"].ToString();
                            label_OgrenciSoyad.Text = reader["Soyad"].ToString();
                            label_OgrenciNumara.Text = reader["Numara"].ToString();
                            label_OgrenciSifre.Text = reader["Sifre"].ToString();
                            textBoxMatNot.Text = reader["MatematikNot"].ToString();
                            textBox_FzkNot.Text = reader["FizikNot"].ToString();
                            textBox_KimyaNot.Text = reader["KimyaNot"].ToString();
                            textBox_BioNot.Text = reader["BiyolojiNot"].ToString();
                            textBox_EdbNot.Text = reader["EdebiyatNot"].ToString();
                            textBox_GeoNot.Text = reader["GeometriNot"].ToString();
                        }
                    }
                }

            }

        }

        private void label_KullaniciAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
