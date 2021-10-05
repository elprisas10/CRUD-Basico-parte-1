using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUDProject
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //pruba de conexiona base de datos
            string connectionString = "";
            MySqlConnection conn;

            try
            {
                connectionString = @"Server=localhost;Database=smis017821;Uid=root;
                                      pwd=usbw; SSL Mode=None";
                conn = new MySqlConnection(connectionString);
                MetroFramework.MetroMessageBox.Show(this, "Se ha establecido la conexion!",
                    "Conexion Existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    
            }

            catch(Exception Ex)
            {
                MetroFramework.MetroMessageBox.Show(this,Ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
