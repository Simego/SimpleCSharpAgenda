using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControleDeContatos
{
    class Connection
    {
        public static SQLiteConnection connection = new SQLiteConnection(@"Data Source=..\..\controledecontatos.db; Version=3;");

        public static SQLiteDataReader ExecuteSql(String sql, params SQLiteParameter[] parameters)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand(sql,connection);
                foreach (SQLiteParameter parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
                command.Prepare();
                //MessageBox.Show(command.CommandText);
                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Open()
        {
            connection.Open();
        }
        public static void Close()
        {
            connection.Close();
        }

    }
}
