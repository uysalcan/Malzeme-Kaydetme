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
    public partial class Form3 : Form
    {
      //  int numlines = 0;
        public Form3()
        {
            InitializeComponent();
        }
  
        private string message = string.Empty;
        SqlConnection baglan = new SqlConnection("Data Source=TECHADDICTED;Initial Catalog=dbMalzeme;Integrated Security=True");
     
        

         
        private void Form3_Load(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MalzNoTxt.Clear();
            GirisTxt.Clear();
            DegerCmb.SelectedItem = null;
            DurumList.Items.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (MalzNoTxt.Text == "")
                hata = 1;
            if (GirisTxt.Text == "")
                hata = 1;
            if (DegerCmb.Text == "")
                hata = 1;
            if (hata == 1)
                MessageBox.Show("MALZEME ALANLARI boş bırakılamaz");
            else
            {
                DurumList.Items.Clear();
                string[] parcalar = GirisTxt.Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                for (int i = 0; i < parcalar.Length; i++)
                {
                    baglan.Open();
                    SqlCommand kmt = new SqlCommand();
                    kmt.Connection = baglan;
                    kmt.CommandType = CommandType.StoredProcedure;
                    kmt.CommandText = "Spnew"; //SP ismi
                    kmt.Parameters.Add("@alan", SqlDbType.NVarChar, 50);
                    kmt.Parameters["@alan"].Value = DegerCmb.Text;
                    kmt.Parameters.Add("@deger", SqlDbType.NVarChar, 50);
                    kmt.Parameters["@deger"].Value = MalzNoTxt.Text;
                    kmt.Parameters.Add("@no", SqlDbType.NVarChar, 50);
                    kmt.Parameters["@no"].Value = parcalar[i];
                    kmt.Parameters.Add("@ERROR", SqlDbType.Char, 500);
                    kmt.Parameters["@ERROR"].Direction = ParameterDirection.Output;
                    kmt.ExecuteNonQuery();
                    message = (string)kmt.Parameters["@ERROR"].Value;//stringe çevirip daha kolay cekmeye yarıyor
                    baglan.Close();
                 
                    string[] sutunlar = { parcalar[i], message };

                    DurumList.Items.Add(new ListViewItem(sutunlar));

                }
            }
        }
        }
       
    }  

