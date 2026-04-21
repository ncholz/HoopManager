namespace HoopManager
{
    partial class Form11
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
            this.cmbJugador = new System.Windows.Forms.ListBox();
            this.txtTemporada = new System.Windows.Forms.TextBox();
            this.numPuntos = new System.Windows.Forms.NumericUpDown();
            this.numRebotes = new System.Windows.Forms.NumericUpDown();
            this.numAsistencias = new System.Windows.Forms.NumericUpDown();
            this.numTriple = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvStatsHistoricas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRebotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsHistoricas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbJugador
            // 
            this.cmbJugador.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.cmbJugador.FormattingEnabled = true;
            this.cmbJugador.ItemHeight = 16;
            this.cmbJugador.Location = new System.Drawing.Point(386, 231);
            this.cmbJugador.Name = "cmbJugador";
            this.cmbJugador.Size = new System.Drawing.Size(120, 84);
            this.cmbJugador.TabIndex = 0;
            this.cmbJugador.SelectedIndexChanged += new System.EventHandler(this.cmbJugador_SelectedIndexChanged);
            // 
            // txtTemporada
            // 
            this.txtTemporada.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.txtTemporada.Location = new System.Drawing.Point(209, 257);
            this.txtTemporada.Name = "txtTemporada";
            this.txtTemporada.Size = new System.Drawing.Size(125, 29);
            this.txtTemporada.TabIndex = 1;
            this.txtTemporada.TextChanged += new System.EventHandler(this.txtTemporada_TextChanged);
            // 
            // numPuntos
            // 
            this.numPuntos.DecimalPlaces = 1;
            this.numPuntos.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numPuntos.Location = new System.Drawing.Point(245, 417);
            this.numPuntos.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPuntos.Name = "numPuntos";
            this.numPuntos.Size = new System.Drawing.Size(150, 23);
            this.numPuntos.TabIndex = 2;
            this.numPuntos.ValueChanged += new System.EventHandler(this.numPuntos_ValueChanged);
            // 
            // numRebotes
            // 
            this.numRebotes.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numRebotes.Location = new System.Drawing.Point(399, 417);
            this.numRebotes.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numRebotes.Name = "numRebotes";
            this.numRebotes.Size = new System.Drawing.Size(150, 23);
            this.numRebotes.TabIndex = 3;
            this.numRebotes.ValueChanged += new System.EventHandler(this.numRebotes_ValueChanged);
            // 
            // numAsistencias
            // 
            this.numAsistencias.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numAsistencias.Location = new System.Drawing.Point(552, 417);
            this.numAsistencias.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numAsistencias.Name = "numAsistencias";
            this.numAsistencias.Size = new System.Drawing.Size(150, 23);
            this.numAsistencias.TabIndex = 4;
            this.numAsistencias.ValueChanged += new System.EventHandler(this.numAsistencias_ValueChanged);
            // 
            // numTriple
            // 
            this.numTriple.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numTriple.Location = new System.Drawing.Point(715, 417);
            this.numTriple.Name = "numTriple";
            this.numTriple.Size = new System.Drawing.Size(150, 23);
            this.numTriple.TabIndex = 5;
            this.numTriple.ValueChanged += new System.EventHandler(this.numTriple_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label1.Location = new System.Drawing.Point(253, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Puntos media";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label2.Location = new System.Drawing.Point(396, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rebotes media";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label3.Location = new System.Drawing.Point(549, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Asistencias media";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label4.Location = new System.Drawing.Point(712, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "% triple";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.btnLimpiar.Location = new System.Drawing.Point(643, 494);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.btnEliminar.Location = new System.Drawing.Point(503, 494);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.btnGuardar.Location = new System.Drawing.Point(372, 494);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label5.Location = new System.Drawing.Point(212, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Temporada";
            // 
            // dgvStatsHistoricas
            // 
            this.dgvStatsHistoricas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatsHistoricas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStatsHistoricas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatsHistoricas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStatsHistoricas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatsHistoricas.Location = new System.Drawing.Point(209, 603);
            this.dgvStatsHistoricas.Name = "dgvStatsHistoricas";
            this.dgvStatsHistoricas.RowHeadersWidth = 51;
            this.dgvStatsHistoricas.RowTemplate.Height = 24;
            this.dgvStatsHistoricas.Size = new System.Drawing.Size(589, 288);
            this.dgvStatsHistoricas.TabIndex = 15;
            this.dgvStatsHistoricas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStatsHistoricas_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1391, 71);
            this.label6.TabIndex = 16;
            this.label6.Text = "GESTIÓN DE ESTADISTICAS HISTORICAS";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1078, 1082);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvStatsHistoricas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTriple);
            this.Controls.Add(this.numAsistencias);
            this.Controls.Add(this.numRebotes);
            this.Controls.Add(this.numPuntos);
            this.Controls.Add(this.txtTemporada);
            this.Controls.Add(this.cmbJugador);
            this.Location = new System.Drawing.Point(300, 0);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRebotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsHistoricas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cmbJugador;
        private System.Windows.Forms.TextBox txtTemporada;
        private System.Windows.Forms.NumericUpDown numPuntos;
        private System.Windows.Forms.NumericUpDown numRebotes;
        private System.Windows.Forms.NumericUpDown numAsistencias;
        private System.Windows.Forms.NumericUpDown numTriple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvStatsHistoricas;
        private System.Windows.Forms.Label label6;
    }
}