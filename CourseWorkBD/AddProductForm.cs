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
    public partial class AddProductForm : Form
    {
        public string id;
        public AddProductForm()
        {
            InitializeComponent();
            Manager.ComboBoxPostavka = comboBoxPostavka;
            Manager.ComboBoxManufacturer = ComboBoxManufacturer;
            Manager.ComboBoxRazdel = ComboBoxRazdel;
            Manager.ComboBoxCatalog = ComboBoxCatalog;
            Manager.InitializeEvent();
            Manager.SetComboBoxCollections();


        }
        private void save_Click(object sender, EventArgs e)
        {
            if (textBoxSizeDiscont.Text == "" || Int32.Parse(textBoxSizeDiscont.Text)>100 )
            {
                MessageBox.Show("Неккоректный ввод скидки");
                return;
            }
            //  var idPostavka = Manager.DictionaryIdTables[comboBoxPostavka].CurrentId == null ? "null" : Manager.DictionaryIdTables[comboBoxPostavka].CurrentId;
            MySqlCommand command = new MySqlCommand($"INSERT INTO electr_product (name_product,cost_product,num_section,Postavka_idPostavka," +
                $"Catalog_idCatalog,manufacturer_idmanufacturer,chapter_idchapter,size_discont) " +
            $"VALUE ('{nameProduct.Text }', {costProduct.Text.Replace(",",".")}, '{numSection.Text}','{Manager.id}'," +
            $"'{Manager.DictionaryIdTables[ComboBoxCatalog].CurrentId}','{Manager.DictionaryIdTables[ComboBoxManufacturer].CurrentId}'," +
            $"'{Manager.DictionaryIdTables[ComboBoxRazdel].CurrentId}','{textBoxSizeDiscont.Text}');", SQL.Connection);
            try
            {
                command.ExecuteNonQuery().ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Проверьте ввёденные данные!");
                return;
            }


            for (int i = 0; i < TableCatalogWithCharacteristics.Rows.Count; i++)
            {

                TableCatalogWithCharacteristics.Rows[i].Cells[2].ReadOnly = false;
                MySqlCommand commandSecond = new MySqlCommand($"INSERT value_characteristics value " +
                    $"((select idcharacteristics from characteristics " +
                    $"where name_characteristic = '{TableCatalogWithCharacteristics[1, i].Value.ToString()}'), " +
                    $"(select idElectr_product from electr_product where idElectr_product = last_insert_id()),'{TableCatalogWithCharacteristics[2, i].Value.ToString()}') ", SQL.Connection);
                commandSecond.ExecuteNonQuery().ToString();
            }
            Close();


        }



        private void comboBoxPostavka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxCatalog_SelectedValueChanged(object sender, EventArgs e)
        {
            TableCatalogWithCharacteristics.DataSource = SQL.SQLQueryAdd(ComboBoxCatalog.SelectedItem.ToString());
            TableCatalogWithCharacteristics.Columns[0].Visible = false;
            TableCatalogWithCharacteristics.Columns[1].HeaderCell.Value = "Наименнование характеристики";
            TableCatalogWithCharacteristics.Columns[1].Width = 220;
            TableCatalogWithCharacteristics.Columns[2].Width = 194;
            TableCatalogWithCharacteristics.Columns[2].HeaderCell.Value = "Значение характеристики";

        }



        private void TableCatalogWithCharacteristics_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < TableCatalogWithCharacteristics.Rows.Count; i++)
            {
                TableCatalogWithCharacteristics.Rows[i].ReadOnly = true;
                TableCatalogWithCharacteristics.Rows[i].Cells[2].ReadOnly = false;
            }

        }

        private void costProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();


            if (!Regex.Match(Symbol, @"[ ]|[0-9,.]|[\x08]").Success)
            {
                e.Handled = true;
            }
        }

        private void numSection_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]|[\x08]").Success)
            {
                e.Handled = true;
            }
        }

        private void textBoxSizeDiscont_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[0-9]|[\x08]").Success)
            {
                e.Handled = true;
            }
        }
    }

}
