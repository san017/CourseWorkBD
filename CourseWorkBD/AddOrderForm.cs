using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkBD
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
            textBoxStatusOrder.Text = "Добавьте товар в заказ";
         
        }

        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            var command = new MySqlCommand($"INSERT electr.order (fio_shopper,numPhoneShopper,addressShopper,Data_order,StatusOrder)" +
                $"VALUES ('{textBoxFioShoppper.Text}','{textBoxNumPhoneShooper.Text}','{textBox1.Text}','{textBoxYear.Text}-{textBoxMonth.Text}-{textBoxDay.Text}','{textBoxStatusOrder.Text}')", SQL.Connection) ;
            command.ExecuteNonQuery();
            Close();
        }
    }
}
