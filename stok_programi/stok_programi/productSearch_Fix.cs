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
    public partial class productSearch_Fix : Form
    {
        MySqlConnection baglan = new MySqlConnection("server=localhost;database=stok;uid=root;pwd=''");
        MySqlCommand komut = new MySqlCommand();
        MySqlDataReader dr;
        String sec_urun_seri;
        public productSearch_Fix()
        {
            InitializeComponent();
        }

public void basla()
        {

            f_ara_combo.Items.Clear();
            f_ara_combo.Text = "Ürün Ara ";
            komut.Connection = baglan;
            komut.CommandText = "select * from urun_tablosu";
            dr = komut.ExecuteReader();
            while (dr.Read())
                f_ara_combo.Items.Add(dr["u_isim"]);
            dr.Close();
            komut.Dispose();
        }

        private void urun_ara_duzelt_formu_Load(object sender, EventArgs e)
        {
            baglan.Open();
            basla();

        }



        private void kaydet_Click(object sender, EventArgs e)
        {
            string ifade;

            ifade = "UPDATE urun_tablosu u SET u.u_seri =" + (char)34 + f_u_seri.Text + (char)34 + " WHERE u.u_isim = " + (char)34 + f_ara_combo.Text + (char)(34);
            MySqlCommand komut = new MySqlCommand(ifade, baglan);
            komut.ExecuteNonQuery();
 
            ifade = "UPDATE urun_tablosu u SET u.u_birim =" + (char)34 + f_u_brm_combo.SelectedItem + (char)34 + " WHERE u.u_isim = " + (char)34 + f_ara_combo.Text + (char)(34);
            komut.CommandText = ifade;
            komut.ExecuteNonQuery();

            ifade = "UPDATE urun_tablosu u SET u.u_fiyat =" + (char)34 + f_u_fiyati.Text + (char)34 + " WHERE u.u_isim = " + (char)34 + f_ara_combo.Text + (char)(34);
            komut.CommandText = ifade;
            komut.ExecuteNonQuery();

            ifade = "UPDATE urun_tablosu u SET u.u_isim =" + (char)34 + f_u_isim.Text + (char)34 + " WHERE u.u_isim = " + (char)34 + f_ara_combo.Text + (char)(34);
            komut.CommandText = ifade;
            komut.ExecuteNonQuery();

            //Eğer ürün seri no değişti ise bunun stok tablosunda da değiştirilmesi gerekir.

            if (sec_urun_seri != f_u_seri.Text)
            {
                ifade = "UPDATE stok_tablosu s SET s.s_u_seri =" + (char)34 + f_u_seri.Text + (char)34 + " WHERE s.s_u_seri = " + (char)34 + sec_urun_seri + (char)(34);
                komut.CommandText = ifade;
                komut.ExecuteNonQuery();
            }


            MessageBox.Show("Data corrected...");
            basla();
            f_u_isim.Text = "";
            f_u_seri.Text ="";
            f_u_fiyati.Text = "";
            f_u_brm_combo.SelectedIndex = -1;
           

        }



        private void f_ara_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            komut.CommandText = "select * from urun_tablosu where u_isim='" + f_ara_combo.SelectedItem + "'";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                sec_urun_seri= Convert.ToString(dr["u_seri"]);
                f_u_isim.Text = Convert.ToString(dr["u_isim"]);
                f_u_seri.Text = Convert.ToString(dr["u_seri"]);
                f_u_fiyati.Text = Convert.ToString(dr["u_fiyat"]);
                for (int i = 0; i < f_u_brm_combo.Items.Count; i++)
                {
                    if (f_u_brm_combo.Items[i].ToString() == Convert.ToString(dr["u_birim"]))
                    {
                        f_u_brm_combo.SelectedItem = f_u_brm_combo.Items[i];
                        break;
                    }
                }


            }
            dr.Close();
        }

        private void cik_Click(object sender, EventArgs e)
        {
            baglan.Close();
            this.Close();
        }
    }
}
