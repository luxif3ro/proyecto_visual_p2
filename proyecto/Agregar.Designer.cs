namespace proyecto
{
    partial class Agregar
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
            this.CBXCategoria = new System.Windows.Forms.ComboBox();
            this.DTPFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBXNombre = new System.Windows.Forms.TextBox();
            this.TBXID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBXPrecio = new System.Windows.Forms.TextBox();
            this.TBXGradosAlcohol = new System.Windows.Forms.TextBox();
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 501);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1023, 64);
            this.flowLayoutPanel1.TabIndex = 6;
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
            this.BTNAceptar.MouseEnter += new System.EventHandler(this.BTNAceptae_MouseEnter);
            this.BTNAceptar.MouseLeave += new System.EventHandler(this.BTNAceptar_MouseLeave);
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
            this.BTNCancelar.MouseEnter += new System.EventHandler(this.BTNCancelar_MouseEnter);
            this.BTNCancelar.MouseLeave += new System.EventHandler(this.BTNCancelar_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.39286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.60714F));
            this.tableLayoutPanel1.Controls.Add(this.CBXCategoria, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DTPFechaIngreso, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBXNombre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBXID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TBXPrecio, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TBXGradosAlcohol, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(173, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 398);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // CBXCategoria
            // 
            this.CBXCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBXCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXCategoria.FormattingEnabled = true;
            this.CBXCategoria.Location = new System.Drawing.Point(212, 201);
            this.CBXCategoria.Name = "CBXCategoria";
            this.CBXCategoria.Size = new System.Drawing.Size(412, 39);
            this.CBXCategoria.TabIndex = 7;
            // 
            // DTPFechaIngreso
            // 
            this.DTPFechaIngreso.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTPFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFechaIngreso.Location = new System.Drawing.Point(212, 333);
            this.DTPFechaIngreso.Name = "DTPFechaIngreso";
            this.DTPFechaIngreso.Size = new System.Drawing.Size(412, 38);
            this.DTPFechaIngreso.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 66);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TBXNombre
            // 
            this.TBXNombre.BackColor = System.Drawing.SystemColors.Window;
            this.TBXNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBXNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXNombre.Location = new System.Drawing.Point(212, 69);
            this.TBXNombre.Name = "TBXNombre";
            this.TBXNombre.Size = new System.Drawing.Size(412, 38);
            this.TBXNombre.TabIndex = 4;
            // 
            // TBXID
            // 
            this.TBXID.BackColor = System.Drawing.SystemColors.Window;
            this.TBXID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBXID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXID.Location = new System.Drawing.Point(212, 3);
            this.TBXID.Name = "TBXID";
            this.TBXID.Size = new System.Drawing.Size(412, 38);
            this.TBXID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 66);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pecio:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 66);
            this.label5.TabIndex = 6;
            this.label5.Text = "Categoria:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 66);
            this.label6.TabIndex = 7;
            this.label6.Text = "Grado:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 68);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha Ingreso:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TBXPrecio
            // 
            this.TBXPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBXPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXPrecio.Location = new System.Drawing.Point(212, 135);
            this.TBXPrecio.Name = "TBXPrecio";
            this.TBXPrecio.Size = new System.Drawing.Size(412, 38);
            this.TBXPrecio.TabIndex = 9;
            // 
            // TBXGradosAlcohol
            // 
            this.TBXGradosAlcohol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBXGradosAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXGradosAlcohol.Location = new System.Drawing.Point(212, 267);
            this.TBXGradosAlcohol.Name = "TBXGradosAlcohol";
            this.TBXGradosAlcohol.Size = new System.Drawing.Size(412, 38);
            this.TBXGradosAlcohol.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agregar Vino ";
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Agregar";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBXID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBXNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBXPrecio;
        private System.Windows.Forms.TextBox TBXGradosAlcohol;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTNAceptar;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.DateTimePicker DTPFechaIngreso;
        private System.Windows.Forms.ComboBox CBXCategoria;
    }
}
