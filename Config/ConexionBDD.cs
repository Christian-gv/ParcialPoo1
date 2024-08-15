using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace ParcialPoo1.Config
{
    internal class ConexionBDD
    {
        private MySqlConnection con = new MySqlConnection("Server=localhost;database=pruebasp1;uid=root;pwd=192837");

        public MySqlConnection AbrirConexion()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }

        public MySqlConnection CerrarConexion()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
    }
}
