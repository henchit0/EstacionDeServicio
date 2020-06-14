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
			this.gbxDatosEstacion = new System.Windows.Forms.GroupBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblCUIT = new System.Windows.Forms.Label();
			this.lblStationName = new System.Windows.Forms.Label();
			this.btnDiesel = new System.Windows.Forms.Button();
			this.btnSuper = new System.Windows.Forms.Button();
			this.btnPremium = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblMontoTotalDiesel = new System.Windows.Forms.Label();
			this.lblTotalLitrosDiesel = new System.Windows.Forms.Label();
			this.lblCantOperacionesDiesel = new System.Windows.Forms.Label();
			this.lblDisponibleDiesel = new System.Windows.Forms.Label();
			this.lblCapacidadDiesel = new System.Windows.Forms.Label();
			this.lblPlayeroDiesel = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblMontoTotalSuper = new System.Windows.Forms.Label();
			this.lblPlayeroSuper = new System.Windows.Forms.Label();
			this.lblTotalLitrosSuper = new System.Windows.Forms.Label();
			this.lblCapacidadSuper = new System.Windows.Forms.Label();
			this.lblCantOperacionesSuper = new System.Windows.Forms.Label();
			this.lblDisponibleSuper = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.lblMontoTotalPremium = new System.Windows.Forms.Label();
			this.lblPlayeroPremium = new System.Windows.Forms.Label();
			this.lblTotalLitrosPremium = new System.Windows.Forms.Label();
			this.lblCapacidadPremium = new System.Windows.Forms.Label();
			this.lblCantOperacionesPremium = new System.Windows.Forms.Label();
			this.lblDisponiblePremium = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblHours = new System.Windows.Forms.Label();
			this.gbxDatosEstacion.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbxDatosEstacion
			// 
			this.gbxDatosEstacion.Controls.Add(this.lblHours);
			this.gbxDatosEstacion.Controls.Add(this.lblPhone);
			this.gbxDatosEstacion.Controls.Add(this.lblAddress);
			this.gbxDatosEstacion.Controls.Add(this.lblCUIT);
			this.gbxDatosEstacion.Controls.Add(this.lblStationName);
			this.gbxDatosEstacion.ForeColor = System.Drawing.Color.Navy;
			this.gbxDatosEstacion.Location = new System.Drawing.Point(12, 12);
			this.gbxDatosEstacion.Name = "gbxDatosEstacion";
			this.gbxDatosEstacion.Size = new System.Drawing.Size(704, 103);
			this.gbxDatosEstacion.TabIndex = 3;
			this.gbxDatosEstacion.TabStop = false;
			this.gbxDatosEstacion.Text = "Datos de la estación";
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
			this.lblStationName.AutoSize = true;
			this.lblStationName.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStationName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.lblStationName.Location = new System.Drawing.Point(210, 16);
			this.lblStationName.Name = "lblStationName";
			this.lblStationName.Size = new System.Drawing.Size(304, 25);
			this.lblStationName.TabIndex = 0;
			this.lblStationName.Text = "NOMBRE DE LA ESTACIÓN";
			this.lblStationName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnDiesel
			// 
			this.btnDiesel.Location = new System.Drawing.Point(44, 168);
			this.btnDiesel.Margin = new System.Windows.Forms.Padding(2);
			this.btnDiesel.Name = "btnDiesel";
			this.btnDiesel.Size = new System.Drawing.Size(88, 32);
			this.btnDiesel.TabIndex = 1;
			this.btnDiesel.Text = "Diesel";
			this.btnDiesel.UseVisualStyleBackColor = true;
			this.btnDiesel.Click += new System.EventHandler(this.btnDiesel_Click);
			// 
			// btnSuper
			// 
			this.btnSuper.Location = new System.Drawing.Point(236, 168);
			this.btnSuper.Margin = new System.Windows.Forms.Padding(2);
			this.btnSuper.Name = "btnSuper";
			this.btnSuper.Size = new System.Drawing.Size(88, 32);
			this.btnSuper.TabIndex = 2;
			this.btnSuper.Text = "Super";
			this.btnSuper.UseVisualStyleBackColor = true;
			this.btnSuper.Click += new System.EventHandler(this.btnSuper_Click);
			// 
			// btnPremium
			// 
			this.btnPremium.Location = new System.Drawing.Point(446, 168);
			this.btnPremium.Margin = new System.Windows.Forms.Padding(2);
			this.btnPremium.Name = "btnPremium";
			this.btnPremium.Size = new System.Drawing.Size(88, 32);
			this.btnPremium.TabIndex = 3;
			this.btnPremium.Text = "Premium";
			this.btnPremium.UseVisualStyleBackColor = true;
			this.btnPremium.Click += new System.EventHandler(this.btnPremium_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblMontoTotalDiesel);
			this.groupBox2.Controls.Add(this.lblTotalLitrosDiesel);
			this.groupBox2.Controls.Add(this.lblCantOperacionesDiesel);
			this.groupBox2.Controls.Add(this.lblDisponibleDiesel);
			this.groupBox2.Controls.Add(this.lblCapacidadDiesel);
			this.groupBox2.Controls.Add(this.lblPlayeroDiesel);
			this.groupBox2.Location = new System.Drawing.Point(25, 206);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(130, 130);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// lblMontoTotalDiesel
			// 
			this.lblMontoTotalDiesel.AutoSize = true;
			this.lblMontoTotalDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMontoTotalDiesel.Location = new System.Drawing.Point(4, 100);
			this.lblMontoTotalDiesel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblMontoTotalDiesel.Name = "lblMontoTotalDiesel";
			this.lblMontoTotalDiesel.Size = new System.Drawing.Size(69, 15);
			this.lblMontoTotalDiesel.TabIndex = 3;
			this.lblMontoTotalDiesel.Text = "montoTotal";
			// 
			// lblTotalLitrosDiesel
			// 
			this.lblTotalLitrosDiesel.AutoSize = true;
			this.lblTotalLitrosDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalLitrosDiesel.Location = new System.Drawing.Point(5, 83);
			this.lblTotalLitrosDiesel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblTotalLitrosDiesel.Name = "lblTotalLitrosDiesel";
			this.lblTotalLitrosDiesel.Size = new System.Drawing.Size(60, 15);
			this.lblTotalLitrosDiesel.TabIndex = 3;
			this.lblTotalLitrosDiesel.Text = "totalLitros";
			this.lblTotalLitrosDiesel.Click += new System.EventHandler(this.lblTotalLitrosDiesel_Click);
			// 
			// lblCantOperacionesDiesel
			// 
			this.lblCantOperacionesDiesel.AutoSize = true;
			this.lblCantOperacionesDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantOperacionesDiesel.Location = new System.Drawing.Point(4, 66);
			this.lblCantOperacionesDiesel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblCantOperacionesDiesel.Name = "lblCantOperacionesDiesel";
			this.lblCantOperacionesDiesel.Size = new System.Drawing.Size(100, 15);
			this.lblCantOperacionesDiesel.TabIndex = 3;
			this.lblCantOperacionesDiesel.Text = "cantOperaciones";
			this.lblCantOperacionesDiesel.Click += new System.EventHandler(this.lblOperacionesDiesel_Click);
			// 
			// lblDisponibleDiesel
			// 
			this.lblDisponibleDiesel.AutoSize = true;
			this.lblDisponibleDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisponibleDiesel.Location = new System.Drawing.Point(4, 49);
			this.lblDisponibleDiesel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblDisponibleDiesel.Name = "lblDisponibleDiesel";
			this.lblDisponibleDiesel.Size = new System.Drawing.Size(64, 15);
			this.lblDisponibleDiesel.TabIndex = 3;
			this.lblDisponibleDiesel.Text = "disponible";
			this.lblDisponibleDiesel.Click += new System.EventHandler(this.lblDisponibleDiesel_Click);
			// 
			// lblCapacidadDiesel
			// 
			this.lblCapacidadDiesel.AutoSize = true;
			this.lblCapacidadDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCapacidadDiesel.Location = new System.Drawing.Point(4, 32);
			this.lblCapacidadDiesel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblCapacidadDiesel.Name = "lblCapacidadDiesel";
			this.lblCapacidadDiesel.Size = new System.Drawing.Size(64, 15);
			this.lblCapacidadDiesel.TabIndex = 3;
			this.lblCapacidadDiesel.Text = "capacidad";
			this.lblCapacidadDiesel.Click += new System.EventHandler(this.lblCapacidadDiesel_Click);
			// 
			// lblPlayeroDiesel
			// 
			this.lblPlayeroDiesel.AutoSize = true;
			this.lblPlayeroDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayeroDiesel.Location = new System.Drawing.Point(4, 15);
			this.lblPlayeroDiesel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblPlayeroDiesel.Name = "lblPlayeroDiesel";
			this.lblPlayeroDiesel.Size = new System.Drawing.Size(47, 15);
			this.lblPlayeroDiesel.TabIndex = 3;
			this.lblPlayeroDiesel.Text = "playero";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lblMontoTotalSuper);
			this.groupBox3.Controls.Add(this.lblPlayeroSuper);
			this.groupBox3.Controls.Add(this.lblTotalLitrosSuper);
			this.groupBox3.Controls.Add(this.lblCapacidadSuper);
			this.groupBox3.Controls.Add(this.lblCantOperacionesSuper);
			this.groupBox3.Controls.Add(this.lblDisponibleSuper);
			this.groupBox3.Location = new System.Drawing.Point(220, 206);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox3.Size = new System.Drawing.Size(130, 130);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			// 
			// lblMontoTotalSuper
			// 
			this.lblMontoTotalSuper.AutoSize = true;
			this.lblMontoTotalSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMontoTotalSuper.Location = new System.Drawing.Point(4, 100);
			this.lblMontoTotalSuper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblMontoTotalSuper.Name = "lblMontoTotalSuper";
			this.lblMontoTotalSuper.Size = new System.Drawing.Size(69, 15);
			this.lblMontoTotalSuper.TabIndex = 4;
			this.lblMontoTotalSuper.Text = "montoTotal";
			// 
			// lblPlayeroSuper
			// 
			this.lblPlayeroSuper.AutoSize = true;
			this.lblPlayeroSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayeroSuper.Location = new System.Drawing.Point(4, 15);
			this.lblPlayeroSuper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblPlayeroSuper.Name = "lblPlayeroSuper";
			this.lblPlayeroSuper.Size = new System.Drawing.Size(47, 15);
			this.lblPlayeroSuper.TabIndex = 9;
			this.lblPlayeroSuper.Text = "playero";
			// 
			// lblTotalLitrosSuper
			// 
			this.lblTotalLitrosSuper.AutoSize = true;
			this.lblTotalLitrosSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalLitrosSuper.Location = new System.Drawing.Point(5, 83);
			this.lblTotalLitrosSuper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblTotalLitrosSuper.Name = "lblTotalLitrosSuper";
			this.lblTotalLitrosSuper.Size = new System.Drawing.Size(60, 15);
			this.lblTotalLitrosSuper.TabIndex = 5;
			this.lblTotalLitrosSuper.Text = "totalLitros";
			// 
			// lblCapacidadSuper
			// 
			this.lblCapacidadSuper.AutoSize = true;
			this.lblCapacidadSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCapacidadSuper.Location = new System.Drawing.Point(4, 32);
			this.lblCapacidadSuper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblCapacidadSuper.Name = "lblCapacidadSuper";
			this.lblCapacidadSuper.Size = new System.Drawing.Size(64, 15);
			this.lblCapacidadSuper.TabIndex = 8;
			this.lblCapacidadSuper.Text = "capacidad";
			// 
			// lblCantOperacionesSuper
			// 
			this.lblCantOperacionesSuper.AutoSize = true;
			this.lblCantOperacionesSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantOperacionesSuper.Location = new System.Drawing.Point(4, 66);
			this.lblCantOperacionesSuper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblCantOperacionesSuper.Name = "lblCantOperacionesSuper";
			this.lblCantOperacionesSuper.Size = new System.Drawing.Size(100, 15);
			this.lblCantOperacionesSuper.TabIndex = 6;
			this.lblCantOperacionesSuper.Text = "cantOperaciones";
			// 
			// lblDisponibleSuper
			// 
			this.lblDisponibleSuper.AutoSize = true;
			this.lblDisponibleSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisponibleSuper.Location = new System.Drawing.Point(4, 49);
			this.lblDisponibleSuper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblDisponibleSuper.Name = "lblDisponibleSuper";
			this.lblDisponibleSuper.Size = new System.Drawing.Size(64, 15);
			this.lblDisponibleSuper.TabIndex = 7;
			this.lblDisponibleSuper.Text = "disponible";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lblMontoTotalPremium);
			this.groupBox4.Controls.Add(this.lblPlayeroPremium);
			this.groupBox4.Controls.Add(this.lblTotalLitrosPremium);
			this.groupBox4.Controls.Add(this.lblCapacidadPremium);
			this.groupBox4.Controls.Add(this.lblCantOperacionesPremium);
			this.groupBox4.Controls.Add(this.lblDisponiblePremium);
			this.groupBox4.Location = new System.Drawing.Point(431, 206);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox4.Size = new System.Drawing.Size(128, 130);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			// 
			// lblMontoTotalPremium
			// 
			this.lblMontoTotalPremium.AutoSize = true;
			this.lblMontoTotalPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMontoTotalPremium.Location = new System.Drawing.Point(4, 100);
			this.lblMontoTotalPremium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblMontoTotalPremium.Name = "lblMontoTotalPremium";
			this.lblMontoTotalPremium.Size = new System.Drawing.Size(69, 15);
			this.lblMontoTotalPremium.TabIndex = 10;
			this.lblMontoTotalPremium.Text = "montoTotal";
			// 
			// lblPlayeroPremium
			// 
			this.lblPlayeroPremium.AutoSize = true;
			this.lblPlayeroPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayeroPremium.Location = new System.Drawing.Point(4, 15);
			this.lblPlayeroPremium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblPlayeroPremium.Name = "lblPlayeroPremium";
			this.lblPlayeroPremium.Size = new System.Drawing.Size(47, 15);
			this.lblPlayeroPremium.TabIndex = 15;
			this.lblPlayeroPremium.Text = "playero";
			// 
			// lblTotalLitrosPremium
			// 
			this.lblTotalLitrosPremium.AutoSize = true;
			this.lblTotalLitrosPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalLitrosPremium.Location = new System.Drawing.Point(5, 83);
			this.lblTotalLitrosPremium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblTotalLitrosPremium.Name = "lblTotalLitrosPremium";
			this.lblTotalLitrosPremium.Size = new System.Drawing.Size(60, 15);
			this.lblTotalLitrosPremium.TabIndex = 11;
			this.lblTotalLitrosPremium.Text = "totalLitros";
			// 
			// lblCapacidadPremium
			// 
			this.lblCapacidadPremium.AutoSize = true;
			this.lblCapacidadPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCapacidadPremium.Location = new System.Drawing.Point(4, 32);
			this.lblCapacidadPremium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblCapacidadPremium.Name = "lblCapacidadPremium";
			this.lblCapacidadPremium.Size = new System.Drawing.Size(64, 15);
			this.lblCapacidadPremium.TabIndex = 14;
			this.lblCapacidadPremium.Text = "capacidad";
			// 
			// lblCantOperacionesPremium
			// 
			this.lblCantOperacionesPremium.AutoSize = true;
			this.lblCantOperacionesPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantOperacionesPremium.Location = new System.Drawing.Point(4, 66);
			this.lblCantOperacionesPremium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblCantOperacionesPremium.Name = "lblCantOperacionesPremium";
			this.lblCantOperacionesPremium.Size = new System.Drawing.Size(100, 15);
			this.lblCantOperacionesPremium.TabIndex = 12;
			this.lblCantOperacionesPremium.Text = "cantOperaciones";
			// 
			// lblDisponiblePremium
			// 
			this.lblDisponiblePremium.AutoSize = true;
			this.lblDisponiblePremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisponiblePremium.Location = new System.Drawing.Point(4, 49);
			this.lblDisponiblePremium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
			this.lblDisponiblePremium.Name = "lblDisponiblePremium";
			this.lblDisponiblePremium.Size = new System.Drawing.Size(64, 15);
			this.lblDisponiblePremium.TabIndex = 13;
			this.lblDisponiblePremium.Text = "disponible";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label3);
			this.groupBox5.Controls.Add(this.label2);
			this.groupBox5.Controls.Add(this.label1);
			this.groupBox5.Location = new System.Drawing.Point(32, 342);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(524, 113);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "groupBox5";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(226, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "label3";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(226, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "label2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(226, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPhone.Location = new System.Drawing.Point(494, 50);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(92, 16);
			this.lblPhone.TabIndex = 3;
			this.lblPhone.Text = "TELEFONO:";
			// 
			// lblHours
			// 
			this.lblHours.AutoSize = true;
			this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHours.Location = new System.Drawing.Point(494, 74);
			this.lblHours.Name = "lblHours";
			this.lblHours.Size = new System.Drawing.Size(187, 16);
			this.lblHours.TabIndex = 4;
			this.lblHours.Text = "HORARIO DE ATENCION:";
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(715, 571);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnPremium);
			this.Controls.Add(this.btnSuper);
			this.Controls.Add(this.btnDiesel);
			this.Controls.Add(this.gbxDatosEstacion);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmMenu";
			this.gbxDatosEstacion.ResumeLayout(false);
			this.gbxDatosEstacion.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatosEstacion;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblStationName;
        private System.Windows.Forms.Button btnDiesel;
        private System.Windows.Forms.Button btnPremium;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSuper;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPlayeroDiesel;
        private System.Windows.Forms.Label lblMontoTotalDiesel;
        private System.Windows.Forms.Label lblTotalLitrosDiesel;
        private System.Windows.Forms.Label lblCantOperacionesDiesel;
        private System.Windows.Forms.Label lblDisponibleDiesel;
        private System.Windows.Forms.Label lblCapacidadDiesel;
        private System.Windows.Forms.Label lblMontoTotalSuper;
        private System.Windows.Forms.Label lblPlayeroSuper;
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblHours;
		private System.Windows.Forms.Label lblPhone;
	}
}

