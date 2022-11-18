
namespace CourseWorkBD
{
    partial class AddProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.costProduct = new System.Windows.Forms.TextBox();
            this.numSection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.ComboBoxCatalog = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.ComboBoxRazdel = new System.Windows.Forms.ComboBox();
            this.comboBoxPostavka = new System.Windows.Forms.ComboBox();
            this.TableCatalogWithCharacteristics = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSizeDiscont = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableCatalogWithCharacteristics)).BeginInit();
            this.SuspendLayout();
            // 
            // nameProduct
            // 
            this.nameProduct.Location = new System.Drawing.Point(156, 12);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(182, 20);
            this.nameProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название продукта";
            // 
            // costProduct
            // 
            this.costProduct.Location = new System.Drawing.Point(156, 52);
            this.costProduct.Name = "costProduct";
            this.costProduct.Size = new System.Drawing.Size(182, 20);
            this.costProduct.TabIndex = 2;
            this.costProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costProduct_KeyPress);
            // 
            // numSection
            // 
            this.numSection.Location = new System.Drawing.Point(156, 95);
            this.numSection.Name = "numSection";
            this.numSection.Size = new System.Drawing.Size(182, 20);
            this.numSection.TabIndex = 3;
            this.numSection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numSection_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Номер секции хранения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Дата поставки товара ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Производитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Размер скидки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Раздел в магазине";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(678, 296);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(98, 49);
            this.save.TabIndex = 16;
            this.save.Text = "Подтвердить добавление";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ComboBoxCatalog
            // 
            this.ComboBoxCatalog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCatalog.FormattingEnabled = true;
            this.ComboBoxCatalog.Location = new System.Drawing.Point(156, 138);
            this.ComboBoxCatalog.Name = "ComboBoxCatalog";
            this.ComboBoxCatalog.Size = new System.Drawing.Size(182, 21);
            this.ComboBoxCatalog.TabIndex = 19;
            this.ComboBoxCatalog.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCatalog_SelectedIndexChanged);
            this.ComboBoxCatalog.SelectedValueChanged += new System.EventHandler(this.ComboBoxCatalog_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Категория товара";
            // 
            // ComboBoxManufacturer
            // 
            this.ComboBoxManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxManufacturer.FormattingEnabled = true;
            this.ComboBoxManufacturer.Location = new System.Drawing.Point(156, 271);
            this.ComboBoxManufacturer.Name = "ComboBoxManufacturer";
            this.ComboBoxManufacturer.Size = new System.Drawing.Size(182, 21);
            this.ComboBoxManufacturer.TabIndex = 24;
            // 
            // ComboBoxRazdel
            // 
            this.ComboBoxRazdel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRazdel.FormattingEnabled = true;
            this.ComboBoxRazdel.Location = new System.Drawing.Point(156, 224);
            this.ComboBoxRazdel.Name = "ComboBoxRazdel";
            this.ComboBoxRazdel.Size = new System.Drawing.Size(182, 21);
            this.ComboBoxRazdel.TabIndex = 23;
            // 
            // comboBoxPostavka
            // 
            this.comboBoxPostavka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxPostavka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPostavka.FormattingEnabled = true;
            this.comboBoxPostavka.Location = new System.Drawing.Point(156, 176);
            this.comboBoxPostavka.Name = "comboBoxPostavka";
            this.comboBoxPostavka.Size = new System.Drawing.Size(182, 21);
            this.comboBoxPostavka.TabIndex = 22;
            this.comboBoxPostavka.SelectedIndexChanged += new System.EventHandler(this.comboBoxPostavka_SelectedIndexChanged);
            // 
            // TableCatalogWithCharacteristics
            // 
            this.TableCatalogWithCharacteristics.AllowUserToAddRows = false;
            this.TableCatalogWithCharacteristics.AllowUserToDeleteRows = false;
            this.TableCatalogWithCharacteristics.AllowUserToResizeColumns = false;
            this.TableCatalogWithCharacteristics.AllowUserToResizeRows = false;
            this.TableCatalogWithCharacteristics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableCatalogWithCharacteristics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableCatalogWithCharacteristics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableCatalogWithCharacteristics.EnableHeadersVisualStyles = false;
            this.TableCatalogWithCharacteristics.Location = new System.Drawing.Point(359, 35);
            this.TableCatalogWithCharacteristics.Name = "TableCatalogWithCharacteristics";
            this.TableCatalogWithCharacteristics.RowHeadersVisible = false;
            this.TableCatalogWithCharacteristics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableCatalogWithCharacteristics.Size = new System.Drawing.Size(417, 257);
            this.TableCatalogWithCharacteristics.TabIndex = 24;
            this.TableCatalogWithCharacteristics.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableCatalogWithCharacteristics_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(367, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Выберите категорию товара а затем введите значения характеристик";
            // 
            // textBoxSizeDiscont
            // 
            this.textBoxSizeDiscont.Location = new System.Drawing.Point(156, 311);
            this.textBoxSizeDiscont.Name = "textBoxSizeDiscont";
            this.textBoxSizeDiscont.Size = new System.Drawing.Size(182, 20);
            this.textBoxSizeDiscont.TabIndex = 26;
            this.textBoxSizeDiscont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSizeDiscont_KeyPress);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 349);
            this.Controls.Add(this.textBoxSizeDiscont);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ComboBoxManufacturer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TableCatalogWithCharacteristics);
            this.Controls.Add(this.ComboBoxRazdel);
            this.Controls.Add(this.comboBoxPostavka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxCatalog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numSection);
            this.Controls.Add(this.costProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductForm";
            this.Text = "Окно добавления товара";
            ((System.ComponentModel.ISupportInitialize)(this.TableCatalogWithCharacteristics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costProduct;
        private System.Windows.Forms.TextBox numSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox ComboBoxCatalog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPostavka;
        private System.Windows.Forms.ComboBox ComboBoxManufacturer;
        private System.Windows.Forms.ComboBox ComboBoxRazdel;
        private System.Windows.Forms.DataGridView TableCatalogWithCharacteristics;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSizeDiscont;
    }
}