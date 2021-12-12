
namespace Kursovaya_work
{
    partial class prosmotr_uslug
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_sr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_sr,
            this.fio_client,
            this.brand,
            this.date_time,
            this.service});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // id_sr
            // 
            this.id_sr.HeaderText = "id";
            this.id_sr.Name = "id_sr";
            // 
            // fio_client
            // 
            this.fio_client.HeaderText = "fio_client";
            this.fio_client.Name = "fio_client";
            // 
            // brand
            // 
            this.brand.HeaderText = "brand";
            this.brand.Name = "brand";
            // 
            // date_time
            // 
            this.date_time.HeaderText = "date";
            this.date_time.Name = "date_time";
            // 
            // service
            // 
            this.service.HeaderText = "service";
            this.service.Name = "service";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Просмотр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prosmotr_uslug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "prosmotr_uslug";
            this.Text = "prosmotr_uslug";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.prosmotr_uslug_FormClosed);
            this.Load += new System.EventHandler(this.prosmotr_uslug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.Button button1;
    }
}