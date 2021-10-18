using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CRUDProject
{
    class Connection
    {
        //propiedades
        private MySqlConnection conn =
            new MySqlConnection( "Server=LocalHost;Database=smis017821;Uid=root;" +
                "pwd=usbw;SSL Mode=None");
        public MySqlCommand command;

        //abrir la conexion
        public MySqlConnection openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public MySqlConnection closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }


    }
}
