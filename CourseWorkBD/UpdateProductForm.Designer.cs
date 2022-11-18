
namespace CourseWorkBD
{
    partial class UpdateProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxNameProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCostProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumSection = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tableUpdateCharacteristics = new System.Windows.Forms.DataGridView();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableUpdateChar = new System.Windows.Forms.DataGridView();
            this.buttonAddCharacteristicByProduct = new System.Windows.Forms.Button();
            this.buttonDeleteFromCharacteristicsByProduct = new System.Windows.Forms.Button();
            this.textBoxSearchIsAllCharacteristics = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.checkBoxAllCharacteristics = new System.Windows.Forms.CheckBox();
            this.textBoxDiscont = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateCharacteristics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateChar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNameProduct
            // 
            this.textBoxNameProduct.Location = new System.Drawing.Point(138, 12);
            this.textBoxNameProduct.Multiline = true;
            this.textBoxNameProduct.Name = "textBoxNameProduct";
            this.textBoxNameProduct.Size = new System.Drawing.Size(182, 52);
            this.textBoxNameProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название продукта";
            // 
            // textBoxCostProduct
            // 
            this.textBoxCostProduct.Location = new System.Drawing.Point(138, 94);
            this.textBoxCostProduct.Name = "textBoxCostProduct";
            this.textBoxCostProduct.Size = new System.Drawing.Size(182, 20);
            this.textBoxCostProduct.TabIndex = 2;
            this.textBoxCostProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCostProduct_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стоимость продукта";
            // 
            // textBoxNumSection
            // 
            this.textBoxNumSection.Location = new System.Drawing.Point(138, 157);
            this.textBoxNumSection.Name = "textBoxNumSection";
            this.textBoxNumSection.Size = new System.Drawing.Size(182, 20);
            this.textBoxNumSection.TabIndex = 4;
            this.textBoxNumSection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumSection_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер секции хранения";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(138, 266);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(139, 236);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(182, 21);
            this.comboBox4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата поставки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Производитель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Скидка в %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Раздел в магазине";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(895, 346);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(128, 39);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Подтвердить редактирование";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tableUpdateCharacteristics
            // 
            this.tableUpdateCharacteristics.AllowUserToAddRows = false;
            this.tableUpdateCharacteristics.AllowUserToDeleteRows = false;
            this.tableUpdateCharacteristics.AllowUserToResizeColumns = false;
            this.tableUpdateCharacteristics.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableUpdateCharacteristics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tableUpdateCharacteristics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableUpdateCharacteristics.DefaultCellStyle = dataGridViewCellStyle6;
            this.tableUpdateCharacteristics.EnableHeadersVisualStyles = false;
            this.tableUpdateCharacteristics.Location = new System.Drawing.Point(370, 21);
            this.tableUpdateCharacteristics.Name = "tableUpdateCharacteristics";
            this.tableUpdateCharacteristics.RowHeadersVisible = false;
            this.tableUpdateCharacteristics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableUpdateCharacteristics.Size = new System.Drawing.Size(300, 279);
            this.tableUpdateCharacteristics.TabIndex = 17;
            this.tableUpdateCharacteristics.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableUpdateCharacteristics_CellValueChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(2, 475);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 18;
            this.comboBox5.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Характеристики товара(измените значение)";
            // 
            // tableUpdateChar
            // 
            this.tableUpdateChar.AllowUserToAddRows = false;
            this.tableUpdateChar.AllowUserToDeleteRows = false;
            this.tableUpdateChar.AllowUserToResizeColumns = false;
            this.tableUpdateChar.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableUpdateChar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tableUpdateChar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableUpdateChar.DefaultCellStyle = dataGridViewCellStyle8;
            this.tableUpdateChar.Location = new System.Drawing.Point(811, 74);
            this.tableUpdateChar.Name = "tableUpdateChar";
            this.tableUpdateChar.ReadOnly = true;
            this.tableUpdateChar.RowHeadersVisible = false;
            this.tableUpdateChar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableUpdateChar.Size = new System.Drawing.Size(212, 226);
            this.tableUpdateChar.TabIndex = 21;
            // 
            // buttonAddCharacteristicByProduct
            // 
            this.buttonAddCharacteristicByProduct.Location = new System.Drawing.Point(370, 309);
            this.buttonAddCharacteristicByProduct.Name = "buttonAddCharacteristicByProduct";
            this.buttonAddCharacteristicByProduct.Size = new System.Drawing.Size(88, 31);
            this.buttonAddCharacteristicByProduct.TabIndex = 22;
            this.buttonAddCharacteristicByProduct.Text = "Добавить";
            this.buttonAddCharacteristicByProduct.UseVisualStyleBackColor = true;
            this.buttonAddCharacteristicByProduct.Click += new System.EventHandler(this.buttonAddCharacteristicByProduct_Click);
            // 
            // buttonDeleteFromCharacteristicsByProduct
            // 
            this.buttonDeleteFromCharacteristicsByProduct.Location = new System.Drawing.Point(582, 309);
            this.buttonDeleteFromCharacteristicsByProduct.Name = "buttonDeleteFromCharacteristicsByProduct";
            this.buttonDeleteFromCharacteristicsByProduct.Size = new System.Drawing.Size(88, 32);
            this.buttonDeleteFromCharacteristicsByProduct.TabIndex = 23;
            this.buttonDeleteFromCharacteristicsByProduct.Text = "Удалить";
            this.buttonDeleteFromCharacteristicsByProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteFromCharacteristicsByProduct.Click += new System.EventHandler(this.buttonDeleteFromCharacteristicsByProduct_Click);
            // 
            // textBoxSearchIsAllCharacteristics
            // 
            this.textBoxSearchIsAllCharacteristics.Location = new System.Drawing.Point(811, 37);
            this.textBoxSearchIsAllCharacteristics.Name = "textBoxSearchIsAllCharacteristics";
            this.textBoxSearchIsAllCharacteristics.Size = new System.Drawing.Size(212, 20);
            this.textBoxSearchIsAllCharacteristics.TabIndex = 24;
            this.textBoxSearchIsAllCharacteristics.TextChanged += new System.EventHandler(this.textBoxSearchIsAllCharacteristics_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(768, 37);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(39, 13);
            this.labelSearch.TabIndex = 25;
            this.labelSearch.Text = "Поиск";
            // 
            // checkBoxAllCharacteristics
            // 
            this.checkBoxAllCharacteristics.AutoSize = true;
            this.checkBoxAllCharacteristics.Location = new System.Drawing.Point(739, 5);
            this.checkBoxAllCharacteristics.Name = "checkBoxAllCharacteristics";
            this.checkBoxAllCharacteristics.Size = new System.Drawing.Size(284, 17);
            this.checkBoxAllCharacteristics.TabIndex = 26;
            this.checkBoxAllCharacteristics.Text = "Показать таблицу всех возможных хаарктеристик";
            this.checkBoxAllCharacteristics.UseVisualStyleBackColor = true;
            this.checkBoxAllCharacteristics.CheckedChanged += new System.EventHandler(this.checkBoxAllCharacteristics_CheckedChanged);
            // 
            // textBoxDiscont
            // 
            this.textBoxDiscont.Location = new System.Drawing.Point(139, 309);
            this.textBoxDiscont.Name = "textBoxDiscont";
            this.textBoxDiscont.Size = new System.Drawing.Size(182, 20);
            this.textBoxDiscont.TabIndex = 27;
            this.textBoxDiscont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDiscont_KeyPress);
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 386);
            this.Controls.Add(this.textBoxDiscont);
            this.Controls.Add(this.checkBoxAllCharacteristics);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearchIsAllCharacteristics);
            this.Controls.Add(this.buttonDeleteFromCharacteristicsByProduct);
            this.Controls.Add(this.buttonAddCharacteristicByProduct);
            this.Controls.Add(this.tableUpdateChar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.tableUpdateCharacteristics);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumSection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCostProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameProduct);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateProductForm";
            this.Text = "Окно редактирования товара";
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateCharacteristics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateChar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCostProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumSection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView tableUpdateCharacteristics;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView tableUpdateChar;
        private System.Windows.Forms.Button buttonAddCharacteristicByProduct;
        private System.Windows.Forms.Button buttonDeleteFromCharacteristicsByProduct;
        private System.Windows.Forms.TextBox textBoxSearchIsAllCharacteristics;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.CheckBox checkBoxAllCharacteristics;
        private System.Windows.Forms.TextBox textBoxDiscont;
    }
}