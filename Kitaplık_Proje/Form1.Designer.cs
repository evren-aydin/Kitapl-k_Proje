
namespace Kitaplık_Proje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioKullanılmıs = new System.Windows.Forms.RadioButton();
            this.radioYeni = new System.Windows.Forms.RadioButton();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSayfaSayısı = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKitapBul = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap ID :";
            // 
            // txtKitapID
            // 
            this.txtKitapID.Enabled = false;
            this.txtKitapID.Location = new System.Drawing.Point(104, 28);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(147, 22);
            this.txtKitapID.TabIndex = 2;
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(104, 74);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(147, 22);
            this.txtKitapAd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Adı :";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(104, 113);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(147, 22);
            this.txtYazar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yazar :";
            // 
            // radioKullanılmıs
            // 
            this.radioKullanılmıs.AutoSize = true;
            this.radioKullanılmıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKullanılmıs.Location = new System.Drawing.Point(104, 225);
            this.radioKullanılmıs.Name = "radioKullanılmıs";
            this.radioKullanılmıs.Size = new System.Drawing.Size(103, 20);
            this.radioKullanılmıs.TabIndex = 7;
            this.radioKullanılmıs.TabStop = true;
            this.radioKullanılmıs.Text = "Kullanılmış";
            this.radioKullanılmıs.UseVisualStyleBackColor = true;
            this.radioKullanılmıs.CheckedChanged += new System.EventHandler(this.radioKullanılmıs_CheckedChanged);
            // 
            // radioYeni
            // 
            this.radioYeni.AutoSize = true;
            this.radioYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioYeni.Location = new System.Drawing.Point(204, 225);
            this.radioYeni.Name = "radioYeni";
            this.radioYeni.Size = new System.Drawing.Size(60, 20);
            this.radioYeni.TabIndex = 8;
            this.radioYeni.TabStop = true;
            this.radioYeni.Text = "Yeni";
            this.radioYeni.UseVisualStyleBackColor = true;
            this.radioYeni.CheckedChanged += new System.EventHandler(this.radioYeni_CheckedChanged);
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir",
            "Tiyatro"});
            this.cmbTur.Location = new System.Drawing.Point(104, 192);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(147, 24);
            this.cmbTur.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tür : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Durum : ";
            // 
            // txtSayfaSayısı
            // 
            this.txtSayfaSayısı.Location = new System.Drawing.Point(104, 154);
            this.txtSayfaSayısı.Name = "txtSayfaSayısı";
            this.txtSayfaSayısı.Size = new System.Drawing.Size(147, 22);
            this.txtSayfaSayısı.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sayfa : ";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(278, 28);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(146, 39);
            this.btnListele.TabIndex = 14;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(278, 73);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(146, 39);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(278, 120);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(146, 39);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(278, 165);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(146, 39);
            this.btnGüncelle.TabIndex = 17;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(446, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtKitapBul
            // 
            this.txtKitapBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapBul.Location = new System.Drawing.Point(457, 219);
            this.txtKitapBul.Name = "txtKitapBul";
            this.txtKitapBul.Size = new System.Drawing.Size(162, 27);
            this.txtKitapBul.TabIndex = 20;
            this.txtKitapBul.TextChanged += new System.EventHandler(this.txtKitapBul_TextChanged);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(625, 216);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(67, 35);
            this.btnBul.TabIndex = 21;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(708, 487);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtKitapBul);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtSayfaSayısı);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.radioYeni);
            this.Controls.Add(this.radioKullanılmıs);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKitapID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kitaplık";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioKullanılmıs;
        private System.Windows.Forms.RadioButton radioYeni;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSayfaSayısı;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtKitapBul;
        private System.Windows.Forms.Button btnBul;
    }
}

