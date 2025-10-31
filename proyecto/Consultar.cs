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
    public partial class Consultar : UserControl
    {
        public Consultar()
        {
            InitializeComponent();
            dataGridView1.DataSource = CRUD.ObtenerVinos();
        }
        private void Consultar_Load(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            string nombre = TBXNombre.Text.Trim();
            string categoriaSeleccionada = (CBXCategoria.SelectedIndex < 0 )? null : CBXCategoria.SelectedItem.ToString();
            List<Vino> resultados;

            resultados = CRUD.Obtener(nombre, categoriaSeleccionada);

            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron vinos que coincidan con los criterios de búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.DataSource = resultados;
            dataGridView1.Refresh();

        }

        private void BTNBuscar_MouseEnter(object sender, EventArgs e)
        {
            BTNBuscar.BackColor = Color.FromArgb(237, 235, 201);
        }
        private void BTNBuscar_MouseLeave(object sender, EventArgs e)
        {
            BTNBuscar.BackColor = Color.FromArgb(252, 249, 216);
        }

        private void BTNTodo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CRUD.ObtenerVinos();
            dataGridView1.Refresh();
        }
        private void BTNTodo_MouseEnter(object sender, EventArgs e)
        {
            BTNTodo.BackColor = Color.FromArgb(237, 235, 201);
        }
        private void BTNTodo_MouseLeave(object sender, EventArgs e)
        {
            BTNTodo.BackColor = Color.FromArgb(252, 249, 216);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
