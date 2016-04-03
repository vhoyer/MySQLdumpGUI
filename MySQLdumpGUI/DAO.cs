using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace MySQLdumpGUI
{
    public class DAO
    {
        DataTable table;
        MySqlCommandBuilder cmdBuilder;
        MySqlDataAdapter adapter;

        public DataTable loadTable(string cmd)
        {
            table = new DataTable();
            adapter = new MySqlDataAdapter(cmd, Connection.Connect);
            cmdBuilder = new MySqlCommandBuilder(adapter);
            adapter.Fill(table);
            return table;
        }
    }
}