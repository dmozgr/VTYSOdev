using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev
{
    public partial class KisiForm : Form
    {
        public KisiForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=Localhost;port=5433;Database=PCB;user ID=postgres;password=145090");

        private void Siparis_Click(object sender, EventArgs e)
        {
            SiparisForm siparisform = new SiparisForm();
            siparisform.Show();
            Hide();
        }

        private void Musteri_Click(object sender, EventArgs e)
        {
            MusteriForm musteriForm = new MusteriForm();
            musteriForm.Show();
            Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into \"Kisi\" (\"kisiNo\",\"adi\",\"meslek\",\"siparis\",\"soyadi\") values (@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtKisino.Text));
            komut1.Parameters.AddWithValue("@p2",txtAdi.Text);
            komut1.Parameters.AddWithValue("@p3", txtMeslek.Text);
            komut1.Parameters.AddWithValue("@p4", int.Parse(txtSiparis.Text));
            komut1.Parameters.AddWithValue("@p5", txtSoyadi.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kisi ekleme islemi basarili");
            Listele();
        }

        private void Listele()
        {
            string sorgu = "select * from \"Kisi\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from \"Kisi\" where \"kisiNo\"=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(txtKisino.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme islemi basarili");
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("Update \"Kisi\" set \"adi\"=@p2, \"soyadi\"=@p3, \"meslek\"=@p4 where \"kisiNo\"=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", int.Parse(txtKisino.Text));
            komut.Parameters.AddWithValue("@p2", txtAdi.Text);
            komut.Parameters.AddWithValue("@p3",txtSoyadi.Text);
            komut.Parameters.AddWithValue("@p4", txtMeslek.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu1 = "Select * From \"Kisi\" where \"kisiNo\"='" + txtKisino.Text + "'";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sorgu1, baglanti);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
        }
    }
}
