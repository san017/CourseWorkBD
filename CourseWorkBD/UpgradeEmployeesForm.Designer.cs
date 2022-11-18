
namespace CourseWorkBD
{
    partial class UpgradeEmployeesForm
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
            this.textBoxNameEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCoof = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumberPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableEmpHisShtraf = new System.Windows.Forms.DataGridView();
            this.buttonUpgrageEmp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDeleteShtraf = new System.Windows.Forms.Button();
            this.tableAllShtraf = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxYearShtraf = new System.Windows.Forms.TextBox();
            this.textBoxMonthShtraf = new System.Windows.Forms.TextBox();
            this.textBoxDayShtraf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmpHisShtraf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAllShtraf)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNameEmp
            // 
            this.textBoxNameEmp.Location = new System.Drawing.Point(113, 19);
            this.textBoxNameEmp.Name = "textBoxNameEmp";
            this.textBoxNameEmp.Size = new System.Drawing.Size(163, 20);
            this.textBoxNameEmp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО сотрудника";
            // 
            // textBoxCoof
            // 
            this.textBoxCoof.Location = new System.Drawing.Point(113, 72);
            this.textBoxCoof.Name = "textBoxCoof";
            this.textBoxCoof.Size = new System.Drawing.Size(163, 20);
            this.textBoxCoof.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кооэфицент";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Должность";
            // 
            // textBoxNumberPhone
            // 
            this.textBoxNumberPhone.Location = new System.Drawing.Point(113, 98);
            this.textBoxNumberPhone.Name = "textBoxNumberPhone";
            this.textBoxNumberPhone.Size = new System.Drawing.Size(163, 20);
            this.textBoxNumberPhone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер телефона";
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(36, 154);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(55, 20);
            this.textBoxDay.TabIndex = 8;
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(113, 154);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(55, 20);
            this.textBoxMonth.TabIndex = 9;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(190, 154);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(55, 20);
            this.textBoxYear.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата поступления на  работу";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "-";
            // 
            // tableEmpHisShtraf
            // 
            this.tableEmpHisShtraf.AllowUserToAddRows = false;
            this.tableEmpHisShtraf.AllowUserToDeleteRows = false;
            this.tableEmpHisShtraf.AllowUserToResizeColumns = false;
            this.tableEmpHisShtraf.AllowUserToResizeRows = false;
            this.tableEmpHisShtraf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableEmpHisShtraf.Location = new System.Drawing.Point(307, 35);
            this.tableEmpHisShtraf.Name = "tableEmpHisShtraf";
            this.tableEmpHisShtraf.ReadOnly = true;
            this.tableEmpHisShtraf.RowHeadersVisible = false;
            this.tableEmpHisShtraf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableEmpHisShtraf.Size = new System.Drawing.Size(384, 171);
            this.tableEmpHisShtraf.TabIndex = 14;
            // 
            // buttonUpgrageEmp
            // 
            this.buttonUpgrageEmp.Location = new System.Drawing.Point(852, 287);
            this.buttonUpgrageEmp.Name = "buttonUpgrageEmp";
            this.buttonUpgrageEmp.Size = new System.Drawing.Size(152, 23);
            this.buttonUpgrageEmp.TabIndex = 15;
            this.buttonUpgrageEmp.Text = "Подтвердить добавление";
            this.buttonUpgrageEmp.UseVisualStyleBackColor = true;
            this.buttonUpgrageEmp.Click += new System.EventHandler(this.buttonUpgrageEmp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Штрафы сотрудника";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(635, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDeleteShtraf
            // 
            this.buttonDeleteShtraf.Location = new System.Drawing.Point(307, 215);
            this.buttonDeleteShtraf.Name = "buttonDeleteShtraf";
            this.buttonDeleteShtraf.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteShtraf.TabIndex = 18;
            this.buttonDeleteShtraf.Text = "Удалить";
            this.buttonDeleteShtraf.UseVisualStyleBackColor = true;
            this.buttonDeleteShtraf.Click += new System.EventHandler(this.buttonDeleteShtraf_Click);
            // 
            // tableAllShtraf
            // 
            this.tableAllShtraf.AllowUserToAddRows = false;
            this.tableAllShtraf.AllowUserToDeleteRows = false;
            this.tableAllShtraf.AllowUserToResizeColumns = false;
            this.tableAllShtraf.AllowUserToResizeRows = false;
            this.tableAllShtraf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAllShtraf.Location = new System.Drawing.Point(759, 35);
            this.tableAllShtraf.Name = "tableAllShtraf";
            this.tableAllShtraf.ReadOnly = true;
            this.tableAllShtraf.RowHeadersVisible = false;
            this.tableAllShtraf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableAllShtraf.Size = new System.Drawing.Size(245, 215);
            this.tableAllShtraf.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(756, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Все штрафы";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(441, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Введите дату нарушения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(543, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(466, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "-";
            // 
            // textBoxYearShtraf
            // 
            this.textBoxYearShtraf.Location = new System.Drawing.Point(559, 214);
            this.textBoxYearShtraf.Name = "textBoxYearShtraf";
            this.textBoxYearShtraf.Size = new System.Drawing.Size(55, 20);
            this.textBoxYearShtraf.TabIndex = 24;
            // 
            // textBoxMonthShtraf
            // 
            this.textBoxMonthShtraf.Location = new System.Drawing.Point(482, 214);
            this.textBoxMonthShtraf.Name = "textBoxMonthShtraf";
            this.textBoxMonthShtraf.Size = new System.Drawing.Size(55, 20);
            this.textBoxMonthShtraf.TabIndex = 23;
            // 
            // textBoxDayShtraf
            // 
            this.textBoxDayShtraf.Location = new System.Drawing.Point(405, 213);
            this.textBoxDayShtraf.Name = "textBoxDayShtraf";
            this.textBoxDayShtraf.Size = new System.Drawing.Size(55, 20);
            this.textBoxDayShtraf.TabIndex = 22;
            // 
            // UpgradeEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 313);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxYearShtraf);
            this.Controls.Add(this.textBoxMonthShtraf);
            this.Controls.Add(this.textBoxDayShtraf);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tableAllShtraf);
            this.Controls.Add(this.buttonDeleteShtraf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonUpgrageEmp);
            this.Controls.Add(this.tableEmpHisShtraf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNumberPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCoof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameEmp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpgradeEmployeesForm";
            this.Text = "Окно редактирования сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.tableEmpHisShtraf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAllShtraf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCoof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumberPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tableEmpHisShtraf;
        private System.Windows.Forms.Button buttonUpgrageEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDeleteShtraf;
        private System.Windows.Forms.DataGridView tableAllShtraf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxYearShtraf;
        private System.Windows.Forms.TextBox textBoxMonthShtraf;
        private System.Windows.Forms.TextBox textBoxDayShtraf;
    }
}