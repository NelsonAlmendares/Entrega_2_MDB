
namespace Entrega2
{
    partial class Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Precio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Descipcion = new System.Windows.Forms.RichTextBox();
            this.Precio_V = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Existencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Sesion = new System.Windows.Forms.Button();
            this.Btn_Conection = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.dataGridViewProd = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 46);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Image = global::Vista.Properties.Resources.cerrar;
            this.Btn_Exit.Location = new System.Drawing.Point(1387, 0);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(43, 46);
            this.Btn_Exit.TabIndex = 1;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Productos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.Txt_Nombre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Txt_Precio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Txt_ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Descipcion);
            this.groupBox1.Controls.Add(this.Precio_V);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_Existencia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1336, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información productos";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Txt_Nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(482, 83);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(369, 26);
            this.Txt_Nombre.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(478, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nombre";
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Txt_Precio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Precio.Location = new System.Drawing.Point(482, 166);
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.Size = new System.Drawing.Size(369, 26);
            this.Txt_Precio.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(924, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precio de Venta $";
            // 
            // Txt_ID
            // 
            this.Txt_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Txt_ID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ID.Location = new System.Drawing.Point(34, 83);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(369, 26);
            this.Txt_ID.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID del Prodcuto";
            // 
            // Txt_Descipcion
            // 
            this.Txt_Descipcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Txt_Descipcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Descipcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descipcion.Location = new System.Drawing.Point(34, 169);
            this.Txt_Descipcion.Name = "Txt_Descipcion";
            this.Txt_Descipcion.Size = new System.Drawing.Size(385, 85);
            this.Txt_Descipcion.TabIndex = 10;
            this.Txt_Descipcion.Text = "";
            // 
            // Precio_V
            // 
            this.Precio_V.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Precio_V.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio_V.Location = new System.Drawing.Point(928, 83);
            this.Precio_V.Name = "Precio_V";
            this.Precio_V.Size = new System.Drawing.Size(369, 26);
            this.Precio_V.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(479, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio $";
            // 
            // Txt_Existencia
            // 
            this.Txt_Existencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Txt_Existencia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Existencia.Location = new System.Drawing.Point(928, 169);
            this.Txt_Existencia.Name = "Txt_Existencia";
            this.Txt_Existencia.Size = new System.Drawing.Size(369, 26);
            this.Txt_Existencia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(924, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Existencias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.Btn_Sesion);
            this.panel2.Controls.Add(this.Btn_Conection);
            this.panel2.Controls.Add(this.Btn_Eliminar);
            this.panel2.Controls.Add(this.Btn_Actualizar);
            this.panel2.Controls.Add(this.Btn_Limpiar);
            this.panel2.Controls.Add(this.Btn_Agregar);
            this.panel2.Location = new System.Drawing.Point(109, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 100);
            this.panel2.TabIndex = 2;
            // 
            // Btn_Sesion
            // 
            this.Btn_Sesion.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Sesion.BackgroundImage = global::Vista.Properties.Resources.acceso;
            this.Btn_Sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Sesion.FlatAppearance.BorderSize = 0;
            this.Btn_Sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sesion.Location = new System.Drawing.Point(1120, 29);
            this.Btn_Sesion.Name = "Btn_Sesion";
            this.Btn_Sesion.Size = new System.Drawing.Size(40, 43);
            this.Btn_Sesion.TabIndex = 10;
            this.Btn_Sesion.UseVisualStyleBackColor = false;
            this.Btn_Sesion.Click += new System.EventHandler(this.Btn_Sesion_Click);
            // 
            // Btn_Conection
            // 
            this.Btn_Conection.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Conection.BackgroundImage = global::Vista.Properties.Resources.wifi;
            this.Btn_Conection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Conection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Conection.FlatAppearance.BorderSize = 0;
            this.Btn_Conection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Conection.Location = new System.Drawing.Point(1072, 29);
            this.Btn_Conection.Name = "Btn_Conection";
            this.Btn_Conection.Size = new System.Drawing.Size(42, 43);
            this.Btn_Conection.TabIndex = 9;
            this.Btn_Conection.UseVisualStyleBackColor = false;
            this.Btn_Conection.Click += new System.EventHandler(this.Btn_Conection_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Image = global::Vista.Properties.Resources.eraser_solid_24;
            this.Btn_Eliminar.Location = new System.Drawing.Point(788, 23);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(216, 54);
            this.Btn_Eliminar.TabIndex = 8;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.Btn_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizar.Image = global::Vista.Properties.Resources.edit_alt_regular_24;
            this.Btn_Actualizar.Location = new System.Drawing.Point(295, 23);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(216, 54);
            this.Btn_Actualizar.TabIndex = 7;
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar.Image = global::Vista.Properties.Resources.brush_alt_regular_24;
            this.Btn_Limpiar.Location = new System.Drawing.Point(541, 23);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(216, 54);
            this.Btn_Limpiar.TabIndex = 6;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(213)))), ((int)(((byte)(241)))));
            this.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Agregar.FlatAppearance.BorderSize = 0;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.Image = global::Vista.Properties.Resources.package_solid_24;
            this.Btn_Agregar.Location = new System.Drawing.Point(50, 23);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(216, 54);
            this.Btn_Agregar.TabIndex = 5;
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // dataGridViewProd
            // 
            this.dataGridViewProd.AllowUserToAddRows = false;
            this.dataGridViewProd.AllowUserToDeleteRows = false;
            this.dataGridViewProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProd.ColumnHeadersHeight = 35;
            this.dataGridViewProd.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProd.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProd.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProd.Name = "dataGridViewProd";
            this.dataGridViewProd.ReadOnly = true;
            this.dataGridViewProd.RowHeadersVisible = false;
            this.dataGridViewProd.Size = new System.Drawing.Size(1333, 240);
            this.dataGridViewProd.TabIndex = 3;
            this.dataGridViewProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProd_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.dataGridViewProd);
            this.panel3.Location = new System.Drawing.Point(41, 537);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1336, 240);
            this.panel3.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Registros:";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 820);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewProd;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Conection;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Precio_V;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Existencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Txt_Descipcion;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Sesion;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label8;
    }
}