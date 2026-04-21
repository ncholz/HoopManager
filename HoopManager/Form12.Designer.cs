namespace HoopManager
{
    partial class Form12
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbLocal = new System.Windows.Forms.ListBox();
            this.cmbVisitante = new System.Windows.Forms.ListBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.Jornada = new System.Windows.Forms.Label();
            this.dgvPartidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new AltoControls.AltoButton();
            this.btnEliminar = new AltoControls.AltoButton();
            this.btnLimpiar = new AltoControls.AltoButton();
            this.btnGestionarStats = new AltoControls.AltoButton();
            this.numJornada = new AltoControls.AltoNMUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLocal
            // 
            this.cmbLocal.BackColor = System.Drawing.Color.DarkOrange;
            this.cmbLocal.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.ItemHeight = 16;
            this.cmbLocal.Location = new System.Drawing.Point(453, 234);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(120, 148);
            this.cmbLocal.TabIndex = 0;
            this.cmbLocal.SelectedIndexChanged += new System.EventHandler(this.cmbLocal_SelectedIndexChanged);
            // 
            // cmbVisitante
            // 
            this.cmbVisitante.BackColor = System.Drawing.Color.DarkOrange;
            this.cmbVisitante.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVisitante.FormattingEnabled = true;
            this.cmbVisitante.ItemHeight = 16;
            this.cmbVisitante.Location = new System.Drawing.Point(683, 234);
            this.cmbVisitante.Name = "cmbVisitante";
            this.cmbVisitante.Size = new System.Drawing.Size(120, 148);
            this.cmbVisitante.TabIndex = 1;
            this.cmbVisitante.SelectedIndexChanged += new System.EventHandler(this.cmbVisitante_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(534, 413);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha.TabIndex = 2;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // Jornada
            // 
            this.Jornada.AutoSize = true;
            this.Jornada.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jornada.Location = new System.Drawing.Point(601, 453);
            this.Jornada.Name = "Jornada";
            this.Jornada.Size = new System.Drawing.Size(58, 16);
            this.Jornada.TabIndex = 3;
            this.Jornada.Text = "Jornada";
            // 
            // dgvPartidos
            // 
            this.dgvPartidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPartidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPartidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidos.GridColor = System.Drawing.Color.DarkOrange;
            this.dgvPartidos.Location = new System.Drawing.Point(222, 686);
            this.dgvPartidos.Name = "dgvPartidos";
            this.dgvPartidos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPartidos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPartidos.RowTemplate.Height = 24;
            this.dgvPartidos.Size = new System.Drawing.Size(846, 345);
            this.dgvPartidos.TabIndex = 17;
            this.dgvPartidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartidos_CellContentClickk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "VS";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Active1 = System.Drawing.Color.DarkOrange;
            this.btnGuardar.Active2 = System.Drawing.Color.DarkOrange;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Inactive1 = System.Drawing.Color.DarkOrange;
            this.btnGuardar.Inactive2 = System.Drawing.Color.DarkOrange;
            this.btnGuardar.Location = new System.Drawing.Point(417, 554);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Radius = 10;
            this.btnGuardar.Size = new System.Drawing.Size(135, 45);
            this.btnGuardar.Stroke = false;
            this.btnGuardar.StrokeColor = System.Drawing.Color.Gray;
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Transparency = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Active1 = System.Drawing.Color.DarkOrange;
            this.btnEliminar.Active2 = System.Drawing.Color.DarkOrange;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Inactive1 = System.Drawing.Color.DarkOrange;
            this.btnEliminar.Inactive2 = System.Drawing.Color.DarkOrange;
            this.btnEliminar.Location = new System.Drawing.Point(568, 554);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Radius = 10;
            this.btnEliminar.Size = new System.Drawing.Size(135, 45);
            this.btnEliminar.Stroke = false;
            this.btnEliminar.StrokeColor = System.Drawing.Color.Gray;
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Transparency = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Active1 = System.Drawing.Color.DarkOrange;
            this.btnLimpiar.Active2 = System.Drawing.Color.DarkOrange;
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Inactive1 = System.Drawing.Color.DarkOrange;
            this.btnLimpiar.Inactive2 = System.Drawing.Color.DarkOrange;
            this.btnLimpiar.Location = new System.Drawing.Point(724, 554);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Radius = 10;
            this.btnLimpiar.Size = new System.Drawing.Size(135, 45);
            this.btnLimpiar.Stroke = false;
            this.btnLimpiar.StrokeColor = System.Drawing.Color.Gray;
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Transparency = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnGestionarStats
            // 
            this.btnGestionarStats.Active1 = System.Drawing.Color.DarkOrange;
            this.btnGestionarStats.Active2 = System.Drawing.Color.DarkOrange;
            this.btnGestionarStats.BackColor = System.Drawing.Color.Transparent;
            this.btnGestionarStats.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGestionarStats.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarStats.ForeColor = System.Drawing.Color.Black;
            this.btnGestionarStats.Inactive1 = System.Drawing.Color.DarkOrange;
            this.btnGestionarStats.Inactive2 = System.Drawing.Color.DarkOrange;
            this.btnGestionarStats.Location = new System.Drawing.Point(524, 635);
            this.btnGestionarStats.Name = "btnGestionarStats";
            this.btnGestionarStats.Radius = 10;
            this.btnGestionarStats.Size = new System.Drawing.Size(226, 38);
            this.btnGestionarStats.Stroke = false;
            this.btnGestionarStats.StrokeColor = System.Drawing.Color.Gray;
            this.btnGestionarStats.TabIndex = 23;
            this.btnGestionarStats.Text = "Gestionar estadísticas";
            this.btnGestionarStats.Transparency = false;
            this.btnGestionarStats.Click += new System.EventHandler(this.btnGestionarStats_Click_1);
            // 
            // numJornada
            // 
            this.numJornada.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numJornada.ForeColor = System.Drawing.SystemColors.Info;
            this.numJornada.Location = new System.Drawing.Point(555, 472);
            this.numJornada.Name = "numJornada";
            this.numJornada.SignColor = System.Drawing.SystemColors.Window;
            this.numJornada.Size = new System.Drawing.Size(166, 40);
            this.numJornada.TabIndex = 24;
            this.numJornada.Value = 0D;
            this.numJornada.Click += new System.EventHandler(this.numJornada_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Equipo local";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(689, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Equipo visitante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(808, 71);
            this.label4.TabIndex = 27;
            this.label4.Text = "GESTIÓN DE PARTIDOS";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1278, 1063);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numJornada);
            this.Controls.Add(this.btnGestionarStats);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPartidos);
            this.Controls.Add(this.Jornada);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbVisitante);
            this.Controls.Add(this.cmbLocal);
            this.Location = new System.Drawing.Point(300, 0);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cmbLocal;
        private System.Windows.Forms.ListBox cmbVisitante;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label Jornada;
        private System.Windows.Forms.DataGridView dgvPartidos;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoButton btnGuardar;
        private AltoControls.AltoButton btnEliminar;
        private AltoControls.AltoButton btnLimpiar;
        private AltoControls.AltoButton btnGestionarStats;
        private AltoControls.AltoNMUpDown numJornada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}