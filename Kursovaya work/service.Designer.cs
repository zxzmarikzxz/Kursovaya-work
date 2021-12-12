
namespace Kursovaya_work
{
    partial class service
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
            this.ID_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_service,
            this.service2,
            this.cost_service});
            this.dataGridView1.Location = new System.Drawing.Point(39, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 397);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID_service
            // 
            this.ID_service.HeaderText = "ID_service";
            this.ID_service.Name = "ID_service";
            // 
            // service2
            // 
            this.service2.FillWeight = 300F;
            this.service2.HeaderText = "service2";
            this.service2.Name = "service2";
            // 
            // cost_service
            // 
            this.cost_service.HeaderText = "cost_service";
            this.cost_service.Name = "cost_service";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вывод списка доступных услуг";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "service";
            this.Text = "service";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.service_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn service2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost_service;
    }
}