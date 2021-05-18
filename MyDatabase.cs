using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Treasurer2
{
    public class MyDatabase
    {

        private MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=mysql1CODE;database=usersdb");
        public MySqlConnection Connection
        {
            get => conn;
            set
            {
                if (conn == value)
                {
                    return;
                }
                conn = value;
            }
        }
        //open connection
        public void openConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        //close connection

        public void closeConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }


        //return connection
        public MySqlConnection getConnection()
        {
            return Connection;
        }

        public DataTable getDataTable(MySqlCommand command)
        {
            command.Connection = getConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            closeConnection();

            return table;
        }
        public void commandExcecuter(MySqlCommand command)
        {
            openConnection();
            command.ExecuteNonQuery();
            closeConnection();
        }
    }
}
