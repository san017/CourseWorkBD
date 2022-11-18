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
    public partial class Main : Form
    {
        int currentRow;
        public int count = 0;
        public int count1 = 0;

        public Main()
        {
            InitializeComponent();
            SQL.Open();
            UpdateDgv();
            tableModification();
            tableCharacheristicsThisProduct.Visible = false;
        }

        private void UpdateDgv()
        {

            tableElectr.DataSource = SQL.SQLQuery("elect_tovar");
            TableCatalog.DataSource = SQL.SQLQuery("catalog");
            TableAllCharacheristic.DataSource = SQL.SQLQuery("characteristics");
            TablePostavka.DataSource = SQL.SQLQuery("all_postavka");
            TableProvider.DataSource = SQL.SQLQuery("Provider");
            tableRazdel.DataSource = SQL.SQLQuery("chapter");
            tableManufacturer.DataSource = SQL.SQLQuery("manufacturer");
            tableEmployees.DataSource = SQL.SQLQuery("all_employees");
            tableTypeShtraf.DataSource = SQL.SQLQuery("type_shtraf");
            tableAllShtrafs.DataSource = SQL.SQLQuery("all_shtraf");
            tablePost.DataSource = SQL.SQLQuery("post");
            tableCharge.DataSource = SQL.SQLQuery("charge");
            tableOrder.DataSource = SQL.SQLQuerySelect($"select idOrder,fio_shopper,numPhoneShopper,addressShopper,Data_order,StatusOrder,(case when  sum(costProductConfirm*numProduct)  IS NOT NULL THEN sum(costProductConfirm*numProduct) ELSE 0 END)as'Cost Order' from electr.order " +
                "left  join order_has_electr_product on order_has_electr_product.order_idOrder = electr.order.idOrder " +
                "left  join electr_product on electr_product.idElectr_product = order_has_electr_product.electr_product_idElectr_product " +
                "group by idOrder; ");
            Manager.ClearSelections(tableEmployees);
            Manager.ClearSelections(tableElectr);
            Manager.ClearSelections(tableManufacturer);
            Manager.ClearSelections(tableAllShtrafs);
            Manager.ClearSelections(TableCatalog);
            Manager.ClearSelections(TableAllCharacheristic);
            Manager.ClearSelections(tableOrder);
            Manager.ClearSelections(TablePostavka);
            Manager.ClearSelections(TableProvider);
            Manager.ClearSelections(tableRazdel);
            Manager.ClearSelections(tableTypeShtraf);
            Manager.ClearSelections(tablePost);
            Manager.ClearSelections(tableCharge);



            if (tableElectr.SelectedRows.Count == 0)
            {

                return;
            }

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddProductForm f = new AddProductForm();
            f.ShowDialog();
            tableElectr.DataSource = SQL.SQLQuery("elect_tovar");
        }
        public void tableModification()
        {
            tableElectr.Columns[0].Visible = false;
            tableElectr.Columns[1].Width = 260;
            tableElectr.Columns[2].Width = 70;
            tableElectr.Columns[3].Width = 70;
            TableAllCharacheristic.Columns[0].Visible = false;
            TableAllCharacheristic.Columns[1].Width = 251;
            TableCatalog.Columns[0].Visible = false;
            TableCatalog.Columns[1].Width = 234;
            TablePostavka.Columns[0].Visible = false;
            TablePostavka.Columns[1].Width = 158;
            TableProvider.Columns[0].Visible = false;
            TableProvider.Columns[1].Width = 263;
            tableRazdel.Columns[0].Visible = false;
            tableRazdel.Columns[1].Width = 234;
            tableManufacturer.Columns[0].Visible = false;
            tableManufacturer.Columns[1].Width = 237;
            tableEmployees.Columns[0].Visible = false;
            tableEmployees.Columns[1].Width = 180;
            tableEmployees.Columns[2].Width = 120;
            tableAllShtrafs.Columns[0].Visible = false;
            tableAllShtrafs.Columns[1].Width = 200;
            tableTypeShtraf.Columns[0].Visible = false;
            tableTypeShtraf.Columns[1].Width = 213;
            tablePost.Columns[0].Visible = false;
            tablePost.Columns[1].Width = 137;
            tableCharge.Columns[0].Visible = false;
            tableCharge.Columns[1].Width = 496;
            tableOrder.Columns[3].Width = 200;
            tableOrder.Columns[1].Width = 200;
            tableCharasteristics.Visible = false;
            button34.Visible = false;
            buttonDeleteFromCharacheristicAndCatalog.Visible = false;
            label4.Visible = false;
            label13.Visible = false;
            tableTypeShtraf.Visible = false;
            buttonUpdatePost.Enabled = false;
            textBoxAddTypeShtraf.Visible = false;
            buttonAddTypeShtraf.Visible = false;
            buttonDeleteTypeShtraf.Visible = false;
            buttonDeleteShtraf.Enabled = false;
            tableAllEmpl.Visible = false;
            buttonAddCompleteEmpHisRazdel.Visible = false;
            tableEmpAndHisRazdel.Visible = false;
            buttonAddEmpHisRazdel.Visible = false;
            buttonDeleteEmpHisRazdel.Visible = false;
            label30.Visible = false;
            buttonUpdateShrafs.Visible = false;
            tableEmpAndHisShtrafs.Visible = false;
            label32.Visible = false;

            label18.Visible = false;
            textBoxSearchEmpl.Visible = false;
            label31.Visible = false;
            textBoxSearchCharacteristicsInCatalog.Visible = false;
            label14.Visible = false;
            label43.Visible = false;
            label42.Visible = false;
            label34.Visible = false;
            label35.Visible = false;

            TableCatalog.Columns[1].HeaderCell.Value = "Название каталога";
            TableAllCharacheristic.Columns[1].HeaderCell.Value = "Наименнование характеристики";
            TableProvider.Columns[1].HeaderCell.Value = "Наименнование поставщика";
            tableRazdel.Columns[1].HeaderCell.Value = "Наименнование раздела ";
            tableManufacturer.Columns[1].HeaderCell.Value = "Наименнование производителя";
            tableEmployees.Columns[1].HeaderCell.Value = "ФИО сотрудника";
            tableEmployees.Columns[2].HeaderCell.Value = "Должность";
            tableEmployees.Columns[3].HeaderCell.Value = "Заработная плата";
            tableEmployees.Columns[4].HeaderCell.Value = "Кооэфицент зараб. платы";
            tableEmployees.Columns[5].HeaderCell.Value = "Номер телефона";
            tableEmployees.Columns[6].HeaderCell.Value = "Дата начала работы";
            tableTypeShtraf.Columns[1].HeaderCell.Value = "Тип штрафа";
            tablePost.Columns[1].HeaderCell.Value = "Наименнование должности";
            tablePost.Columns[2].HeaderCell.Value = "Заработная плата";
            tableCharge.Columns[1].HeaderCell.Value = "Обязанности";
            tableOrder.Columns[0].HeaderCell.Value = "Номер заказа";
            tableOrder.Columns[1].HeaderCell.Value = "ФИО покупателя";
            tableOrder.Columns[2].HeaderCell.Value = "Номер телефона покупателя";
            tableOrder.Columns[3].HeaderCell.Value = "Адрес доставки";
            tableOrder.Columns[4].HeaderCell.Value = "Дата заказа";
            tableOrder.Columns[5].HeaderCell.Value = "Статус заказа";
            tableOrder.Columns[6].HeaderCell.Value = "Стоимость заказа";

        }

        private void DeleteButtonElectrTable_Click(object sender, EventArgs e)
        {

            if (tableElectr.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите товар для удаления");
                return;
            }
            SQL.DeleteFromTable(tableElectr, "electr_product", "idElectr_product", 0);
            tableElectr.DataSource = SQL.SQLQuery("elect_tovar");
            if (tableElectr.SelectedRows.Count == 0)
            {
                return;
            }
            tableCharacheristicsThisProduct.DataSource = SQL.SQLQuerySelect($"select name_product,name_characteristic,value_characteristics from value_characteristics " +
              "join electr_product on electr_product.idElectr_product = value_characteristics.electr_product_idElectr_product " +
              "join characteristics on characteristics.idcharacteristics = value_characteristics.characteristics_idcharacteristics " +
              $"where name_product = '{tableElectr.SelectedRows[0].Cells[1].Value.ToString()}' ");

        }

        private void textBoxSearchByNameProduct_TextChanged(object sender, EventArgs e)
        {
            (tableElectr.DataSource as DataTable).DefaultView.RowFilter = $"`Название товара` LIKE'%{textBoxSearchByNameProduct.Text}%'";
        }

        private void textBoxSearchByDate_TextChanged(object sender, EventArgs e)
        {
            (tableElectr.DataSource as DataTable).DefaultView.RowFilter = $"CONVERT(`Дата поставки`,'System.String') LIKE'%{textBoxSearchByDate.Text}%'";
        }

        private void textBoxSearchByManufacturer_TextChanged(object sender, EventArgs e)
        {
            (tableElectr.DataSource as DataTable).DefaultView.RowFilter = $"`Производитель` LIKE'%{textBoxSearchByManufacturer.Text}%'";
        }


        private void buttonAddthisCatalogTable_Click(object sender, EventArgs e)
        {
            if (textBoxAddWithCatalog.Text != "")
            {
                MySqlCommand command = new MySqlCommand($"INSERT INTO catalog (name_catalog) VALUE ('{textBoxAddWithCatalog.Text}') ", SQL.Connection);
                command.ExecuteNonQuery().ToString();
                TableCatalog.DataSource = SQL.SQLQuery("catalog");
                textBoxAddWithCatalog.Clear();
            }
            else
            {

                MessageBox.Show("Поле для ввода пустое");
            }
        }

        private void buttonDeleteWithCatalogTable_Click(object sender, EventArgs e)
        {
            if (TableCatalog.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите из каталога товар");
                return;
            }
            else
            {
                SQL.DeleteFromTable(TableCatalog, "catalog", "idCatalog", 0);
                TableCatalog.DataSource = SQL.SQLQuery("catalog");
                button34.Visible = false;
                label14.Visible = false;
                label4.Visible = false;
                buttonDeleteFromCharacheristicAndCatalog.Visible = false;
                tableCharasteristics.Visible = false;
                textBoxSearchCharacteristicsInCatalog.Visible = false;
                label43.Visible = false;
                label42.Visible = false;
            }


        }


        private void TableCatalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                return;
            }

            label43.Text = TableCatalog.SelectedRows[0].Cells[1].Value.ToString();
            label43.Visible = true;
            button34.Visible = true;
            label14.Visible = true;
            label4.Visible = true;
            buttonDeleteFromCharacheristicAndCatalog.Visible = true;
            tableCharasteristics.Visible = true;
            textBoxSearchCharacteristicsInCatalog.Visible = true;
            label42.Visible = true;
            Manager.ClearSelections(tableCharasteristics);
            tableCharasteristics.DataSource = SQL.SqlQueryCharacteristics(TableCatalog.
                Rows[TableCatalog.CurrentRow.Index].Cells[0].Value.ToString());
            tableCharasteristics.Columns[3].Width = 229;
            tableCharasteristics.Columns[3].HeaderCell.Value = "Наименнование характеристики";
            tableCharasteristics.Columns[1].Visible = false;
            tableCharasteristics.Columns[0].Visible = false;
            tableCharasteristics.Columns[2].Visible = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (label13.Visible == false)
            {
                MessageBox.Show("Выберите добавляемую характеристику");
                return;
            }
            MySqlCommand command = new MySqlCommand($"INSERT INTO catalog_has_characteristics  (catalog_idCatalog,characteristics_idcharacteristics) " +
                  $"VALUE ('{TableCatalog.CurrentRow.Cells[0].Value}','{TableAllCharacheristic.CurrentRow.Cells[0].Value}')", SQL.Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                MessageBox.Show("Данная характеристика уже добавлена");
                return;
            }

            tableCharasteristics.DataSource = SQL.SqlQueryCharacteristics(TableCatalog.
                Rows[TableCatalog.CurrentRow.Index].Cells[0].Value.ToString());
        }
        private void buttonAddCharacheristics_Click(object sender, EventArgs e)
        {
            if (textBoxAddIsCharacteristics.Text == "")
            {
                MessageBox.Show("Поле для ввода пустое!");
                return;
            }
            MySqlCommand command = new MySqlCommand($"INSERT INTO characteristics (name_characteristic) VALUE('{textBoxAddIsCharacteristics.Text}')", SQL.Connection);
            try
            {
                command.ExecuteNonQuery().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Данная характеристика уже существует");
                return;

            }

            textBoxAddIsCharacteristics.Clear();
            TableAllCharacheristic.DataSource = SQL.SQLQuery("characteristics");

        }
        private void buttonDeleteCharacheristic_Click(object sender, EventArgs e)
        {
            if (TableAllCharacheristic.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите характеристику для удаления");
                return;
            }
            SQL.DeleteFromTable(TableAllCharacheristic, "characteristics", "idcharacteristics", 0);
            TableAllCharacheristic.DataSource = SQL.SQLQuery("characteristics");
            tableCharasteristics.DataSource = SQL.SqlQueryCharacteristics(TableCatalog.
              Rows[TableCatalog.CurrentRow.Index].Cells[0].Value.ToString()); ;
            label13.Text = "";
        }

        private void textBoxSearchIsCatalog_TextChanged(object sender, EventArgs e)
        {
            (TableCatalog.DataSource as DataTable).DefaultView.RowFilter = $"name_catalog LIKE'%{textBoxSearchIsCatalog.Text}%'";
        }
        //по выделенной строке появятся характеристики товара
        public void tableElectr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableElectr.SelectedRows.Count == 0)
            {
                tableCharacheristicsThisProduct.DataSource = SQL.SQLQuerySelect($"select name_product,name_characteristic,value_characteristics from value_characteristics " +
    "join electr_product on electr_product.idElectr_product = value_characteristics.electr_product_idElectr_product " +
    "join characteristics on characteristics.idcharacteristics = value_characteristics.characteristics_idcharacteristics " +
    "where idElectr_product <1");
            }
            Manager.ClearSelections(tableCharacheristicsThisProduct);
            tableCharacheristicsThisProduct.DataSource = SQL.SQLQuerySelect($"select name_product,name_characteristic,value_characteristics from value_characteristics " +
          "join electr_product on electr_product.idElectr_product = value_characteristics.electr_product_idElectr_product " +
          "join characteristics on characteristics.idcharacteristics = value_characteristics.characteristics_idcharacteristics " +
          $"where name_product = '{tableElectr.CurrentRow.Cells[1].Value.ToString()}' ");
            tableCharacheristicsThisProduct.Columns["name_product"].Visible = false;
            tableCharacheristicsThisProduct.Columns[1].Width = 150;
            tableCharacheristicsThisProduct.Columns[1].HeaderCell.Value ="Наименнование характеристики";
            tableCharacheristicsThisProduct.Columns[2].Width = 197;
            tableCharacheristicsThisProduct.Columns[2].HeaderCell.Value = "Значение характеристики";
            currentRow = tableElectr.CurrentRow.Index;

        }

        private void buttonAddProvider_Click(object sender, EventArgs e)
        {
            if (textBoxAddProvider.Text == "")
            {
                MessageBox.Show("Поле ввода пустое!");
                return;
            }
            MySqlCommand command = new MySqlCommand($"INSERT INTO provider (name_provider) VALUE ('{textBoxAddProvider.Text}')", SQL.Connection);
            command.ExecuteNonQuery();
            TableProvider.DataSource = SQL.SQLQuery("Provider");
            textBoxAddProvider.Clear();
        }

        private void buttonDeleteProvider_Click(object sender, EventArgs e)
        {
            if (TableProvider.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выбери поставщика для удаления");
                return;
            }
            SQL.DeleteFromTable(TableProvider, "provider", "idProvider", 0);
            TableProvider.DataSource = SQL.SQLQuery("Provider");
            TablePostavka.DataSource = SQL.SQLQuery("all_postavka");
        }

        private void buttonAddPostavka_Click(object sender, EventArgs e)
        {
            if (TableProvider.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите поставщика");
                return;
            }
            if (Int32.Parse(textBoxYear.Text) < 2000 || Int32.Parse(textBoxDay.Text) < 1 || Int32.Parse(textBoxMonth.Text) < 1)
            {
                MessageBox.Show("Неккоректная дата!");
                return;
            }
            MySqlCommand command = new MySqlCommand($"INSERT INTO postavka (Provider_idProvider,Data_postavki) " +
                $"VALUE({TableProvider.CurrentRow.Cells[0].Value.ToString()},'{textBoxYear.Text}-{textBoxMonth.Text}-{textBoxDay.Text}')", SQL.Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                if (textBoxDay.Text == "" || textBoxMonth.Text == "" || textBoxYear.Text == "")
                {
                    MessageBox.Show("Введите дату");
                    return;
                }
                MessageBox.Show("Неккоректная дата!");
                return;
            }
            textBoxDay.Clear();
            textBoxMonth.Clear();
            textBoxYear.Clear();
            TablePostavka.DataSource = SQL.SQLQuery("all_postavka");
        }

        private void buttonDeletePostavka_Click(object sender, EventArgs e)
        {
            SQL.DeleteFromTable(TablePostavka, "postavka", "idPostavka", 0);
            TablePostavka.DataSource = SQL.SQLQuery("all_postavka");
        }

        private void textBoxSearchProvider_TextChanged(object sender, EventArgs e)
        {
            (TableProvider.DataSource as DataTable).DefaultView.RowFilter = $"name_provider LIKE'%{textBoxSearchProvider.Text}%'";
        }

        private void textBoxSearchPostavka_TextChanged(object sender, EventArgs e)
        {
            (TablePostavka.DataSource as DataTable).DefaultView.RowFilter = $"CONVERT(`Дата поставки`,'System.String') LIKE'%{textBoxSearchPostavka.Text}%'";
        }

        private void buttonDeleteFromCharacheristicAndCatalog_Click(object sender, EventArgs e)
        {
            if (tableCharasteristics.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите характеристику для удаления");
                return;
            }
            SQL.DeleteFromTable(tableCharasteristics, "catalog_has_characteristics", " characteristics_idcharacteristics", 2);
            tableCharasteristics.DataSource = SQL.SqlQueryCharacteristics(TableCatalog.
                Rows[TableCatalog.CurrentRow.Index].Cells[0].Value.ToString());

        }
        #region textBoxForTablePostavka
        private void textBoxDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxDay.MaxLength = 2;
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxMonth.MaxLength = 2;
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxYear.MaxLength = 4;
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
        #endregion
        //Кнопка для добавления в dgv с разделами магазина
        private void buttonAddRazdel_Click(object sender, EventArgs e)
        {
            if (textBoxAddRazdel.Text == "")
            {
                MessageBox.Show("Поле ввода пустое");
                return;
            }
            MySqlCommand command = new MySqlCommand($"INSERT INTO chapter(name_razdel) VALUES ('{textBoxAddRazdel.Text}')", SQL.Connection);
            command.ExecuteNonQuery();
            textBoxAddRazdel.Clear();
            tableRazdel.DataSource = SQL.SQLQuery("chapter");
        }



        private void TableAllCharacheristic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TableAllCharacheristic.SelectedRows.Count == 0)
            {
                return;
            }
            if (e.RowIndex < 0)
            {

                label13.Visible = false;
                return;
            }

            if (tableCharasteristics.Visible)
            {
                label13.Visible = true;
            }
            else label13.Visible = false;
            label13.Text = TableAllCharacheristic.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void textBoxSearchCharacteristicsInCatalog_TextChanged(object sender, EventArgs e)
        {
            (tableCharasteristics.DataSource as DataTable).DefaultView.RowFilter = $"name_characteristic LIKE'%{textBoxSearchCharacteristicsInCatalog.Text}%'";
        }

        private void buttonDeleteRazdel_Click(object sender, EventArgs e)
        {
            if (tableRazdel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите раздел для удаления");
                return;
            }
            SQL.DeleteFromTable(tableRazdel, "chapter", "idchapter", 0);
            tableRazdel.DataSource = SQL.SQLQuery("chapter");
        }

        private void textBoxSearchAllCharacteristics_TextChanged(object sender, EventArgs e)
        {
            (TableAllCharacheristic.DataSource as DataTable).DefaultView.RowFilter = $"name_characteristic LIKE'%{textBoxSearchAllCharacteristics.Text}%'";
        }

        private void buttonAddManufacturer_Click(object sender, EventArgs e)
        {
            if (textBoxAddManufacturer.Text == "")
            {
                MessageBox.Show("Поле ввода пустое");
                return;
            }
            MySqlCommand command = new MySqlCommand($"INSERT INTO manufacturer (name_manufacturer) VALUES ('{textBoxAddManufacturer.Text}') ", SQL.Connection);
            command.ExecuteNonQuery();
            tableManufacturer.DataSource = SQL.SQLQuery("manufacturer");
        }
        public void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            if (tableElectr.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выделено больше двух строк");
            }
            else
            {
                if (tableElectr.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите товар для редактирования");
                    return;
                }
                UpdateProductForm f = new UpdateProductForm(tableElectr.SelectedRows[0]);

                f.ShowDialog();

                tableCharacheristicsThisProduct.DataSource = SQL.SQLQuerySelect($"select name_product,name_characteristic,value_characteristics from value_characteristics " +
              "join electr_product on electr_product.idElectr_product = value_characteristics.electr_product_idElectr_product " +
              "join characteristics on characteristics.idcharacteristics = value_characteristics.characteristics_idcharacteristics " +
              $"where name_product = '{tableElectr.CurrentRow.Cells[1].Value.ToString()}' ");
                tableElectr.DataSource = SQL.SQLQuery("elect_tovar");
                tableElectr.ClearSelection();
                tableElectr.Rows[currentRow].Selected = true;




            }

        }

        private void buttonDeleteFromTableManufacturer_Click(object sender, EventArgs e)
        {
            if (tableManufacturer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите производителя для удаления");
                return;
            }
            SQL.DeleteFromTable(tableManufacturer, "manufacturer", "idmanufacturer", 0);
            tableManufacturer.DataSource = SQL.SQLQuery("manufacturer");
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tableCharacheristicsThisProduct.Visible = true;
            }
            else
            {
                tableCharacheristicsThisProduct.Visible = false;
            }
        }

        //Всё связанное с сотрудниками

        private void buttonAddPost_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand($"INSERT INTO post(name_post,payday) VALUES ('{textBoxNamePost.Text}',{textBoxPaydayByPost.Text})", SQL.Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                if (textBoxNamePost.Text == "" || textBoxPaydayByPost.Text == "")
                {
                    MessageBox.Show("Поля ввода пустые");
                    return;
                }
                else MessageBox.Show("Проверьте вводимые данные");
                return;
            }
            tablePost.DataSource = SQL.SQLQuery("post");
        }

        private void buttonDeletePost_Click(object sender, EventArgs e)
        {
            if (tablePost.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите должность для удаления");
                return;
            }
            SQL.DeleteFromTable(tablePost, "post", "idPost", 0);
            tablePost.DataSource = SQL.SQLQuery("post");
        }

        private void textBoxSearchPost_TextChanged(object sender, EventArgs e)
        {
            (tablePost.DataSource as DataTable).DefaultView.RowFilter = $"name_post LIKE'%{textBoxSearchPost.Text}%'";
        }

        private void buttonUpdatePost_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand($"update POST set payday = {tablePost.CurrentRow.Cells[2].Value} where idPost = {tablePost.CurrentRow.Cells[0].Value} ", SQL.Connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Отредактировано");
            tableEmployees.DataSource = SQL.SQLQuery("all_employees");
        }

        private void tablePost_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < tablePost.Rows.Count; i++)
            {
                tablePost.Rows[i].ReadOnly = true;
            }
            for (int i = 0; i < tablePost.Rows.Count; i++)
            {
                tablePost.Rows[i].Cells[2].ReadOnly = false;
                if (tablePost.Columns[2].Index.ToString() == e.ColumnIndex.ToString())
                {
                    buttonUpdatePost.Enabled = true;
                }
                else
                {
                    buttonUpdatePost.Enabled = false;
                }
                Manager.ClearSelections(tableChargeInPost);
                tableChargeInPost.DataSource = SQL.SQLQuerySelect($"select post_idPost,name_post,Charge_idCharge,Charge from post_has_charge " +
                    $"join post on post.idPost = post_has_charge.post_idPost " +
                    $"join charge on charge.idCharge = post_has_charge.Charge_idCharge " +
                    $"where idPost = '{tablePost.CurrentRow.Cells[0].Value}'");
                tableChargeInPost.Columns[0].Visible = false;
                tableChargeInPost.Columns[2].Visible = false;
                tableChargeInPost.Columns[3].Width = 190;
                tableChargeInPost.Columns[1].HeaderCell.Value = "Должность";
                tableChargeInPost.Columns[3].HeaderCell.Value = "Обязанности";

            }

        }

        private void checkBoxTypeShtraf_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTypeShtraf.Checked)
            {
                tableTypeShtraf.Visible = true;
                textBoxAddTypeShtraf.Visible = true;
                buttonAddTypeShtraf.Visible = true;
                buttonDeleteTypeShtraf.Visible = true;
            }
            else
            {
                tableTypeShtraf.Visible = false;
                textBoxAddTypeShtraf.Visible = false;
                buttonAddTypeShtraf.Visible = false;
                buttonDeleteTypeShtraf.Visible = false;
            }

        }

        private void buttonAddTypeShtraf_Click(object sender, EventArgs e)
        {
            if (textBoxAddTypeShtraf.Text == "")
            {
                MessageBox.Show("Поле для ввода пустое");
                return;
            }
            MySqlCommand command = new MySqlCommand($"INSERT INTO type_shtraf(vid_shtraf) VALUES ('{textBoxAddTypeShtraf.Text}')", SQL.Connection);
            command.ExecuteNonQuery();
            tableTypeShtraf.DataSource = SQL.SQLQuery("type_shtraf");
        }

        private void buttonDeleteTypeShtraf_Click(object sender, EventArgs e)
        {
            if (tableTypeShtraf.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите тип штрафа для удаления");
                return;
            }
            SQL.DeleteFromTable(tableTypeShtraf, "type_shtraf", "idtype_shtraf", 0);
            tableTypeShtraf.DataSource = SQL.SQLQuery("type_shtraf");
        }

        private void buttonAddShtraf_Click(object sender, EventArgs e)
        {
            if (textBoxAddShtraf.Text == "")
            {
                MessageBox.Show("Ошибка! Поля ввода пустые!");
                return;
            }
            var s = textBoxCostShtraf.Text.Length == 0 ? "0" : textBoxCostShtraf.Text;
            try
            {
                MySqlCommand command = new MySqlCommand($"INSERT INTO shtraf (name_shtraf,type_shtraf_idtype_shtraf,cost_shtraf) " +
               $"VALUES ('{textBoxAddShtraf.Text}','{tableTypeShtraf.SelectedRows[0].Cells[0].Value}',{s})", SQL.Connection);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка! Поля ввода пустые!");
                return;
            }

            tableAllShtrafs.DataSource = SQL.SQLQuery("all_shtraf");
        }
        private void tableTypeShtraf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxSelectedTypeShtraf.Text = tableTypeShtraf.CurrentRow.Cells[1].Value.ToString();
        }

        private void buttonDeleteShtraf_Click(object sender, EventArgs e)
        {
            SQL.DeleteFromTable(tableAllShtrafs, "shtraf", "idShtraf", 0);
            tableAllShtrafs.DataSource = SQL.SQLQuery("all_shtraf");
        }

        private void tableAllShtrafs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (count < 1)
            {
                for (int i = 0; i < tableAllShtrafs.Rows.Count; i++)
                {
                    tableAllShtrafs.Rows[i].ReadOnly = true;

                }
            }

            buttonDeleteShtraf.Enabled = tableAllShtrafs.CurrentRow.Selected;
        }

        private void buttonAddCharge_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand($"INSERT INTO charge (Charge) VALUES('{textBoxAddCharge.Text}')", SQL.Connection);
            command.ExecuteNonQuery();
            tableCharge.DataSource = SQL.SQLQuery("charge");
        }

        private void buttonDeleteCharge_Click(object sender, EventArgs e)
        {
            if (tableCharge.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите обязанность из таблицы для удаления!");
                return;
            }
            SQL.DeleteFromTable(tableCharge, "charge", "idCharge", 0);
            tableCharge.DataSource = SQL.SQLQuery("charge");
            Manager.ClearSelections(tableChargeInPost);
            tableChargeInPost.DataSource = SQL.SQLQuerySelect($"select post_idPost,name_post,Charge_idCharge,Charge from post_has_charge " +
                 $"join post on post.idPost = post_has_charge.post_idPost " +
                 $"join charge on charge.idCharge = post_has_charge.Charge_idCharge " +
                 $"where idPost = '{tablePost.CurrentRow.Cells[0].Value}'");

        }

        private void textBoxSearchCharge_TextChanged(object sender, EventArgs e)
        {
            (tableCharge.DataSource as DataTable).DefaultView.RowFilter = $"charge LIKE'%{textBoxSearchCharge.Text}%'";
        }

        private void buttonAddChargeInPost_Click(object sender, EventArgs e)
        {
            if (tablePost.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите должность");
                return;
            }
            MySqlCommand command = new MySqlCommand($"INSERT INTO post_has_charge (post_idPost,Charge_idCharge)" +
                $" VALUES ('{tablePost.CurrentRow.Cells[0].Value}','{tableCharge.CurrentRow.Cells[0].Value}')", SQL.Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Данная обязанность уже добавлена");
                return;
            }

            tableChargeInPost.DataSource = SQL.SQLQuerySelect($"select post_idPost,name_post,Charge_idCharge,Charge from post_has_charge " +
                  $"join post on post.idPost = post_has_charge.post_idPost " +
                  $"join charge on charge.idCharge = post_has_charge.Charge_idCharge " +
                  $"where idPost = '{tablePost.CurrentRow.Cells[0].Value}'");
        }

        private void buttonDeleteChargeInPost_Click(object sender, EventArgs e)
        {
            if (tableChargeInPost.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пустая");
                return;
            }
            if (tableChargeInPost.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите обязанность для удаления");
                return;
            }
            MySqlCommand command = new MySqlCommand($"delete from post_has_charge" +
                $" where post_idPost = {tableChargeInPost.CurrentRow.Cells[0].Value} AND " +
                $"Charge_idCharge ={tableChargeInPost.SelectedRows[0].Cells[2].Value}", SQL.Connection);
            command.ExecuteNonQuery();
            tableChargeInPost.DataSource = SQL.SQLQuerySelect($"select post_idPost,name_post,Charge_idCharge,Charge from post_has_charge " +
                  $"join post on post.idPost = post_has_charge.post_idPost " +
                  $"join charge on charge.idCharge = post_has_charge.Charge_idCharge " +
                  $"where idPost = '{tablePost.CurrentRow.Cells[0].Value}'");
        }

        private void buttonAddEmployees_Click(object sender, EventArgs e)
        {
            var s = new AddEmployeesForm();
            s.ShowDialog();
            tableEmployees.DataSource = SQL.SQLQuery("all_employees");
        }

        private void buttonDeleteEmployees_Click(object sender, EventArgs e)
        {
            SQL.DeleteFromTable(tableEmployees, "employees", "idemployees", 0);
            tableEmployees.DataSource = SQL.SQLQuery("all_employees");
        }

        private void textBoxSearchEmployees_TextChanged(object sender, EventArgs e)
        {
            (tableEmployees.DataSource as DataTable).DefaultView.RowFilter = $"fio_employee LIKE'%{textBoxSearchEmployees.Text}%'";
        }

        private void tableEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tableEmpAndHisShtrafs.DataSource = SQL.SQLQuerySelect($"select name_shtraf,vid_shtraf,cost_shtraf,data_shtraf from employees_has_shtraf " +
                $"join employees on employees.idemployees = employees_has_shtraf.employees_idemployees " +
                $"join shtraf on shtraf.idShtraf = employees_has_shtraf.Shtraf_idShtraf " +
                $"join type_shtraf on shtraf.type_shtraf_idtype_shtraf = type_shtraf.idtype_shtraf" +
                $" where idemployees = {tableEmployees.CurrentRow.Cells[0].Value}");

            Manager.ClearSelections(tableEmpAndHisShtrafs);
            tableEmpAndHisShtrafs.Columns[0].Width = 268;
            tableEmpAndHisShtrafs.Columns[2].Width = 70;
            tableEmpAndHisShtrafs.Columns[0].HeaderCell.Value = "Причина штрафа";
            tableEmpAndHisShtrafs.Columns[1].HeaderCell.Value = "Тип штрафа";
            tableEmpAndHisShtrafs.Columns[2].HeaderCell.Value = "Штраф в руб.";
            tableEmpAndHisShtrafs.Columns[3].HeaderCell.Value = "Дата нарушения";
            tableEmpAndHisShtrafs.ClearSelection();




        }

        private void buttonAddEmpHisRazdel_Click(object sender, EventArgs e)
        {
            tableAllEmpl.DataSource = SQL.SQLQuerySelect($"SELECT idemployees,fio_employee FROM electr.employees");
            tableAllEmpl.Columns[0].Visible = false;
            tableAllEmpl.Columns[1].Width = 230;
            tableAllEmpl.Columns[1].HeaderCell.Value = "Список всех сотрудников";
            tableAllEmpl.Visible = true;
            buttonAddCompleteEmpHisRazdel.Visible = true;
            label30.Visible = true;
            label18.Visible = true;
            textBoxSearchEmpl.Visible = true;
            label31.Visible = true;
        }
        private void tableRazdel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkBoxEmpHisRazdel.Checked)
            {
                label35.Visible = true;
            }
            tableEmpAndHisRazdel.DataSource = SQL.SQLQuerySelect($"select idemployees,fio_employee from chapter_has_employees " +
                $" join chapter on chapter.idchapter = chapter_has_employees.chapter_idchapter " +
                $" join employees on employees.idemployees = chapter_has_employees.employees_idemployees " +
                $" where name_razdel = '{tableRazdel.SelectedRows[0].Cells[1].Value}' ");
            label35.Text = tableRazdel.SelectedRows[0].Cells[1].Value.ToString();
            Manager.ClearSelections(tableEmpAndHisRazdel);
            tableEmpAndHisRazdel.Columns[0].Visible = false;
            tableEmpAndHisRazdel.Columns[1].Width = 218;
            tableEmpAndHisRazdel.Columns[1].HeaderCell.Value = "Сотрудники в разделе";

        }

        private void checkBoxEmpHisRazdel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEmpHisRazdel.Checked)
            {

                tableEmpAndHisRazdel.Visible = true;
                buttonAddEmpHisRazdel.Visible = true;
                buttonDeleteEmpHisRazdel.Visible = true;
                label34.Visible = true;
            }
            else
            {

                tableEmpAndHisRazdel.Visible = false;
                buttonAddEmpHisRazdel.Visible = false;
                buttonDeleteEmpHisRazdel.Visible = false;
                tableAllEmpl.Visible = false;
                buttonAddCompleteEmpHisRazdel.Visible = false;
                label30.Visible = false;
                label34.Visible = false;
                label35.Visible = false;
                label18.Visible = false;
                textBoxSearchEmpl.Visible = false;
                label31.Visible = false;
            }
        }

        private void buttonAddCompleteEmpHisRazdel_Click(object sender, EventArgs e)
        {
            if (tableEmpAndHisRazdel.SelectedRows.Count == 0)
            {
                if (tableRazdel.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите раздел для добавления сотрудника");
                    return;
                }
                MySqlCommand command = new MySqlCommand($"INSERT INTO chapter_has_employees (chapter_idchapter,employees_idemployees)" +
       $" VALUES ('{tableRazdel.SelectedRows[0].Cells[0].Value}','{tableAllEmpl.SelectedRows[0].Cells[0].Value}')", SQL.Connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Данный сотрудник уже добавлен в раздел");
                    return;
                }

                tableEmpAndHisRazdel.DataSource = SQL.SQLQuerySelect($"select idemployees,fio_employee from chapter_has_employees " +
               $" join chapter on chapter.idchapter = chapter_has_employees.chapter_idchapter " +
               $" join employees on employees.idemployees = chapter_has_employees.employees_idemployees " +
               $" where name_razdel = '{tableRazdel.SelectedRows[0].Cells[1].Value}' ");
            }
            else
            {
                MySqlCommand command = new MySqlCommand($"INSERT INTO chapter_has_employees (chapter_idchapter,employees_idemployees)" +
              $" VALUES ('{tableRazdel.SelectedRows[0].Cells[0].Value}','{tableAllEmpl.SelectedRows[0].Cells[0].Value}')", SQL.Connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Данный сотрудник уже добавлен в раздел");
                    return;
                }
                tableEmpAndHisRazdel.DataSource = SQL.SQLQuerySelect($"select idemployees,fio_employee from chapter_has_employees " +
             $" join chapter on chapter.idchapter = chapter_has_employees.chapter_idchapter " +
             $" join employees on employees.idemployees = chapter_has_employees.employees_idemployees " +
             $" where name_razdel = '{tableRazdel.SelectedRows[0].Cells[1].Value}' ");

            }
        }

        private void buttonDeleteEmpHisRazdel_Click(object sender, EventArgs e)
        {
            if (tableEmpAndHisRazdel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника для удаления");
                return;
            }
            MySqlCommand command = new MySqlCommand($"delete from chapter_has_employees" +
                $" where chapter_idchapter = '{tableRazdel.SelectedRows[0].Cells[0].Value}' " +
                $" AND employees_idemployees = '{tableEmpAndHisRazdel.CurrentRow.Cells[0].Value}'", SQL.Connection);
            command.ExecuteNonQuery();
            tableEmpAndHisRazdel.DataSource = SQL.SQLQuerySelect($"select idemployees,fio_employee from chapter_has_employees " +
          $" join chapter on chapter.idchapter = chapter_has_employees.chapter_idchapter " +
          $" join employees on employees.idemployees = chapter_has_employees.employees_idemployees " +
          $" where name_razdel = '{tableRazdel.SelectedRows[0].Cells[1].Value}' ");

        }



        private void buttonUpdateEmployees_Click(object sender, EventArgs e)
        {
            if (tableEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Нет");
                return;
            }
            var s = new UpgradeEmployeesForm(tableEmployees.SelectedRows[0]);
            s.ShowDialog();
            tableEmployees.DataSource = SQL.SQLQuery("all_employees");
        }

        private void buttonUpdateShrafs_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableAllShtrafs.Rows.Count; i++)
            {
                var command = new MySqlCommand($"update shtraf set name_shtraf='{tableAllShtrafs.Rows[i].Cells[1].Value}', " +
            $"cost_shtraf = '{tableAllShtrafs.Rows[i].Cells[3].Value}'" +
            $"where idShtraf = '{tableAllShtrafs.Rows[i].Cells[0].Value}'", SQL.Connection);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Отредактировано");
            count--;
            if (count <= 1)
            {
                buttonModeUpdateShtrafs.Enabled = true;
                buttonUpdateShrafs.Visible = false;
            }
        }

        private void buttonModeUpdateShtrafs_Click(object sender, EventArgs e)
        {
            buttonUpdateShrafs.Visible = true;
            count++;
            if (count >= 1)
            {
                buttonModeUpdateShtrafs.Enabled = false;
            }

            for (int i = 0; i < tableAllShtrafs.Rows.Count; i++)
            {
                tableAllShtrafs.Rows[i].Cells[1].ReadOnly = false;
                tableAllShtrafs.Rows[i].Cells[3].ReadOnly = false;
            }
        }

        private void checkBoxShtrafsAndChargeEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShtrafsAndChargeEmp.Checked)
            {
                tableEmpAndHisShtrafs.Visible = true;
                label32.Visible = true;

            }
            else
            {
                tableEmpAndHisShtrafs.Visible = false;
                label32.Visible = false;

            }
        }

        private void textBoxAddWithCatalog_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            char f = e.KeyChar;

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]|[ ]|[0-9]").Success && f != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxAddIsCharacteristics_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tableOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableOrder.SelectedRows.Count == 0)
            {
                return;
            }
            tableProductInOrder.DataSource = SQL.SQLQuerySelect($"select name_product,(costProductConfirm*numProduct),numProduct from order_has_electr_product " +
                $"join electr_product on electr_product.idElectr_product = order_has_electr_product.electr_product_idElectr_product " +
                $"join electr.order on electr.order.idOrder = order_has_electr_product.order_idOrder " +
                $"where idOrder = '{tableOrder.SelectedRows[0].Cells[0].Value}' ");
            tableProductInOrder.Columns[0].HeaderCell.Value = "Название товара";
            tableProductInOrder.Columns[0].Width = 220;
            tableProductInOrder.Columns[1].HeaderCell.Value = "Стоимость товара";
            tableProductInOrder.Columns[2].HeaderCell.Value = "Количество товара";
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            var s = new AddOrderForm();
            s.ShowDialog();
            tableOrder.DataSource = SQL.SQLQuerySelect($"select idOrder,fio_shopper,numPhoneShopper,addressShopper,Data_order,StatusOrder," +
            $"(case when  sum(costProductConfirm*numProduct)  IS NOT NULL THEN sum(costProductConfirm*numProduct) ELSE 0 END)as'Cost Order' " +
            $"from electr.order" +
            " left  join order_has_electr_product on order_has_electr_product.order_idOrder = electr.order.idOrder " +
            " left  join electr_product on electr_product.idElectr_product = order_has_electr_product.electr_product_idElectr_product " +
            " group by idOrder; ");
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (tableOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ для удаления");
                return;
            }
            SQL.DeleteFromTable(tableOrder, "electr.order", "idOrder", 0);
            tableOrder.DataSource = SQL.SQLQuerySelect($"select idOrder,fio_shopper,numPhoneShopper,addressShopper,Data_order,StatusOrder," +
          $"(case when  sum(costProductConfirm*numProduct)  IS NOT NULL THEN sum(costProductConfirm*numProduct) ELSE 0 END)as'Cost Order' " +
          $"from electr.order" +
          " left  join order_has_electr_product on order_has_electr_product.order_idOrder = electr.order.idOrder " +
          " left  join electr_product on electr_product.idElectr_product = order_has_electr_product.electr_product_idElectr_product " +
          " group by idOrder; ");
            if (tableOrder.SelectedRows.Count == 0)
            {
                tableProductInOrder.DataSource = SQL.SQLQuerySelect($"select name_product,(costProductConfirm*numProduct),numProduct from order_has_electr_product " +
          $"join electr_product on electr_product.idElectr_product = order_has_electr_product.electr_product_idElectr_product " +
          $"join electr.order on electr.order.idOrder = order_has_electr_product.order_idOrder ");
                return;
            }
            tableProductInOrder.DataSource = SQL.SQLQuerySelect($"select name_product,(costProductConfirm*numProduct),numProduct from order_has_electr_product " +
           $"join electr_product on electr_product.idElectr_product = order_has_electr_product.electr_product_idElectr_product " +
           $"join electr.order on electr.order.idOrder = order_has_electr_product.order_idOrder " +
           $"where idOrder = '{tableOrder.SelectedRows[0].Cells[0].Value}' ");
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            if (tableOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выделите заказ");
                return;
            }

            var s = new UpdateFormOrder(tableOrder.SelectedRows[0]);
            s.ShowDialog();
            tableOrder.DataSource = SQL.SQLQuerySelect($"select idOrder,fio_shopper,numPhoneShopper,addressShopper,Data_order,StatusOrder," +
           $"(case when  sum(costProductConfirm*numProduct)  IS NOT NULL THEN sum(costProductConfirm*numProduct) ELSE 0 END)as'Cost Order' " +
           $"from electr.order" +
           " left  join order_has_electr_product on order_has_electr_product.order_idOrder = electr.order.idOrder " +
           " left  join electr_product on electr_product.idElectr_product = order_has_electr_product.electr_product_idElectr_product " +
           " group by idOrder; ");
            if (tableOrder.SelectedRows.Count == 0)
            {
                return;
            }

            tableProductInOrder.DataSource = SQL.SQLQuerySelect($"select name_product,(costProductConfirm*numProduct),numProduct from order_has_electr_product " +
             $"join electr_product on electr_product.idElectr_product = order_has_electr_product.electr_product_idElectr_product " +
             $"join electr.order on electr.order.idOrder = order_has_electr_product.order_idOrder " +
             $"where idOrder = '{tableOrder.SelectedRows[0].Cells[0].Value}' ");

        }

        private void textBoxSearchEmpl_TextChanged(object sender, EventArgs e)
        {
            (tableAllEmpl.DataSource as DataTable).DefaultView.RowFilter = $"fio_employee LIKE'%{textBoxSearchEmpl.Text}%'";
        }

        private void textBoxSearchFioShopper_TextChanged(object sender, EventArgs e)
        {
            (tableOrder.DataSource as DataTable).DefaultView.RowFilter = $"fio_shopper LIKE'%{textBoxSearchFioShopper.Text}%'";
        }

        private void textBoxSearchNumPhone_TextChanged(object sender, EventArgs e)
        {
            (tableOrder.DataSource as DataTable).DefaultView.RowFilter = $"numPhoneShopper LIKE'%{textBoxSearchNumPhone.Text}%'";
        }

        private void textBoxSearchAddress_TextChanged(object sender, EventArgs e)
        {
            (tableOrder.DataSource as DataTable).DefaultView.RowFilter = $"addressShopper LIKE'%{textBoxSearchAddress.Text}%'";
        }
    }
}




