namespace AgenciaViajes
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEstadoAvio = new System.Windows.Forms.Button();
            this.PanelReserva = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFNacimientoV4 = new System.Windows.Forms.DateTimePicker();
            this.dtpFNacimientoV3 = new System.Windows.Forms.DateTimePicker();
            this.dtpFNacimientoV2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFNacimientoV1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbnroIDV4 = new System.Windows.Forms.TextBox();
            this.tbnroIDV3 = new System.Windows.Forms.TextBox();
            this.tbnroIDV2 = new System.Windows.Forms.TextBox();
            this.tbnroIDV1 = new System.Windows.Forms.TextBox();
            this.cbTipoIDV4 = new System.Windows.Forms.ListBox();
            this.cbTipoIDV3 = new System.Windows.Forms.ListBox();
            this.cbTipoIDV2 = new System.Windows.Forms.ListBox();
            this.cbTipoIDV1 = new System.Windows.Forms.ListBox();
            this.cbTipoPlan = new System.Windows.Forms.ListBox();
            this.cbTipoID = new System.Windows.Forms.ListBox();
            this.btnFCancelar = new System.Windows.Forms.Button();
            this.btnFReserva = new System.Windows.Forms.Button();
            this.tbNameV4 = new System.Windows.Forms.TextBox();
            this.tbNameV3 = new System.Windows.Forms.TextBox();
            this.tbNameV2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNameV1 = new System.Windows.Forms.TextBox();
            this.tbCiudadDestino = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaRegreso = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNroID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameR = new System.Windows.Forms.TextBox();
            this.btnConsultarReservas = new System.Windows.Forms.Button();
            this.pnroReserva = new System.Windows.Forms.Panel();
            this.btnDoIt = new System.Windows.Forms.Button();
            this.tbNROCONS = new System.Windows.Forms.TextBox();
            this.labNroReserva = new System.Windows.Forms.Label();
            this.PanelReserva.SuspendLayout();
            this.pnroReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LA AGENCIA DEL MECHUQUE";
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(24, 97);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(107, 23);
            this.btnReservar.TabIndex = 1;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(176, 97);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(186, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar Reserva Existente";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(391, 95);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(166, 23);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar Reserva existente";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(754, 95);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(201, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar Monto de Reserva Existente";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEstadoAvio
            // 
            this.btnEstadoAvio.Location = new System.Drawing.Point(981, 95);
            this.btnEstadoAvio.Name = "btnEstadoAvio";
            this.btnEstadoAvio.Size = new System.Drawing.Size(123, 23);
            this.btnEstadoAvio.TabIndex = 5;
            this.btnEstadoAvio.Text = "Ver Estado avión";
            this.btnEstadoAvio.UseVisualStyleBackColor = true;
            this.btnEstadoAvio.Click += new System.EventHandler(this.btnEstadoAvio_Click);
            // 
            // PanelReserva
            // 
            this.PanelReserva.Controls.Add(this.label13);
            this.PanelReserva.Controls.Add(this.dtpFNacimientoV4);
            this.PanelReserva.Controls.Add(this.dtpFNacimientoV3);
            this.PanelReserva.Controls.Add(this.dtpFNacimientoV2);
            this.PanelReserva.Controls.Add(this.dtpFNacimientoV1);
            this.PanelReserva.Controls.Add(this.label12);
            this.PanelReserva.Controls.Add(this.label11);
            this.PanelReserva.Controls.Add(this.tbnroIDV4);
            this.PanelReserva.Controls.Add(this.tbnroIDV3);
            this.PanelReserva.Controls.Add(this.tbnroIDV2);
            this.PanelReserva.Controls.Add(this.tbnroIDV1);
            this.PanelReserva.Controls.Add(this.cbTipoIDV4);
            this.PanelReserva.Controls.Add(this.cbTipoIDV3);
            this.PanelReserva.Controls.Add(this.cbTipoIDV2);
            this.PanelReserva.Controls.Add(this.cbTipoIDV1);
            this.PanelReserva.Controls.Add(this.cbTipoPlan);
            this.PanelReserva.Controls.Add(this.cbTipoID);
            this.PanelReserva.Controls.Add(this.btnFCancelar);
            this.PanelReserva.Controls.Add(this.btnFReserva);
            this.PanelReserva.Controls.Add(this.tbNameV4);
            this.PanelReserva.Controls.Add(this.tbNameV3);
            this.PanelReserva.Controls.Add(this.tbNameV2);
            this.PanelReserva.Controls.Add(this.label10);
            this.PanelReserva.Controls.Add(this.tbNameV1);
            this.PanelReserva.Controls.Add(this.tbCiudadDestino);
            this.PanelReserva.Controls.Add(this.label9);
            this.PanelReserva.Controls.Add(this.dtpFechaRegreso);
            this.PanelReserva.Controls.Add(this.label8);
            this.PanelReserva.Controls.Add(this.dtpFechaSalida);
            this.PanelReserva.Controls.Add(this.label7);
            this.PanelReserva.Controls.Add(this.label6);
            this.PanelReserva.Controls.Add(this.dtpFechaNacimiento);
            this.PanelReserva.Controls.Add(this.label5);
            this.PanelReserva.Controls.Add(this.tbNroID);
            this.PanelReserva.Controls.Add(this.label4);
            this.PanelReserva.Controls.Add(this.label3);
            this.PanelReserva.Controls.Add(this.label2);
            this.PanelReserva.Controls.Add(this.tbNameR);
            this.PanelReserva.Location = new System.Drawing.Point(24, 199);
            this.PanelReserva.Name = "PanelReserva";
            this.PanelReserva.Size = new System.Drawing.Size(1089, 405);
            this.PanelReserva.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(605, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Fecha Nacimiento";
            // 
            // dtpFNacimientoV4
            // 
            this.dtpFNacimientoV4.Location = new System.Drawing.Point(548, 317);
            this.dtpFNacimientoV4.Name = "dtpFNacimientoV4";
            this.dtpFNacimientoV4.Size = new System.Drawing.Size(200, 20);
            this.dtpFNacimientoV4.TabIndex = 41;
            // 
            // dtpFNacimientoV3
            // 
            this.dtpFNacimientoV3.Location = new System.Drawing.Point(548, 270);
            this.dtpFNacimientoV3.Name = "dtpFNacimientoV3";
            this.dtpFNacimientoV3.Size = new System.Drawing.Size(200, 20);
            this.dtpFNacimientoV3.TabIndex = 40;
            // 
            // dtpFNacimientoV2
            // 
            this.dtpFNacimientoV2.Location = new System.Drawing.Point(548, 220);
            this.dtpFNacimientoV2.Name = "dtpFNacimientoV2";
            this.dtpFNacimientoV2.Size = new System.Drawing.Size(200, 20);
            this.dtpFNacimientoV2.TabIndex = 39;
            // 
            // dtpFNacimientoV1
            // 
            this.dtpFNacimientoV1.Location = new System.Drawing.Point(548, 172);
            this.dtpFNacimientoV1.Name = "dtpFNacimientoV1";
            this.dtpFNacimientoV1.Size = new System.Drawing.Size(200, 20);
            this.dtpFNacimientoV1.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(403, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Numero Identificación";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Tipo Identificación";
            // 
            // tbnroIDV4
            // 
            this.tbnroIDV4.Location = new System.Drawing.Point(385, 317);
            this.tbnroIDV4.Name = "tbnroIDV4";
            this.tbnroIDV4.Size = new System.Drawing.Size(147, 20);
            this.tbnroIDV4.TabIndex = 35;
            // 
            // tbnroIDV3
            // 
            this.tbnroIDV3.Location = new System.Drawing.Point(385, 270);
            this.tbnroIDV3.Name = "tbnroIDV3";
            this.tbnroIDV3.Size = new System.Drawing.Size(147, 20);
            this.tbnroIDV3.TabIndex = 34;
            // 
            // tbnroIDV2
            // 
            this.tbnroIDV2.Location = new System.Drawing.Point(385, 220);
            this.tbnroIDV2.Name = "tbnroIDV2";
            this.tbnroIDV2.Size = new System.Drawing.Size(147, 20);
            this.tbnroIDV2.TabIndex = 33;
            // 
            // tbnroIDV1
            // 
            this.tbnroIDV1.Location = new System.Drawing.Point(385, 172);
            this.tbnroIDV1.Name = "tbnroIDV1";
            this.tbnroIDV1.Size = new System.Drawing.Size(147, 20);
            this.tbnroIDV1.TabIndex = 32;
            // 
            // cbTipoIDV4
            // 
            this.cbTipoIDV4.FormattingEnabled = true;
            this.cbTipoIDV4.Items.AddRange(new object[] {
            "CC",
            "CE",
            "PA",
            "TI"});
            this.cbTipoIDV4.Location = new System.Drawing.Point(254, 317);
            this.cbTipoIDV4.Name = "cbTipoIDV4";
            this.cbTipoIDV4.Size = new System.Drawing.Size(109, 56);
            this.cbTipoIDV4.TabIndex = 31;
            this.cbTipoIDV4.SelectedIndexChanged += new System.EventHandler(this.cbTipoIDV4_SelectedIndexChanged);
            // 
            // cbTipoIDV3
            // 
            this.cbTipoIDV3.FormattingEnabled = true;
            this.cbTipoIDV3.Items.AddRange(new object[] {
            "CC",
            "CE",
            "PA",
            "TI"});
            this.cbTipoIDV3.Location = new System.Drawing.Point(254, 257);
            this.cbTipoIDV3.Name = "cbTipoIDV3";
            this.cbTipoIDV3.Size = new System.Drawing.Size(109, 56);
            this.cbTipoIDV3.TabIndex = 30;
            // 
            // cbTipoIDV2
            // 
            this.cbTipoIDV2.FormattingEnabled = true;
            this.cbTipoIDV2.Items.AddRange(new object[] {
            "CC",
            "CE",
            "PA",
            "TI"});
            this.cbTipoIDV2.Location = new System.Drawing.Point(254, 195);
            this.cbTipoIDV2.Name = "cbTipoIDV2";
            this.cbTipoIDV2.Size = new System.Drawing.Size(109, 56);
            this.cbTipoIDV2.TabIndex = 29;
            // 
            // cbTipoIDV1
            // 
            this.cbTipoIDV1.FormattingEnabled = true;
            this.cbTipoIDV1.Items.AddRange(new object[] {
            "CC",
            "CE",
            "PA",
            "TI"});
            this.cbTipoIDV1.Location = new System.Drawing.Point(254, 136);
            this.cbTipoIDV1.Name = "cbTipoIDV1";
            this.cbTipoIDV1.Size = new System.Drawing.Size(109, 56);
            this.cbTipoIDV1.TabIndex = 28;
            // 
            // cbTipoPlan
            // 
            this.cbTipoPlan.FormattingEnabled = true;
            this.cbTipoPlan.Items.AddRange(new object[] {
            "Todo Incluido",
            "Medio Incluido",
            "Básico"});
            this.cbTipoPlan.Location = new System.Drawing.Point(504, 75);
            this.cbTipoPlan.Name = "cbTipoPlan";
            this.cbTipoPlan.Size = new System.Drawing.Size(162, 43);
            this.cbTipoPlan.TabIndex = 27;
            // 
            // cbTipoID
            // 
            this.cbTipoID.FormattingEnabled = true;
            this.cbTipoID.Items.AddRange(new object[] {
            "CC",
            "CE",
            "PA"});
            this.cbTipoID.Location = new System.Drawing.Point(12, 74);
            this.cbTipoID.Name = "cbTipoID";
            this.cbTipoID.Size = new System.Drawing.Size(109, 43);
            this.cbTipoID.TabIndex = 26;
            // 
            // btnFCancelar
            // 
            this.btnFCancelar.Location = new System.Drawing.Point(694, 367);
            this.btnFCancelar.Name = "btnFCancelar";
            this.btnFCancelar.Size = new System.Drawing.Size(178, 23);
            this.btnFCancelar.TabIndex = 25;
            this.btnFCancelar.Text = "Cancelar";
            this.btnFCancelar.UseVisualStyleBackColor = true;
            this.btnFCancelar.Click += new System.EventHandler(this.btnFCancelar_Click);
            // 
            // btnFReserva
            // 
            this.btnFReserva.Location = new System.Drawing.Point(878, 367);
            this.btnFReserva.Name = "btnFReserva";
            this.btnFReserva.Size = new System.Drawing.Size(200, 23);
            this.btnFReserva.TabIndex = 24;
            this.btnFReserva.Text = "Seleccionar Puestos";
            this.btnFReserva.UseVisualStyleBackColor = true;
            this.btnFReserva.Click += new System.EventHandler(this.btnFReserva_Click);
            // 
            // tbNameV4
            // 
            this.tbNameV4.Location = new System.Drawing.Point(12, 317);
            this.tbNameV4.Name = "tbNameV4";
            this.tbNameV4.Size = new System.Drawing.Size(223, 20);
            this.tbNameV4.TabIndex = 23;
            // 
            // tbNameV3
            // 
            this.tbNameV3.Location = new System.Drawing.Point(12, 270);
            this.tbNameV3.Name = "tbNameV3";
            this.tbNameV3.Size = new System.Drawing.Size(223, 20);
            this.tbNameV3.TabIndex = 21;
            // 
            // tbNameV2
            // 
            this.tbNameV2.Location = new System.Drawing.Point(12, 220);
            this.tbNameV2.Name = "tbNameV2";
            this.tbNameV2.Size = new System.Drawing.Size(223, 20);
            this.tbNameV2.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nombre del Viajero";
            // 
            // tbNameV1
            // 
            this.tbNameV1.Location = new System.Drawing.Point(12, 172);
            this.tbNameV1.Name = "tbNameV1";
            this.tbNameV1.Size = new System.Drawing.Size(223, 20);
            this.tbNameV1.TabIndex = 16;
            // 
            // tbCiudadDestino
            // 
            this.tbCiudadDestino.Location = new System.Drawing.Point(504, 29);
            this.tbCiudadDestino.Name = "tbCiudadDestino";
            this.tbCiudadDestino.Size = new System.Drawing.Size(130, 20);
            this.tbCiudadDestino.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(501, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ciudad Destino";
            // 
            // dtpFechaRegreso
            // 
            this.dtpFechaRegreso.Location = new System.Drawing.Point(879, 75);
            this.dtpFechaRegreso.Name = "dtpFechaRegreso";
            this.dtpFechaRegreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRegreso.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(876, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fecha Regreso";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(672, 75);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaSalida.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(669, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha Salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo Plan";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(285, 75);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // tbNroID
            // 
            this.tbNroID.Location = new System.Drawing.Point(128, 75);
            this.tbNroID.Name = "tbNroID";
            this.tbNroID.Size = new System.Drawing.Size(147, 20);
            this.tbNroID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numero Identificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Identificación";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de quien reserva";
            // 
            // tbNameR
            // 
            this.tbNameR.Location = new System.Drawing.Point(14, 32);
            this.tbNameR.Name = "tbNameR";
            this.tbNameR.Size = new System.Drawing.Size(471, 20);
            this.tbNameR.TabIndex = 0;
            // 
            // btnConsultarReservas
            // 
            this.btnConsultarReservas.Location = new System.Drawing.Point(573, 95);
            this.btnConsultarReservas.Name = "btnConsultarReservas";
            this.btnConsultarReservas.Size = new System.Drawing.Size(171, 23);
            this.btnConsultarReservas.TabIndex = 7;
            this.btnConsultarReservas.Text = "Consultar Reservas";
            this.btnConsultarReservas.UseVisualStyleBackColor = true;
            this.btnConsultarReservas.Click += new System.EventHandler(this.btnConsultarReservas_Click);
            // 
            // pnroReserva
            // 
            this.pnroReserva.Controls.Add(this.btnDoIt);
            this.pnroReserva.Controls.Add(this.tbNROCONS);
            this.pnroReserva.Controls.Add(this.labNroReserva);
            this.pnroReserva.Location = new System.Drawing.Point(452, 124);
            this.pnroReserva.Name = "pnroReserva";
            this.pnroReserva.Size = new System.Drawing.Size(250, 75);
            this.pnroReserva.TabIndex = 8;
            // 
            // btnDoIt
            // 
            this.btnDoIt.Location = new System.Drawing.Point(7, 42);
            this.btnDoIt.Name = "btnDoIt";
            this.btnDoIt.Size = new System.Drawing.Size(234, 27);
            this.btnDoIt.TabIndex = 2;
            this.btnDoIt.Text = "button1";
            this.btnDoIt.UseVisualStyleBackColor = true;
            this.btnDoIt.Click += new System.EventHandler(this.btnDoIt_Click);
            // 
            // tbNROCONS
            // 
            this.tbNROCONS.Location = new System.Drawing.Point(7, 16);
            this.tbNROCONS.Name = "tbNROCONS";
            this.tbNROCONS.Size = new System.Drawing.Size(234, 20);
            this.tbNROCONS.TabIndex = 1;
            // 
            // labNroReserva
            // 
            this.labNroReserva.AutoSize = true;
            this.labNroReserva.Location = new System.Drawing.Point(52, 0);
            this.labNroReserva.Name = "labNroReserva";
            this.labNroReserva.Size = new System.Drawing.Size(122, 13);
            this.labNroReserva.TabIndex = 0;
            this.labNroReserva.Text = "Ingrese Nro De Reserva";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 625);
            this.Controls.Add(this.pnroReserva);
            this.Controls.Add(this.btnConsultarReservas);
            this.Controls.Add(this.PanelReserva);
            this.Controls.Add(this.btnEstadoAvio);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelReserva.ResumeLayout(false);
            this.PanelReserva.PerformLayout();
            this.pnroReserva.ResumeLayout(false);
            this.pnroReserva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEstadoAvio;
        private System.Windows.Forms.Panel PanelReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameR;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNroID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCiudadDestino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaRegreso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFReserva;
        private System.Windows.Forms.TextBox tbNameV4;
        private System.Windows.Forms.TextBox tbNameV3;
        private System.Windows.Forms.TextBox tbNameV2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNameV1;
        private System.Windows.Forms.Button btnFCancelar;
        private System.Windows.Forms.Button btnConsultarReservas;
        private System.Windows.Forms.ListBox cbTipoID;
        private System.Windows.Forms.ListBox cbTipoPlan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpFNacimientoV4;
        private System.Windows.Forms.DateTimePicker dtpFNacimientoV3;
        private System.Windows.Forms.DateTimePicker dtpFNacimientoV2;
        private System.Windows.Forms.DateTimePicker dtpFNacimientoV1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbnroIDV4;
        private System.Windows.Forms.TextBox tbnroIDV3;
        private System.Windows.Forms.TextBox tbnroIDV2;
        private System.Windows.Forms.TextBox tbnroIDV1;
        private System.Windows.Forms.ListBox cbTipoIDV4;
        private System.Windows.Forms.ListBox cbTipoIDV3;
        private System.Windows.Forms.ListBox cbTipoIDV2;
        private System.Windows.Forms.ListBox cbTipoIDV1;
        private System.Windows.Forms.Panel pnroReserva;
        private System.Windows.Forms.TextBox tbNROCONS;
        private System.Windows.Forms.Label labNroReserva;
        private System.Windows.Forms.Button btnDoIt;
    }
}

