using MySqlConnector;
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

namespace CourseWorkBD
{

    public partial class AddEmployeesForm : Form
    {
        public static int id;
        public AddEmployeesForm()
        {
            InitializeComponent();
            textBoxCoof.Text = "1";
            textBoxDay.MaxLength = 2;
            textBoxMonth.MaxLength = 2;
            textBoxYear.MaxLength = 4;
            var query = $"select name_post from post;";
            var adapter = new MySqlDataAdapter(query, SQL.Connection);
            var table = new DataTable();
            adapter.Fill(table);
            comboBoxPost.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                comboBoxPost.Items.Add(table.Rows[i].ItemArray[0].ToString());
            }
        }


        private void textBoxNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void textBoxFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            char f = e.KeyChar;

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]|[ ]").Success && f != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonAddEmployees_Click(object sender, EventArgs e)
        {
        
            MySqlCommand command = new MySqlCommand($"INSERT INTO employees(fio_employee,Post_idPost,Coof,number_phone,date_work) " +
                $"VALUES" +
                $"('{textBoxFIO.Text}','{id}','{textBoxCoof.Text.Replace(",", ".")}','{textBoxNumberPhone.Text}','{textBoxYear.Text}-{textBoxMonth.Text}-{textBoxDay.Text}')", SQL.Connection);
            try
            {
                if (textBoxNumberPhone.TextLength > 12 || Int32.Parse(textBoxDay.Text) > 32 || Int32.Parse(textBoxMonth.Text) > 12
                    || Int32.Parse(textBoxDay.Text) == 0 || Int32.Parse(textBoxMonth.Text) == 0 || Int32.Parse(textBoxYear.Text) == 0)
                {
                    MessageBox.Show("Проверьте введённые данные");
                    return;
                }
                else
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Проверьте введённые данные");
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Проверьте введённые данные");
            }



        }

        private void comboBoxPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = $"select idPost from post where name_post ='{comboBoxPost.SelectedItem}'";
            var command = new MySqlCommand(query, SQL.Connection);
            id = (int)command.ExecuteScalar();
        }

        private void textBoxCoof_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();


            if (!Regex.Match(Symbol, @"[ ]|[0-9,.]|[\x08]").Success)
            {
                e.Handled = true;
            }
        }

        private void textBoxDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]|[\x08]").Success)
            {
                e.Handled = true;
            }
        }

        private void textBoxMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]|[\x08]").Success)
            {
                e.Handled = true;
            }
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]|[\x08]").Success)
            {
                e.Handled = true;
            }
        }
    }
}