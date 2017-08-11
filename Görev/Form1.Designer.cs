namespace Görev
{
    partial class Form1
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
            this.MalzemeList = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Maltxt = new System.Windows.Forms.TextBox();
            this.Desentxt = new System.Windows.Forms.TextBox();
            this.Denemetxt = new System.Windows.Forms.TextBox();
            this.Ebattxt = new System.Windows.Forms.TextBox();
            this.Renktxt = new System.Windows.Forms.TextBox();
            this.Ipliktxt = new System.Windows.Forms.TextBox();
            this.Tusetxt = new System.Windows.Forms.TextBox();
            this.Birimcmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.TemizleBtn = new System.Windows.Forms.Button();
            this.CikisBtn = new System.Windows.Forms.Button();
            this.ListelemeBtn = new System.Windows.Forms.Button();
            this.TopluVGBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExcelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MalzemeList
            // 
            this.MalzemeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.MalzemeList.FullRowSelect = true;
            this.MalzemeList.Location = new System.Drawing.Point(171, 12);
            this.MalzemeList.Name = "MalzemeList";
            this.MalzemeList.Size = new System.Drawing.Size(623, 306);
            this.MalzemeList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.MalzemeList.TabIndex = 0;
            this.MalzemeList.UseCompatibleStateImageBehavior = false;
            this.MalzemeList.View = System.Windows.Forms.View.Details;
            this.MalzemeList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "id";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Birim";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Malzemeno";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "desenno";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "denemeno";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Ebat";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Renk";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Iplik";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Tuse";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "KayıtTarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Malzemeno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Maltxt
            // 
            this.Maltxt.Location = new System.Drawing.Point(67, 19);
            this.Maltxt.Name = "Maltxt";
            this.Maltxt.Size = new System.Drawing.Size(100, 20);
            this.Maltxt.TabIndex = 2;
            // 
            // Desentxt
            // 
            this.Desentxt.Location = new System.Drawing.Point(67, 45);
            this.Desentxt.Name = "Desentxt";
            this.Desentxt.Size = new System.Drawing.Size(100, 20);
            this.Desentxt.TabIndex = 3;
            // 
            // Denemetxt
            // 
            this.Denemetxt.Location = new System.Drawing.Point(67, 72);
            this.Denemetxt.Name = "Denemetxt";
            this.Denemetxt.Size = new System.Drawing.Size(100, 20);
            this.Denemetxt.TabIndex = 4;
            // 
            // Ebattxt
            // 
            this.Ebattxt.Location = new System.Drawing.Point(67, 98);
            this.Ebattxt.Name = "Ebattxt";
            this.Ebattxt.Size = new System.Drawing.Size(100, 20);
            this.Ebattxt.TabIndex = 5;
            // 
            // Renktxt
            // 
            this.Renktxt.Location = new System.Drawing.Point(67, 124);
            this.Renktxt.Name = "Renktxt";
            this.Renktxt.Size = new System.Drawing.Size(100, 20);
            this.Renktxt.TabIndex = 6;
            // 
            // Ipliktxt
            // 
            this.Ipliktxt.Location = new System.Drawing.Point(67, 150);
            this.Ipliktxt.Name = "Ipliktxt";
            this.Ipliktxt.Size = new System.Drawing.Size(100, 20);
            this.Ipliktxt.TabIndex = 7;
            // 
            // Tusetxt
            // 
            this.Tusetxt.Location = new System.Drawing.Point(67, 176);
            this.Tusetxt.Name = "Tusetxt";
            this.Tusetxt.Size = new System.Drawing.Size(100, 20);
            this.Tusetxt.TabIndex = 8;
            // 
            // Birimcmb
            // 
            this.Birimcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Birimcmb.FormattingEnabled = true;
            this.Birimcmb.Items.AddRange(new object[] {
            "KG",
            "Litre"});
            this.Birimcmb.Location = new System.Drawing.Point(67, 202);
            this.Birimcmb.Name = "Birimcmb";
            this.Birimcmb.Size = new System.Drawing.Size(100, 21);
            this.Birimcmb.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "DesenNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ebat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Renk";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Iplik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tuse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "DenemeNo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Birim";
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.Location = new System.Drawing.Point(9, 255);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(75, 63);
            this.KaydetBtn.TabIndex = 17;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.UseVisualStyleBackColor = true;
            this.KaydetBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // TemizleBtn
            // 
            this.TemizleBtn.Location = new System.Drawing.Point(91, 255);
            this.TemizleBtn.Name = "TemizleBtn";
            this.TemizleBtn.Size = new System.Drawing.Size(75, 63);
            this.TemizleBtn.TabIndex = 18;
            this.TemizleBtn.Text = "Temizleme";
            this.TemizleBtn.UseVisualStyleBackColor = true;
            this.TemizleBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // CikisBtn
            // 
            this.CikisBtn.Location = new System.Drawing.Point(253, 324);
            this.CikisBtn.Name = "CikisBtn";
            this.CikisBtn.Size = new System.Drawing.Size(75, 53);
            this.CikisBtn.TabIndex = 19;
            this.CikisBtn.Text = "Çıkış";
            this.CikisBtn.UseVisualStyleBackColor = true;
            this.CikisBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // ListelemeBtn
            // 
            this.ListelemeBtn.Location = new System.Drawing.Point(9, 324);
            this.ListelemeBtn.Name = "ListelemeBtn";
            this.ListelemeBtn.Size = new System.Drawing.Size(75, 53);
            this.ListelemeBtn.TabIndex = 20;
            this.ListelemeBtn.Text = "Listeleme";
            this.ListelemeBtn.UseVisualStyleBackColor = true;
            this.ListelemeBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // TopluVGBtn
            // 
            this.TopluVGBtn.Location = new System.Drawing.Point(91, 324);
            this.TopluVGBtn.Name = "TopluVGBtn";
            this.TopluVGBtn.Size = new System.Drawing.Size(75, 53);
            this.TopluVGBtn.TabIndex = 21;
            this.TopluVGBtn.Text = "Toplu Veri Güncelleme";
            this.TopluVGBtn.UseVisualStyleBackColor = true;
            this.TopluVGBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Maltxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Desentxt);
            this.groupBox1.Controls.Add(this.Denemetxt);
            this.groupBox1.Controls.Add(this.Ebattxt);
            this.groupBox1.Controls.Add(this.Renktxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Ipliktxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Tusetxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Birimcmb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 228);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Değerleri";
            // 
            // ExcelBtn
            // 
            this.ExcelBtn.Location = new System.Drawing.Point(172, 324);
            this.ExcelBtn.Name = "ExcelBtn";
            this.ExcelBtn.Size = new System.Drawing.Size(75, 53);
            this.ExcelBtn.TabIndex = 23;
            this.ExcelBtn.Text = "Excel Aktarma";
            this.ExcelBtn.UseVisualStyleBackColor = true;
            this.ExcelBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(806, 389);
            this.Controls.Add(this.ExcelBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TopluVGBtn);
            this.Controls.Add(this.ListelemeBtn);
            this.Controls.Add(this.CikisBtn);
            this.Controls.Add(this.TemizleBtn);
            this.Controls.Add(this.KaydetBtn);
            this.Controls.Add(this.MalzemeList);
            this.Name = "Form1";
            this.Text = "Malzeme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView MalzemeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Maltxt;
        private System.Windows.Forms.TextBox Desentxt;
        private System.Windows.Forms.TextBox Denemetxt;
        private System.Windows.Forms.TextBox Ebattxt;
        private System.Windows.Forms.TextBox Renktxt;
        private System.Windows.Forms.TextBox Ipliktxt;
        private System.Windows.Forms.TextBox Tusetxt;
        private System.Windows.Forms.ComboBox Birimcmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button KaydetBtn;
        private System.Windows.Forms.Button TemizleBtn;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.Button CikisBtn;
        private System.Windows.Forms.Button ListelemeBtn;
        private System.Windows.Forms.Button TopluVGBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ExcelBtn;
    }
}

