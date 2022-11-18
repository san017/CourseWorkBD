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
using CourseWorkBD.AddElectronicProduct;
namespace CourseWorkBD
{

    public partial class UpdateFormOrder : Form
    {
        public string idOrder;
        public string idd;
        public int count = 0;
        public UpdateFormOrder(DataGridViewRow dr)
        {
            InitializeComponent();
            idOrder = dr.Cells[0].Value.ToString();
            var s = SQL.SQLQuerySelect("select idOrder,fio_shopper,numPhoneShopper,addressShopper,Data_order,StatusOrder," +
                "(case when  sum(costProductConfirm*numProduct)  IS NOT NULL THEN sum(costProductConfirm*numProduct) ELSE 0 END)as'Cost Order' from electr.order " +
                  "left  join order_has_electr_product on order_has_electr_product.order_idOrder = electr.order.idOrder " +
                  "left  join electr_product on electr_product.idElectr_product = order_has_electr_product.electr_product_idElectr_product " +
                  $"where idOrder = '{idOrder}' ");
            var f = SQL.SQLQuerySelect("select idElectr_product from electr_product;");

            tableProductThisOrder.DataSource = SQL.SQLQuerySelect("select idElectr_product,name_product,(costProductConfirm*numProduct)," +
                "numProduct from order_has_electr_product " +
                  "join electr_product on electr_product.idElectr_product = order_has_electr_product.electr_product_idElectr_product " +
                  "join electr.order on electr.order.idOrder = order_has_electr_product.order_idOrder " +
                  $"where idOrder = '{idOrder}'; ");
            tableAllProduct.DataSource = SQL.SQLQuerySelect("select idElectr_product,name_product, " +
                "round((cost_product*(1-size_discont/100)),2)as 'cost', name_catalog, size_discont from electr_product " +
                "join catalog on catalog.idCatalog = electr_product.Catalog_idCatalog;");
            textBoxFioShopper.Text = s.Rows[0].ItemArray[1].ToString();
            textBoxNumShopper.Text = s.Rows[0].ItemArray[2].ToString();
            textBoxAddressShopper.Text = s.Rows[0].ItemArray[3].ToString();
            var date = s.Rows[0].ItemArray[4].ToString();
            var dateday = date.Substring(0, 2);
            var datemonth = date.Substring(3, 2);
            var dateYear = date.Substring(6, 4);
            textBoxDay.Text = dateday;
            textBoxMonth.Text = datemonth;
            textBoxYear.Text = dateYear;
            textBoxStatus.Text = s.Rows[0].ItemArray[5].ToString();

            Manager.ClearSelections(tableAllProduct);

            if (f.Rows.Count == 0)
            {
                tableAllProduct.DataSource = SQL.SQLQuerySelect("select idElectr_product,name_product, " +
                "round((cost_product*(1-size_discont/100)),2) as 'cost', name_catalog, size_discont from electr_product " +
                "join catalog on catalog.idCatalog = electr_product.Catalog_idCatalog;");
                tableProductThisOrder.DataSource = SQL.SQLQuerySelect("select idElectr_product,name_product,(costProductConfirm*numProduct)," +
                "numProduct from order_has_electr_product " +
                  "join electr_product on electr_product.idElectr_product = order_has_electr_product.electr_product_idElectr_product " +
                  "join electr.order on electr.order.idOrder = order_has_electr_product.order_idOrder " +
                  $"where idOrder = '{idOrder}'; ");
            }
            else { idd = f.Rows[0].ItemArray[0].ToString(); }
            tableAllProduct.Columns[0].Visible = false;
            tableAllProduct.Columns[1].HeaderCell.Value= "Название товара";
            tableAllProduct.Columns[2].HeaderCell.Value= "Стоимость";
            tableAllProduct.Columns[3].HeaderCell.Value= "Тип товара";
            tableAllProduct.Columns[4].HeaderCell.Value= "Скидка в %";
            tableProductThisOrder.Columns[0].Visible = false;
            tableProductThisOrder.Columns[1].HeaderCell.Value = "Название товара";
            tableProductThisOrder.Columns[1].Width = 200;
            tableProductThisOrder.Columns[2].HeaderCell.Value = "Стоимость";
            tableProductThisOrder.Columns[3].HeaderCell.Value = "Кол-во товара";
           
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var command = new MySqlCommand($"UPDATE electr.order " +
                $"set fio_shopper='{textBoxFioShopper.Text}',numPhoneShopper ='{textBoxNumShopper.Text}'," +
                $"addressShopper ='{textBoxAddressShopper.Text}',Data_order = '{textBoxYear.Text}-{textBoxMonth.Text}-{textBoxDay.Text}'," +
                $"StatusOrder = '{textBoxStatus.Text}'" +
                $"where idOrder = '{idOrder}'", SQL.Connection);
            command.ExecuteNonQuery();
            Close();
        }
        private void buttonAddProductThisOrder_Click(object sender, EventArgs e)
        {
            if (textBoxNumProduct.Text == "")
            {
                MessageBox.Show("Введите количество товара!");
                return;
            }
            if (tableAllProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите добавляемый товар");
                return;
            }
            for (int i = 0; i < tableAllProduct.SelectedRows.Count; i++)
            {
                var command = new MySqlCommand($"INSERT electr.order_has_electr_product (order_idOrder,electr_product_idElectr_product,costProductConfirm,numProduct) " +
               $"VALUES ('{idOrder}','{tableAllProduct.SelectedRows[i].Cells[0].Value}'," +
               $"(select cost_product*(1-size_discont/100) from electr_product where idElectr_product = '{tableAllProduct.SelectedRows[i].Cells[0].Value}')," +
               $"'{textBoxNumProduct.Text}')", SQL.Connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Данный товар уже добавлен");
                    return;
                   
                }
                
            }
            textBoxNumProduct.Clear();
            tableProductThisOrder.DataSource = SQL.SQLQuerySelect("select idElectr_product,name_product,(costProductConfirm*numProduct),numProduct from order_has_electr_product " +
                "join electr_product on electr_product.idElectr_product = order_has_electr_product.electr_product_idElectr_product " +
                "join electr.order on electr.order.idOrder = order_has_electr_product.order_idOrder " +
                $"where idOrder = '{idOrder}'; ");
            tableAllProduct.DataSource = SQL.SQLQuerySelect("select idElectr_product,name_product, round((cost_product*(1-size_discont/100)),2)as 'cost', name_catalog, size_discont from electr_product " +
      "join catalog on catalog.idCatalog = electr_product.Catalog_idCatalog;");
            count--;

        }
        private void buttonDeleteProductThisOrder_Click(object sender, EventArgs e)
        {
            if (tableProductThisOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для удаления");
                return;
            }
            for (int i = 0; i < tableProductThisOrder.SelectedRows.Count; i++)
            {
                var command = new MySqlCommand($"delete from order_has_electr_product where order_idOrder = {idOrder} and " +
               $"electr_product_idElectr_product = {tableProductThisOrder.SelectedRows[i].Cells[0].Value};", SQL.Connection);
                command.ExecuteNonQuery();
            }

            tableProductThisOrder.DataSource = SQL.SQLQuerySelect("select idElectr_product,name_product,(costProductConfirm*numProduct),numProduct from order_has_electr_product " +
                "join electr_product on electr_product.idElectr_product = order_has_electr_product.electr_product_idElectr_product " +
                "join electr.order on electr.order.idOrder = order_has_electr_product.order_idOrder " +
                $"where idOrder = '{idOrder}'; ");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxStatus.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxStatus.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxStatus.Text = button3.Text;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (tableProductThisOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для редактирования");
                return;
            }
            var command1 = new MySqlCommand($"update  electr.order_has_electr_product set numProduct = '{tableProductThisOrder.CurrentRow.Cells[3].Value}' " +
           $"where order_idOrder = '{idOrder}' and electr_product_idElectr_product = '{tableProductThisOrder.CurrentRow.Cells[0].Value}'; ", SQL.Connection);
            command1.ExecuteNonQuery();
            tableProductThisOrder.DataSource = SQL.SQLQuerySelect("select idElectr_product,name_product,(costProductConfirm*numProduct)," +
              "numProduct from order_has_electr_product " +
                "join electr_product on electr_product.idElectr_product = order_has_electr_product.electr_product_idElectr_product " +
                "join electr.order on electr.order.idOrder = order_has_electr_product.order_idOrder " +
                $"where idOrder = '{idOrder}'; ");
            MessageBox.Show("Отредактировано");

        }

        private void textBoxcost_TextChanged(object sender, EventArgs e)
        {

            // textBoxcost.Text.Replace(textBoxcost.Text, tableProductThisOrder.Rows[0].Cells[2].Value.ToString());
        }
        private void UpdateSum()
        {
            var s = SQL.SQLQuerySelect($"select sum(costProductConfirm*numProduct),numProduct from order_has_electr_product where order_idOrder ={idOrder}");
            textBoxcost.Text = s.Rows[0].ItemArray[0].ToString();
        }
        private void tableProductThisOrder_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateSum();
        }

        private void tableProductThisOrder_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateSum();
        }

        private void tableProductThisOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < tableProductThisOrder.Rows.Count; i++)
            {
                tableProductThisOrder.Rows[i].Cells[1].ReadOnly = true;
                tableProductThisOrder.Rows[i].Cells[2].ReadOnly = true;

            }
        }
    }
}
