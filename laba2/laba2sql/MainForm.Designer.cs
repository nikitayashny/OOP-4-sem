namespace laba2sql
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CloseButton = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_size = new System.Windows.Forms.Label();
            this.numericUpDown_size = new System.Windows.Forms.NumericUpDown();
            this.label_weight = new System.Windows.Forms.Label();
            this.numericUpDown_weight = new System.Windows.Forms.NumericUpDown();
            this.label_type = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label_date = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label_amount = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.numericUpDown_amount = new System.Windows.Forms.NumericUpDown();
            this.trackBar_price = new System.Windows.Forms.TrackBar();
            this.label_producer = new System.Windows.Forms.Label();
            this.textBox_producer = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.dataGridView_Product = new System.Windows.Forms.DataGridView();
            this.button_toProducer = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_search = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_searchType = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_program = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_close = new System.Windows.Forms.ToolStripButton();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label_min = new System.Windows.Forms.Label();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.label_max = new System.Windows.Forms.Label();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.button_Tools = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_delete = new System.Windows.Forms.Label();
            this.textBox_delete = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(1022, 34);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(13, 58);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(73, 16);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Название";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(16, 78);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(165, 22);
            this.textBox_name.TabIndex = 3;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(13, 108);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(141, 16);
            this.id.TabIndex = 4;
            this.id.Text = "Инвентарный номер";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(16, 127);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(165, 22);
            this.textBox_id.TabIndex = 5;
            this.textBox_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_id_KeyPress);
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(13, 156);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(57, 16);
            this.label_size.TabIndex = 6;
            this.label_size.Text = "Размер";
            // 
            // numericUpDown_size
            // 
            this.numericUpDown_size.Location = new System.Drawing.Point(16, 175);
            this.numericUpDown_size.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_size.Name = "numericUpDown_size";
            this.numericUpDown_size.Size = new System.Drawing.Size(165, 22);
            this.numericUpDown_size.TabIndex = 7;
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Location = new System.Drawing.Point(13, 206);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(31, 16);
            this.label_weight.TabIndex = 8;
            this.label_weight.Text = "Вес";
            // 
            // numericUpDown_weight
            // 
            this.numericUpDown_weight.Location = new System.Drawing.Point(16, 225);
            this.numericUpDown_weight.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_weight.Name = "numericUpDown_weight";
            this.numericUpDown_weight.Size = new System.Drawing.Size(165, 22);
            this.numericUpDown_weight.TabIndex = 9;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(13, 255);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(32, 16);
            this.label_type.TabIndex = 10;
            this.label_type.Text = "Тип";
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Бутылка",
            "Коробка",
            "Пакет",
            "Ящик"});
            this.comboBox_type.Location = new System.Drawing.Point(16, 274);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(165, 24);
            this.comboBox_type.TabIndex = 11;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(13, 306);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(39, 16);
            this.label_date.TabIndex = 12;
            this.label_date.Text = "Дата";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(16, 325);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(165, 22);
            this.dateTimePicker_date.TabIndex = 13;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Location = new System.Drawing.Point(13, 355);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(85, 16);
            this.label_amount.TabIndex = 14;
            this.label_amount.Text = "Количество";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(13, 404);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(40, 16);
            this.label_price.TabIndex = 17;
            this.label_price.Text = "Цена";
            // 
            // numericUpDown_amount
            // 
            this.numericUpDown_amount.Location = new System.Drawing.Point(16, 374);
            this.numericUpDown_amount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown_amount.Name = "numericUpDown_amount";
            this.numericUpDown_amount.Size = new System.Drawing.Size(165, 22);
            this.numericUpDown_amount.TabIndex = 18;
            // 
            // trackBar_price
            // 
            this.trackBar_price.Location = new System.Drawing.Point(16, 423);
            this.trackBar_price.Maximum = 100000;
            this.trackBar_price.Name = "trackBar_price";
            this.trackBar_price.Size = new System.Drawing.Size(165, 56);
            this.trackBar_price.TabIndex = 19;
            this.trackBar_price.Scroll += new System.EventHandler(this.trackBar_price_Scroll);
            // 
            // label_producer
            // 
            this.label_producer.AutoSize = true;
            this.label_producer.Location = new System.Drawing.Point(13, 482);
            this.label_producer.Name = "label_producer";
            this.label_producer.Size = new System.Drawing.Size(111, 16);
            this.label_producer.TabIndex = 20;
            this.label_producer.Text = "Производитель";
            // 
            // textBox_producer
            // 
            this.textBox_producer.Location = new System.Drawing.Point(16, 502);
            this.textBox_producer.Name = "textBox_producer";
            this.textBox_producer.Size = new System.Drawing.Size(165, 22);
            this.textBox_producer.TabIndex = 21;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(16, 567);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(165, 23);
            this.AddButton.TabIndex = 22;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(875, 77);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(157, 23);
            this.button_refresh.TabIndex = 23;
            this.button_refresh.Text = "Обновить таблицу";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // dataGridView_Product
            // 
            this.dataGridView_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Product.Location = new System.Drawing.Point(219, 78);
            this.dataGridView_Product.Name = "dataGridView_Product";
            this.dataGridView_Product.RowHeadersWidth = 51;
            this.dataGridView_Product.RowTemplate.Height = 24;
            this.dataGridView_Product.Size = new System.Drawing.Size(650, 512);
            this.dataGridView_Product.TabIndex = 24;
            // 
            // button_toProducer
            // 
            this.button_toProducer.Location = new System.Drawing.Point(874, 567);
            this.button_toProducer.Name = "button_toProducer";
            this.button_toProducer.Size = new System.Drawing.Size(157, 23);
            this.button_toProducer.TabIndex = 25;
            this.button_toProducer.Text = "Производители";
            this.button_toProducer.UseVisualStyleBackColor = true;
            this.button_toProducer.Click += new System.EventHandler(this.button_toProducer_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_search,
            this.toolStripButton_searchType,
            this.toolStripButton1,
            this.toolStripButton_program,
            this.toolStripButton_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1074, 27);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripButton_search
            // 
            this.toolStripButton_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_search.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_search.Image")));
            this.toolStripButton_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_search.Name = "toolStripButton_search";
            this.toolStripButton_search.Size = new System.Drawing.Size(152, 24);
            this.toolStripButton_search.Text = "Поиск по названию";
            this.toolStripButton_search.Click += new System.EventHandler(this.toolStripButton_search_Click);
            // 
            // toolStripButton_searchType
            // 
            this.toolStripButton_searchType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_searchType.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_searchType.Image")));
            this.toolStripButton_searchType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_searchType.Name = "toolStripButton_searchType";
            this.toolStripButton_searchType.Size = new System.Drawing.Size(113, 24);
            this.toolStripButton_searchType.Text = "Поиск по типу";
            this.toolStripButton_searchType.Click += new System.EventHandler(this.toolStripButton_searchType_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(116, 24);
            this.toolStripButton1.Text = "Поиск по цене";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton_program
            // 
            this.toolStripButton_program.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_program.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_program.Image")));
            this.toolStripButton_program.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_program.Name = "toolStripButton_program";
            this.toolStripButton_program.Size = new System.Drawing.Size(108, 24);
            this.toolStripButton_program.Text = "О программе";
            this.toolStripButton_program.Click += new System.EventHandler(this.toolStripButton_program_Click);
            // 
            // toolStripButton_close
            // 
            this.toolStripButton_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_close.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_close.Image")));
            this.toolStripButton_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_close.Name = "toolStripButton_close";
            this.toolStripButton_close.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton_close.Text = "<";
            this.toolStripButton_close.Click += new System.EventHandler(this.toolStripButton_close_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(12, 34);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(206, 22);
            this.textBox_search.TabIndex = 27;
            this.textBox_search.Visible = false;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(220, 31);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 28);
            this.button_search.TabIndex = 28;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Visible = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(301, 37);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(28, 16);
            this.label_min.TabIndex = 29;
            this.label_min.Text = "min";
            this.label_min.Visible = false;
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(335, 34);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(100, 22);
            this.textBox_min.TabIndex = 30;
            this.textBox_min.Visible = false;
            this.textBox_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_min_KeyPress);
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(441, 37);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(32, 16);
            this.label_max.TabIndex = 31;
            this.label_max.Text = "max";
            this.label_max.Visible = false;
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(479, 34);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(100, 22);
            this.textBox_max.TabIndex = 32;
            this.textBox_max.Visible = false;
            this.textBox_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_max_KeyPress);
            // 
            // button_Tools
            // 
            this.button_Tools.Location = new System.Drawing.Point(2, 0);
            this.button_Tools.Name = "button_Tools";
            this.button_Tools.Size = new System.Drawing.Size(19, 23);
            this.button_Tools.TabIndex = 33;
            this.button_Tools.Text = ">";
            this.button_Tools.UseVisualStyleBackColor = true;
            this.button_Tools.Click += new System.EventHandler(this.button_Tools_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(875, 106);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(156, 23);
            this.button_clear.TabIndex = 34;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_delete
            // 
            this.label_delete.AutoSize = true;
            this.label_delete.Location = new System.Drawing.Point(872, 137);
            this.label_delete.Name = "label_delete";
            this.label_delete.Size = new System.Drawing.Size(105, 16);
            this.label_delete.TabIndex = 35;
            this.label_delete.Text = "Удаление по id";
            // 
            // textBox_delete
            // 
            this.textBox_delete.Location = new System.Drawing.Point(875, 156);
            this.textBox_delete.Name = "textBox_delete";
            this.textBox_delete.Size = new System.Drawing.Size(156, 22);
            this.textBox_delete.TabIndex = 36;
            this.textBox_delete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_delete_KeyPress);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(875, 184);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(92, 23);
            this.button_delete.TabIndex = 37;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(794, 37);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 38;
            this.button_back.Text = "Назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 613);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1074, 22);
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1074, 635);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_delete);
            this.Controls.Add(this.label_delete);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Tools);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_toProducer);
            this.Controls.Add(this.dataGridView_Product);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textBox_producer);
            this.Controls.Add(this.label_producer);
            this.Controls.Add(this.trackBar_price);
            this.Controls.Add(this.numericUpDown_amount);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.numericUpDown_weight);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.numericUpDown_size);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.id);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.NumericUpDown numericUpDown_size;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.NumericUpDown numericUpDown_weight;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.NumericUpDown numericUpDown_amount;
        private System.Windows.Forms.TrackBar trackBar_price;
        private System.Windows.Forms.Label label_producer;
        public System.Windows.Forms.TextBox textBox_producer;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataGridView dataGridView_Product;
        private System.Windows.Forms.Button button_toProducer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ToolStripButton toolStripButton_searchType;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.ToolStripButton toolStripButton_program;
        private System.Windows.Forms.Button button_Tools;
        private System.Windows.Forms.ToolStripButton toolStripButton_close;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label_delete;
        private System.Windows.Forms.TextBox textBox_delete;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

