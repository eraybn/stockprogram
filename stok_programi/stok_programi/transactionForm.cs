using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace stok_programi
{
    public partial class transactionForm : Form
    {
        public transactionForm()
        {
            InitializeComponent();
        }
        public char menu_sec;
        public String[] mus_tc = new String[1000];
        public String[] urun_num = new String[1000];
        public Double[] urun_fiyat = new Double[1000];
        public String[] urun_birim = new String[1000];
        public Double[] urun_stok_miktari = new Double[1000];
        public String sec_urun_seri;
        public String sec_mus_tc;
        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=stok;Uid=root;Pwd='';");

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Now;
            f_tarih.Text = tarih.ToShortDateString();
            f_saat.Text = tarih.ToShortTimeString();
        }

        private void islem_formu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (menu_sec == 'a') this.Text = "ÜRÜN SATINALMA İŞLEMLERİ";
            if (menu_sec == 's') this.Text = "ÜRÜN SATIŞ İŞLEMLERİ";
            if (menu_sec == 'a') f_sat_fiyat.ReadOnly = true;
            if (menu_sec == 's') f_al_fiyat.ReadOnly = true;
            baglan.Open();

            MySqlCommand oku_komut = new MySqlCommand();
            oku_komut.Connection = baglan;
            oku_komut.CommandText = "select * from musteri_tablosu";
            MySqlDataReader oku;
            oku = oku_komut.ExecuteReader();

            int i = 0;
            f_musteri_combo.Items.Clear();
            while (oku.Read())
            {
                f_musteri_combo.Items.Add(oku["m_isim"]);
                mus_tc[i] = Convert.ToString(oku["m_tc_no"]);
                i++;
            }

            oku.Close();
            i = 0;
            oku_komut.CommandText = "select * from urun_tablosu";
            oku = oku_komut.ExecuteReader();
            f_urun_combo.Items.Clear();
            while (oku.Read())
            {
                f_urun_combo.Items.Add(oku["u_isim"]);
                urun_birim[i] = Convert.ToString(oku["u_birim"]);
                urun_fiyat[i] = Convert.ToDouble(oku["u_fiyat"]);
                urun_num[i] = Convert.ToString(oku["u_seri"]);
                urun_stok_miktari[i] = Convert.ToDouble(oku["u_stok_miktar"]);
                i++;
            }
            baglan.Close();
        }


        private void f_musteri_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f_musteri_combo.SelectedIndex >= 0) sec_mus_tc = mus_tc[f_musteri_combo.SelectedIndex];
        }



        private void f_urun_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f_urun_combo.SelectedIndex >= 0)
            {
                f_al_fiyat.Text = Convert.ToString(urun_fiyat[f_urun_combo.SelectedIndex]);
                f_sat_fiyat.Text = Convert.ToString(Convert.ToDouble(f_al_fiyat.Text) * 13 / 10);
                sec_urun_seri = urun_num[f_urun_combo.SelectedIndex];
                if (f_urun_combo.SelectedIndex >= 0)
                {
                    s_urun_a.Visible = true;
                    s_u_adet.Visible = true;
                    s_urun_a.Text = Convert.ToString(urun_stok_miktari[f_urun_combo.SelectedIndex]);
                }
            }
        }
    
        private void f_miktar_TextChanged(object sender, EventArgs e)
        {
            if ((menu_sec == 'a') && (f_miktar.Text != "") && (f_al_fiyat.Text != "")) f_tutar.Text = Convert.ToString(Convert.ToDouble(f_miktar.Text) * Convert.ToDouble(f_al_fiyat.Text));
            if ((menu_sec == 's') && (f_miktar.Text != "") && (f_sat_fiyat.Text != "")) f_tutar.Text = Convert.ToString(Convert.ToDouble(f_miktar.Text) * Convert.ToDouble(f_sat_fiyat.Text));
        }

        private void f_al_fiyat_TextChanged(object sender, EventArgs e)
        {
            if (f_al_fiyat.Text != "") f_sat_fiyat.Text = Convert.ToString(Convert.ToDouble(f_al_fiyat.Text) * 13 / 10);
            if ((menu_sec == 'a') && (f_miktar.Text != "") && (f_al_fiyat.Text != "")) f_tutar.Text = Convert.ToString(Convert.ToDouble(f_miktar.Text) * Convert.ToDouble(f_al_fiyat.Text));
            if ((menu_sec == 's') && (f_miktar.Text != "") && (f_sat_fiyat.Text != "")) f_tutar.Text = Convert.ToString(Convert.ToDouble(f_miktar.Text) * Convert.ToDouble(f_sat_fiyat.Text));
        }

        private void f_sat_fiyat_TextChanged(object sender, EventArgs e)
        {
            if ((menu_sec == 'a') && (f_miktar.Text != "") && (f_al_fiyat.Text != "")) f_tutar.Text = Convert.ToString(Convert.ToDouble(f_miktar.Text) * Convert.ToDouble(f_al_fiyat.Text));
            if ((menu_sec == 's') && (f_miktar.Text != "") && (f_sat_fiyat.Text != "")) f_tutar.Text = Convert.ToString(Convert.ToDouble(f_miktar.Text) * Convert.ToDouble(f_sat_fiyat.Text));

        }

      

        private void kaydet_Click(object sender, EventArgs e)
        {
            if ((f_tutar.Text == "") || (f_urun_combo.SelectedIndex < 0) || (f_musteri_combo.SelectedIndex < 0))
            {
                MessageBox.Show("Fill in the Required Data...");
                return;
            }

            if ((Convert.ToDouble(f_miktar.Text)> Convert.ToDouble(s_urun_a.Text)) && (menu_sec=='s'))
            {
                MessageBox.Show("Sales Quantity Cannot Be More Than Stock...");
                return;
            }
            String f_fiyat, sec_al_sat;
            if (menu_sec == 'a')
            {
                sec_al_sat = "AL";
                f_fiyat = f_al_fiyat.Text;
            }
            else
            {
                sec_al_sat = "SAT";
                f_fiyat = f_sat_fiyat.Text;
            }
            String k_fiyat = f_fiyat.Replace(',', '.');
            String k_tutar = f_tutar.Text.Replace(',', '.');            
            DateTime tarih;
            String d_tarih;
            tarih = Convert.ToDateTime(f_tarih.Text);
            d_tarih = tarih.ToString("yyyy.MM.dd");

            try
            {
                baglan.Open();
                MySqlCommand kayit_komut = new MySqlCommand();
                kayit_komut.Connection = baglan;
                MySqlCommand update_komut = new MySqlCommand();
                update_komut.Connection = baglan;
                // kayit_komut.CommandText = "insert into stok_tablosu (s_u_seri,s_m_tc,s_miktar,s_fiyat,s_tutar,s_al_sat,s_tarih,s_saat) values  ('" + sec_urun_seri + "','" + sec_mus_tc + "','" + f_miktar.Text + "','" + k_fiyat + "','" + k_tutar + "','" + sec_al_sat + "','" + d_tarih + "','" + f_saat.Text + "')";

                kayit_komut.CommandText = "insert into stok_tablosu (s_u_seri,s_m_tc,s_miktar,s_fiyat,s_tutar,s_al_sat,s_tarih,s_saat) values  (@sus , @smtc , @fm , @ff ,@ft , @sas , @dt, @fs )";

                kayit_komut.Parameters.AddWithValue("@sus", sec_urun_seri);
                kayit_komut.Parameters.AddWithValue("@smtc", sec_mus_tc);
                kayit_komut.Parameters.AddWithValue("@fm", f_miktar.Text);
                kayit_komut.Parameters.AddWithValue("@ff", k_fiyat);
                kayit_komut.Parameters.AddWithValue("@ft", k_tutar);
                kayit_komut.Parameters.AddWithValue("@sas", sec_al_sat);
                kayit_komut.Parameters.AddWithValue("@dt", d_tarih);
                kayit_komut.Parameters.AddWithValue("@fs", f_saat.Text);

                object sonuc = null;
                sonuc = kayit_komut.ExecuteNonQuery();
                if (sonuc != null)
                {
                    MessageBox.Show("Transaction Recorded in System", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Stok miktarını düzenleyelim

                    if (menu_sec == 'a')
                    {
                        urun_stok_miktari[f_urun_combo.SelectedIndex] = urun_stok_miktari[f_urun_combo.SelectedIndex] + Convert.ToDouble(f_miktar.Text);

                    }
                    else
                    {
                        urun_stok_miktari[f_urun_combo.SelectedIndex] = urun_stok_miktari[f_urun_combo.SelectedIndex] - Convert.ToDouble(f_miktar.Text);
                    }


                    //Ürün tablosundaki stok adedini düzenleyelim

                    String k_urun_a = Convert.ToString(urun_stok_miktari[f_urun_combo.SelectedIndex]);
                     k_urun_a = k_urun_a.Replace(',', '.');

                   update_komut.CommandText="UPDATE urun_tablosu u SET u.u_stok_miktar =" + (char)34 + k_urun_a + (char)34 + " WHERE u.u_seri = " + (char)34 + sec_urun_seri + (char)(34);

                   update_komut.ExecuteNonQuery();
                   update_komut.Dispose();

                    //İşlem bitti ekranı boşaltalım

                   f_musteri_combo.Text = "İsim Seçiniz";
                   f_urun_combo.Text = "Ürün Seçiniz";
                   f_musteri_combo.SelectedIndex = -1;
                   f_urun_combo.SelectedIndex = -1;
                   f_miktar.Text = "";
                   f_tutar.Text = "";
                   f_al_fiyat.Text = "";
                   f_sat_fiyat.Text = "";
                    s_urun_a.Visible = false;
                    s_u_adet.Visible = false;
                    s_urun_a.Text = "0";

                }
                else
                    MessageBox.Show("Error!... Transaction Could Not Be Saved To System", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kayit_komut.Dispose();
                baglan.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata : " + HataYakala.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
