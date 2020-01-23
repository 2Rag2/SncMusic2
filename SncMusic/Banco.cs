using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SncMusic
{
    public static class Banco
    { 
        static MySqlConnection cn;
        public static MySqlCommand Abrir()
        {
            MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.StrConn);
            cn.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = cn;
            return comm;
        }
        public static void Fechar()
        { // se o estado da conexão for igual a aberto então fechar conexão
            if (cn.State == System.Data.ConnectionState.Open)
            
                cn.Close();
            
        }
    }

}
