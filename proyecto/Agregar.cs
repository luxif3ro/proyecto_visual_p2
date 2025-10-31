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
    public partial class Agregar : UserControl
    {
        public Agregar()
        {
            InitializeComponent();
        }
        private void BTNAceptae_MouseEnter(object sender, EventArgs e)
        {
            BTNAceptar.BackColor = Color.FromArgb(237, 235, 201);
        }
        private void BTNAceptar_MouseLeave(object sender, EventArgs e)
        {
            BTNAceptar.BackColor = Color.FromArgb(252, 249, 216);
        }
        private void BTNAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TBXID.Text);
                string nombre = TBXNombre.Text;
                decimal precio = decimal.Parse(TBXPrecio.Text);
                decimal gradosAlcohol = decimal.Parse(TBXGradosAlcohol.Text);
                DateTime fechaIngreso = DTPFechaIngreso.Value;
                string categoriaVino = CBXCategoria.SelectedItem.ToString();
                Console.WriteLine(fechaIngreso);
                Vino nuevoVino = new Vino(id, nombre, precio, gradosAlcohol, fechaIngreso, categoriaVino);
                CRUD.RegistrarVino(nuevoVino);
                // Limpiar los campos después de agregar
                TBXID.Clear();
                TBXNombre.Clear();
                TBXPrecio.Clear();
                TBXGradosAlcohol.Clear();
                DTPFechaIngreso.Value = DateTime.Now;
                CBXCategoria.SelectedIndex = -1;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese datos válidos en todos los campos.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
        private void BTNCancelar_MouseEnter(object sender, EventArgs e)
        {
            BTNCancelar.BackColor = Color.FromArgb(237, 235, 201);
        }
        private void BTNCancelar_MouseLeave(object sender, EventArgs e)
        {
            BTNCancelar.BackColor = Color.FromArgb(252, 249, 216);
        }
        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            TBXID.Clear();
            TBXNombre.Clear();
            TBXPrecio.Clear();
            TBXGradosAlcohol.Clear();
            DTPFechaIngreso.Value = DateTime.Now;
            CBXCategoria.SelectedIndex = -1;
            MessageBox.Show("Operación cancelada.");
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
