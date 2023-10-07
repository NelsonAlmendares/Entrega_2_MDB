using System;
using Modelo;
using System.Data;

namespace Controlador
{
    public class ControllerPedido
    {
        // Constructor de clases
        public ControllerPedido() { }
        public string IdPedido { get; set; }
        public string IdProd { get; set; }
        public int Cantidad { get; set; }

        // Usamos métodos para retornar datos según el patrón MVC

        public int InsertData() {
            return ModelPedido.InsertData(IdPedido, IdProd, Cantidad);
        }

        public DataTable LoadProducts() {
            return ModelPedido.LoadData();
        }

        public string ShowItems (string IpProd) {
            return ModelPedido.ShowQuantityItems(IpProd);
        }
    }
}
