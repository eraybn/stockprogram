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
    public partial class productRegistration : Form
    {
        public productRegistration()
        {
            InitializeComponent();
        }

        private void cik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            if((f_u_isim.Text=="") || (f_u_seri.Text == "") || (f_u_fiyati.Text == "") || (f_u_brm_combo.SelectedIndex < 0))
            {
                MessageBox.Show("Fill in the information completely...");
                return;
            }

            MySqlConnection bag = new MySqlConnection();
            bag.ConnectionString = "Server=localhost;Database=stok;Uid=root;Pwd=''";
            bag.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = bag;
            komut.CommandText = "insert into urun_tablosu (u_seri,u_isim,u_birim,u_fiyat,u_stok_miktar) values ('" + f_u_seri.Text + "','" + f_u_isim.Text + "','" + f_u_brm_combo.SelectedItem.ToString() + "','" + f_u_fiyati.Text + "','" + textBox1.Text + "')";
            komut.ExecuteNonQuery();
            komut.Dispose();
            bag.Close();
            MessageBox.Show("Recorded...");
            f_u_isim.Text = null;
            f_u_fiyati.Text = null;
            f_u_seri.Text = null;
            f_u_brm_combo.SelectedIndex = -1;
            f_u_brm_combo.Text = "Select unit";

        }

        private void f_u_fiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            int  n,nokta=0;
            char ch= e.KeyChar;
            if (!char.IsDigit(ch)) e.KeyChar = '\0';
            if (ch == Convert.ToChar(8)) e.KeyChar = ch;
            if (ch == '.')
            {   
                for (n=0;n< f_u_fiyati.Text.Length; n++)
                    {
                    if (f_u_fiyati.Text.Substring(n,1) == ".") nokta++;
                    }
                if (nokta == 0) e.KeyChar = '.';
            }
           
        }



 










    }
}
