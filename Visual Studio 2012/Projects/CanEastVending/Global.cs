using Microsoft.Data.Schema.ScriptDom;
using Microsoft.Data.Schema.ScriptDom.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

//The global class acts as a module containing global sqlconnection variables and public methods that are used by many other classes in the namespace
namespace CanEastVending
{
    public static class Global
    {

        public static SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\100425724\\Documents\\Visual Studio 2012\\Projects\\CanEastVending\\CanEastVending\\Database.mdf\";Integrated Security=True;Connect Timeout=30");

        public static void openConnection()
        {
            con.Open();
        }

        public static DataTable GetData(string sqlCommand)
        {
            SqlCommand command = new SqlCommand(sqlCommand, Global.con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }
    }
}
