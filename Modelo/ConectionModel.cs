using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Modelo
{
    public class ConectionModel
    {
        public static SqlConnection Conectar ()
        {
            SqlConnection Connect;

            try
            {
                string server, database, uid, pwd;
                server = "DESKTOP-SUBCSB2";
                database = "Bodega";
                uid = "NelsonAlmendares";
                pwd = "admin";

                string ConnectionSql = "Data Source=" + server + ";" + "Initial Catalog=" + database + ";" + "User ID=" + uid + ";" + "Password=" + pwd + ";";
                Connect = new SqlConnection(ConnectionSql);
                Connect.Open();
                return Connect;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at:" +  ex);
                return null;
            }
        }
    }
}
