using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Actualizar : UserControl
    {
        Vino vinoEncontrado;
        public Actualizar()
        {
            InitializeComponent();
        }
        private void Actualizar_Load(object sender, EventArgs e)
        {
            
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNAceptar_Click(object sender, EventArgs e)
        {
            if (vinoEncontrado != null)
            {
                vinoEncontrado.nombre = TBXNombre.Text;
                vinoEncontrado.precio = decimal.Parse(TBXPrecio.Text);
                vinoEncontrado.gradosAlcohol = decimal.Parse(TBXGradosAlcohol.Text);
                vinoEncontrado.fechaIngrso = DTPFechaIngreso.Value;
                vinoEncontrado.categoriaVino = CBXCategoria.SelectedItem.ToString();
                CRUD.ActualizarVino(vinoEncontrado);
               
            }
            else
            {
                MessageBox.Show("No se ha buscado un vino para actualizar.");
            }
            TBXID.Clear();
            TBXNombre.Clear();
            TBXPrecio.Clear();
            TBXGradosAlcohol.Clear();
            DTPFechaIngreso.Value = DateTime.Now;
            CBXCategoria.SelectedIndex = -1;
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            TBXID.Clear();
            TBXNombre.Clear();
            TBXPrecio.Clear();
            TBXGradosAlcohol.Clear();
            DTPFechaIngreso.Value = DateTime.Now;
            CBXCategoria.SelectedIndex = -1;
            vinoEncontrado = null;
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            int idaBuscar = int.Parse(TBXID.Text);
            vinoEncontrado = CRUD.Obtener(idaBuscar);
            if(vinoEncontrado != null)
            {
                TBXNombre.Text = vinoEncontrado.nombre;
                TBXPrecio.Text = vinoEncontrado.precio.ToString();
                TBXGradosAlcohol.Text = vinoEncontrado.gradosAlcohol.ToString();
                DTPFechaIngreso.Value = vinoEncontrado.fechaIngrso;
                CBXCategoria.SelectedItem = vinoEncontrado.categoriaVino;
            }
            else
            {
                MessageBox.Show("No se encontró un vino con ese ID.");
            }
        }
        private void BTNBuscar_Enter(object sender, EventArgs e)
        {
            BTNBuscar.BackColor = Color.LightGray;
        }
        private void BTNBuscar_Leave(object sender, EventArgs e)
        {
            BTNBuscar.BackColor = Color.FromArgb(252, 249, 216);
        }
        private void BTNAceptar_Enter(object sender, EventArgs e)
        {
            BTNAceptar.BackColor = Color.LightGray;
        }
        private void BTNAceptar_Leave(object sender, EventArgs e)
        {
            BTNAceptar.BackColor = Color.FromArgb(252, 249, 216); ;
        }
        private void BTNCancelar_Enter(object sender, EventArgs e)
        {
            BTNCancelar.BackColor = Color.LightGray;
        }
        private void BTNCancelar_Leave(object sender, EventArgs e)
        {
            BTNCancelar.BackColor = Color.FromArgb(252, 249, 216);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (CBXCategoria.Items.Count == 0)
            {
                CBXCategoria.Items.AddRange(new string[] {
        "Destilado",
        "Fermentado",
        "Aromatico",
        "Fortificado"
    });
                CBXCategoria.SelectedIndex = -1;
            }
        }
    }
}
