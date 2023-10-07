
namespace Entrega2
{
    partial class Pedidos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataPedidos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtExistencias = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_ID = new System.Windows.Forms.TextBox();
            this.Btn_Sesion = new System.Windows.Forms.Button();
            this.Btn_Conection = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Minimizar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 47);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pedidos";
            // 
            // CmbNames
            // 
            this.CmbNames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbNames.DisplayMember = "-";
            this.CmbNames.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbNames.FormattingEnabled = true;
            this.CmbNames.Location = new System.Drawing.Point(71, 155);
            this.CmbNames.Name = "CmbNames";
            this.CmbNames.Size = new System.Drawing.Size(430, 25);
            this.CmbNames.TabIndex = 1;
            this.CmbNames.Tag = "Seleccionar";
            this.CmbNames.Text = "Seleccionar...";
            this.CmbNames.ValueMember = "-";
            this.CmbNames.SelectedIndexChanged += new System.EventHandler(this.CmbNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Productos Almacenados";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(71, 257);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(281, 25);
            this.TxtCantidad.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_ID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtExistencias);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CmbNames);
            this.groupBox1.Controls.Add(this.TxtCantidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 327);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cantidad";
            // 
            // DataPedidos
            // 
            this.DataPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPedidos.Location = new System.Drawing.Point(16, 554);
            this.DataPedidos.Name = "DataPedidos";
            this.DataPedidos.Size = new System.Drawing.Size(586, 240);
            this.DataPedidos.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Historial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Disponibles";
            // 
            // TxtExistencias
            // 
            this.TxtExistencias.Enabled = false;
            this.TxtExistencias.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExistencias.Location = new System.Drawing.Point(371, 257);
            this.TxtExistencias.Name = "TxtExistencias";
            this.TxtExistencias.Size = new System.Drawing.Size(130, 25);
            this.TxtExistencias.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "ID del Pedido";
            // 
            // Txt_ID
            // 
            this.Txt_ID.Location = new System.Drawing.Point(216, 66);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(161, 26);
            this.Txt_ID.TabIndex = 21;
            // 
            // Btn_Sesion
            // 
            this.Btn_Sesion.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Sesion.BackgroundImage = global::Vista.Properties.Resources.acceso;
            this.Btn_Sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Sesion.FlatAppearance.BorderSize = 0;
            this.Btn_Sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sesion.Location = new System.Drawing.Point(434, 425);
            this.Btn_Sesion.Name = "Btn_Sesion";
            this.Btn_Sesion.Size = new System.Drawing.Size(40, 43);
            this.Btn_Sesion.TabIndex = 21;
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
            this.Btn_Conection.Location = new System.Drawing.Point(386, 425);
            this.Btn_Conection.Name = "Btn_Conection";
            this.Btn_Conection.Size = new System.Drawing.Size(42, 43);
            this.Btn_Conection.TabIndex = 20;
            this.Btn_Conection.UseVisualStyleBackColor = false;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(213)))), ((int)(((byte)(241)))));
            this.Btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Agregar.FlatAppearance.BorderSize = 0;
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.Image = global::Vista.Properties.Resources.package_solid_24;
            this.Btn_Agregar.Location = new System.Drawing.Point(130, 419);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(216, 54);
            this.Btn_Agregar.TabIndex = 19;
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Minimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.Btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.Image = global::Vista.Properties.Resources.minimizar_signo;
            this.Btn_Minimizar.Location = new System.Drawing.Point(539, 0);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(43, 47);
            this.Btn_Minimizar.TabIndex = 15;
            this.Btn_Minimizar.UseVisualStyleBackColor = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
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
            this.Btn_Exit.Location = new System.Drawing.Point(582, 0);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(43, 47);
            this.Btn_Exit.TabIndex = 2;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 820);
            this.Controls.Add(this.Btn_Sesion);
            this.Controls.Add(this.Btn_Conection);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataPedidos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataPedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Sesion;
        private System.Windows.Forms.Button Btn_Conection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtExistencias;
        private System.Windows.Forms.TextBox Txt_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Minimizar;
    }
}