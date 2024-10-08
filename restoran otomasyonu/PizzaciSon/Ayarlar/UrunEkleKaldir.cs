﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaciSon.Ayarlar
{
    public partial class UrunEkleKaldir : Form
    {
        public UrunEkleKaldir()
        {
            InitializeComponent();
        }

        public static string ConnectionString = "Data Source=.;Initial Catalog = Pizzacı; Integrated Security = True";
        string secilenUrunAdi = "";
        int secilenUrunFiyat = 0;
        string secilenUrunKategori = "";
        int secilenUrunId = 0;

        private void btnListele_Click(object sender, EventArgs e)
        {
            lstViewUrunler.Items.Clear();
            string kategoriSecim = "";
            kategoriSecim = cmbBxKategori.Text;
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand cmd = new SqlCommand("select * from FiyatListesi1 where kategori='" + kategoriSecim + "' order by urunId", bg);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = oku["urunIsim"].ToString();
                listele.SubItems.Add(oku["fiyat"].ToString());
                listele.SubItems.Add(oku["kategori"].ToString());
                listele.SubItems.Add(oku["urunId"].ToString());
                lstViewUrunler.Items.Add(listele);
            }
            bg.Close();
        }

        private void lstViewUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string items = "";
            if (lstViewUrunler.SelectedItems.Count == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    items = lstViewUrunler.SelectedItems[0].SubItems[i].Text;
                    if (i == 0)
                        secilenUrunAdi = items;
                    if (i == 1)
                        secilenUrunFiyat = Convert.ToInt32(items);
                    if (i == 2)
                        secilenUrunKategori = items;
                    if (i == 3)
                        secilenUrunId = Convert.ToInt32(items);
                }
            }

        }
        private void btnKaldir_Click(object sender, EventArgs e)
        {
            SqlConnection bg = new SqlConnection(ConnectionString);
            bg.Open();
            SqlCommand guncel = new SqlCommand("delete FiyatListesi1 where urunId=@urunId and urunIsim=@urunIsim and fiyat=@fiyat ", bg);
            guncel.Parameters.AddWithValue("@urunIsim", secilenUrunAdi);
            guncel.Parameters.AddWithValue("@fiyat", secilenUrunFiyat);
            guncel.Parameters.AddWithValue("@urunId", secilenUrunId);
            guncel.ExecuteNonQuery();
            bg.Close();

            lstViewUrunler.Items.Clear();
            string kategoriSecim = "";
            kategoriSecim = cmbBxKategori.Text;
            bg.Open();
            guncel = new SqlCommand("select * from FiyatListesi1 where kategori='" + kategoriSecim + "' order by urunId", bg);
            SqlDataReader oku = guncel.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = oku["urunIsim"].ToString();
                listele.SubItems.Add(oku["fiyat"].ToString());
                listele.SubItems.Add(oku["kategori"].ToString());
                listele.SubItems.Add(oku["urunId"].ToString());
                lstViewUrunler.Items.Add(listele);
            }
            bg.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string yeniUrunAdi = ""; int yeniUrunFiyat = 0;
            string yeniUrunKategori = ""; string yeniUrunStokKategori = "";

            if (txtBxUrunAdi.Text != "")
                yeniUrunAdi = txtBxUrunAdi.Text;
            if (txtBxUrunFiyati.Text != "")
                yeniUrunFiyat = Convert.ToInt32(txtBxUrunFiyati.Text);
            if (cmbBxUrunKategori.Text != "")
                yeniUrunKategori = cmbBxUrunKategori.Text;
            if (cmbBxStokKategori.Text != "")
                yeniUrunStokKategori = cmbBxStokKategori.Text;

            SqlConnection bg = new SqlConnection(ConnectionString);
            if (yeniUrunAdi != "" && yeniUrunFiyat != 0 && yeniUrunKategori != "")
            {
                bg.Open();
                SqlCommand guncel = new SqlCommand("insert into FiyatListesi1(urunIsim, fiyat, kategori, stokKategori) values(@urunIsim, @fiyat, @ kategori, @stokKategori)", bg);

                guncel.Parameters.AddWithValue("@urunIsim", yeniUrunAdi);
                guncel.Parameters.AddWithValue("@fiyat", yeniUrunFiyat);
                guncel.Parameters.AddWithValue("@kategori", yeniUrunKategori);
                guncel.Parameters.AddWithValue("@stokKategori", yeniUrunStokKategori);
                guncel.ExecuteNonQuery();
                bg.Close();

                lstViewUrunler.Items.Clear();
                string kategoriSecim = "";
                kategoriSecim = cmbBxKategori.Text;
                bg.Open();
                SqlCommand cmd = new SqlCommand("select * from FiyatListesi1 where kategori='" + yeniUrunKategori + "' order by urunId", bg);
                SqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem listele = new ListViewItem();
                    listele.Text = oku["urunIsim"].ToString();
                    listele.SubItems.Add(oku["fiyat"].ToString());
                    listele.SubItems.Add(oku["kategori"].ToString());
                    listele.SubItems.Add(oku["urunId"].ToString());
                    lstViewUrunler.Items.Add(listele);
                }
                bg.Close();
            }
            else
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz!!!");
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            AyarlarAna anasayfa = new AyarlarAna();
            anasayfa.Show();
            this.Hide();
        }

        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            UrunEkleKaldir urunEkleKaldir = new UrunEkleKaldir();
            urunEkleKaldir.Show();
            this.Hide();
        }
        private void btnMasaEkleKaldir_Click(object sender, EventArgs e)
        {
            MasaEkleKaldir masaEkleKaldir = new MasaEkleKaldir();
            masaEkleKaldir.Show();
            this.Hide();
        }

        private void cnbBxUrunKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxKategori.Text == "İçecek") ;
            {

            }
        }

        private void btnMasaEkleKaldir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
