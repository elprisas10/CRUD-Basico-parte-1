using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUDProject
{
    class Crud
    {
        //instancia de la clase connection
        private Connection conn = new Connection();

        //metodo para seleccionar los registros de la tabla de la base de datos
        public MySqlDataReader select(string query)
        {
            MySqlDataReader dataReader;

            //utilizar command de la clase connection
            conn.command = new MySqlCommand(query, conn.openConnection()); //prepara la consulta
            dataReader = conn.command.ExecuteReader(); //ejecuta la consulta
            return dataReader;
        }

        public void executeQuery(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            conn.command = new MySqlCommand(query, conn.openConnection());
            adapter.InsertCommand = conn.command;
            adapter.InsertCommand.ExecuteNonQuery();
            conn.command.Dispose();
            conn.closeConnection();
        }
    }
}
