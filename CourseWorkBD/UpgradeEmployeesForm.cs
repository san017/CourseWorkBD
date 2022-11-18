using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWorkBD.AddElectronicProduct;
using MySqlConnector;
namespace CourseWorkBD
{
    public partial class UpgradeEmployeesForm : Form
    {
        public string id;
        public int idd;
        public UpgradeEmployeesForm(DataGridViewRow dr)
        {
            InitializeComponent();
            id = dr.Cells[0].Value.ToString();
            var s = SQL.SQLQuerySelect($"select idemployees,fio_employee,name_post,(payday*Coof)as'payday',Coof,number_phone,date_work from employees  " +
                   " join post on employees.Post_idPost = post.idPost" +
                   $" where idemployees = '{id}' ");

            var date = s.Rows[0].ItemArray[6].ToString();
            var dateday = date.Substring(0, 2);
            var datemonth = date.Substring(3, 2);
            var dateYear = date.Substring(6, 4);
            textBoxNameEmp.Text = s.Rows[0].ItemArray[1].ToString();
            textBoxCoof.Text = s.Rows[0].ItemArray[4].ToString();
            textBoxCoof.Text = Regex.Replace(s.Rows[0].ItemArray[4].ToString(), ",", ".");
            textBoxNumberPhone.Text = s.Rows[0].ItemArray[5].ToString();
            textBoxDay.Text = dateday;
            textBoxMonth.Text = datemonth;
            textBoxYear.Text = dateYear;
            var comboboxquery = SQL.SQLQuerySelect("select name_post from post");
            comboBox1.Items.Clear();
            for (int i = 0; i < comboboxquery.Rows.Count; i++)
            {
                comboBox1.Items.Add(comboboxquery.Rows[i].ItemArray[0].ToString());
            }

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {

                if (comboBox1.Items[i].ToString() == s.Rows[0].ItemArray[2].ToString())
                {
                    comboBox1.SelectedIndex = i;
                    break;
                }

            }
            Manager.ClearSelections(tableAllShtraf);
            tableEmpHisShtraf.DataSource = SQL.SQLQuerySelect($"select idshtraf,name_shtraf,vid_shtraf,cost_shtraf,data_shtraf from employees_has_shtraf " +
                $"join employees on employees.idemployees = employees_has_shtraf.employees_idemployees " +
                $"join shtraf on shtraf.idShtraf = employees_has_shtraf.Shtraf_idShtraf " +
                $"join type_shtraf on shtraf.type_shtraf_idtype_shtraf = type_shtraf.idtype_shtraf" +
                $" where idemployees = {id}");
            tableAllShtraf.DataSource = SQL.SQLQuery("all_shtraf");
            tableAllShtraf.Columns[0].Visible = false;
            tableEmpHisShtraf.Columns[0].Visible = false;
            tableEmpHisShtraf.Columns[1].HeaderCell.Value = "Причина штрафа";
            tableEmpHisShtraf.Columns[2].HeaderCell.Value = "Вид штрафа";
            tableEmpHisShtraf.Columns[3].HeaderCell.Value = "Штраф";
            tableEmpHisShtraf.Columns[4].HeaderCell.Value = "Дата нарушения";

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = $"select idPost from post where name_post ='{comboBox1.SelectedItem}'";
            var command = new MySqlCommand(query, SQL.Connection);
            idd = (int)command.ExecuteScalar();
        }

        private void buttonUpgrageEmp_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand($"UPDATE employees set fio_employee ='{textBoxNameEmp.Text}',  Post_idPost ='{idd}'," +
                $" Coof ='{textBoxCoof.Text.Replace(",", ".")}', number_phone ='{textBoxNumberPhone.Text}'," +
                $" date_work ='{textBoxYear.Text}-{textBoxMonth.Text}-{textBoxDay.Text}' where idemployees = '{id}'", SQL.Connection);
            command.ExecuteNonQuery();
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBoxYearShtraf.Text == "" || textBoxMonthShtraf.Text =="" || textBoxDayShtraf.Text == "")
            {
                MessageBox.Show("Введите дату нарушения");
                return;
            }
            for (int i = 0; i < tableEmpHisShtraf.Rows.Count; i++)
            {
                if (tableEmpHisShtraf.Rows[i].Cells[0].Value.ToString() == tableAllShtraf.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Такой штраф уже есть");
                    return;
                }
            }
            MySqlCommand command = new MySqlCommand($"INSERT INTO employees_has_shtraf(employees_idemployees,Shtraf_idShtraf,data_shtraf)" +
                $"VALUES('{id}','{tableAllShtraf.CurrentRow.Cells[0].Value}','{textBoxYearShtraf.Text}-{textBoxMonthShtraf.Text}-{textBoxDayShtraf.Text}')", SQL.Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
               
                if (tableAllShtraf.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите штраф для добавления");
                    return;
                }
                MessageBox.Show("Ошибка! Проверьте введённую дату нарушения");
            }
          
            tableEmpHisShtraf.DataSource = SQL.SQLQuerySelect($"select  idshtraf,name_shtraf,vid_shtraf,cost_shtraf,data_shtraf from employees_has_shtraf " +
              $"join employees on employees.idemployees = employees_has_shtraf.employees_idemployees " +
              $"join shtraf on shtraf.idShtraf = employees_has_shtraf.Shtraf_idShtraf " +
              $"join type_shtraf on shtraf.type_shtraf_idtype_shtraf = type_shtraf.idtype_shtraf" +
              $" where idemployees = {id}");

        }

        private void buttonDeleteShtraf_Click(object sender, EventArgs e)
        {
            if (tableEmpHisShtraf.Rows.Count == 0)
            {
                MessageBox.Show("Пустая таблица");
                return;
            }
            else
            {
                var command = new MySqlCommand($"DELETE FROM employees_has_shtraf " +
             $" WHERE employees_idemployees ='{id}' AND Shtraf_idShtraf = '{tableEmpHisShtraf.CurrentRow.Cells[0].Value}'", SQL.Connection);
                command.ExecuteNonQuery();
                tableEmpHisShtraf.DataSource = SQL.SQLQuerySelect($"select  idshtraf,name_shtraf,vid_shtraf,cost_shtraf,data_shtraf from employees_has_shtraf " +
               $"join employees on employees.idemployees = employees_has_shtraf.employees_idemployees " +
               $"join shtraf on shtraf.idShtraf = employees_has_shtraf.Shtraf_idShtraf " +
               $"join type_shtraf on shtraf.type_shtraf_idtype_shtraf = type_shtraf.idtype_shtraf" +
               $" where idemployees = {id}");
            }
         
        }
    }
}
