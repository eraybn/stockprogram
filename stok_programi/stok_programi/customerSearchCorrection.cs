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
    public partial class customerSearchCorrection : Form
    {

        MySqlConnection baglan = new MySqlConnection("server=localhost;database=stok;uid=root;pwd=''");
        MySqlCommand komut = new MySqlCommand();
        MySqlDataReader dr;
        String sec_musteri_tc;
        public customerSearchCorrection()
        {
            InitializeComponent();
        }

        public void basla()
        {

            f_ara_combo.Items.Clear();
            f_ara_combo.Text = "Müşteri Ara ";
            komut.Connection = baglan;
            komut.CommandText = "select * from musteri_tablosu";
            dr = komut.ExecuteReader();
            while (dr.Read())
                f_ara_combo.Items.Add(dr["m_isim"]);
            dr.Close();
            komut.Dispose();
        }
        private void musteri_arama_duzeltme_formu_Load(object sender, EventArgs e)
        {
            baglan.Open();
            basla();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            string ifade;
   

            ifade = "UPDATE musteri_tablosu m SET m.m_tc_no =" + (char)34 + f_m_tc_no.Text + (char)34 + " WHERE m.m_isim = " + (char)34 + f_ara_combo.Text + (char)34;
            MySqlCommand komut = new MySqlCommand(ifade, baglan);
            komut.ExecuteNonQuery();


            ifade = "UPDATE musteri_tablosu m SET m.m_firma_ismi =" + (char)34 + f_m_firma_ismi.Text + (char)34 + " WHERE m.m_isim = " + (char)34 + f_ara_combo.Text + (char)34;
            komut.CommandText = ifade;
            komut.ExecuteNonQuery();

            ifade = "UPDATE musteri_tablosu m SET m.m_tel =" + (char)34 + f_m_tel.Text + (char)34 + " WHERE m.m_isim = " + (char)34 + f_ara_combo.Text + (char)34;
            komut.CommandText = ifade;
            komut.ExecuteNonQuery();

            ifade = "UPDATE musteri_tablosu m SET m.m_adres =" + (char)34 + f_m_adres.Text + (char)34 + " WHERE m.m_isim = " + (char)34 + f_ara_combo.Text + (char)34;
            komut.CommandText = ifade;
            komut.ExecuteNonQuery();

            ifade = "UPDATE musteri_tablosu m SET m.m_mail =" + (char)34 + f_m_mail.Text + (char)34 + " WHERE m.m_isim = " + (char)34 + f_ara_combo.Text + (char)34;
            komut.CommandText = ifade;
            komut.ExecuteNonQuery();

            ifade = "UPDATE musteri_tablosu m SET m.m_isim =" + (char)34 + f_m_isim.Text + (char)34 + " WHERE m.m_isim = " + (char)34 + f_ara_combo.Text + (char)34;
            komut.CommandText = ifade;
            komut.ExecuteNonQuery();

            //Eğer müşteri TC no değişti ise bunun stok tablosunda da değiştirilmesi gerekir.
            if (sec_musteri_tc != f_m_tc_no.Text)
            {
                ifade = "UPDATE stok_tablosu s SET s.s_m_tc =" + (char)34 + f_m_tc_no.Text + (char)34 + " WHERE s.s_m_tc = " + (char)34 + sec_musteri_tc + (char)(34);
                komut.CommandText = ifade;
                komut.ExecuteNonQuery();  
            }     
     
                MessageBox.Show ("Data Edited..");

            basla();
            f_m_isim.Text = "";
            f_m_tc_no.Text = "";
            f_m_tel.Text = "";
            f_m_adres.Text = "";
            f_m_mail.Text = "";
            f_m_firma_ismi.Text = "";

        }

        private void f_ara_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            komut.CommandText = "select * from musteri_tablosu where m_isim='" + f_ara_combo.SelectedItem + "'";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                f_m_isim.Text = Convert.ToString(dr["m_isim"]);
                f_m_tc_no.Text = Convert.ToString(dr["m_tc_no"]);
                f_m_tel.Text = Convert.ToString(dr["m_tel"]);
                f_m_adres.Text = Convert.ToString(dr["m_adres"]);
                f_m_mail.Text = Convert.ToString(dr["m_mail"]);
                f_m_firma_ismi.Text = Convert.ToString(dr["m_firma_ismi"]);
                sec_musteri_tc = Convert.ToString(dr["m_tc_no"]);
            }
                      
            dr.Close();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            baglan.Close();
            this.Close();
        }
    }
    }

