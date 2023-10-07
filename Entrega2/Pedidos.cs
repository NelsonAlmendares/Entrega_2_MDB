using System;
using System.Windows.Forms;
using Controlador;

namespace Entrega2
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        // Instancia para acceder al metodo para ingresar los datos
        ControllerPedido InsertData = new ControllerPedido();

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Regresar a la Bienvenida para realizar otras acciones como registrar productos
        private void Btn_Sesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bienvenida login = new Bienvenida();
            login.Show();

        }

        // Llenamos el combobox con los datos que se obtienen por medio del nombre en el Modelo
        void FillNames() {
            CmbNames.DataSource = DataController.LoadNames();
            CmbNames.DisplayMember = ("nombre");
            CmbNames.ValueMember = ("idprod");
        }

        // Llenamos el Grid de datos por medio del método que retorna el Modelo sin parámetros
        void LoadData() {
            ControllerPedido LoadData = new ControllerPedido();
            DataPedidos.DataSource = LoadData.LoadProducts();
        }

        // Mostramos en un campo de texto por medio de un parámetro la cantidad de los productos en la tabla
        void ShowItems (string selectedName) {
            ControllerPedido items = new ControllerPedido();
            string itemSelected = items.ShowItems(selectedName);
            TxtExistencias.Text = itemSelected;
        }

        void CleanData() {
            Txt_ID.ResetText();
            TxtCantidad.ResetText();
        }

        void InsertDatos() {
            // Validaciones de cantidad de los campos para no sobrepasar los límites de ingreso
            int Existencias = Convert.ToInt32(TxtExistencias.Text);
            int Cantidad = Convert.ToInt32(TxtCantidad.Text);

            if (TxtCantidad.Text == "")
            {
                MessageBox.Show("Campo de Cantidad debe estar lleno", "CAMPOS VACÍOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Cantidad >= Existencias)
            {
                MessageBox.Show("La cantidad Ingresada supera la cantidad de producto en Existencias", "CANTIDAD FUERA DE RANGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Cantidad <= 0) 
            {
                MessageBox.Show("La cantidad Ingresada no puede ser igual o menor que 0", "CANTIDAD FUERA DE RANGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InsertData.IdProd = CmbNames.SelectedValue.ToString();
                InsertData.IdPedido = Txt_ID.Text;
                InsertData.Cantidad = Convert.ToInt32(TxtCantidad.Text);
                // Definimos una variable que sirve como identificador de datos, y lo evaluamos según el retorno
                int response = InsertData.InsertData();
                // Si es mayor a 0 la insercción fue correcta, de lo contrario F
                if (response >= 1)
                {
                    MessageBox.Show("Pedido realizado correctamente", "SOLICITUD APROBADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataPedidos.DataSource = InsertData.LoadProducts();
                    CleanData();
                    FillNames();
                }
                else
                {
                    MessageBox.Show("Pedido no pudo ser registrado", "SOLICITUD DENEGADA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            InsertDatos();
        }

        // Evento que captura el cambio del item selecionado y asigna el nuevo contenido de los productos existentes
        private void CmbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedIndex = CmbNames.SelectedValue.ToString();
            ShowItems(selectedIndex);
        }

        // Método load para ejecutar desde el inicio el llenado de los datos de los ComboBox y los Grids
        private void Pedidos_Load(object sender, EventArgs e)
        {
            FillNames();
            LoadData();
            CmbNames.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
