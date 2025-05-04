namespace OgrenciNotSistemi
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_Info = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_Insta = new System.Windows.Forms.PictureBox();
            this.pictureBox_Lınkedin = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox_Minimize = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.button_GirisYap = new System.Windows.Forms.Button();
            this.button_SifremiUnuttum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Insta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Lınkedin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.pictureBox_Info);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox_Insta);
            this.panel1.Controls.Add(this.pictureBox_Lınkedin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 500);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox_Info
            // 
            this.pictureBox_Info.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Info.Image")));
            this.pictureBox_Info.Location = new System.Drawing.Point(148, 457);
            this.pictureBox_Info.Name = "pictureBox_Info";
            this.pictureBox_Info.Size = new System.Drawing.Size(46, 34);
            this.pictureBox_Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Info.TabIndex = 13;
            this.pictureBox_Info.TabStop = false;
            this.pictureBox_Info.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "v1.0";
            // 
            // pictureBox_Insta
            // 
            this.pictureBox_Insta.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Insta.Image")));
            this.pictureBox_Insta.Location = new System.Drawing.Point(95, 378);
            this.pictureBox_Insta.Name = "pictureBox_Insta";
            this.pictureBox_Insta.Size = new System.Drawing.Size(35, 33);
            this.pictureBox_Insta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Insta.TabIndex = 4;
            this.pictureBox_Insta.TabStop = false;
            this.pictureBox_Insta.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox_Lınkedin
            // 
            this.pictureBox_Lınkedin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Lınkedin.Image")));
            this.pictureBox_Lınkedin.Location = new System.Drawing.Point(136, 379);
            this.pictureBox_Lınkedin.Name = "pictureBox_Lınkedin";
            this.pictureBox_Lınkedin.Size = new System.Drawing.Size(31, 31);
            this.pictureBox_Lınkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Lınkedin.TabIndex = 3;
            this.pictureBox_Lınkedin.TabStop = false;
            this.pictureBox_Lınkedin.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "İletişim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Not Sistemine\r\n         Hoşgeldiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(552, 12);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Close.TabIndex = 1;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox_Minimize
            // 
            this.pictureBox_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Minimize.Image")));
            this.pictureBox_Minimize.Location = new System.Drawing.Point(514, 12);
            this.pictureBox_Minimize.Name = "pictureBox_Minimize";
            this.pictureBox_Minimize.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Minimize.TabIndex = 2;
            this.pictureBox_Minimize.TabStop = false;
            this.pictureBox_Minimize.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(235, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hesabınıza Giriş Yapın\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(285, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kullanıcı Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(285, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Şifre:";
            // 
            // textBox_KullaniciAdi
            // 
            this.textBox_KullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_KullaniciAdi.Location = new System.Drawing.Point(289, 200);
            this.textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            this.textBox_KullaniciAdi.Size = new System.Drawing.Size(227, 24);
            this.textBox_KullaniciAdi.TabIndex = 9;
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Sifre.Location = new System.Drawing.Point(289, 279);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(227, 24);
            this.textBox_Sifre.TabIndex = 10;
            this.textBox_Sifre.UseSystemPasswordChar = true;
            // 
            // button_GirisYap
            // 
            this.button_GirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.button_GirisYap.FlatAppearance.BorderSize = 2;
            this.button_GirisYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_GirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_GirisYap.Location = new System.Drawing.Point(351, 318);
            this.button_GirisYap.Name = "button_GirisYap";
            this.button_GirisYap.Size = new System.Drawing.Size(103, 34);
            this.button_GirisYap.TabIndex = 11;
            this.button_GirisYap.Text = "Giriş Yap";
            this.button_GirisYap.UseVisualStyleBackColor = false;
            this.button_GirisYap.Click += new System.EventHandler(this.button_GirisYap_Click);
            // 
            // button_SifremiUnuttum
            // 
            this.button_SifremiUnuttum.AutoSize = true;
            this.button_SifremiUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.button_SifremiUnuttum.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SifremiUnuttum.ForeColor = System.Drawing.Color.White;
            this.button_SifremiUnuttum.Location = new System.Drawing.Point(339, 366);
            this.button_SifremiUnuttum.Name = "button_SifremiUnuttum";
            this.button_SifremiUnuttum.Size = new System.Drawing.Size(126, 21);
            this.button_SifremiUnuttum.TabIndex = 12;
            this.button_SifremiUnuttum.Text = "Şifremi Unuttum";
            // 
            // formLogin
            // 
            this.AcceptButton = this.button_GirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.button_SifremiUnuttum);
            this.Controls.Add(this.button_GirisYap);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.textBox_KullaniciAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox_Minimize);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formLogin";
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formLogin_MouseDown_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Insta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Lınkedin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_Insta;
        private System.Windows.Forms.PictureBox pictureBox_Lınkedin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.PictureBox pictureBox_Minimize;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_KullaniciAdi;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.Button button_GirisYap;
        private System.Windows.Forms.Label button_SifremiUnuttum;
        private System.Windows.Forms.PictureBox pictureBox_Info;
    }
}