namespace laba2sql
{
    partial class dopForm
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
            this.dataGridView_producer = new System.Windows.Forms.DataGridView();
            this.label_country = new System.Windows.Forms.Label();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.label_organization = new System.Windows.Forms.Label();
            this.textBox_organization = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_phone = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.button_add2 = new System.Windows.Forms.Button();
            this.button_refresh2 = new System.Windows.Forms.Button();
            this.button_close2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_producer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_producer
            // 
            this.dataGridView_producer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_producer.Location = new System.Drawing.Point(304, 63);
            this.dataGridView_producer.Name = "dataGridView_producer";
            this.dataGridView_producer.RowHeadersWidth = 51;
            this.dataGridView_producer.RowTemplate.Height = 24;
            this.dataGridView_producer.Size = new System.Drawing.Size(589, 375);
            this.dataGridView_producer.TabIndex = 0;
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.Location = new System.Drawing.Point(16, 107);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(55, 16);
            this.label_country.TabIndex = 1;
            this.label_country.Text = "Страна";
            // 
            // textBox_country
            // 
            this.textBox_country.Location = new System.Drawing.Point(19, 126);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(176, 22);
            this.textBox_country.TabIndex = 2;
            // 
            // label_organization
            // 
            this.label_organization.AutoSize = true;
            this.label_organization.Location = new System.Drawing.Point(16, 63);
            this.label_organization.Name = "label_organization";
            this.label_organization.Size = new System.Drawing.Size(94, 16);
            this.label_organization.TabIndex = 3;
            this.label_organization.Text = "Организация";
            // 
            // textBox_organization
            // 
            this.textBox_organization.Location = new System.Drawing.Point(19, 82);
            this.textBox_organization.Name = "textBox_organization";
            this.textBox_organization.Size = new System.Drawing.Size(176, 22);
            this.textBox_organization.TabIndex = 4;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(16, 151);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(47, 16);
            this.label_address.TabIndex = 5;
            this.label_address.Text = "Адрес";
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(19, 170);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(176, 22);
            this.textBox_address.TabIndex = 6;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(16, 195);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(67, 16);
            this.label_phone.TabIndex = 7;
            this.label_phone.Text = "Телефон";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(19, 214);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(176, 22);
            this.textBox_phone.TabIndex = 8;
            // 
            // button_add2
            // 
            this.button_add2.Location = new System.Drawing.Point(19, 257);
            this.button_add2.Name = "button_add2";
            this.button_add2.Size = new System.Drawing.Size(176, 23);
            this.button_add2.TabIndex = 9;
            this.button_add2.Text = "Добавить";
            this.button_add2.UseVisualStyleBackColor = true;
            this.button_add2.Click += new System.EventHandler(this.button_add2_Click);
            // 
            // button_refresh2
            // 
            this.button_refresh2.Location = new System.Drawing.Point(19, 312);
            this.button_refresh2.Name = "button_refresh2";
            this.button_refresh2.Size = new System.Drawing.Size(176, 23);
            this.button_refresh2.TabIndex = 10;
            this.button_refresh2.Text = "Обновить";
            this.button_refresh2.UseVisualStyleBackColor = true;
            this.button_refresh2.Click += new System.EventHandler(this.button_refresh2_Click);
            // 
            // button_close2
            // 
            this.button_close2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_close2.Location = new System.Drawing.Point(843, 12);
            this.button_close2.Name = "button_close2";
            this.button_close2.Size = new System.Drawing.Size(50, 44);
            this.button_close2.TabIndex = 11;
            this.button_close2.Text = "X";
            this.button_close2.UseVisualStyleBackColor = true;
            this.button_close2.Click += new System.EventHandler(this.button_close2_Click);
            // 
            // dopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.button_close2);
            this.Controls.Add(this.button_refresh2);
            this.Controls.Add(this.button_add2);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.textBox_organization);
            this.Controls.Add(this.label_organization);
            this.Controls.Add(this.textBox_country);
            this.Controls.Add(this.label_country);
            this.Controls.Add(this.dataGridView_producer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dopForm";
            this.Text = "dopForm";
            this.Load += new System.EventHandler(this.dopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_producer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_producer;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.TextBox textBox_country;
        private System.Windows.Forms.Label label_organization;
        public System.Windows.Forms.TextBox textBox_organization;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Button button_add2;
        private System.Windows.Forms.Button button_refresh2;
        private System.Windows.Forms.Button button_close2;
    }
}