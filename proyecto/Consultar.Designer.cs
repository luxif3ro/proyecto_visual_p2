namespace proyecto
{
    partial class Consultar
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
            this.BTNTodo = new System.Windows.Forms.Button();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CBXCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBXNombre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(249)))), ((int)(((byte)(216)))));
            this.panel1.Controls.Add(this.BTNTodo);
            this.panel1.Controls.Add(this.BTNBuscar);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 565);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BTNTodo
            // 
            this.BTNTodo.FlatAppearance.BorderSize = 0;
            this.BTNTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNTodo.Image = global::proyecto.Properties.Resources.busqueda;
            this.BTNTodo.Location = new System.Drawing.Point(245, 233);
            this.BTNTodo.Name = "BTNTodo";
            this.BTNTodo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BTNTodo.Size = new System.Drawing.Size(165, 41);
            this.BTNTodo.TabIndex = 11;
            this.BTNTodo.Text = "Todo";
            this.BTNTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTNTodo.UseVisualStyleBackColor = true;
            this.BTNTodo.Click += new System.EventHandler(this.BTNTodo_Click);
            this.BTNTodo.MouseEnter += new System.EventHandler(this.BTNTodo_MouseEnter);
            this.BTNTodo.MouseLeave += new System.EventHandler(this.BTNTodo_MouseLeave);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.FlatAppearance.BorderSize = 0;
            this.BTNBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBuscar.Image = global::proyecto.Properties.Resources.busqueda;
            this.BTNBuscar.Location = new System.Drawing.Point(416, 233);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(165, 41);
            this.BTNBuscar.TabIndex = 10;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            this.BTNBuscar.MouseEnter += new System.EventHandler(this.BTNBuscar_MouseEnter);
            this.BTNBuscar.MouseLeave += new System.EventHandler(this.BTNBuscar_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CBXCategoria, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBXNombre, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(153, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 134);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 67);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CBXCategoria
            // 
            this.CBXCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBXCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXCategoria.FormattingEnabled = true;
            this.CBXCategoria.Location = new System.Drawing.Point(218, 70);
            this.CBXCategoria.Name = "CBXCategoria";
            this.CBXCategoria.Size = new System.Drawing.Size(210, 39);
            this.CBXCategoria.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 67);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TBXNombre
            // 
            this.TBXNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBXNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXNombre.Location = new System.Drawing.Point(218, 3);
            this.TBXNombre.Name = "TBXNombre";
            this.TBXNombre.Size = new System.Drawing.Size(210, 38);
            this.TBXNombre.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 261);
            this.dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consultar Vino ";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Consultar";
            this.Size = new System.Drawing.Size(1023, 565);
            this.Load += new System.EventHandler(this.Consultar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CBXCategoria;
        private System.Windows.Forms.TextBox TBXNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.Button BTNTodo;
    }
}
