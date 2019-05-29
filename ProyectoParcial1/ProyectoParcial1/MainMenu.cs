using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoParcial1.UI.Consultas;
using ProyectoParcial1.UI.Registros;

namespace ProyectoParcial1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductos registroProductos = new rProductos();
            registroProductos.Show();
        }

        private void VerValorTotalDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cValorInventario VerValorInventario = new cValorInventario();
            VerValorInventario.Show();
        }
    }
}
