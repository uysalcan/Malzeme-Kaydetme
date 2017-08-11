namespace Görev
{
    partial class Form2
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
            this.RenkTxt = new System.Windows.Forms.TextBox();
            this.VeriList = new System.Windows.Forms.ListView();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RenkTxt
            // 
            this.RenkTxt.Location = new System.Drawing.Point(6, 19);
            this.RenkTxt.Name = "RenkTxt";
            this.RenkTxt.Size = new System.Drawing.Size(601, 20);
            this.RenkTxt.TabIndex = 0;
            this.RenkTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // VeriList
            // 
            this.VeriList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.VeriList.FullRowSelect = true;
            this.VeriList.Location = new System.Drawing.Point(12, 57);
            this.VeriList.Name = "VeriList";
            this.VeriList.Size = new System.Drawing.Size(613, 192);
            this.VeriList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.VeriList.TabIndex = 1;
            this.VeriList.UseCompatibleStateImageBehavior = false;
            this.VeriList.View = System.Windows.Forms.View.Details;
            this.VeriList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.columnHeader11.Text = "Desenno";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Denemeno";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RenkTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renk No Giriniz";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(643, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VeriList);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox RenkTxt;
        private System.Windows.Forms.ListView VeriList;
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}