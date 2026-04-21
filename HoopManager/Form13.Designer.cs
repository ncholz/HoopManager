namespace HoopManager
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.lblMarcador = new System.Windows.Forms.Label();
            this.cmbJugador = new System.Windows.Forms.ComboBox();
            this.numT2M = new System.Windows.Forms.NumericUpDown();
            this.numT2I = new System.Windows.Forms.NumericUpDown();
            this.numT3M = new System.Windows.Forms.NumericUpDown();
            this.numT3I = new System.Windows.Forms.NumericUpDown();
            this.numTLI = new System.Windows.Forms.NumericUpDown();
            this.numTLM = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numMinutos = new System.Windows.Forms.NumericUpDown();
            this.numRebO = new System.Windows.Forms.NumericUpDown();
            this.numRebD = new System.Windows.Forms.NumericUpDown();
            this.numAsistencias = new System.Windows.Forms.NumericUpDown();
            this.numRobos = new System.Windows.Forms.NumericUpDown();
            this.numTapones = new System.Windows.Forms.NumericUpDown();
            this.numPerdidas = new System.Windows.Forms.NumericUpDown();
            this.numFaltas = new System.Windows.Forms.NumericUpDown();
            this.numValoracion = new System.Windows.Forms.NumericUpDown();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvStatsPartido = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Valoración = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rbLocales = new System.Windows.Forms.RadioButton();
            this.rbVisitantes = new System.Windows.Forms.RadioButton();
            this.volver = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numT2M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT2I)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT3M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT3I)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTLI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTLM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRebO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRebD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRobos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTapones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPerdidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFaltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValoracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsPartido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarcador
            // 
            this.lblMarcador.AutoSize = true;
            this.lblMarcador.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcador.Location = new System.Drawing.Point(1048, 246);
            this.lblMarcador.Name = "lblMarcador";
            this.lblMarcador.Size = new System.Drawing.Size(116, 48);
            this.lblMarcador.TabIndex = 0;
            this.lblMarcador.Text = "0 - 0";
            this.lblMarcador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMarcador.Click += new System.EventHandler(this.lblMarcador_Click);
            // 
            // cmbJugador
            // 
            this.cmbJugador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJugador.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.cmbJugador.FormattingEnabled = true;
            this.cmbJugador.Location = new System.Drawing.Point(244, 258);
            this.cmbJugador.Name = "cmbJugador";
            this.cmbJugador.Size = new System.Drawing.Size(121, 24);
            this.cmbJugador.TabIndex = 1;
            this.cmbJugador.SelectedIndexChanged += new System.EventHandler(this.cmbJugador_SelectedIndexChanged);
            // 
            // numT2M
            // 
            this.numT2M.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numT2M.Location = new System.Drawing.Point(351, 347);
            this.numT2M.Name = "numT2M";
            this.numT2M.Size = new System.Drawing.Size(171, 23);
            this.numT2M.TabIndex = 2;
            this.numT2M.ValueChanged += new System.EventHandler(this.numT2M_ValueChanged);
            // 
            // numT2I
            // 
            this.numT2I.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numT2I.Location = new System.Drawing.Point(543, 347);
            this.numT2I.Name = "numT2I";
            this.numT2I.Size = new System.Drawing.Size(164, 23);
            this.numT2I.TabIndex = 3;
            this.numT2I.ValueChanged += new System.EventHandler(this.numT2I_ValueChanged);
            // 
            // numT3M
            // 
            this.numT3M.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numT3M.Location = new System.Drawing.Point(351, 399);
            this.numT3M.Name = "numT3M";
            this.numT3M.Size = new System.Drawing.Size(171, 23);
            this.numT3M.TabIndex = 4;
            this.numT3M.ValueChanged += new System.EventHandler(this.numT3M_ValueChanged);
            // 
            // numT3I
            // 
            this.numT3I.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numT3I.Location = new System.Drawing.Point(543, 399);
            this.numT3I.Name = "numT3I";
            this.numT3I.Size = new System.Drawing.Size(164, 23);
            this.numT3I.TabIndex = 5;
            this.numT3I.ValueChanged += new System.EventHandler(this.numT3I_ValueChanged);
            // 
            // numTLI
            // 
            this.numTLI.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numTLI.Location = new System.Drawing.Point(543, 447);
            this.numTLI.Name = "numTLI";
            this.numTLI.Size = new System.Drawing.Size(164, 23);
            this.numTLI.TabIndex = 6;
            this.numTLI.ValueChanged += new System.EventHandler(this.numTLI_ValueChanged);
            // 
            // numTLM
            // 
            this.numTLM.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numTLM.Location = new System.Drawing.Point(351, 447);
            this.numTLM.Name = "numTLM";
            this.numTLM.Size = new System.Drawing.Size(171, 23);
            this.numTLM.TabIndex = 7;
            this.numTLM.ValueChanged += new System.EventHandler(this.numTLM_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label1.Location = new System.Drawing.Point(194, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "T2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label2.Location = new System.Drawing.Point(194, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "T3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label3.Location = new System.Drawing.Point(194, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "TL";
            // 
            // numMinutos
            // 
            this.numMinutos.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numMinutos.Location = new System.Drawing.Point(773, 271);
            this.numMinutos.Name = "numMinutos";
            this.numMinutos.Size = new System.Drawing.Size(156, 23);
            this.numMinutos.TabIndex = 11;
            this.numMinutos.ValueChanged += new System.EventHandler(this.numMinutos_ValueChanged);
            // 
            // numRebO
            // 
            this.numRebO.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numRebO.Location = new System.Drawing.Point(799, 405);
            this.numRebO.Name = "numRebO";
            this.numRebO.Size = new System.Drawing.Size(156, 23);
            this.numRebO.TabIndex = 12;
            this.numRebO.ValueChanged += new System.EventHandler(this.numRebO_ValueChanged);
            // 
            // numRebD
            // 
            this.numRebD.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numRebD.Location = new System.Drawing.Point(973, 405);
            this.numRebD.Name = "numRebD";
            this.numRebD.Size = new System.Drawing.Size(156, 23);
            this.numRebD.TabIndex = 13;
            this.numRebD.ValueChanged += new System.EventHandler(this.numRebD_ValueChanged);
            // 
            // numAsistencias
            // 
            this.numAsistencias.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numAsistencias.Location = new System.Drawing.Point(437, 494);
            this.numAsistencias.Name = "numAsistencias";
            this.numAsistencias.Size = new System.Drawing.Size(173, 23);
            this.numAsistencias.TabIndex = 14;
            this.numAsistencias.ValueChanged += new System.EventHandler(this.numAsistencias_ValueChanged);
            // 
            // numRobos
            // 
            this.numRobos.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numRobos.Location = new System.Drawing.Point(437, 533);
            this.numRobos.Name = "numRobos";
            this.numRobos.Size = new System.Drawing.Size(173, 23);
            this.numRobos.TabIndex = 15;
            this.numRobos.ValueChanged += new System.EventHandler(this.numRobos_ValueChanged);
            // 
            // numTapones
            // 
            this.numTapones.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numTapones.Location = new System.Drawing.Point(437, 571);
            this.numTapones.Name = "numTapones";
            this.numTapones.Size = new System.Drawing.Size(173, 23);
            this.numTapones.TabIndex = 16;
            this.numTapones.ValueChanged += new System.EventHandler(this.numTapones_ValueChanged);
            // 
            // numPerdidas
            // 
            this.numPerdidas.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numPerdidas.Location = new System.Drawing.Point(437, 615);
            this.numPerdidas.Name = "numPerdidas";
            this.numPerdidas.Size = new System.Drawing.Size(173, 23);
            this.numPerdidas.TabIndex = 17;
            this.numPerdidas.ValueChanged += new System.EventHandler(this.numPerdidas_ValueChanged);
            // 
            // numFaltas
            // 
            this.numFaltas.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numFaltas.Location = new System.Drawing.Point(437, 653);
            this.numFaltas.Name = "numFaltas";
            this.numFaltas.Size = new System.Drawing.Size(173, 23);
            this.numFaltas.TabIndex = 18;
            this.numFaltas.ValueChanged += new System.EventHandler(this.numFaltas_ValueChanged);
            // 
            // numValoracion
            // 
            this.numValoracion.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.numValoracion.Location = new System.Drawing.Point(437, 693);
            this.numValoracion.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numValoracion.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numValoracion.Name = "numValoracion";
            this.numValoracion.Size = new System.Drawing.Size(173, 23);
            this.numValoracion.TabIndex = 19;
            this.numValoracion.ValueChanged += new System.EventHandler(this.numValoracion_ValueChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.btnLimpiar.Location = new System.Drawing.Point(994, 631);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.btnEliminar.Location = new System.Drawing.Point(854, 631);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.btnGuardar.Location = new System.Drawing.Point(723, 631);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvStatsPartido
            // 
            this.dgvStatsPartido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatsPartido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStatsPartido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatsPartido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStatsPartido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatsPartido.Location = new System.Drawing.Point(284, 788);
            this.dgvStatsPartido.Name = "dgvStatsPartido";
            this.dgvStatsPartido.RowHeadersWidth = 51;
            this.dgvStatsPartido.RowTemplate.Height = 24;
            this.dgvStatsPartido.Size = new System.Drawing.Size(815, 317);
            this.dgvStatsPartido.TabIndex = 23;
            this.dgvStatsPartido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStatsPartido_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label4.Location = new System.Drawing.Point(330, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Asistencias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label5.Location = new System.Drawing.Point(330, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Robos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label6.Location = new System.Drawing.Point(330, 577);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tapones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label7.Location = new System.Drawing.Point(330, 621);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Pérdidas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label8.Location = new System.Drawing.Point(330, 659);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Faltas";
            // 
            // Valoración
            // 
            this.Valoración.AutoSize = true;
            this.Valoración.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.Valoración.Location = new System.Drawing.Point(330, 695);
            this.Valoración.Name = "Valoración";
            this.Valoración.Size = new System.Drawing.Size(93, 20);
            this.Valoración.TabIndex = 29;
            this.Valoración.Text = "Valoración";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label9.Location = new System.Drawing.Point(796, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Rebotes ofensivos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label10.Location = new System.Drawing.Point(970, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Rebotes defensivos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label11.Location = new System.Drawing.Point(774, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Minutos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label12.Location = new System.Drawing.Point(368, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "Metidos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(558, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "Intentados";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(250, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "Jugador";
            // 
            // rbLocales
            // 
            this.rbLocales.AutoSize = true;
            this.rbLocales.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.rbLocales.Location = new System.Drawing.Point(427, 222);
            this.rbLocales.Name = "rbLocales";
            this.rbLocales.Size = new System.Drawing.Size(211, 20);
            this.rbLocales.TabIndex = 37;
            this.rbLocales.TabStop = true;
            this.rbLocales.Text = "Nombre equipo local (Local)";
            this.rbLocales.UseVisualStyleBackColor = true;
            this.rbLocales.CheckedChanged += new System.EventHandler(this.rbLocales_CheckedChanged);
            // 
            // rbVisitantes
            // 
            this.rbVisitantes.AutoSize = true;
            this.rbVisitantes.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.rbVisitantes.Location = new System.Drawing.Point(427, 246);
            this.rbVisitantes.Name = "rbVisitantes";
            this.rbVisitantes.Size = new System.Drawing.Size(262, 20);
            this.rbVisitantes.TabIndex = 38;
            this.rbVisitantes.TabStop = true;
            this.rbVisitantes.Text = "Nombre equipo visitante (Visitante)";
            this.rbVisitantes.UseVisualStyleBackColor = true;
            this.rbVisitantes.CheckedChanged += new System.EventHandler(this.rbVisitantes_CheckedChanged);
            // 
            // volver
            // 
            this.volver.BackColor = System.Drawing.Color.Transparent;
            this.volver.Image = ((System.Drawing.Image)(resources.GetObject("volver.Image")));
            this.volver.Location = new System.Drawing.Point(1156, 1042);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(69, 63);
            this.volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volver.TabIndex = 39;
            this.volver.TabStop = false;
            this.volver.Click += new System.EventHandler(this.atras);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(84, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(963, 57);
            this.label14.TabIndex = 40;
            this.label14.Text = "GESTIÓN DE PUNTOS DEL PARTIDO";
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1351, 1117);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.rbVisitantes);
            this.Controls.Add(this.rbLocales);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Valoración);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvStatsPartido);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.numValoracion);
            this.Controls.Add(this.numFaltas);
            this.Controls.Add(this.numPerdidas);
            this.Controls.Add(this.numTapones);
            this.Controls.Add(this.numRobos);
            this.Controls.Add(this.numAsistencias);
            this.Controls.Add(this.numRebD);
            this.Controls.Add(this.numRebO);
            this.Controls.Add(this.numMinutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTLM);
            this.Controls.Add(this.numTLI);
            this.Controls.Add(this.numT3I);
            this.Controls.Add(this.numT3M);
            this.Controls.Add(this.numT2I);
            this.Controls.Add(this.numT2M);
            this.Controls.Add(this.cmbJugador);
            this.Controls.Add(this.lblMarcador);
            this.Name = "Form13";
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numT2M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT2I)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT3M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT3I)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTLI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTLM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRebO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRebD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAsistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRobos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTapones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPerdidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFaltas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValoracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatsPartido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcador;
        private System.Windows.Forms.ComboBox cmbJugador;
        private System.Windows.Forms.NumericUpDown numT2M;
        private System.Windows.Forms.NumericUpDown numT2I;
        private System.Windows.Forms.NumericUpDown numT3M;
        private System.Windows.Forms.NumericUpDown numT3I;
        private System.Windows.Forms.NumericUpDown numTLI;
        private System.Windows.Forms.NumericUpDown numTLM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMinutos;
        private System.Windows.Forms.NumericUpDown numRebO;
        private System.Windows.Forms.NumericUpDown numRebD;
        private System.Windows.Forms.NumericUpDown numAsistencias;
        private System.Windows.Forms.NumericUpDown numRobos;
        private System.Windows.Forms.NumericUpDown numTapones;
        private System.Windows.Forms.NumericUpDown numPerdidas;
        private System.Windows.Forms.NumericUpDown numFaltas;
        private System.Windows.Forms.NumericUpDown numValoracion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvStatsPartido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Valoración;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rbLocales;
        private System.Windows.Forms.RadioButton rbVisitantes;
        private System.Windows.Forms.PictureBox volver;
        private System.Windows.Forms.Label label14;
    }
}