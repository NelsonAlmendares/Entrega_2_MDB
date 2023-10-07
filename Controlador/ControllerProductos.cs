using System;
using Modelo;
using System.Data;

namespace Controlador
{
    public class ControllerProductos
    {
        // Defino el constructor
        public ControllerProductos () { }

        // Métodos de acceso y asignación de las variblas por patrón arquitectonico
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public int Existencias { get; set; }
        public double Precio { get; set; }
        public double PrecioV { get; set; }

        public int InsertData () 
        {
            return ModelProductos.InsertData(ID, Nombre, Description, Existencias, Precio, PrecioV);
        }

        public DataTable LoadProducts () 
        {
            return ModelProductos.LoadData();
        }

        public bool UpdateData () 
        {
            return ModelProductos.UpdateProduct(Nombre, Description, Existencias, Precio, PrecioV, ID);
        }

        public bool DeleteData()
        {
            return ModelProductos.DeleteProduct(ID);
        }
    }
}
