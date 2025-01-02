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
    public partial class customerRegistration : Form
    {
        public customerRegistration()
        {
            InitializeComponent();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            if ((f_m_tc_no.Text == "") || (f_m_isim.Text == "") || (f_m_tel.Text == "") || (f_m_adres.Text == ""))
            {
                MessageBox.Show(" * Do not leave required information blank ...");
                return;
            }

            MySqlConnection baglan = new MySqlConnection("Server = Localhost; Database = stok;uid=root;Pwd='';");

            try
            {
                baglan.Open();
                MySqlCommand komut = new MySqlCommand("insert into musteri_tablosu (m_tc_no,m_isim,m_tel,m_adres,m_mail,m_firma_ismi) values ( '" + f_m_tc_no.Text + "','" +
                    f_m_isim.Text + "','" + f_m_tel.Text + "','" + f_m_adres.Text + "','" + f_m_mail.Text + "','" + f_m_firma_ismi.Text + "')", baglan);

                object sonuc = null;
                sonuc = komut.ExecuteNonQuery();
                if (sonuc != null)
                {
                    MessageBox.Show("Data Saved to System..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    f_m_tc_no.Text = "";
                    f_m_isim.Text = "";
                    f_m_tel.Text = "";
                    f_m_adres.Text = "";
                    f_m_mail.Text = "";
                    f_m_firma_ismi.Text = "";
                }
                else

                    MessageBox.Show("Data Could Not Be Saved..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                komut.Dispose();
                baglan.Close();
            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata" + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

