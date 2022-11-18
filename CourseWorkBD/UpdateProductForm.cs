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
    public partial class UpdateProductForm : Form
    {
        public string id;
        public string idd;
        public string name_tovar;
        public int count = 0;
        private Dictionary<int, string> ChangesTableCharacteristics = new Dictionary<int, string>();
        public string TxtBoxNameProduct
        {
            set { textBoxNameProduct.Text = value; }
        }
        public string TxtBoxCostProduct
        {
            set { textBoxCostProduct.Text = value; }
        }
        public UpdateProductForm(DataGridViewRow dr)
        {
            var tableElectrProductSQL = new DataTable();
            InitializeComponent();
            Manager.ComboBoxPostavka = comboBox1;
            Manager.ComboBoxManufacturer = comboBox2;
            Manager.ComboBoxRazdel = comboBox4;
            Manager.ComboBoxCatalog = comboBox5;
            Manager.InitializeEvent();
            Manager.SetComboBoxCollections();
            id = dr.Cells[0].Value.ToString();
            idd = dr.Cells[0].Value.ToString();
            name_tovar = dr.Cells[1].Value.ToString();
            //   selectTableUpdateCharacheristics(dr);
            tableUpdateCharacteristics.DataSource = SQL.SQLQuerySelect($"select idElectr_product,name_product,idcharacteristics,name_characteristic,value_characteristics from value_characteristics " +
         "join electr_product on electr_product.idElectr_product = value_characteristics.electr_product_idElectr_product " +
         "join characteristics on characteristics.idcharacteristics = value_characteristics.characteristics_idcharacteristics " +
         $"where idElectr_product = '{dr.Cells[0].Value.ToString()}' ");
            var s = new MySqlDataAdapter($"select name_product,cost_product,num_section,size_discont from electr_product " +
                         $"where idElectr_product = {dr.Cells[0].Value.ToString()} ", SQL.Connection);
            s.Fill(tableElectrProductSQL);
            tableUpdateChar.DataSource = SQL.SQLQuery("characteristics");
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {

                if (comboBox1.Items[i].ToString() == dr.Cells[4].Value.ToString())
                {
                    comboBox1.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < comboBox2.Items.Count; i++)
            {
                if (comboBox2.Items[i].ToString() == dr.Cells[7].Value.ToString())
                {
                    comboBox2.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < comboBox4.Items.Count; i++)
            {
                if (comboBox4.Items[i].ToString() == dr.Cells[5].Value.ToString())
                {
                    comboBox4.SelectedIndex = i;
                    break;
                }
            }
            //   textBoxNameProduct.Text = dr.Cells[1].Value.ToString();
            textBoxNameProduct.Text = tableElectrProductSQL.Rows[0].ItemArray[0].ToString();
            textBoxCostProduct.Text = Regex.Replace(tableElectrProductSQL.Rows[0].ItemArray[1].ToString(), ",", ".");
            textBoxNumSection.Text = tableElectrProductSQL.Rows[0].ItemArray[2].ToString();
            textBoxDiscont.Text = tableElectrProductSQL.Rows[0].ItemArray[3].ToString();
            textBoxNameProduct.SelectionStart = 0;
            textBoxCostProduct.SelectionStart = 0;
            textBoxNumSection.SelectionStart = 0;
            tableModification();
            


        }
        public void tableModification()
        {

            tableUpdateCharacteristics.Columns[0].Visible = false;
            tableUpdateCharacteristics.Columns[2].Visible = false;
            tableUpdateCharacteristics.Columns[3].ReadOnly = true;
            labelSearch.Visible = false;
            textBoxSearchIsAllCharacteristics.Visible = false;
            tableUpdateChar.Visible = false;
            buttonAddCharacteristicByProduct.Enabled = false;
            tableUpdateChar.Columns[0].Visible = false;
            tableUpdateChar.Columns[1].Width = 209;
            tableUpdateCharacteristics.Columns[1].Visible = false;
            tableUpdateCharacteristics.Columns[3].Width =150;
            tableUpdateCharacteristics.Columns[4].Width =146;

        }
        public void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBoxDiscont.Text) > 100 || textBoxDiscont.Text == "")
            {
                MessageBox.Show("Неккоректный ввод скидки");
                return;
            }

            MySqlCommand command = new MySqlCommand($"UPDATE electr_product set name_product = '{textBoxNameProduct.Text}'," +
       $" cost_product = '{textBoxCostProduct.Text}', " +
       $" num_section = {textBoxNumSection.Text}," +
       $" Postavka_idPostavka = '{Manager.id}' ," +
       $" manufacturer_idmanufacturer = '{Manager.DictionaryIdTables[comboBox2].CurrentId}'," +
       $" chapter_idchapter = '{Manager.DictionaryIdTables[comboBox4].CurrentId}'," +
       $" size_discont = '{textBoxDiscont.Text}' where idElectr_product ={id}", SQL.Connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введённые данные");

                return;
            }
       

            for (int i = 0; i < tableUpdateCharacteristics.Rows.Count; i++)
            {
                MySqlCommand command1 = new MySqlCommand($"update value_characteristics set value_characteristics ='{tableUpdateCharacteristics.Rows[i].Cells[4].Value.ToString()}' " +
                 $"where electr_product_idElectr_product =(select idElectr_product from electr_product " +
                 $"where name_product ='{textBoxNameProduct.Text}') and " +
                 $"characteristics_idcharacteristics =(select idcharacteristics from characteristics where name_characteristic = '{tableUpdateCharacteristics.Rows[i].Cells[3].Value.ToString()}')", SQL.Connection);
                command1.ExecuteNonQuery();
            }

            ChangesTableCharacteristics.Clear();
            Close();
        }
        private void UpdateDgv()
        {
            flag = true;
            tableUpdateCharacteristics.DataSource = SQL.SQLQuerySelect($"select idElectr_product,name_product,idcharacteristics,name_characteristic,value_characteristics from value_characteristics " +
                "join electr_product on electr_product.idElectr_product = value_characteristics.electr_product_idElectr_product " +
                "join characteristics on characteristics.idcharacteristics = value_characteristics.characteristics_idcharacteristics " +
                $"where idElectr_product = {id} ");
            
            foreach (var kvp in ChangesTableCharacteristics)
            {
               if (kvp.Value != null)
                {
                    return;
                }
                tableUpdateCharacteristics.Rows[kvp.Key].Cells[4].Value = kvp.Value;
            }
            flag = false;
        }
        public void buttonAddCharacteristicByProduct_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < tableUpdateCharacteristics.Rows.Count; i++)
            {
                if (tableUpdateCharacteristics.Rows[i].Cells[3].Value.ToString() == tableUpdateChar.CurrentRow.Cells[1].Value.ToString())
                {
                    MessageBox.Show("Такая характеристика уже есть");
                    return;
                }
            }
            if (tableUpdateCharacteristics.Rows.Count == 0)
            {
                MySqlCommand command1 = new MySqlCommand($"INSERT INTO value_characteristics(characteristics_idcharacteristics,electr_product_idElectr_product)" +
                           $" values ('{tableUpdateChar.CurrentRow.Cells[0].Value.ToString()}', '{id}') ", SQL.Connection);
                command1.ExecuteNonQuery();
                UpdateDgv();
            }
            else
            {
                MySqlCommand command = new MySqlCommand($"INSERT INTO value_characteristics(characteristics_idcharacteristics,electr_product_idElectr_product)" +
                      $" values ('{tableUpdateChar.CurrentRow.Cells[0].Value.ToString()}', '{id}') ", SQL.Connection);
                command.ExecuteNonQuery();
                UpdateDgv();
            }



        }



        private void buttonDeleteFromCharacteristicsByProduct_Click(object sender, EventArgs e)
        {
            if (tableUpdateCharacteristics.Rows.Count == 0)
            {
                MessageBox.Show("Пустая таблица");
                return;
            }
            else
            {
                for (int i = 0; i < tableUpdateCharacteristics.SelectedRows.Count; i++)
                {
                    MySqlCommand command = new MySqlCommand($"delete from value_characteristics " +
                                 $"where characteristics_idcharacteristics = '{tableUpdateCharacteristics.SelectedRows[i].Cells[2].Value.ToString()}'and " +
                                 $"electr_product_idElectr_product ={tableUpdateCharacteristics.CurrentRow.Cells[0].Value.ToString()}", SQL.Connection);
                    command.ExecuteNonQuery();
                }

                UpdateDgv();
            }
           
        }

        private void textBoxSearchIsAllCharacteristics_TextChanged(object sender, EventArgs e)
        {
            (tableUpdateChar.DataSource as DataTable).DefaultView.RowFilter = $"name_characteristic LIKE'%{textBoxSearchIsAllCharacteristics.Text}%'";
        }

        private void checkBoxAllCharacteristics_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAllCharacteristics.Checked)
            {

                labelSearch.Visible = true;
                textBoxSearchIsAllCharacteristics.Visible = true;
                tableUpdateChar.Visible = true;
                buttonAddCharacteristicByProduct.Enabled = true;
            }
            else
            {
                buttonAddCharacteristicByProduct.Enabled = false;
                labelSearch.Visible = false;
                textBoxSearchIsAllCharacteristics.Visible = false;
                tableUpdateChar.Visible = false;
            }
        }
        private bool flag = false;
        private void tableUpdateCharacteristics_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (flag)
            {
                return;
            }
         
            var text = tableUpdateCharacteristics.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            ChangesTableCharacteristics[e.RowIndex] = text;
           
        }

        private void textBoxCostProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[ ]|[0-9,.]|[\x08]").Success)
            {
                e.Handled = true;
            }
        }

        private void textBoxNumSection_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]|[\x08]").Success)
            {
                e.Handled = true;
            }
        }

        private void textBoxDiscont_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]|[\x08]").Success)
            {
                e.Handled = true;
            }
        }
    }

}


