
namespace CourseWorkBD
{
    partial class UpdateFormOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxFioShopper = new System.Windows.Forms.TextBox();
            this.textBoxNumShopper = new System.Windows.Forms.TextBox();
            this.textBoxAddressShopper = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxcost = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tableProductThisOrder = new System.Windows.Forms.DataGridView();
            this.tableAllProduct = new System.Windows.Forms.DataGridView();
            this.textBoxNumProduct = new System.Windows.Forms.TextBox();
            this.buttonAddProductThisOrder = new System.Windows.Forms.Button();
            this.buttonDeleteProductThisOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductThisOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAllProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFioShopper
            // 
            this.textBoxFioShopper.Location = new System.Drawing.Point(159, 30);
            this.textBoxFioShopper.Name = "textBoxFioShopper";
            this.textBoxFioShopper.Size = new System.Drawing.Size(141, 20);
            this.textBoxFioShopper.TabIndex = 0;
            // 
            // textBoxNumShopper
            // 
            this.textBoxNumShopper.Location = new System.Drawing.Point(159, 56);
            this.textBoxNumShopper.Name = "textBoxNumShopper";
            this.textBoxNumShopper.Size = new System.Drawing.Size(141, 20);
            this.textBoxNumShopper.TabIndex = 1;
            // 
            // textBoxAddressShopper
            // 
            this.textBoxAddressShopper.Location = new System.Drawing.Point(159, 89);
            this.textBoxAddressShopper.Name = "textBoxAddressShopper";
            this.textBoxAddressShopper.Size = new System.Drawing.Size(141, 20);
            this.textBoxAddressShopper.TabIndex = 2;
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(128, 128);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(51, 20);
            this.textBoxDay.TabIndex = 3;
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(201, 128);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(51, 20);
            this.textBoxMonth.TabIndex = 4;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(274, 128);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(51, 20);
            this.textBoxYear.TabIndex = 5;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(159, 209);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(141, 20);
            this.textBoxStatus.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ожидает оплаты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "В процессе доставки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(159, 299);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "Завершено";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxcost
            // 
            this.textBoxcost.Location = new System.Drawing.Point(159, 163);
            this.textBoxcost.Name = "textBoxcost";
            this.textBoxcost.Size = new System.Drawing.Size(141, 20);
            this.textBoxcost.TabIndex = 10;
            this.textBoxcost.TextChanged += new System.EventHandler(this.textBoxcost_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1251, 321);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(161, 44);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Подтвердить добавление";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tableProductThisOrder
            // 
            this.tableProductThisOrder.AllowUserToAddRows = false;
            this.tableProductThisOrder.AllowUserToDeleteRows = false;
            this.tableProductThisOrder.AllowUserToResizeColumns = false;
            this.tableProductThisOrder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableProductThisOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableProductThisOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableProductThisOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableProductThisOrder.EnableHeadersVisualStyles = false;
            this.tableProductThisOrder.Location = new System.Drawing.Point(438, 27);
            this.tableProductThisOrder.Name = "tableProductThisOrder";
            this.tableProductThisOrder.RowHeadersVisible = false;
            this.tableProductThisOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableProductThisOrder.Size = new System.Drawing.Size(334, 266);
            this.tableProductThisOrder.TabIndex = 12;
            this.tableProductThisOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableProductThisOrder_CellClick);
            this.tableProductThisOrder.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.tableProductThisOrder_RowsAdded);
            this.tableProductThisOrder.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.tableProductThisOrder_RowsRemoved);
            // 
            // tableAllProduct
            // 
            this.tableAllProduct.AllowUserToAddRows = false;
            this.tableAllProduct.AllowUserToDeleteRows = false;
            this.tableAllProduct.AllowUserToResizeColumns = false;
            this.tableAllProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableAllProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableAllProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableAllProduct.DefaultCellStyle = dataGridViewCellStyle4;
            this.tableAllProduct.EnableHeadersVisualStyles = false;
            this.tableAllProduct.Location = new System.Drawing.Point(963, 30);
            this.tableAllProduct.Name = "tableAllProduct";
            this.tableAllProduct.ReadOnly = true;
            this.tableAllProduct.RowHeadersVisible = false;
            this.tableAllProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableAllProduct.Size = new System.Drawing.Size(397, 266);
            this.tableAllProduct.TabIndex = 13;
            // 
            // textBoxNumProduct
            // 
            this.textBoxNumProduct.Location = new System.Drawing.Point(819, 151);
            this.textBoxNumProduct.Name = "textBoxNumProduct";
            this.textBoxNumProduct.Size = new System.Drawing.Size(141, 20);
            this.textBoxNumProduct.TabIndex = 14;
            // 
            // buttonAddProductThisOrder
            // 
            this.buttonAddProductThisOrder.Location = new System.Drawing.Point(844, 189);
            this.buttonAddProductThisOrder.Name = "buttonAddProductThisOrder";
            this.buttonAddProductThisOrder.Size = new System.Drawing.Size(88, 36);
            this.buttonAddProductThisOrder.TabIndex = 15;
            this.buttonAddProductThisOrder.Text = "Добавить товар в заказ";
            this.buttonAddProductThisOrder.UseVisualStyleBackColor = true;
            this.buttonAddProductThisOrder.Click += new System.EventHandler(this.buttonAddProductThisOrder_Click);
            // 
            // buttonDeleteProductThisOrder
            // 
            this.buttonDeleteProductThisOrder.Location = new System.Drawing.Point(697, 299);
            this.buttonDeleteProductThisOrder.Name = "buttonDeleteProductThisOrder";
            this.buttonDeleteProductThisOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteProductThisOrder.TabIndex = 16;
            this.buttonDeleteProductThisOrder.Text = "Удалить";
            this.buttonDeleteProductThisOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteProductThisOrder.Click += new System.EventHandler(this.buttonDeleteProductThisOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ФИО покупателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Номет телефона покупателя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Адрес доставки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Дата заказа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Стоимость заказа";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Статус заказа";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(438, 299);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(170, 23);
            this.buttonEdit.TabIndex = 25;
            this.buttonEdit.Text = "Подтвердить редактирование";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Товары добавленные в заказ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(983, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Таблица всех товаров";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(819, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Введите кол-во товара\r\n";
            // 
            // UpdateFormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 368);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteProductThisOrder);
            this.Controls.Add(this.buttonAddProductThisOrder);
            this.Controls.Add(this.textBoxNumProduct);
            this.Controls.Add(this.tableAllProduct);
            this.Controls.Add(this.tableProductThisOrder);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxcost);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.textBoxAddressShopper);
            this.Controls.Add(this.textBoxNumShopper);
            this.Controls.Add(this.textBoxFioShopper);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateFormOrder";
            this.Text = "Окно редактирования заказа";
            ((System.ComponentModel.ISupportInitialize)(this.tableProductThisOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAllProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFioShopper;
        private System.Windows.Forms.TextBox textBoxNumShopper;
        private System.Windows.Forms.TextBox textBoxAddressShopper;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxcost;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView tableProductThisOrder;
        private System.Windows.Forms.DataGridView tableAllProduct;
        private System.Windows.Forms.TextBox textBoxNumProduct;
        private System.Windows.Forms.Button buttonAddProductThisOrder;
        private System.Windows.Forms.Button buttonDeleteProductThisOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}