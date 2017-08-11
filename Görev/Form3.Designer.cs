namespace Görev
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DegerCmb = new System.Windows.Forms.ComboBox();
            this.DurumList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KaydetBtn2 = new System.Windows.Forms.Button();
            this.TemizleBtm2 = new System.Windows.Forms.Button();
            this.CikisBtn2 = new System.Windows.Forms.Button();
            this.GirisTxt = new System.Windows.Forms.TextBox();
            this.dbMalzemeDataSet = new Görev.dbMalzemeDataSet();
            this.tblMalzemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMalzemeTableAdapter = new Görev.dbMalzemeDataSetTableAdapters.tblMalzemeTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MalzNoTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbMalzemeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalzemeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DegerCmb
            // 
            this.DegerCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DegerCmb.FormattingEnabled = true;
            this.DegerCmb.Items.AddRange(new object[] {
            "Desenno",
            "Denemeno",
            "Ebat",
            "Renk",
            "Iplık",
            "Tuse"});
            this.DegerCmb.Location = new System.Drawing.Point(4, 19);
            this.DegerCmb.Name = "DegerCmb";
            this.DegerCmb.Size = new System.Drawing.Size(263, 21);
            this.DegerCmb.TabIndex = 1;
            this.DegerCmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DurumList
            // 
            this.DurumList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.DurumList.Location = new System.Drawing.Point(180, 79);
            this.DurumList.Name = "DurumList";
            this.DurumList.Size = new System.Drawing.Size(421, 170);
            this.DurumList.TabIndex = 3;
            this.DurumList.UseCompatibleStateImageBehavior = false;
            this.DurumList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Malzeme Numarası";
            this.columnHeader1.Width = 213;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Durum";
            this.columnHeader2.Width = 207;
            // 
            // KaydetBtn2
            // 
            this.KaydetBtn2.Location = new System.Drawing.Point(383, 12);
            this.KaydetBtn2.Name = "KaydetBtn2";
            this.KaydetBtn2.Size = new System.Drawing.Size(69, 64);
            this.KaydetBtn2.TabIndex = 4;
            this.KaydetBtn2.Text = "Kaydet";
            this.KaydetBtn2.UseVisualStyleBackColor = true;
            this.KaydetBtn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // TemizleBtm2
            // 
            this.TemizleBtm2.Location = new System.Drawing.Point(459, 12);
            this.TemizleBtm2.Name = "TemizleBtm2";
            this.TemizleBtm2.Size = new System.Drawing.Size(70, 64);
            this.TemizleBtm2.TabIndex = 5;
            this.TemizleBtm2.Text = "Temizle";
            this.TemizleBtm2.UseVisualStyleBackColor = true;
            this.TemizleBtm2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CikisBtn2
            // 
            this.CikisBtn2.Location = new System.Drawing.Point(535, 12);
            this.CikisBtn2.Name = "CikisBtn2";
            this.CikisBtn2.Size = new System.Drawing.Size(75, 64);
            this.CikisBtn2.TabIndex = 6;
            this.CikisBtn2.Text = "Çıkış";
            this.CikisBtn2.UseVisualStyleBackColor = true;
            this.CikisBtn2.Click += new System.EventHandler(this.button3_Click);
            // 
            // GirisTxt
            // 
            this.GirisTxt.Location = new System.Drawing.Point(12, 79);
            this.GirisTxt.Multiline = true;
            this.GirisTxt.Name = "GirisTxt";
            this.GirisTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GirisTxt.Size = new System.Drawing.Size(162, 170);
            this.GirisTxt.TabIndex = 8;
            // 
            // dbMalzemeDataSet
            // 
            this.dbMalzemeDataSet.DataSetName = "dbMalzemeDataSet";
            this.dbMalzemeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMalzemeBindingSource
            // 
            this.tblMalzemeBindingSource.DataMember = "tblMalzeme";
            this.tblMalzemeBindingSource.DataSource = this.dbMalzemeDataSet;
            // 
            // tblMalzemeTableAdapter
            // 
            this.tblMalzemeTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MalzNoTxt);
            this.groupBox1.Controls.Add(this.DegerCmb);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 69);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncellenecek Malzeme Alanını Seçiniz";
            // 
            // MalzNoTxt
            // 
            this.MalzNoTxt.Location = new System.Drawing.Point(4, 43);
            this.MalzNoTxt.Name = "MalzNoTxt";
            this.MalzNoTxt.Size = new System.Drawing.Size(163, 20);
            this.MalzNoTxt.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(613, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GirisTxt);
            this.Controls.Add(this.CikisBtn2);
            this.Controls.Add(this.TemizleBtm2);
            this.Controls.Add(this.KaydetBtn2);
            this.Controls.Add(this.DurumList);
            this.Name = "Form3";
            this.Text = "Toplu Veri Güncelleme";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbMalzemeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalzemeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox DegerCmb;
        private System.Windows.Forms.ListView DurumList;
        private System.Windows.Forms.Button KaydetBtn2;
        private System.Windows.Forms.Button TemizleBtm2;
        private System.Windows.Forms.Button CikisBtn2;
        private System.Windows.Forms.TextBox GirisTxt;
        private dbMalzemeDataSet dbMalzemeDataSet;
        private System.Windows.Forms.BindingSource tblMalzemeBindingSource;
        private dbMalzemeDataSetTableAdapters.tblMalzemeTableAdapter tblMalzemeTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox MalzNoTxt;
    }
}