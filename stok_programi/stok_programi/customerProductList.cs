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
    public partial class customerProductList : Form
    {
       public char menu_sec;
       MySqlConnection baglan = new MySqlConnection();
       MySqlCommand komut = new MySqlCommand();
       MySqlDataReader dr;
        String[] sec_urun_list = new String[1000];
        public customerProductList()
        {
            InitializeComponent();
        }

        private void musteri_urun_listesi_Load(object sender, EventArgs e)
        {
            // Formun ControlBox özelliğini false yaparak sağ üstteki kontrolleri iptal ediyoruz
            // Böylece çıkış işlemini mutlaka çıkış butonundan yapılmasını sağlıyoruz.

            baglan.ConnectionString = "Server=localhost;database=stok;; Convert Zero Datetime=true; Allow Zero Datetime=true ;Uid=root;Pwd='' ";
            baglan.Open();
            komut.Connection = baglan;




            if (menu_sec == 'm')
            {
                d_grid.Visible = false;
                liste.Visible = true;
                bindingNavigator1.Visible = false;
                komut.CommandText = "select * from musteri_tablosu";
                dr = komut.ExecuteReader();
                liste.SelectionTabs = new int[] { 120, 250, 400, 600, 750 };

                liste.Text = "Muşteri Tc \t Ad Soyad  \t Telefon \t Firma \t Mail \n";
                while (dr.Read())
                {
                    liste.Text += dr["m_tc_no"] + "\t" + dr["m_isim"] + "\t" + dr["m_tel"] + "\t" + dr["m_firma_ismi"] + "\t" + dr["m_mail"] + "\n";
                }
            }

            if (menu_sec == 'u')
            {
                d_grid.Visible = false;
                liste.Visible = true;
                bindingNavigator1.Visible = false;
                komut.CommandText = "select * from urun_tablosu";
                dr = komut.ExecuteReader();
                liste.SelectionTabs = new int[] { 120, 400, 550, 650 };

                liste.Text = "Ürün Seri No\t Ürün Adı  \t Birimi \t Alış Fiyatı \n";
                while (dr.Read())
                {
                    liste.Text += dr["u_seri"] + "\t" + dr["u_isim"] + "\t" + dr["u_birim"] + "\t" + dr["u_fiyat"] + "\n";
                }
            }


            if (menu_sec == 't')
            {
                //d_grid nesnesinin AutoSizeColumns özelliğini Fill yaparak sütunları ekrana full yerleşim sağlarız.
                // d_grid font ayarı alttaki hibi yapılır
                // this.d_grid.DefaultCellStyle.Font = new Font("Arial", 12);
                //d_grig hücre font özellikleri defaultCellStyle özelliği ile düzenlenir.
                //d_grig sütun başlıkları font özellikleri RowHeaderdefaultCellStyle özelliği ile düzenlenir.

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable tablo = new DataTable();
                d_grid.Visible = true;
                liste.Visible = false;
                bindingNavigator1.Visible = true;
                komut.CommandText = "select * from urun_tablosu   ";
                komut.Connection = baglan;
                da.SelectCommand = komut;
                da.Fill(tablo);
               // d_grid.DataSource = tablo; //Navigator kullanılmayacaksa alttaki 3 satır yerine bu satır kullanılır

                 bindingSource1.DataSource = tablo;
                 d_grid.DataSource = bindingSource1;
                 bindingNavigator1.BindingSource = bindingSource1;

            }

            if (menu_sec == 's')
            {

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable tablo = new DataTable();
                d_grid.Visible = true;
                liste.Visible = false;
                bindingNavigator1.Visible = false;
                // Sistem tarih ve saat formatı ile MySql date vetime format aynı değilse
                // sorgu içerisinde dönüştürme yapmak gerekir. Altta dönüşüm görülmektedir
                komut.CommandText = "select s_u_seri, s_m_tc,s_miktar,s_fiyat,s_tutar,CONVERT(s_tarih, NCHAR) AS s_tarih,CONVERT(s_saat, NCHAR) AS s_saat, s_al_sat  from stok_tablosu";
                komut.Connection = baglan;
                da.SelectCommand = komut;

                da.Fill(tablo);
                d_grid.DataSource = tablo;
            }



            if (menu_sec == 'd')
            {
                int i = 0;
                d_grid.Visible = false;
                liste.Visible = true;
                bindingNavigator1.Visible = false;
                urun_sec_c.Visible = true;

                komut.CommandText = "select * from urun_tablosu";
                dr = komut.ExecuteReader();
                urun_sec_c.Items.Clear();
                while (dr.Read())
                {
                    urun_sec_c.Items.Add(dr["u_isim"]);
                    sec_urun_list[i] =Convert.ToString(dr["u_seri"]);
                    i++;
                        }
                komut.Dispose();
                dr.Close();

            }

        }






        private void urun_sec_c_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double gelen=0, giden=0, fark = 0;
            liste.Text = "";
            komut.CommandText = "select * from stok_tablosu where s_u_seri='"+sec_urun_list[urun_sec_c.SelectedIndex]+"' ";

             dr = komut.ExecuteReader();
            liste.SelectionTabs = new int[] { 120, 220, 330, 440, 550,660,770 };

            liste.Text = "Müşteri TC\t Miktar  \t Fiyat \t Tutar \t Tarih \t Saat \t AL/SAT \n";
            while (dr.Read())
            {

                liste.Text += dr["s_m_tc"] + "\t" + dr["s_miktar"] + "\t" + dr["s_fiyat"] + "\t" + dr["s_tutar"] + "\t" + dr["s_tarih"] + "\t" + dr["s_saat"] + "\t" + dr["s_al_sat"] + "\n";
                if (Convert.ToString(dr["s_al_sat"]) == "AL") gelen +=Convert.ToDouble( dr["s_miktar"]);
                else giden += Convert.ToDouble(dr["s_miktar"]);

            }
            liste.Text += "------------------------------------------\n";
            liste.Text += "Alınan Toplamı  : " + Convert.ToString(gelen)+"\n";
            liste.Text += "Satılan Toplamı : " + Convert.ToString(giden) + "\n";
            fark = gelen - giden;
            liste.Text += "Stoktaki Ürün   : " + Convert.ToString(fark) + "\n";
            dr.Close();
            komut.Dispose();


        }

        private void cik_Click(object sender, EventArgs e)
        {
            komut.Dispose();
            baglan.Close();
            this.Close();
        }
    }
}
