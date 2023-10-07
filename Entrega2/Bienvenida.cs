using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega2
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Productos_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            this.Hide();
            prod.Show();
        }

        private void Btn_Pedidos_Click(object sender, EventArgs e)
        {
            Pedidos ped = new Pedidos();
            this.Hide();
            ped.Show();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) {
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
