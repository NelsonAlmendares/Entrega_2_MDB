using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class DataModelo
    {
        public static DataTable LoadNames() 
        {
            DataTable Data;
            try
            {
                string RunTypeQuery = "SELECT * FROM [dbo].[Producto]";
                SqlCommand CmbSelect = new SqlCommand(string.Format(RunTypeQuery), ConectionModel.Conectar());
                SqlDataAdapter ADP = new SqlDataAdapter(CmbSelect);
                Data = new DataTable();
                ADP.Fill(Data);
                return Data;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error at: " + ex);
                return null;
            }
        }
    }
}
