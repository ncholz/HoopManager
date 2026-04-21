namespace HoopManager
{
    partial class Form10
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDorsal = new System.Windows.Forms.NumericUpDown();
            this.txtAltura = new System.Windows.Forms.NumericUpDown();
            this.cmbPosicion = new System.Windows.Forms.ListBox();
            this.cmbEquipo = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.Dorsal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtDorsal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(269, 210);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtDorsal
            // 
            this.txtDorsal.Location = new System.Drawing.Point(388, 210);
            this.txtDorsal.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.txtDorsal.Name = "txtDorsal";
            this.txtDorsal.Size = new System.Drawing.Size(120, 22);
            this.txtDorsal.TabIndex = 1;
            this.txtDorsal.ValueChanged += new System.EventHandler(this.txtDorsal_ValueChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(209, 317);
            this.txtAltura.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(120, 22);
            this.txtAltura.TabIndex = 2;
            this.txtAltura.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtAltura.ValueChanged += new System.EventHandler(this.txtAltura_ValueChanged);
            // 
            // cmbPosicion
            // 
            this.cmbPosicion.FormattingEnabled = true;
            this.cmbPosicion.ItemHeight = 16;
            this.cmbPosicion.Location = new System.Drawing.Point(388, 317);
            this.cmbPosicion.Name = "cmbPosicion";
            this.cmbPosicion.Size = new System.Drawing.Size(120, 84);
            this.cmbPosicion.TabIndex = 3;
            this.cmbPosicion.SelectedIndexChanged += new System.EventHandler(this.cmbPosicion_SelectedIndexChanged);
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.ItemHeight = 16;
            this.cmbEquipo.Location = new System.Drawing.Point(547, 317);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(120, 84);
            this.cmbEquipo.TabIndex = 4;
            this.cmbEquipo.SelectedIndexChanged += new System.EventHandler(this.cmbEquipo_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(525, 439);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(385, 439);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(254, 439);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJugadores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvJugadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Location = new System.Drawing.Point(118, 540);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.RowHeadersWidth = 51;
            this.dgvJugadores.RowTemplate.Height = 24;
            this.dgvJugadores.Size = new System.Drawing.Size(755, 310);
            this.dgvJugadores.TabIndex = 11;
            this.dgvJugadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJugadores_CellClick);
            // 
            // Dorsal
            // 
            this.Dorsal.AutoSize = true;
            this.Dorsal.Location = new System.Drawing.Point(424, 179);
            this.Dorsal.Name = "Dorsal";
            this.Dorsal.Size = new System.Drawing.Size(47, 16);
            this.Dorsal.TabIndex = 12;
            this.Dorsal.Text = "Dorsal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Altura (cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(688, 57);
            this.label2.TabIndex = 14;
            this.label2.Text = "GESTIÓN DE JUGADORES";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1211, 1118);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dorsal);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEquipo);
            this.Controls.Add(this.cmbPosicion);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtDorsal);
            this.Controls.Add(this.txtNombre);
            this.Location = new System.Drawing.Point(300, 0);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDorsal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown txtDorsal;
        private System.Windows.Forms.NumericUpDown txtAltura;
        private System.Windows.Forms.ListBox cmbPosicion;
        private System.Windows.Forms.ListBox cmbEquipo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.Label Dorsal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}