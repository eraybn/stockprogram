using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stok_programi
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void ürünTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productRegistration u_kayit_frm = new productRegistration();
            u_kayit_frm.ShowDialog();
        }

        private void müşteriTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerRegistration m_kayit_frm = new customerRegistration();
            m_kayit_frm.ShowDialog();
        }

        private void ürünSatınAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            transactionForm islem_frm = new transactionForm();
            islem_frm.menu_sec = 'a';
            islem_frm.Show();
        }

        private void ürünSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionForm islem_frm = new transactionForm();
            islem_frm.menu_sec = 's';
            islem_frm.Show();
        }

        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerProductList m_u_list = new customerProductList();
            m_u_list.menu_sec = 'm';
            m_u_list.ShowDialog();

        }



        private void textListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerProductList m_u_list = new customerProductList();
            m_u_list.menu_sec = 'u';
            m_u_list.ShowDialog();
        }

        private void tabloŞeklindeListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerProductList m_u_list = new customerProductList();
            m_u_list.menu_sec = 't';
            m_u_list.Show();
        }

        private void alışVerişListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerProductList m_u_list = new customerProductList();
            m_u_list.menu_sec = 's';
            m_u_list.Show();
        }

        private void ürünStokListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerProductList m_u_list = new customerProductList();
            m_u_list.menu_sec = 'd';
            m_u_list.Show();
        }

        private void ürünBilgiDüzeltmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           productSearch_Fix u_a_d_frm = new productSearch_Fix();
            u_a_d_frm.ShowDialog();
        }

        private void müşteriBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerSearchCorrection m_a_d_frm = new customerSearchCorrection();
            m_a_d_frm.ShowDialog();

        }

        private void stokBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockTransactionCorrection st_d_frm = new stockTransactionCorrection();
            st_d_frm.ShowDialog();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
