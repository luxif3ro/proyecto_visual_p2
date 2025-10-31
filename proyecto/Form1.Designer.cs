namespace proyecto
{
    partial class HomeScreen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNConsultar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.BTNMenu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.BTNSalir);
            this.panel1.Controls.Add(this.BTNConsultar);
            this.panel1.Controls.Add(this.BTNEliminar);
            this.panel1.Controls.Add(this.BTNActualizar);
            this.panel1.Controls.Add(this.BTNAgregar);
            this.panel1.Controls.Add(this.BTNMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 565);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(60, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1023, 565);
            this.panel2.TabIndex = 2;
            // 
            // BTNSalir
            // 
            this.BTNSalir.BackColor = System.Drawing.Color.Transparent;
            this.BTNSalir.FlatAppearance.BorderSize = 0;
            this.BTNSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSalir.Image = global::proyecto.Properties.Resources.salida;
            this.BTNSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSalir.Location = new System.Drawing.Point(12, 348);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(40, 40);
            this.BTNSalir.TabIndex = 5;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNSalir.UseVisualStyleBackColor = false;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            this.BTNSalir.MouseEnter += new System.EventHandler(this.BTNSalir_MouseEnter);
            this.BTNSalir.MouseLeave += new System.EventHandler(this.BTNSalir_MouseLeave);
            // 
            // BTNConsultar
            // 
            this.BTNConsultar.BackColor = System.Drawing.Color.Transparent;
            this.BTNConsultar.FlatAppearance.BorderSize = 0;
            this.BTNConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNConsultar.Image = global::proyecto.Properties.Resources.busqueda;
            this.BTNConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNConsultar.Location = new System.Drawing.Point(12, 278);
            this.BTNConsultar.Name = "BTNConsultar";
            this.BTNConsultar.Size = new System.Drawing.Size(40, 40);
            this.BTNConsultar.TabIndex = 4;
            this.BTNConsultar.Text = "Consultar";
            this.BTNConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNConsultar.UseVisualStyleBackColor = false;
            this.BTNConsultar.Click += new System.EventHandler(this.BTNConsultar_Click);
            this.BTNConsultar.MouseEnter += new System.EventHandler(this.BTNConsultar_MouseEnter);
            this.BTNConsultar.MouseLeave += new System.EventHandler(this.BTNConsultar_MouseLeave);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BTNEliminar.FlatAppearance.BorderSize = 0;
            this.BTNEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEliminar.Image = global::proyecto.Properties.Resources.basura;
            this.BTNEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNEliminar.Location = new System.Drawing.Point(12, 210);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(40, 40);
            this.BTNEliminar.TabIndex = 3;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNEliminar.UseVisualStyleBackColor = false;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            this.BTNEliminar.MouseEnter += new System.EventHandler(this.BTNEliminar_MouseEnter);
            this.BTNEliminar.MouseLeave += new System.EventHandler(this.BTNEliminar_MouseLeave);
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.BackColor = System.Drawing.Color.Transparent;
            this.BTNActualizar.FlatAppearance.BorderSize = 0;
            this.BTNActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNActualizar.Image = global::proyecto.Properties.Resources.actualizar;
            this.BTNActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNActualizar.Location = new System.Drawing.Point(13, 146);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(40, 40);
            this.BTNActualizar.TabIndex = 2;
            this.BTNActualizar.Text = "Actualizar";
            this.BTNActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNActualizar.UseVisualStyleBackColor = false;
            this.BTNActualizar.Click += new System.EventHandler(this.BTNActualizar_Click);
            this.BTNActualizar.MouseEnter += new System.EventHandler(this.BTNActualizar_MouseEnter);
            this.BTNActualizar.MouseLeave += new System.EventHandler(this.BTNActualizar_MouseLeave);
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BTNAgregar.FlatAppearance.BorderSize = 0;
            this.BTNAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAgregar.Image = global::proyecto.Properties.Resources.mas2;
            this.BTNAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNAgregar.Location = new System.Drawing.Point(12, 78);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(40, 40);
            this.BTNAgregar.TabIndex = 1;
            this.BTNAgregar.Text = "Agregar";
            this.BTNAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNAgregar.UseVisualStyleBackColor = false;
            this.BTNAgregar.Click += new System.EventHandler(this.BTNAgregar_Click);
            this.BTNAgregar.MouseEnter += new System.EventHandler(this.BTNAgregar_MouseEnter);
            this.BTNAgregar.MouseLeave += new System.EventHandler(this.BTNAgregar_MouseLeave);
            // 
            // BTNMenu
            // 
            this.BTNMenu.BackColor = System.Drawing.Color.Transparent;
            this.BTNMenu.FlatAppearance.BorderSize = 0;
            this.BTNMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMenu.Image = global::proyecto.Properties.Resources.menu_hamburguesa1;
            this.BTNMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMenu.Location = new System.Drawing.Point(13, 13);
            this.BTNMenu.Name = "BTNMenu";
            this.BTNMenu.Size = new System.Drawing.Size(40, 40);
            this.BTNMenu.TabIndex = 0;
            this.BTNMenu.Text = "Menu";
            this.BTNMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNMenu.UseVisualStyleBackColor = false;
            this.BTNMenu.Click += new System.EventHandler(this.BTNMenu_Click);
            this.BTNMenu.MouseEnter += new System.EventHandler(this.BTNMenu_MouseEnter);
            this.BTNMenu.MouseLeave += new System.EventHandler(this.BTNMenu_MouseLeave);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 565);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTNMenu;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNConsultar;
        private System.Windows.Forms.Button BTNSalir;
    }
}

