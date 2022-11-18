using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkBD.AddElectronicProduct
{
    public static class Manager
    {

        public static ComboBox ComboBoxPostavka;
        public static ComboBox ComboBoxManufacturer;
        public static ComboBox ComboBoxCatalog;
        public static ComboBox ComboBoxRazdel;
        // public static ComboBox ComboBoxAddCatalogIsTable;
        public static Dictionary<ComboBox, ComboBoxInfo> DictionaryIdTables;
        public static int id;
        public static int idd;

        public static void FillComboBox(ComboBox combobox, string name, int columnPosition)
        {
            var query = $"select *from {name};";
            var adapter = new MySqlDataAdapter(query, SQL.Connection);
            var table = new DataTable();
            adapter.Fill(table);
            combobox.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                combobox.Items.Add(table.Rows[i].ItemArray[columnPosition].ToString());
            }

        }
        public static void InitializeEvent()
        {
            DictionaryIdTables = new Dictionary<ComboBox, ComboBoxInfo>()
            {

                [ComboBoxPostavka] = new ComboBoxInfo("postavka", "Provider_idProvider", "Data_postavki"),
                [ComboBoxManufacturer] = new ComboBoxInfo("all_manufacturer", "id производителя", "Наименнование производителя"),
             
                [ComboBoxCatalog] = new ComboBoxInfo("all_catalog", "id категории", "Название категории"),
                // [ComboBoxAddCatalogIsTable] = new ComboBoxInfo("all_catalog", "id категории", "Название категории"),
                [ComboBoxRazdel] = new ComboBoxInfo("electr.chapter", "idchapter", "name_razdel")
            };
            foreach (var item in DictionaryIdTables)
            {
                item.Key.SelectedIndexChanged += ComboBoxSelectedIndexChanged;
            }
        }
        public static void SetComboBoxCollections()
        {
            FillComboBox(ComboBoxPostavka, "postavka", 1);
            FillComboBox(ComboBoxManufacturer, "all_manufacturer", 1);
         
            FillComboBox(ComboBoxCatalog, "all_catalog", 1);
            FillComboBox(ComboBoxRazdel, "electr.chapter", 1);
        }

        public static void DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var dt = sender as DataGridView;
            dt.ClearSelection();
        }
        //Метод  отмены выделения строки в таблице
        public static void ClearSelections(DataGridView nametable)
        {
            nametable.DataBindingComplete += DataBindingComplete;
        }
        public static void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            string date, dateDay, dateMonth, dateYear;

            var cb = sender as ComboBox;

            string query;
            string query1;
          
            if (cb == ComboBoxPostavka)
            {
                date = cb.SelectedItem.ToString();
                dateDay = date.Substring(0, 2);
                dateMonth = date.Substring(3, 2);
                dateYear = date.Substring(6, 4);
                query1 = $"select idPostavka from postavka where Data_postavki  = '{dateYear}-{dateMonth}-{dateDay}';";
                var command1 = new MySqlCommand(query1, SQL.Connection);
                id = (int)command1.ExecuteScalar();
                if (id != null)
                {
                    DictionaryIdTables[cb].CurrentId = id.ToString();

                }
            }
            else
            {
                query = $"select `{DictionaryIdTables[cb].NameColumnId}` from {DictionaryIdTables[cb].Name} where `{DictionaryIdTables[cb].AlterNameColumn}`  = '{cb.SelectedItem}';";
                var command = new MySqlCommand(query, SQL.Connection);
               idd= (int)command.ExecuteScalar();
            }

            if (idd != null)
            {
                DictionaryIdTables[cb].CurrentId = idd.ToString();

            }
      
        }
        public class ComboBoxInfo
        {
            public ComboBoxInfo(string name, string nameColumnId, string alterNameColumn)
            {
                Name = name;
                NameColumnId = nameColumnId;
                AlterNameColumn = alterNameColumn;
            }

            public string Name { get; set; }
            public string CurrentId { get; set; }
            public string NameColumnId { get; }
            public string AlterNameColumn { get; }
        }
    }
}

