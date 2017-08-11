using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Office.Interop.Excel;

namespace Görev
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=TECHADDICTED;Initial Catalog=dbMalzeme;Integrated Security=True");
        private void verilerigörüntüle()
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
                MalzemeList.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e)
        {
            Maltxt.MaxLength = 8;
            Desentxt.MaxLength = 30;
            Denemetxt.MaxLength = 30;
            Ebattxt.MaxLength = 30;
            Renktxt.MaxLength = 30;
            Ipliktxt.MaxLength = 30;
            Tusetxt.MaxLength = 30;
            verilerigörüntüle();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (Maltxt.Text == "")
                hata = 1;
            if (Desentxt.Text == "")
                hata = 1;
            if (Denemetxt.Text == "")
                hata = 1;
            if (Ebattxt.Text == "")
                hata = 1;
            if (Renktxt.Text == "")
                hata = 1;
            if (Ipliktxt.Text == "")
                hata = 1;
            if (Tusetxt.Text == "")
                hata = 1;
            if (Birimcmb.Text == "")
                hata = 1;
            if (hata == 1)
                MessageBox.Show("Boş Bırakılamaz.");
            else
            {
                baglan.Open();
                try
                {
                    SqlCommand komut = new SqlCommand("Insert into  tblMalzeme(Birim,Malzemeno,Desenno,Denemeno,Ebat,Renk,Iplik,Tuse) VALUES  ('"
                    + Birimcmb.Text + "','"
                    + Maltxt.Text + "','"
                    + Desentxt.Text + "','"
                    + Denemetxt.Text + "','"
                    + Ebattxt.Text + "','"
                    + Renktxt.Text + "','"
                    + Ipliktxt.Text + "','"
                    + Tusetxt.Text + "')", baglan);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MalzemeList.Items.Clear();
                    verilerigörüntüle();
                }
                catch (SqlException)
                {
                    DialogResult cikis = MessageBox.Show("Güncellemek İstediğinize Eminmisiz?", "Emin Misiniz?", MessageBoxButtons.YesNo);
                    if (cikis == DialogResult.Yes)
                    {

                        SqlCommand komut = new SqlCommand("update tblMalzeme set Birim='" + Birimcmb.Text.ToString() + "',Malzemeno='" + Maltxt.Text.ToString() + "',Desenno='" + Desentxt.Text.ToString() + "' ,Denemeno='" + Denemetxt.Text.ToString() + "' ,Ebat='" + Ebattxt.Text.ToString() + "' ,Renk='" + Renktxt.Text.ToString() + "' ,Iplik='" + Ipliktxt.Text.ToString() + "' ,Tuse='" + Tusetxt.Text.ToString() + "'where id=" + id + "", baglan);
                        komut.ExecuteNonQuery();
                        baglan.Close();//
                        MalzemeList.Items.Clear();
                        verilerigörüntüle();
                    }
                    if (cikis == DialogResult.No)
                    {
                        baglan.Close();
                    }
                }
            }
        }
        int id = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            MalzemeList.Items.Clear();//Silinen listview
            Maltxt.Clear();
            Desentxt.Clear();
            Denemetxt.Clear();
            Ebattxt.Clear();
            Renktxt.Clear();
            Ipliktxt.Clear();
            Tusetxt.Clear();
            Birimcmb.SelectedItem = null;
            verilerigörüntüle();//Silinen listview verisini geriye yazdırmak (Refresh özelliği) olarak ayarladım
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(MalzemeList.SelectedItems[0].SubItems[0].Text);
            Birimcmb.Text = MalzemeList.SelectedItems[0].SubItems[1].Text;
            Maltxt.Text = MalzemeList.SelectedItems[0].SubItems[2].Text;
            Desentxt.Text = MalzemeList.SelectedItems[0].SubItems[3].Text;
            Denemetxt.Text = MalzemeList.SelectedItems[0].SubItems[4].Text;
            Ebattxt.Text = MalzemeList.SelectedItems[0].SubItems[5].Text;
            Renktxt.Text = MalzemeList.SelectedItems[0].SubItems[6].Text;
            Ipliktxt.Text = MalzemeList.SelectedItems[0].SubItems[7].Text;
            Tusetxt.Text = MalzemeList.SelectedItems[0].SubItems[8].Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            {
               
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];

                object hucre;
                Range rr;//using Microsoft.Office.Interop.Excel; tanımlanmadığında hata veriyor.
                string str;
                hucre = ws.Cells[1, 1];//kaçıncı hücreye geleceği
                rr = ws.get_Range(hucre, hucre);
                str = "id";
                rr.Value2 = str;
                rr.Font.Bold = true;//kalınlık
                rr.Font.Size = 12;//Boyut

                hucre = ws.Cells[1, 2];
                rr = ws.get_Range(hucre, hucre);
                str = "Birim";
                rr.Value2 = str;
                rr.Font.Bold = true;
                rr.Font.Size = 12;

                hucre = ws.Cells[1, 3];
                rr = ws.get_Range(hucre, hucre);
                str = "Malzemeno";
                rr.Value2 = str;
                rr.Font.Bold = true;
                rr.Font.Size = 12;

                hucre = ws.Cells[1, 4];
                rr = ws.get_Range(hucre, hucre);
                str = "Desenno";
                rr.Value2 = str;
                rr.Font.Bold = true;
                rr.Font.Size = 12;
               
              hucre = ws.Cells[1, 5];
                rr = ws.get_Range(hucre, hucre);
                str = "Denemeno";
                rr.Value2 = str;
                rr.Font.Bold = true;
                rr.Font.Size = 12;

                hucre = ws.Cells[1, 6];
                rr = ws.get_Range(hucre, hucre);
                str = "Ebat";
                rr.Value2 = str;
                rr.Font.Bold = true;
                rr.Font.Size = 12;

                hucre = ws.Cells[1, 7];
                rr = ws.get_Range(hucre, hucre);
                str = "Renk";
                rr.Value2 = str;
                rr.Font.Bold = true;
                rr.Font.Size = 12;

                hucre = ws.Cells[1, 8];
                rr = ws.get_Range(hucre, hucre);
                str = "Iplik";
                rr.Value2 = str;
                rr.Font.Bold = true;
                rr.Font.Size = 12;

                hucre = ws.Cells[1, 9];
                rr = ws.get_Range(hucre, hucre);
                str = "Tuse";
                rr.Value2 = str;
                rr.Font.Bold = true;
                rr.Font.Size = 12;
                hucre = ws.Cells[1, 10];

                rr = ws.get_Range(hucre, hucre);
                str = "KayitTarih";
                rr.Value2 = str;
                rr.Font.Bold = true;
                rr.Font.Size = 12;
                int dikey = 2;
                int yatay = 2;

                foreach (ListViewItem lvi in MalzemeList.Items)
                {

                    dikey = 1;
                    foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                    {
                        ws.Cells[yatay, dikey] = lvs.Text;
                        dikey++;
                        //Excel kolon genişliğini buradan aayarlıyoruz.
                        ws.Columns.ColumnWidth = 12;
                    }
                    yatay++;
                }
            }
        }
    }
}

        
    
        



        
    