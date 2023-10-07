using System;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class ModelPedido
    {
        // Métodos del Modelo que preocesan las consultas de la base de datos 
        public static int InsertData (string IdPedido, string IdProduc, int Cantidad) 
        {
            int retorno = 0;
            try
            {
                SqlCommand RunInsertQuery = new SqlCommand(string.Format("INSERT INTO [dbo].[Pedido] (idpedido, idprod, cantidad) VALUES ('{0}', '{1}', '{2}')", IdPedido, IdProduc, Cantidad), 
                    ConectionModel.Conectar());
                retorno = Convert.ToInt32(RunInsertQuery.ExecuteNonQuery());
                return retorno;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error at: " + ex);
                return 0;
            }
        }

        public static DataTable LoadData () 
        {
            DataTable Data;
            try
            {
                string SelectQuery = "SELECT idpedido AS ID, nombre AS Producto, cantidad FROM[dbo].[Pedido] INNER JOIN[dbo].[Producto] ON[dbo].[Pedido].idprod = [dbo].[Producto].idprod;";
                SqlCommand TblSelect = new SqlCommand(SelectQuery, ConectionModel.Conectar());
                SqlDataAdapter ADP = new SqlDataAdapter(TblSelect);
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

        public static string ShowQuantityItems(string ID)
        {
            string existencias = null;
            try
            {
                string RunQuantityItems = "SELECT existencias AS Existentes FROM [dbo].[Producto] WHERE idprod = @ID;";
                SqlConnection connect = ConectionModel.Conectar();
                SqlCommand RunQuery = new SqlCommand(string.Format(RunQuantityItems), ConectionModel.Conectar());
                RunQuery.Parameters.AddWithValue("@ID", ID);
                SqlDataReader reader = RunQuery.ExecuteReader();

                if (reader.Read())
                {
                    existencias = reader["Existentes"].ToString();
                }
                reader.Close();
                connect.Close();
                return existencias;

            }
            catch (SqlException ErrorSql)
            {
                Console.WriteLine("Error at: " + ErrorSql);
                return null;
            }
            catch (Exception ErrorNormal)
            {
                Console.WriteLine("Error at: " + ErrorNormal);
                return null;
            }
        }
    }
}
