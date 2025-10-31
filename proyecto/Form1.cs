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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            MostrarControl(new Agregar());

            panel1.Width = 60;
            if (panel1.Width == 200)
            {
                BTNMenu.Text = "Menú";
                BTNAgregar.Text = "Agregar";
                BTNActualizar.Text = "Actualizar";
                BTNEliminar.Text = "Eliminar";
                BTNConsultar.Text = "Consultar";
                BTNSalir.Text = "Salir";
            }
            else
            {
                BTNMenu.Text = "";
                BTNAgregar.Text = "";
                BTNActualizar.Text = "";
                BTNEliminar.Text = "";
                BTNConsultar.Text = "";
                BTNSalir.Text = "";
            }
        }

        private void BTNMenu_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 200)
            {
                panel1.Width = 60;

                BTNMenu.Text = "";
                BTNMenu.Size = new Size(40, 40);

                BTNAgregar.Text = "";
                BTNAgregar.Size = new Size(40, 40);

                BTNActualizar.Text = "";
                BTNActualizar.Size = new Size(40, 40);

                BTNEliminar.Text = "";
                BTNEliminar.Size = new Size(40, 40);

                BTNConsultar.Text = "";
                BTNConsultar.Size = new Size(40, 40);

                BTNSalir.Text = "";
                BTNSalir.Size = new Size(40, 40);
            }
            else
            {
                panel1.Width = 200;

                BTNMenu.Text = "Menú";
                BTNMenu.Size = new Size(100, 40);
                
                BTNAgregar.Text = "Agregar";
                BTNAgregar.Size = new Size(100, 40);

                BTNActualizar.Text = "Actualizar";
                BTNActualizar.Size = new Size(100, 40);

                BTNEliminar.Text = "Eliminar";
                BTNEliminar.Size = new Size(100, 40);

                BTNConsultar.Text = "Consultar";
                BTNConsultar.Size = new Size(100, 40);

                BTNSalir.Text = "Salir";
                BTNSalir.Size = new Size(100, 40);
            }
        }

        private void BTNMenu_MouseEnter(object sender, EventArgs e)
        {
            BTNMenu.BackColor = Color.FromArgb(9, 166, 163);
        }

        private void BTNMenu_MouseLeave(object sender, EventArgs e)
        {
            BTNMenu.BackColor = Color.Transparent;
        }

        private void BTNAgregar_MouseEnter(object sender, EventArgs e)
        {
            BTNAgregar.BackColor = Color.FromArgb(9, 166, 163);
        }
        private void BTNAgregar_MouseLeave(object sender, EventArgs e)
        {
            BTNAgregar.BackColor = Color.Transparent;
        }

        private void BTNActualizar_MouseEnter(object sender, EventArgs e)
        {
            BTNActualizar.BackColor = Color.FromArgb(9, 166, 163);
        }
        private void BTNActualizar_MouseLeave(object sender, EventArgs e)
        {
            BTNActualizar.BackColor = Color.Transparent;
        }
        private void BTNEliminar_MouseEnter(object sender, EventArgs e)
        {
            BTNEliminar.BackColor = Color.FromArgb(9, 166, 163);
        }
        private void BTNEliminar_MouseLeave(object sender, EventArgs e)
        {
            BTNEliminar.BackColor = Color.Transparent;
        }
        private void BTNConsultar_MouseEnter(object sender, EventArgs e)
        {
            BTNConsultar.BackColor = Color.FromArgb(9, 166, 163);
        }
        private void BTNConsultar_MouseLeave(object sender, EventArgs e)
        {
            BTNConsultar.BackColor = Color.Transparent;
        }
        private void BTNSalir_MouseEnter(object sender, EventArgs e)
        {
            BTNSalir.BackColor = Color.FromArgb(9, 166, 163);
        }
        private void BTNSalir_MouseLeave(object sender, EventArgs e)
        {
            BTNSalir.BackColor = Color.Transparent;
        }
        private void BTNSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MostrarControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(control);
            control.BringToFront();
        }
        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            MostrarControl(new Agregar());
        }

        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            MostrarControl(new Actualizar());
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            MostrarControl(new Eliminar());
        }

        private void BTNConsultar_Click(object sender, EventArgs e)
        {
            MostrarControl(new Consultar());
        }
    }
}
