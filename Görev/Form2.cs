using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Görev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=TECHADDICTED;Initial Catalog=dbMalzeme;Integrated Security=True");




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VeriList.Items.Clear();
            SqlCommand doldur = new SqlCommand("select * from tblMalzeme where Renk like '%" + RenkTxt.Text + "%'", baglan);
            baglan.Open();
            SqlDataReader rdr = doldur.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem li = new ListViewItem();
                li.Text = rdr["id"].ToString();
            
                li.SubItems.Add(rdr["Birim"].ToString());
                li.SubItems.Add(rdr["Malzemeno"].ToString());
                li.SubItems.Add(rdr["Desenno"].ToString());
                li.SubItems.Add(rdr["Denemeno"].ToString());
                li.SubItems.Add(rdr["Ebat"].ToString());
                li.SubItems.Add(rdr["Renk"].ToString());
                li.SubItems.Add(rdr["Iplik"].ToString());
                li.SubItems.Add(rdr["Tuse"].ToString());
                li.SubItems.Add(rdr["KayitTarih"].ToString());
                VeriList.Items.Add(li);
            }

            baglan.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From tblMalzeme", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Birim"].ToString());
                ekle.SubItems.Add(oku["Malzemeno"].ToString());
                ekle.SubItems.Add(oku["Desenno"].ToString());
                ekle.SubItems.Add(oku["Denemeno"].ToString());
                ekle.SubItems.Add(oku["Ebat"].ToString());
                ekle.SubItems.Add(oku["Renk"].ToString());
                ekle.SubItems.Add(oku["Iplik"].ToString());
                ekle.SubItems.Add(oku["Tuse"].ToString());
                ekle.SubItems.Add(oku["KayitTarih"].ToString());
                VeriList.Items.Add(ekle);
            }
            baglan.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
        
            
        
        

