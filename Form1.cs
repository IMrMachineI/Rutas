using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rutas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ruta nuevaRuta = new Ruta();
        Base nuevaBase;
        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = nuevaRuta.reporte();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevaBase = new Base(txtNombreDeBase.Text, Convert.ToInt32(txtTiempoEnLlegar.Text));
            nuevaRuta.agregarBase(nuevaBase);
        }

        private void btnAgregarInicio_Click(object sender, EventArgs e)
        {
            nuevaBase = new Base(txtNombreDeBase.Text, Convert.ToInt32(txtTiempoEnLlegar.Text));
            nuevaRuta.agregarInicio(nuevaBase);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
