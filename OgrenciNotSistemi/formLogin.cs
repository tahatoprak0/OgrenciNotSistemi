using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OgrenciNotSistemi
{
    public partial class formLogin: Form
   {
        //Access Database Connection String
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\OgrenciNotSistemiDB.mdb";
        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public formLogin()
        {
            InitializeComponent();
        }

    

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formLogin_MouseDown_1(object sender, MouseEventArgs e)
        {
           

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öğrencilerin notlarını görüntülediği, öğretmenlerin not bilgisini sisteme girdiği ve yöneticilerin sistemi kontrol ettiği bir öğrenci not bilgi sistemidir.");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/tahatoprak0");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/tahatayyibtoprak/");
        }

        private void button_GirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox_KullaniciAdi.Text;
            string sifre = textBox_Sifre.Text;
            string rol = "";

            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                

                using (OleDbConnection connect = new OleDbConnection(connectionString)) 
                {
                    connect.Open();
                    string queryOgrenciler = "SELECT * FROM Ogrenciler WHERE Numara = @numara AND Sifre = @sifre";

                    using (OleDbCommand command = new OleDbCommand(queryOgrenciler, connect)) {
                        command.Parameters.AddWithValue("@numara", kullaniciAdi);
                        command.Parameters.AddWithValue("@sifre", sifre);

                        using (OleDbDataReader reader = command.ExecuteReader()) 
                        {
                            if (reader.Read()) 
                            {
                                rol = "Öğrenci";
                                MessageBox.Show("Öğrenci Girişi Başarılı! Hoşgeldin " + kullaniciAdi);
                                this.Hide();
                                FormOgrenci ogrForm = new FormOgrenci();
                                ogrForm.ShowDialog();
                                this.Close();
                            }
                        }
                    }

                    if (rol == "") {
                        string queryOgretmenler = "SELECT * FROM Ogretmenler WHERE KullaniciAdi = @kullaniciAdi AND Sifre = @sifre";

                        using (OleDbCommand command = new OleDbCommand(queryOgretmenler, connect)) 
                        {
                            command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                            command.Parameters.AddWithValue("@sifre", sifre);

                            using (OleDbDataReader reader = command.ExecuteReader()) 
                            {
                                if (reader.Read()) 
                                {
                                    rol = "Öğretmen";
                                    MessageBox.Show("Öğretmen Girişi Başarılı! Hoşgeldin " + kullaniciAdi);
                                    this.Hide();
                                    FormOgretmen ogrtmn = new FormOgretmen();
                                    ogrtmn.ShowDialog();
                                    
                                    this.Close();
                                }
                            }
                        }
                    }

                }

                if (rol == "") {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş olamaz!","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            textBox_KullaniciAdi.Select();
        }
    }
}
