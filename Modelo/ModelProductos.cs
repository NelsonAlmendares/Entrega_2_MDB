using System;
using System.Data.SqlClient;
using System.Data;

namespace Modelo
{
    public class ModelProductos
    {
        public static int InsertData (string ID, string Nombre, string Description, int Existencias, double Precio, double PrecioV) 
        {
            int retorno = 0;
            try
            {
                SqlCommand RunInserQuery = new SqlCommand(string.Format("INSERT INTO [dbo].[Producto] (idprod, nombre, descripcion, existencias, precio, preciov) VALUES ('{0}', '{1}' ,'{2}' , '{3}', '{4}', '{5}')", ID, Nombre, Description, Existencias, Precio, PrecioV), 
                    ConectionModel.Conectar());
                retorno = Convert.ToInt32(RunInserQuery.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception ex) 
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
                string SelectQuery = "SELECT idprod AS ID, nombre AS Nombre, descripcion AS Descripcción, existencias AS Existentes, precio AS Precio, preciov AS 'Precio de Venta', ganancia AS 'Ganancias:' FROM[dbo].[Producto] WHERE existencias <> 0";
                SqlCommand TblSelect = new SqlCommand(SelectQuery, ConectionModel.Conectar());
                SqlDataAdapter Adapter = new SqlDataAdapter(TblSelect);
                Data = new DataTable();
                Adapter.Fill(Data);
                return Data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at: " + ex);
                return null;
            }
        }

        public static bool UpdateProduct(string Nombre, string Description, int Existencias, double Precio, double PrecioV, string ID)
        {
            bool Retorno = false;
            try
            {
                SqlCommand RunUpdateQuery = new SqlCommand(string.Format("UPDATE [dbo].[Producto] SET nombre = '{0}', descripcion = '{1}', existencias = '{2}', precio = '{3}', preciov = '{4}' WHERE idprod = '{5}' ", Nombre, Description, Existencias, Precio, PrecioV, ID), 
                    ConectionModel.Conectar());
                Retorno = Convert.ToBoolean(RunUpdateQuery.ExecuteNonQuery());
                return Retorno;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error at: " + ex);
                return false;
            }
        }

        public static bool DeleteProduct(string ID) 
        {
            bool Retorno;
            try
            {
                SqlCommand RunDeleteQuery = new SqlCommand(string.Format("DELETE FROM [dbo].[Producto] WHERE idprod = '{0}'", ID), ConectionModel.Conectar());
                Retorno = Convert.ToBoolean(RunDeleteQuery.ExecuteNonQuery());
                return Retorno;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error at: " + ex);
                return false;
            }
        }
    }
}
