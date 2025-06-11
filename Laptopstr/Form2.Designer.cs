namespace Laptopstr
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbnama = new System.Windows.Forms.TextBox();
            this.txtbharga = new System.Windows.Forms.TextBox();
            this.txtbstok = new System.Windows.Forms.TextBox();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnbuy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Harga Barang:\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Barang:";
            // 
            // txtbnama
            // 
            this.txtbnama.Location = new System.Drawing.Point(222, 97);
            this.txtbnama.Name = "txtbnama";
            this.txtbnama.Size = new System.Drawing.Size(193, 30);
            this.txtbnama.TabIndex = 3;
            // 
            // txtbharga
            // 
            this.txtbharga.Location = new System.Drawing.Point(222, 163);
            this.txtbharga.Name = "txtbharga";
            this.txtbharga.Size = new System.Drawing.Size(193, 30);
            this.txtbharga.TabIndex = 3;
            // 
            // txtbstok
            // 
            this.txtbstok.Location = new System.Drawing.Point(222, 220);
            this.txtbstok.Name = "txtbstok";
            this.txtbstok.Size = new System.Drawing.Size(193, 30);
            this.txtbstok.TabIndex = 3;
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(66, 274);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(91, 56);
            this.btncreate.TabIndex = 4;
            this.btncreate.Text = "Create";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(181, 274);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(118, 56);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(323, 274);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(92, 56);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnbuy
            // 
            this.btnbuy.Location = new System.Drawing.Point(66, 357);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(349, 38);
            this.btnbuy.TabIndex = 5;
            this.btnbuy.Text = "Buy";
            this.btnbuy.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(446, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(504, 311);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.txtbstok);
            this.Controls.Add(this.txtbharga);
            this.Controls.Add(this.txtbnama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbnama;
        private System.Windows.Forms.TextBox txtbharga;
        private System.Windows.Forms.TextBox txtbstok;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}