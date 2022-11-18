
namespace CourseWorkBD
{
    partial class AddOrderForm
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
            this.textBoxFioShoppper = new System.Windows.Forms.TextBox();
            this.textBoxNumPhoneShooper = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStatusOrder = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSaveOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxFioShoppper
            // 
            this.textBoxFioShoppper.Location = new System.Drawing.Point(118, 16);
            this.textBoxFioShoppper.Name = "textBoxFioShoppper";
            this.textBoxFioShoppper.Size = new System.Drawing.Size(134, 20);
            this.textBoxFioShoppper.TabIndex = 0;
            // 
            // textBoxNumPhoneShooper
            // 
            this.textBoxNumPhoneShooper.Location = new System.Drawing.Point(117, 52);
            this.textBoxNumPhoneShooper.Name = "textBoxNumPhoneShooper";
            this.textBoxNumPhoneShooper.Size = new System.Drawing.Size(134, 20);
            this.textBoxNumPhoneShooper.TabIndex = 1;
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(10, 154);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(38, 20);
            this.textBoxDay.TabIndex = 2;
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(86, 154);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(38, 20);
            this.textBoxMonth.TabIndex = 13;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(162, 154);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(38, 20);
            this.textBoxYear.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ФИО покупателя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Номер телефона";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Дата оформления заказа";
            // 
            // textBoxStatusOrder
            // 
            this.textBoxStatusOrder.Location = new System.Drawing.Point(86, 197);
            this.textBoxStatusOrder.Name = "textBoxStatusOrder";
            this.textBoxStatusOrder.ReadOnly = true;
            this.textBoxStatusOrder.Size = new System.Drawing.Size(134, 20);
            this.textBoxStatusOrder.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-2, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Статус заказа";
            // 
            // buttonSaveOrder
            // 
            this.buttonSaveOrder.Location = new System.Drawing.Point(130, 223);
            this.buttonSaveOrder.Name = "buttonSaveOrder";
            this.buttonSaveOrder.Size = new System.Drawing.Size(90, 41);
            this.buttonSaveOrder.TabIndex = 22;
            this.buttonSaveOrder.Text = "Подтвердить добавление";
            this.buttonSaveOrder.UseVisualStyleBackColor = true;
            this.buttonSaveOrder.Click += new System.EventHandler(this.buttonSaveOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Адрес доставки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 24;
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 269);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveOrder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxStatusOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.textBoxNumPhoneShooper);
            this.Controls.Add(this.textBoxFioShoppper);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrderForm";
            this.Text = "Окно добавления заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFioShoppper;
        private System.Windows.Forms.TextBox textBoxNumPhoneShooper;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStatusOrder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSaveOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}