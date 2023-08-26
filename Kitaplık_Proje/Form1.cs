using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kitaplık_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\LENOVO\Desktop\Kitaplik.mdb
        //Tırnaktan önceki @ işareti, dosya yolu olduğunu belirtmek için kullanılır.
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\LENOVO\Desktop\Kitaplik.mdb");

        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Kitaplar",baglanti);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }
        string durum = "";
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Insert into Kitaplar (KitapAd,Yazar,Tur,Sayfa,Durum) Values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1",txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", cmbTur.Text);
            komut.Parameters.AddWithValue("@p4", txtSayfaSayısı.Text);
            komut.Parameters.AddWithValue("@p5", durum);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydetme İşlemi Gerçekleşti !!!");
        }

        private void radioKullanılmıs_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void radioYeni_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;//seçtiğim değeri(hücreyi) 0 olarak tut ve bunun satır indexini al
            txtKitapID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            txtKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSayfaSayısı.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmbTur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString()=="True")
            {
                
                    radioYeni.Checked = true;
            }
            else
            {
                radioKullanılmıs.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from kitaplar where kitapid=@p1",baglanti);

            komut.Parameters.AddWithValue("@p1",txtKitapID.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silinme İşlemi Gerçekleşti !!!");

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update kitaplar set kitapad=@p1,yazar=@p2,tur=@p3,sayfa=@p4,durum=@p5 where kitapid=@p6 ",baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazar.Text);
            komut.Parameters.AddWithValue("@p3", cmbTur.Text);
            komut.Parameters.AddWithValue("@p4", txtSayfaSayısı.Text);
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", txtKitapID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti !!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OleDbCommand komut = new OleDbCommand(" select * from kitaplar where kitapad=@p1  ", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapBul.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);//eger sql komutunda şart (where) varsa onu buraya yazıp datagrit içerisine sadece istediğimiz şarttaki satırların yazılmasını sağlıyoruz

            da.Fill(dt);
            dataGridView1.DataSource = dt;




            
        }

        private void txtKitapBul_TextChanged(object sender, EventArgs e)
        {
            
            OleDbCommand komut = new OleDbCommand(" select * from kitaplar where kitapad like '%"+txtKitapBul.Text+"%' ", baglanti);
            komut.Parameters.AddWithValue(txtKitapBul.Text, txtKitapBul.Text);

    
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);//eger sql komutunda şart (where) varsa onu buraya yazıp datagrit içerisine sadece istediğimiz şarttaki satırların yazılmasını sağlıyoruz

            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
