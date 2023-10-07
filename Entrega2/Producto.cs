using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Controlador;

namespace Entrega2
{
    public partial class Producto : Form
    {
        // Instancia para actualizar los productos:
        ControllerProductos UpdateProduct = new ControllerProductos();
        // Instancia para agregar los productos:
        ControllerProductos AgregarProducto = new ControllerProductos();
        // Instancia para eliminar los productos:
        ControllerProductos DeleteProducto = new ControllerProductos();

        public Producto()
        {
            InitializeComponent();
            FillDataGridView();
            // this.dataGridViewProd.Columns[0].Visible = false;
            Btn_Eliminar.Enabled = false;
            Btn_Actualizar.Enabled = false;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void FillDataGridView()
        {
            ControllerProductos FillData = new ControllerProductos();
            dataGridViewProd.DataSource = FillData.LoadProducts();
        }


        void InsertData()
        {
            if (Txt_ID.Text == "")
            {
                MessageBox.Show("Campo de ID debe estar lleno", "CAMPOS VACÍOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else if (Txt_Existencia.Text == "") 
            {
                MessageBox.Show("Campo de Existencias debe estar lleno", "CAMPOS VACÍOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Txt_Precio.Text == "")
            {
                MessageBox.Show("Campo de Precio debe estar lleno", "CAMPOS VACÍOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Txt_Descipcion.Text == "")
            {
                MessageBox.Show("Campo de Descripción debe estar lleno", "CAMPOS VACÍOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Precio_V.Text == "")
            {
                MessageBox.Show("Campo de precio de venta debe estar lleno", "CAMPOS VACÍOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AgregarProducto.ID = Txt_ID.Text;
                AgregarProducto.Nombre = Txt_Nombre.Text;
                AgregarProducto.Description = Txt_Descipcion.Text;
                AgregarProducto.Existencias = Convert.ToInt32(Txt_Existencia.Text);
                AgregarProducto.Precio = Convert.ToDouble(Txt_Precio.Text);
                AgregarProducto.PrecioV = Convert.ToDouble(Precio_V.Text);
                int response = AgregarProducto.InsertData();

                if (response >= 1)
                {
                    MessageBox.Show("Productos agregados correctamente", "SOLICITUD APROBADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewProd.DataSource = AgregarProducto.LoadProducts();
                }
                else
                {
                    MessageBox.Show("Productos no pudieron ser Registrados", "SOLICITUD DENEGADA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        void UpdateData()
        {
            UpdateProduct.ID = Txt_ID.Text;
            UpdateProduct.Nombre = Txt_Nombre.Text;
            UpdateProduct.Description = Txt_Descipcion.Text;
            UpdateProduct.Existencias = Convert.ToInt32(Txt_Existencia.Text);
            UpdateProduct.Precio = Convert.ToDouble(Txt_Precio.Text);
            UpdateProduct.PrecioV = Convert.ToDouble(Precio_V.Text);
            bool response = UpdateProduct.UpdateData();
            if (response == true)
            {
                MessageBox.Show("Productos actualizados correctamente", "SOLICITUD APROBADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewProd.DataSource = AgregarProducto.LoadProducts();
                CleanData();
                Btn_Agregar.Enabled = true;
                Btn_Actualizar.Enabled = false;
                Btn_Limpiar.Enabled = true;
                Btn_Eliminar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Productos no puedieron ser actualizados correctamente", "SOLICITUD DENEGADA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        void CleanData () 
        {
            Txt_Descipcion.ResetText();
            Txt_Nombre.ResetText();
            Txt_Existencia.ResetText();
            Txt_ID.ResetText();
            Txt_Precio.ResetText();
            Precio_V.ResetText();
        }

        void DeleteData ()
        {
            if (MessageBox.Show("¿Está seguro de que quiere eliminar el registro?", "BORRAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                DeleteProducto.ID = Txt_ID.Text;
                bool Response = DeleteProducto.DeleteData();
                if (Response == true)
                {
                    MessageBox.Show("Producto eliminado correctamente", "ELIMINACIÓN CORRECTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewProd.DataSource = AgregarProducto.LoadProducts();
                    CleanData();
                    Btn_Agregar.Enabled = true;
                    Btn_Actualizar.Enabled = false;
                    Btn_Limpiar.Enabled = true;
                    Btn_Eliminar.Enabled = false;
                }
                else 
                {
                    MessageBox.Show("Producto no pudo ser eliminado correctamente", "ELIMINACIÓN DENEGADA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void Btn_Conection_Click(object sender, EventArgs e)
        {
            SqlConnection TestConect = new SqlConnection();
            TestConect = ConectionController.ConnectModel();
            if (TestConect != null)
            {
                MessageBox.Show("Conexión con el servidor realizada de manera exitosa", "CONEXIÓN ESTABLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sin conexión, verifique que los servicios del servidior estén activos\n" +
                    "Comuniquese con su Administrador", "CONEXIÓN NO ESTABLECIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            InsertData();
            CleanData();
        }

        private void dataGridViewProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Posicion;
            Posicion = this.dataGridViewProd.CurrentRow.Index;

            Txt_ID.Text = this.dataGridViewProd[0, Posicion].Value.ToString();
            Txt_Nombre.Text = this.dataGridViewProd[1, Posicion].Value.ToString();
            Txt_Descipcion.Text = this.dataGridViewProd[2, Posicion].Value.ToString();
            Txt_Existencia.Text = this.dataGridViewProd[3, Posicion].Value.ToString();
            Txt_Precio.Text = this.dataGridViewProd[4, Posicion].Value.ToString();
            Precio_V.Text = this.dataGridViewProd[5, Posicion].Value.ToString();
            Btn_Eliminar.Enabled = true;
            Btn_Actualizar.Enabled = true;
            Btn_Agregar.Enabled = false;
            Btn_Limpiar.Enabled = false;
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            CleanData();
            Btn_Agregar.Enabled = true;
        }

        private void Btn_Sesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bienvenida login = new Bienvenida();
            login.Show();
        }
    }
}
