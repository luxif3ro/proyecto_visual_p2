namespace proyecto
{
    partial class Actualizar
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTNAceptar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Nombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBXNombre = new System.Windows.Forms.TextBox();
            this.CBXCategoria = new System.Windows.Forms.ComboBox();
            this.TBXPrecio = new System.Windows.Forms.TextBox();
            this.TBXGradosAlcohol = new System.Windows.Forms.TextBox();
            this.DTPFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.TBXID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.BTNBuscar);
            this.panel1.Controls.Add(this.TBXID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 565);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BTNAceptar);
            this.flowLayoutPanel1.Controls.Add(this.BTNCancelar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 501);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1023, 64);
            this.flowLayoutPanel1.TabIndex = 13;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // BTNAceptar
            // 
            this.BTNAceptar.FlatAppearance.BorderSize = 0;
            this.BTNAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAceptar.Image = global::proyecto.Properties.Resources.controlar;
            this.BTNAceptar.Location = new System.Drawing.Point(825, 3);
            this.BTNAceptar.Name = "BTNAceptar";
            this.BTNAceptar.Size = new System.Drawing.Size(195, 43);
            this.BTNAceptar.TabIndex = 0;
            this.BTNAceptar.Text = "Aceptar";
            this.BTNAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNAceptar.UseVisualStyleBackColor = true;
            this.BTNAceptar.Click += new System.EventHandler(this.BTNAceptar_Click);
            this.BTNAceptar.MouseEnter += new System.EventHandler(this.BTNAceptar_Enter);
            this.BTNAceptar.MouseLeave += new System.EventHandler(this.BTNAceptar_Leave);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.FlatAppearance.BorderSize = 0;
            this.BTNCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCancelar.Image = global::proyecto.Properties.Resources.cruz;
            this.BTNCancelar.Location = new System.Drawing.Point(624, 3);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(195, 43);
            this.BTNCancelar.TabIndex = 1;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            this.BTNCancelar.MouseEnter += new System.EventHandler(this.BTNCancelar_Enter);
            this.BTNCancelar.MouseLeave += new System.EventHandler(this.BTNCancelar_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Nombre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TBXNombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CBXCategoria, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBXPrecio, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TBXGradosAlcohol, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DTPFechaIngreso, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(305, 142);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(423, 307);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(3, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(205, 61);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre:";
            this.Nombre.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 61);
            this.label4.TabIndex = 1;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 61);
            this.label5.TabIndex = 2;
            this.label5.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 61);
            this.label6.TabIndex = 3;
            this.label6.Text = "Grado alcohol:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 63);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fecha Ingreso:";
            // 
            // TBXNombre
            // 
            this.TBXNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBXNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXNombre.Location = new System.Drawing.Point(214, 3);
            this.TBXNombre.Name = "TBXNombre";
            this.TBXNombre.Size = new System.Drawing.Size(206, 38);
            this.TBXNombre.TabIndex = 5;
            // 
            // CBXCategoria
            // 
            this.CBXCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBXCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXCategoria.FormattingEnabled = true;
            this.CBXCategoria.Location = new System.Drawing.Point(214, 64);
            this.CBXCategoria.Name = "CBXCategoria";
            this.CBXCategoria.Size = new System.Drawing.Size(206, 39);
            this.CBXCategoria.TabIndex = 6;
            // 
            // TBXPrecio
            // 
            this.TBXPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBXPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXPrecio.Location = new System.Drawing.Point(214, 125);
            this.TBXPrecio.Name = "TBXPrecio";
            this.TBXPrecio.Size = new System.Drawing.Size(206, 38);
            this.TBXPrecio.TabIndex = 7;
            // 
            // TBXGradosAlcohol
            // 
            this.TBXGradosAlcohol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBXGradosAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXGradosAlcohol.Location = new System.Drawing.Point(214, 186);
            this.TBXGradosAlcohol.Name = "TBXGradosAlcohol";
            this.TBXGradosAlcohol.Size = new System.Drawing.Size(206, 38);
            this.TBXGradosAlcohol.TabIndex = 8;
            // 
            // DTPFechaIngreso
            // 
            this.DTPFechaIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTPFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaIngreso.Location = new System.Drawing.Point(214, 247);
            this.DTPFechaIngreso.Name = "DTPFechaIngreso";
            this.DTPFechaIngreso.Size = new System.Drawing.Size(206, 38);
            this.DTPFechaIngreso.TabIndex = 9;
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.FlatAppearance.BorderSize = 0;
            this.BTNBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBuscar.Image = global::proyecto.Properties.Resources.busqueda;
            this.BTNBuscar.Location = new System.Drawing.Point(626, 78);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(55, 38);
            this.BTNBuscar.TabIndex = 6;
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            this.BTNBuscar.MouseEnter += new System.EventHandler(this.BTNBuscar_Enter);
            this.BTNBuscar.MouseLeave += new System.EventHandler(this.BTNBuscar_Leave);
            // 
            // TBXID
            // 
            this.TBXID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXID.Location = new System.Drawing.Point(487, 76);
            this.TBXID.Name = "TBXID";
            this.TBXID.Size = new System.Drawing.Size(133, 38);
            this.TBXID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID a Buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Actualizar Vino ";
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Actualizar";
            this.Size = new System.Drawing.Size(1023, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.TextBox TBXID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBXNombre;
        private System.Windows.Forms.ComboBox CBXCategoria;
        private System.Windows.Forms.TextBox TBXPrecio;
        private System.Windows.Forms.TextBox TBXGradosAlcohol;
        private System.Windows.Forms.DateTimePicker DTPFechaIngreso;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTNAceptar;
        private System.Windows.Forms.Button BTNCancelar;
    }
}
