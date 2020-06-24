namespace EstacionDeServicio
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.gbxDatosEstacion = new System.Windows.Forms.GroupBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.lblStationName = new System.Windows.Forms.Label();
            this.btnDiesel = new System.Windows.Forms.Button();
            this.btnSuper = new System.Windows.Forms.Button();
            this.btnPremium = new System.Windows.Forms.Button();
            this.gbxDiesel = new System.Windows.Forms.GroupBox();
            this.lblMontoTotalDiesel = new System.Windows.Forms.Label();
            this.lblTotalLitrosDiesel = new System.Windows.Forms.Label();
            this.lblCantOperacionesDiesel = new System.Windows.Forms.Label();
            this.lblDisponibleDiesel = new System.Windows.Forms.Label();
            this.lblCapacidadDiesel = new System.Windows.Forms.Label();
            this.lblPlayeroDiesel = new System.Windows.Forms.Label();
            this.gbxSuper = new System.Windows.Forms.GroupBox();
            this.lblMontoTotalSuper = new System.Windows.Forms.Label();
            this.lblPlayeroSuper = new System.Windows.Forms.Label();
            this.lblTotalLitrosSuper = new System.Windows.Forms.Label();
            this.lblCapacidadSuper = new System.Windows.Forms.Label();
            this.lblCantOperacionesSuper = new System.Windows.Forms.Label();
            this.lblDisponibleSuper = new System.Windows.Forms.Label();
            this.gbxPremiun = new System.Windows.Forms.GroupBox();
            this.lblMontoTotalPremium = new System.Windows.Forms.Label();
            this.lblPlayeroPremium = new System.Windows.Forms.Label();
            this.lblTotalLitrosPremium = new System.Windows.Forms.Label();
            this.lblCapacidadPremium = new System.Windows.Forms.Label();
            this.lblCantOperacionesPremium = new System.Windows.Forms.Label();
            this.lblDisponiblePremium = new System.Windows.Forms.Label();
            this.gbxTotalGeneral = new System.Windows.Forms.GroupBox();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblTotalFacturado = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbxDatosEstacion.SuspendLayout();
            this.gbxDiesel.SuspendLayout();
            this.gbxSuper.SuspendLayout();
            this.gbxPremiun.SuspendLayout();
            this.gbxTotalGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatosEstacion
            // 
            this.gbxDatosEstacion.Controls.Add(this.lblHours);
            this.gbxDatosEstacion.Controls.Add(this.lblPhone);
            this.gbxDatosEstacion.Controls.Add(this.lblAddress);
            this.gbxDatosEstacion.Controls.Add(this.lblCUIT);
            this.gbxDatosEstacion.Controls.Add(this.lblStationName);
            this.gbxDatosEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosEstacion.ForeColor = System.Drawing.Color.Navy;
            this.gbxDatosEstacion.Location = new System.Drawing.Point(12, 12);
            this.gbxDatosEstacion.Name = "gbxDatosEstacion";
            this.gbxDatosEstacion.Size = new System.Drawing.Size(704, 103);
            this.gbxDatosEstacion.TabIndex = 3;
            this.gbxDatosEstacion.TabStop = false;
            this.gbxDatosEstacion.Text = "Datos de la estación";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(494, 74);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(149, 16);
            this.lblHours.TabIndex = 4;
            this.lblHours.Text = "Horario de atencion:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(494, 50);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(74, 16);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Telefono:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(11, 74);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(74, 16);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Dirección";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.Location = new System.Drawing.Point(11, 50);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(47, 16);
            this.lblCUIT.TabIndex = 1;
            this.lblCUIT.Text = "CUIT:";
            // 
            // lblStationName
            // 
            this.lblStationName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStationName.AutoSize = true;
            this.lblStationName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStationName.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblStationName.Location = new System.Drawing.Point(195, 16);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(316, 25);
            this.lblStationName.TabIndex = 0;
            this.lblStationName.Text = "NOMBRE DE LA ESTACIÓN";
            this.lblStationName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDiesel
            // 
            this.btnDiesel.BackColor = System.Drawing.Color.Teal;
            this.btnDiesel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiesel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiesel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnDiesel.Location = new System.Drawing.Point(12, 137);
            this.btnDiesel.Name = "btnDiesel";
            this.btnDiesel.Size = new System.Drawing.Size(206, 66);
            this.btnDiesel.TabIndex = 1;
            this.btnDiesel.Text = "Diesel";
            this.btnDiesel.UseVisualStyleBackColor = false;
            this.btnDiesel.Click += new System.EventHandler(this.btnDiesel_Click);
            // 
            // btnSuper
            // 
            this.btnSuper.BackColor = System.Drawing.Color.Maroon;
            this.btnSuper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuper.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnSuper.Location = new System.Drawing.Point(257, 137);
            this.btnSuper.Name = "btnSuper";
            this.btnSuper.Size = new System.Drawing.Size(207, 66);
            this.btnSuper.TabIndex = 2;
            this.btnSuper.Text = "Super";
            this.btnSuper.UseVisualStyleBackColor = false;
            this.btnSuper.Click += new System.EventHandler(this.btnSuper_Click);
            // 
            // btnPremium
            // 
            this.btnPremium.BackColor = System.Drawing.Color.Green;
            this.btnPremium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPremium.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPremium.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnPremium.Location = new System.Drawing.Point(509, 136);
            this.btnPremium.Name = "btnPremium";
            this.btnPremium.Size = new System.Drawing.Size(207, 66);
            this.btnPremium.TabIndex = 3;
            this.btnPremium.Text = "Premium";
            this.btnPremium.UseVisualStyleBackColor = false;
            this.btnPremium.Click += new System.EventHandler(this.btnPremium_Click);
            // 
            // gbxDiesel
            // 
            this.gbxDiesel.Controls.Add(this.lblMontoTotalDiesel);
            this.gbxDiesel.Controls.Add(this.lblTotalLitrosDiesel);
            this.gbxDiesel.Controls.Add(this.lblCantOperacionesDiesel);
            this.gbxDiesel.Controls.Add(this.lblDisponibleDiesel);
            this.gbxDiesel.Controls.Add(this.lblCapacidadDiesel);
            this.gbxDiesel.Controls.Add(this.lblPlayeroDiesel);
            this.gbxDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDiesel.ForeColor = System.Drawing.Color.Teal;
            this.gbxDiesel.Location = new System.Drawing.Point(12, 241);
            this.gbxDiesel.Name = "gbxDiesel";
            this.gbxDiesel.Size = new System.Drawing.Size(206, 239);
            this.gbxDiesel.TabIndex = 3;
            this.gbxDiesel.TabStop = false;
            this.gbxDiesel.Text = "Diesel";
            this.gbxDiesel.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblMontoTotalDiesel
            // 
            this.lblMontoTotalDiesel.AutoSize = true;
            this.lblMontoTotalDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotalDiesel.Location = new System.Drawing.Point(7, 185);
            this.lblMontoTotalDiesel.Margin = new System.Windows.Forms.Padding(3);
            this.lblMontoTotalDiesel.Name = "lblMontoTotalDiesel";
            this.lblMontoTotalDiesel.Size = new System.Drawing.Size(99, 20);
            this.lblMontoTotalDiesel.TabIndex = 3;
            this.lblMontoTotalDiesel.Text = "montoTotal";
            // 
            // lblTotalLitrosDiesel
            // 
            this.lblTotalLitrosDiesel.AutoSize = true;
            this.lblTotalLitrosDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLitrosDiesel.Location = new System.Drawing.Point(7, 165);
            this.lblTotalLitrosDiesel.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotalLitrosDiesel.Name = "lblTotalLitrosDiesel";
            this.lblTotalLitrosDiesel.Size = new System.Drawing.Size(90, 20);
            this.lblTotalLitrosDiesel.TabIndex = 3;
            this.lblTotalLitrosDiesel.Text = "totalLitros";
            this.lblTotalLitrosDiesel.Click += new System.EventHandler(this.lblTotalLitrosDiesel_Click);
            // 
            // lblCantOperacionesDiesel
            // 
            this.lblCantOperacionesDiesel.AutoSize = true;
            this.lblCantOperacionesDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantOperacionesDiesel.Location = new System.Drawing.Point(7, 145);
            this.lblCantOperacionesDiesel.Margin = new System.Windows.Forms.Padding(3);
            this.lblCantOperacionesDiesel.Name = "lblCantOperacionesDiesel";
            this.lblCantOperacionesDiesel.Size = new System.Drawing.Size(145, 20);
            this.lblCantOperacionesDiesel.TabIndex = 3;
            this.lblCantOperacionesDiesel.Text = "cantOperaciones";
            this.lblCantOperacionesDiesel.Click += new System.EventHandler(this.lblOperacionesDiesel_Click);
            // 
            // lblDisponibleDiesel
            // 
            this.lblDisponibleDiesel.AutoSize = true;
            this.lblDisponibleDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibleDiesel.Location = new System.Drawing.Point(7, 103);
            this.lblDisponibleDiesel.Margin = new System.Windows.Forms.Padding(3);
            this.lblDisponibleDiesel.Name = "lblDisponibleDiesel";
            this.lblDisponibleDiesel.Size = new System.Drawing.Size(90, 20);
            this.lblDisponibleDiesel.TabIndex = 3;
            this.lblDisponibleDiesel.Text = "disponible";
            this.lblDisponibleDiesel.Click += new System.EventHandler(this.lblDisponibleDiesel_Click);
            // 
            // lblCapacidadDiesel
            // 
            this.lblCapacidadDiesel.AutoSize = true;
            this.lblCapacidadDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadDiesel.Location = new System.Drawing.Point(7, 83);
            this.lblCapacidadDiesel.Margin = new System.Windows.Forms.Padding(3);
            this.lblCapacidadDiesel.Name = "lblCapacidadDiesel";
            this.lblCapacidadDiesel.Size = new System.Drawing.Size(91, 20);
            this.lblCapacidadDiesel.TabIndex = 3;
            this.lblCapacidadDiesel.Text = "capacidad";
            this.lblCapacidadDiesel.Click += new System.EventHandler(this.lblCapacidadDiesel_Click);
            // 
            // lblPlayeroDiesel
            // 
            this.lblPlayeroDiesel.AutoSize = true;
            this.lblPlayeroDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayeroDiesel.Location = new System.Drawing.Point(10, 40);
            this.lblPlayeroDiesel.Margin = new System.Windows.Forms.Padding(3);
            this.lblPlayeroDiesel.Name = "lblPlayeroDiesel";
            this.lblPlayeroDiesel.Size = new System.Drawing.Size(61, 20);
            this.lblPlayeroDiesel.TabIndex = 3;
            this.lblPlayeroDiesel.Text = "Playero";
            // 
            // gbxSuper
            // 
            this.gbxSuper.Controls.Add(this.lblMontoTotalSuper);
            this.gbxSuper.Controls.Add(this.lblPlayeroSuper);
            this.gbxSuper.Controls.Add(this.lblTotalLitrosSuper);
            this.gbxSuper.Controls.Add(this.lblCapacidadSuper);
            this.gbxSuper.Controls.Add(this.lblCantOperacionesSuper);
            this.gbxSuper.Controls.Add(this.lblDisponibleSuper);
            this.gbxSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSuper.ForeColor = System.Drawing.Color.Maroon;
            this.gbxSuper.Location = new System.Drawing.Point(257, 241);
            this.gbxSuper.Name = "gbxSuper";
            this.gbxSuper.Size = new System.Drawing.Size(207, 239);
            this.gbxSuper.TabIndex = 4;
            this.gbxSuper.TabStop = false;
            this.gbxSuper.Text = "Super";
            // 
            // lblMontoTotalSuper
            // 
            this.lblMontoTotalSuper.AutoSize = true;
            this.lblMontoTotalSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotalSuper.Location = new System.Drawing.Point(7, 185);
            this.lblMontoTotalSuper.Margin = new System.Windows.Forms.Padding(3);
            this.lblMontoTotalSuper.Name = "lblMontoTotalSuper";
            this.lblMontoTotalSuper.Size = new System.Drawing.Size(99, 20);
            this.lblMontoTotalSuper.TabIndex = 4;
            this.lblMontoTotalSuper.Text = "montoTotal";
            // 
            // lblPlayeroSuper
            // 
            this.lblPlayeroSuper.AutoSize = true;
            this.lblPlayeroSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayeroSuper.Location = new System.Drawing.Point(7, 40);
            this.lblPlayeroSuper.Margin = new System.Windows.Forms.Padding(3);
            this.lblPlayeroSuper.Name = "lblPlayeroSuper";
            this.lblPlayeroSuper.Size = new System.Drawing.Size(61, 20);
            this.lblPlayeroSuper.TabIndex = 9;
            this.lblPlayeroSuper.Text = "Playero";
            // 
            // lblTotalLitrosSuper
            // 
            this.lblTotalLitrosSuper.AutoSize = true;
            this.lblTotalLitrosSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLitrosSuper.Location = new System.Drawing.Point(7, 165);
            this.lblTotalLitrosSuper.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotalLitrosSuper.Name = "lblTotalLitrosSuper";
            this.lblTotalLitrosSuper.Size = new System.Drawing.Size(90, 20);
            this.lblTotalLitrosSuper.TabIndex = 5;
            this.lblTotalLitrosSuper.Text = "totalLitros";
            // 
            // lblCapacidadSuper
            // 
            this.lblCapacidadSuper.AutoSize = true;
            this.lblCapacidadSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadSuper.Location = new System.Drawing.Point(7, 83);
            this.lblCapacidadSuper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.lblCapacidadSuper.Name = "lblCapacidadSuper";
            this.lblCapacidadSuper.Size = new System.Drawing.Size(91, 20);
            this.lblCapacidadSuper.TabIndex = 8;
            this.lblCapacidadSuper.Text = "capacidad";
            // 
            // lblCantOperacionesSuper
            // 
            this.lblCantOperacionesSuper.AutoSize = true;
            this.lblCantOperacionesSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantOperacionesSuper.Location = new System.Drawing.Point(7, 145);
            this.lblCantOperacionesSuper.Margin = new System.Windows.Forms.Padding(3);
            this.lblCantOperacionesSuper.Name = "lblCantOperacionesSuper";
            this.lblCantOperacionesSuper.Size = new System.Drawing.Size(145, 20);
            this.lblCantOperacionesSuper.TabIndex = 6;
            this.lblCantOperacionesSuper.Text = "cantOperaciones";
            // 
            // lblDisponibleSuper
            // 
            this.lblDisponibleSuper.AutoSize = true;
            this.lblDisponibleSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibleSuper.Location = new System.Drawing.Point(7, 103);
            this.lblDisponibleSuper.Margin = new System.Windows.Forms.Padding(3);
            this.lblDisponibleSuper.Name = "lblDisponibleSuper";
            this.lblDisponibleSuper.Size = new System.Drawing.Size(90, 20);
            this.lblDisponibleSuper.TabIndex = 7;
            this.lblDisponibleSuper.Text = "disponible";
            // 
            // gbxPremiun
            // 
            this.gbxPremiun.Controls.Add(this.lblMontoTotalPremium);
            this.gbxPremiun.Controls.Add(this.lblPlayeroPremium);
            this.gbxPremiun.Controls.Add(this.lblTotalLitrosPremium);
            this.gbxPremiun.Controls.Add(this.lblCapacidadPremium);
            this.gbxPremiun.Controls.Add(this.lblCantOperacionesPremium);
            this.gbxPremiun.Controls.Add(this.lblDisponiblePremium);
            this.gbxPremiun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPremiun.ForeColor = System.Drawing.Color.Green;
            this.gbxPremiun.Location = new System.Drawing.Point(509, 241);
            this.gbxPremiun.Name = "gbxPremiun";
            this.gbxPremiun.Size = new System.Drawing.Size(207, 239);
            this.gbxPremiun.TabIndex = 4;
            this.gbxPremiun.TabStop = false;
            this.gbxPremiun.Text = "Premiun";
            // 
            // lblMontoTotalPremium
            // 
            this.lblMontoTotalPremium.AutoSize = true;
            this.lblMontoTotalPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotalPremium.Location = new System.Drawing.Point(7, 185);
            this.lblMontoTotalPremium.Margin = new System.Windows.Forms.Padding(3);
            this.lblMontoTotalPremium.Name = "lblMontoTotalPremium";
            this.lblMontoTotalPremium.Size = new System.Drawing.Size(99, 20);
            this.lblMontoTotalPremium.TabIndex = 10;
            this.lblMontoTotalPremium.Text = "montoTotal";
            // 
            // lblPlayeroPremium
            // 
            this.lblPlayeroPremium.AutoSize = true;
            this.lblPlayeroPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayeroPremium.Location = new System.Drawing.Point(7, 40);
            this.lblPlayeroPremium.Margin = new System.Windows.Forms.Padding(3);
            this.lblPlayeroPremium.Name = "lblPlayeroPremium";
            this.lblPlayeroPremium.Size = new System.Drawing.Size(61, 20);
            this.lblPlayeroPremium.TabIndex = 15;
            this.lblPlayeroPremium.Text = "Playero";
            // 
            // lblTotalLitrosPremium
            // 
            this.lblTotalLitrosPremium.AutoSize = true;
            this.lblTotalLitrosPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLitrosPremium.Location = new System.Drawing.Point(7, 165);
            this.lblTotalLitrosPremium.Margin = new System.Windows.Forms.Padding(3);
            this.lblTotalLitrosPremium.Name = "lblTotalLitrosPremium";
            this.lblTotalLitrosPremium.Size = new System.Drawing.Size(90, 20);
            this.lblTotalLitrosPremium.TabIndex = 11;
            this.lblTotalLitrosPremium.Text = "totalLitros";
            // 
            // lblCapacidadPremium
            // 
            this.lblCapacidadPremium.AutoSize = true;
            this.lblCapacidadPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadPremium.Location = new System.Drawing.Point(7, 83);
            this.lblCapacidadPremium.Margin = new System.Windows.Forms.Padding(3);
            this.lblCapacidadPremium.Name = "lblCapacidadPremium";
            this.lblCapacidadPremium.Size = new System.Drawing.Size(91, 20);
            this.lblCapacidadPremium.TabIndex = 14;
            this.lblCapacidadPremium.Text = "capacidad";
            // 
            // lblCantOperacionesPremium
            // 
            this.lblCantOperacionesPremium.AutoSize = true;
            this.lblCantOperacionesPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantOperacionesPremium.Location = new System.Drawing.Point(7, 145);
            this.lblCantOperacionesPremium.Margin = new System.Windows.Forms.Padding(3);
            this.lblCantOperacionesPremium.Name = "lblCantOperacionesPremium";
            this.lblCantOperacionesPremium.Size = new System.Drawing.Size(145, 20);
            this.lblCantOperacionesPremium.TabIndex = 12;
            this.lblCantOperacionesPremium.Text = "cantOperaciones";
            // 
            // lblDisponiblePremium
            // 
            this.lblDisponiblePremium.AutoSize = true;
            this.lblDisponiblePremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponiblePremium.Location = new System.Drawing.Point(7, 103);
            this.lblDisponiblePremium.Margin = new System.Windows.Forms.Padding(3);
            this.lblDisponiblePremium.Name = "lblDisponiblePremium";
            this.lblDisponiblePremium.Size = new System.Drawing.Size(90, 20);
            this.lblDisponiblePremium.TabIndex = 13;
            this.lblDisponiblePremium.Text = "disponible";
            // 
            // gbxTotalGeneral
            // 
            this.gbxTotalGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTotalGeneral.Controls.Add(this.lblMontoTotal);
            this.gbxTotalGeneral.Controls.Add(this.lblTotalFacturado);
            this.gbxTotalGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTotalGeneral.ForeColor = System.Drawing.Color.Navy;
            this.gbxTotalGeneral.Location = new System.Drawing.Point(189, 508);
            this.gbxTotalGeneral.Name = "gbxTotalGeneral";
            this.gbxTotalGeneral.Size = new System.Drawing.Size(369, 86);
            this.gbxTotalGeneral.TabIndex = 5;
            this.gbxTotalGeneral.TabStop = false;
            this.gbxTotalGeneral.Text = "Total General";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(99, 25);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(114, 24);
            this.lblMontoTotal.TabIndex = 1;
            this.lblMontoTotal.Text = "MontoTotal";
            this.lblMontoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalFacturado
            // 
            this.lblTotalFacturado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFacturado.AutoSize = true;
            this.lblTotalFacturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFacturado.Location = new System.Drawing.Point(99, 49);
            this.lblTotalFacturado.Name = "lblTotalFacturado";
            this.lblTotalFacturado.Size = new System.Drawing.Size(156, 24);
            this.lblTotalFacturado.TabIndex = 0;
            this.lblTotalFacturado.Text = "Total Facturado";
            this.lblTotalFacturado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Location = new System.Drawing.Point(644, 568);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 30);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(731, 610);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbxTotalGeneral);
            this.Controls.Add(this.gbxSuper);
            this.Controls.Add(this.gbxPremiun);
            this.Controls.Add(this.gbxDiesel);
            this.Controls.Add(this.btnPremium);
            this.Controls.Add(this.btnSuper);
            this.Controls.Add(this.btnDiesel);
            this.Controls.Add(this.gbxDatosEstacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.gbxDatosEstacion.ResumeLayout(false);
            this.gbxDatosEstacion.PerformLayout();
            this.gbxDiesel.ResumeLayout(false);
            this.gbxDiesel.PerformLayout();
            this.gbxSuper.ResumeLayout(false);
            this.gbxSuper.PerformLayout();
            this.gbxPremiun.ResumeLayout(false);
            this.gbxPremiun.PerformLayout();
            this.gbxTotalGeneral.ResumeLayout(false);
            this.gbxTotalGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatosEstacion;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblStationName;
        private System.Windows.Forms.Button btnDiesel;
        private System.Windows.Forms.Button btnPremium;
        private System.Windows.Forms.GroupBox gbxDiesel;
        private System.Windows.Forms.Button btnSuper;
        private System.Windows.Forms.GroupBox gbxSuper;
        private System.Windows.Forms.GroupBox gbxPremiun;
        private System.Windows.Forms.Label lblPlayeroDiesel;
        private System.Windows.Forms.Label lblMontoTotalDiesel;
        private System.Windows.Forms.Label lblTotalLitrosDiesel;
        private System.Windows.Forms.Label lblCantOperacionesDiesel;
        private System.Windows.Forms.Label lblDisponibleDiesel;
        private System.Windows.Forms.Label lblCapacidadDiesel;
        private System.Windows.Forms.Label lblMontoTotalSuper;
        private System.Windows.Forms.Label lblTotalLitrosSuper;
        private System.Windows.Forms.Label lblCapacidadSuper;
        private System.Windows.Forms.Label lblCantOperacionesSuper;
        private System.Windows.Forms.Label lblDisponibleSuper;
        private System.Windows.Forms.Label lblMontoTotalPremium;
        private System.Windows.Forms.Label lblPlayeroPremium;
        private System.Windows.Forms.Label lblTotalLitrosPremium;
        private System.Windows.Forms.Label lblCapacidadPremium;
        private System.Windows.Forms.Label lblCantOperacionesPremium;
        private System.Windows.Forms.Label lblDisponiblePremium;
        private System.Windows.Forms.GroupBox gbxTotalGeneral;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label lblTotalFacturado;
		private System.Windows.Forms.Label lblHours;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Label lblPlayeroSuper;
	}
}

