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
    public partial class stockTransactionCorrection : Form
    {
        MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=stok;Uid=root;Pwd=''");
        MySqlCommand oku_komut = new MySqlCommand();
        public int secilen_kay_no = 0;
        public int max_kay_no = 0;
        public String sec_al_sat = "";

        public stockTransactionCorrection()
        {
            InitializeComponent();
        }

        private void stok_islem_duzeltme_formu_Load(object sender, EventArgs e)
        {
                baglan.Open();

           
            oku_komut.Connection = baglan;
            oku_komut.CommandText = "select * from stok_tablosu ORDER BY s_sira DESC LIMIT 0, 1";
            MySqlDataReader oku;
            oku = oku_komut.ExecuteReader();
            oku.Read();
            secilen_kay_no = Convert.ToUInt16(oku["s_sira"]);
            max_kay_no = secilen_kay_no;

            f_m_tc.Text = Convert.ToString(oku["s_m_tc"]);
            f_u_seri.Text = Convert.ToString(oku["s_u_seri"]);

            f_saat.Text = Convert.ToString(oku["s_saat"]);
            if (Convert.ToString(oku["s_al_sat"]) == "AL")
            {
                f_al_fiyat.Text = Convert.ToString(oku["s_fiyat"]);
                f_sat_fiyat.Text = "";
            }

            else
            {
                f_sat_fiyat.Text = Convert.ToString(oku["s_fiyat"]);
                f_al_fiyat.Text = "";
            }
                
            f_miktar.Text = Convert.ToString(oku["s_miktar"]);
            f_tutar.Text = Convert.ToString(oku["s_tutar"]);
            sec_al_sat = Convert.ToString(oku["s_al_sat"]);
            f_tarih.Text = (Convert.ToString(oku["s_tarih"])).Substring(0, 10);
            oku.Close();
            ileri.Enabled = false;

        }

        private void geri_Click(object sender, EventArgs e)
        {
           
            oku_komut.Connection = baglan;
            if (secilen_kay_no > 1)
                secilen_kay_no--;
            else
            {
                MessageBox.Show("You are in the first registration...");
                return;
            }
            oku_komut.CommandText = "select * from stok_tablosu where s_sira=" + "'" + secilen_kay_no + "'";

            MySqlDataReader oku;
            oku = oku_komut.ExecuteReader();
            oku.Read();

            f_m_tc.Text = Convert.ToString(oku["s_m_tc"]);
            f_u_seri.Text = Convert.ToString(oku["s_u_seri"]);
            String k_tarih;
            k_tarih = Convert.ToString(oku["s_tarih"]);
            f_tarih.Text = k_tarih.Substring(0, 10);

            f_saat.Text = Convert.ToString(oku["s_saat"]);

            if (Convert.ToString(oku["s_al_sat"]) == "AL")
            {
                f_al_fiyat.Text = Convert.ToString(oku["s_fiyat"]);
                f_sat_fiyat.Text = "";
            }

            else
            {
                f_sat_fiyat.Text = Convert.ToString(oku["s_fiyat"]);
                f_al_fiyat.Text = "";
            }

            f_miktar.Text = Convert.ToString(oku["s_miktar"]);
            f_tutar.Text = Convert.ToString(oku["s_tutar"]);
            sec_al_sat = Convert.ToString(oku["s_al_sat"]);
            oku.Close();
            ileri.Enabled = true;

        }

        private void ileri_Click(object sender, EventArgs e)
        {
            
            oku_komut.Connection = baglan;
            if (secilen_kay_no < max_kay_no)
                secilen_kay_no++;
            else
            {
                MessageBox.Show("You are in the last record...");
                return;
            }
            oku_komut.CommandText = "select * from stok_tablosu where s_sira=" + "'" + secilen_kay_no + "'";

            MySqlDataReader oku;
            oku = oku_komut.ExecuteReader();
            oku.Read();

            f_m_tc.Text = Convert.ToString(oku["s_m_tc"]);
            f_u_seri.Text = Convert.ToString(oku["s_u_seri"]);
            String k_tarih;
            k_tarih =Convert.ToString (oku["s_tarih"]);
            f_tarih.Text = k_tarih.Substring(0, 10);

            f_saat.Text = Convert.ToString(oku["s_saat"]);

            if (Convert.ToString(oku["s_al_sat"]) == "AL")
            {
                f_al_fiyat.Text = Convert.ToString(oku["s_fiyat"]);
                f_sat_fiyat.Text = "";
            }

            else
            {
                f_sat_fiyat.Text = Convert.ToString(oku["s_fiyat"]);
                f_al_fiyat.Text = "";
            }

            f_miktar.Text = Convert.ToString(oku["s_miktar"]);
            f_tutar.Text = Convert.ToString(oku["s_tutar"]);
            sec_al_sat = Convert.ToString(oku["s_al_sat"]);
            oku.Close();

        }

        private void kaydet_Click(object sender, EventArgs e)
        {
                  try
            {
                string ifade;
               

                ifade = "UPDATE stok_tablosu s SET s.s_m_tc =" + (char)34 + f_m_tc.Text + (char)34 + " WHERE s.s_sira = " + (char)34 + secilen_kay_no + (char)(34);
                MySqlCommand komut = new MySqlCommand(ifade, baglan);
                komut.ExecuteNonQuery();


                ifade = "UPDATE stok_tablosu s SET s.s_u_seri =" + (char)34 + f_u_seri.Text + (char)34 + " WHERE s.s_sira = " + (char)34 + secilen_kay_no + (char)(34);
                komut.CommandText = ifade;
                komut.ExecuteNonQuery();

                DateTime tarih;
                String d_tarih;
                tarih = Convert.ToDateTime(f_tarih.Text);
                d_tarih = tarih.ToString("yyyy.MM.dd");

                ifade = "UPDATE stok_tablosu s SET s.s_tarih =" + (char)34 + d_tarih + (char)34 + " WHERE s.s_sira = " + (char)34 + secilen_kay_no + (char)(34);
                komut.CommandText = ifade;
                komut.ExecuteNonQuery();


                ifade = "UPDATE stok_tablosu s SET s.s_saat =" + (char)34 + f_saat.Text + (char)34 + " WHERE s.s_sira = " + (char)34 + secilen_kay_no + (char)(34);
                komut.CommandText = ifade;
                komut.ExecuteNonQuery();

                String k_miktar = f_miktar.Text.Replace(',', '.');
                ifade = "UPDATE stok_tablosu s SET s.s_miktar =" + (char)34 + k_miktar + (char)34 + " WHERE s.s_sira = " + (char)34 + secilen_kay_no + (char)(34);
                komut.CommandText = ifade;
                komut.ExecuteNonQuery();



                String k_tutar = f_tutar.Text.Replace(',', '.');

                ifade = "UPDATE stok_tablosu s SET s.s_tutar =" + (char)34 + k_tutar + (char)34 + " WHERE s.s_sira = " + (char)34 + secilen_kay_no + (char)(34);
                komut.CommandText = ifade;
                komut.ExecuteNonQuery();
                String k_fiyat;

                if (sec_al_sat == "AL")
                    k_fiyat = f_al_fiyat.Text.Replace(',', '.');
                else
                    k_fiyat = f_sat_fiyat.Text.Replace(',', '.');

                ifade = "UPDATE stok_tablosu s SET s.s_fiyat =" + (char)34 + k_fiyat + (char)34 + " WHERE s.s_sira = " + (char)34 + secilen_kay_no + (char)(34);
                komut.CommandText = ifade;
                komut.ExecuteNonQuery();

                MessageBox.Show("Transaction recorded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                komut.Dispose();
            
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            baglan.Close();
            this.Close();
        }

        private void f_miktar_TextChanged(object sender, EventArgs e)
        {
            if ( (sec_al_sat == "AL") && (f_al_fiyat.Text!="") && (f_miktar.Text!=""))
                f_tutar.Text = Convert.ToString(Convert.ToDouble(f_miktar.Text) * Convert.ToDouble(f_al_fiyat.Text));
            if ((sec_al_sat == "AL") && (f_sat_fiyat.Text != "") && (f_miktar.Text != ""))
                f_tutar.Text = Convert.ToString(Convert.ToDouble(f_miktar.Text) * Convert.ToDouble(f_sat_fiyat.Text));

        }
    }
}
