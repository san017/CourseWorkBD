using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
namespace CourseWorkBD
{
    public static class SQL
    {

        public static MySqlConnection Connection;
        static SQL()
        {
            try
            {
                Connection = new MySqlConnection("server=localhost;port=3306;username=root;password=antdemnb2;database=electr");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Неееееееет");
            }

        }
        public static void Open()
        {
            Connection.Open();
        }

        public static void Close()
        {
            Connection.Close();

        }

        public static DataTable SQLQuery(string nameTable)
        {

            MySqlDataAdapter adapt = new MySqlDataAdapter($"select *from {nameTable} ", SQL.Connection);
            var table = new DataTable();
            adapt.Fill(table);
            return table;
        }
        public static DataTable SQLQueryAdd(string name)
        {

            MySqlDataAdapter adapt = new MySqlDataAdapter($"select name_catalog, name_characteristic from catalog_has_characteristics chc join catalog c on c.idCatalog = chc.catalog_idCatalog join characteristics  ch on ch.idcharacteristics = chc.characteristics_idcharacteristics where c.name_catalog = '{name}'", SQL.Connection);
            var table = new DataTable();
            adapt.Fill(table);
            table.Columns.Add("Значение");
            return table;

        }
        public static DataTable SQLQuerySelect(string query)
        {

            MySqlDataAdapter adapt = new MySqlDataAdapter(query, SQL.Connection);
            var table = new DataTable();
            adapt.Fill(table);
            return table;
        }
        public static DataTable SqlQueryCharacteristics(string nameTable)
        {
            MySqlDataAdapter adapt = new MySqlDataAdapter($" select idCatalog, name_catalog, idcharacteristics,name_characteristic " +
                $"from catalog_has_characteristics chc join catalog c on c.idCatalog = chc.catalog_idCatalog " +
                $"join characteristics  ch on ch.idcharacteristics = chc.characteristics_idcharacteristics " +
                $"where catalog_idCatalog = '{nameTable}'; ", SQL.Connection);
            var table = new DataTable();
            adapt.Fill(table);
            return table;
        }
        public static void DeleteFromTable(DataGridView nameTable, string nameTableIsSql, string id, int j)
        {
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление", "Внимание!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < nameTable.SelectedRows.Count; i++)
                {
                    MySqlCommand delete = new MySqlCommand($"delete from {nameTableIsSql} where {id} = {nameTable.SelectedRows[i].Cells[j].Value.ToString()}", SQL.Connection);
                    try
                    {
                        delete.ExecuteNonQuery().ToString();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Невозможно удалить товар");
                        return;
                    }
                }

            }
            else
            {
                return;
            }
            MySqlCommand auto = new MySqlCommand($"alter table {nameTableIsSql} auto_increment = 0", SQL.Connection);
            auto.ExecuteNonQuery().ToString();
        }
    }
}
