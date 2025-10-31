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
    public partial class Eliminar : UserControl
    {
        public Eliminar()
        {
            InitializeComponent();
            dataGridView1.DataSource = CRUD.ObtenerVinos();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            try
            {
                CRUD.EliminarVino(id);
                dataGridView1.Refresh();
                MessageBox.Show("Vino eliminado correctamente.", "Eliminar Vino", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("No se encontró un vino con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
    }
