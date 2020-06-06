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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMontoTotalSuper = new System.Windows.Forms.Label();
            this.lblTotalLitrosSuper = new System.Windows.Forms.Label();
            this.lblCantOperacionesSuper = new System.Windows.Forms.Label();
            this.lblDisponibleSuper = new System.Windows.Forms.Label();
            this.lblCapacidadSuper = new System.Windows.Forms.Label();
            this.lblPlayeroSuper = new System.Windows.Forms.Label();
            this.lblMontoTotalPremium = new System.Windows.Forms.Label();
            this.lblTotalLitrosPremium = new System.Windows.Forms.Label();
            this.lblCantOperacionesPremium = new System.Windows.Forms.Label();
            this.lblDisponiblePremium = new System.Windows.Forms.Label();
            this.lblCapacidadPremium = new System.Windows.Forms.Label();
            this.lblPlayeroPremium = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblCUIT);
            this.groupBox1.Controls.Add(this.lblStationName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la estación";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(18, 106);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(90, 24);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Dirección";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.Location = new System.Drawing.Point(18, 67);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(57, 24);
            this.lblCUIT.TabIndex = 1;
            this.lblCUIT.Text = "CUIT:";
            // 
            // lblStationName
            // 
            this.lblStationName.AutoSize = true;
            this.lblStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationName.Location = new System.Drawing.Point(18, 32);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(84, 24);
            this.lblStationName.TabIndex = 0;
            this.lblStationName.Text = "Nombre:";
            // 
            // btnDiesel
            // 
            this.btnDiesel.Location = new System.Drawing.Point(59, 207);
            this.btnDiesel.Name = "btnDiesel";
            this.btnDiesel.Size = new System.Drawing.Size(118, 40);
            this.btnDiesel.TabIndex = 1;
            this.btnDiesel.Text = "Diesel";
            this.btnDiesel.UseVisualStyleBackColor = true;
            this.btnDiesel.Click += new System.EventHandler(this.btnDiesel_Click);
            // 
            // btnSuper
            // 
            this.btnSuper.Location = new System.Drawing.Point(314, 207);
            this.btnSuper.Name = "btnSuper";
            this.btnSuper.Size = new System.Drawing.Size(118, 40);
            this.btnSuper.TabIndex = 2;
            this.btnSuper.Text = "Super";
            this.btnSuper.UseVisualStyleBackColor = true;
            this.btnSuper.Click += new System.EventHandler(this.btnSuper_Click);
            // 
            // btnPremium
            // 
            this.btnPremium.Location = new System.Drawing.Point(594, 207);
            this.btnPremium.Name = "btnPremium";
            this.btnPremium.Size = new System.Drawing.Size(118, 40);
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
            this.groupBox2.Location = new System.Drawing.Point(33, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 160);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblMontoTotalDiesel
            // 
            this.lblMontoTotalDiesel.AutoSize = true;
            this.lblMontoTotalDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotalDiesel.Location = new System.Drawing.Point(6, 123);
            this.lblMontoTotalDiesel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblMontoTotalDiesel.Name = "lblMontoTotalDiesel";
            this.lblMontoTotalDiesel.Size = new System.Drawing.Size(84, 18);
            this.lblMontoTotalDiesel.TabIndex = 3;
            this.lblMontoTotalDiesel.Text = "montoTotal";
            // 
            // lblTotalLitrosDiesel
            // 
            this.lblTotalLitrosDiesel.AutoSize = true;
            this.lblTotalLitrosDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLitrosDiesel.Location = new System.Drawing.Point(7, 102);
            this.lblTotalLitrosDiesel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblTotalLitrosDiesel.Name = "lblTotalLitrosDiesel";
            this.lblTotalLitrosDiesel.Size = new System.Drawing.Size(73, 18);
            this.lblTotalLitrosDiesel.TabIndex = 3;
            this.lblTotalLitrosDiesel.Text = "totalLitros";
            this.lblTotalLitrosDiesel.Click += new System.EventHandler(this.lblTotalLitrosDiesel_Click);
            // 
            // lblCantOperacionesDiesel
            // 
            this.lblCantOperacionesDiesel.AutoSize = true;
            this.lblCantOperacionesDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantOperacionesDiesel.Location = new System.Drawing.Point(6, 81);
            this.lblCantOperacionesDiesel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblCantOperacionesDiesel.Name = "lblCantOperacionesDiesel";
            this.lblCantOperacionesDiesel.Size = new System.Drawing.Size(121, 18);
            this.lblCantOperacionesDiesel.TabIndex = 3;
            this.lblCantOperacionesDiesel.Text = "cantOperaciones";
            this.lblCantOperacionesDiesel.Click += new System.EventHandler(this.lblOperacionesDiesel_Click);
            // 
            // lblDisponibleDiesel
            // 
            this.lblDisponibleDiesel.AutoSize = true;
            this.lblDisponibleDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibleDiesel.Location = new System.Drawing.Point(6, 60);
            this.lblDisponibleDiesel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblDisponibleDiesel.Name = "lblDisponibleDiesel";
            this.lblDisponibleDiesel.Size = new System.Drawing.Size(74, 18);
            this.lblDisponibleDiesel.TabIndex = 3;
            this.lblDisponibleDiesel.Text = "disponible";
            this.lblDisponibleDiesel.Click += new System.EventHandler(this.lblDisponibleDiesel_Click);
            // 
            // lblCapacidadDiesel
            // 
            this.lblCapacidadDiesel.AutoSize = true;
            this.lblCapacidadDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadDiesel.Location = new System.Drawing.Point(5, 39);
            this.lblCapacidadDiesel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblCapacidadDiesel.Name = "lblCapacidadDiesel";
            this.lblCapacidadDiesel.Size = new System.Drawing.Size(75, 18);
            this.lblCapacidadDiesel.TabIndex = 3;
            this.lblCapacidadDiesel.Text = "capacidad";
            this.lblCapacidadDiesel.Click += new System.EventHandler(this.lblCapacidadDiesel_Click);
            // 
            // lblPlayeroDiesel
            // 
            this.lblPlayeroDiesel.AutoSize = true;
            this.lblPlayeroDiesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayeroDiesel.Location = new System.Drawing.Point(6, 18);
            this.lblPlayeroDiesel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblPlayeroDiesel.Name = "lblPlayeroDiesel";
            this.lblPlayeroDiesel.Size = new System.Drawing.Size(56, 18);
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
            this.groupBox3.Location = new System.Drawing.Point(293, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 160);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMontoTotalPremium);
            this.groupBox4.Controls.Add(this.lblPlayeroPremium);
            this.groupBox4.Controls.Add(this.lblTotalLitrosPremium);
            this.groupBox4.Controls.Add(this.lblCapacidadPremium);
            this.groupBox4.Controls.Add(this.lblCantOperacionesPremium);
            this.groupBox4.Controls.Add(this.lblDisponiblePremium);
            this.groupBox4.Location = new System.Drawing.Point(575, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 160);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // lblMontoTotalSuper
            // 
            this.lblMontoTotalSuper.AutoSize = true;
            this.lblMontoTotalSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotalSuper.Location = new System.Drawing.Point(6, 123);
            this.lblMontoTotalSuper.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblMontoTotalSuper.Name = "lblMontoTotalSuper";
            this.lblMontoTotalSuper.Size = new System.Drawing.Size(84, 18);
            this.lblMontoTotalSuper.TabIndex = 4;
            this.lblMontoTotalSuper.Text = "montoTotal";
            // 
            // lblTotalLitrosSuper
            // 
            this.lblTotalLitrosSuper.AutoSize = true;
            this.lblTotalLitrosSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLitrosSuper.Location = new System.Drawing.Point(7, 102);
            this.lblTotalLitrosSuper.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblTotalLitrosSuper.Name = "lblTotalLitrosSuper";
            this.lblTotalLitrosSuper.Size = new System.Drawing.Size(73, 18);
            this.lblTotalLitrosSuper.TabIndex = 5;
            this.lblTotalLitrosSuper.Text = "totalLitros";
            // 
            // lblCantOperacionesSuper
            // 
            this.lblCantOperacionesSuper.AutoSize = true;
            this.lblCantOperacionesSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantOperacionesSuper.Location = new System.Drawing.Point(6, 81);
            this.lblCantOperacionesSuper.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblCantOperacionesSuper.Name = "lblCantOperacionesSuper";
            this.lblCantOperacionesSuper.Size = new System.Drawing.Size(121, 18);
            this.lblCantOperacionesSuper.TabIndex = 6;
            this.lblCantOperacionesSuper.Text = "cantOperaciones";
            // 
            // lblDisponibleSuper
            // 
            this.lblDisponibleSuper.AutoSize = true;
            this.lblDisponibleSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibleSuper.Location = new System.Drawing.Point(6, 60);
            this.lblDisponibleSuper.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblDisponibleSuper.Name = "lblDisponibleSuper";
            this.lblDisponibleSuper.Size = new System.Drawing.Size(74, 18);
            this.lblDisponibleSuper.TabIndex = 7;
            this.lblDisponibleSuper.Text = "disponible";
            // 
            // lblCapacidadSuper
            // 
            this.lblCapacidadSuper.AutoSize = true;
            this.lblCapacidadSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadSuper.Location = new System.Drawing.Point(5, 39);
            this.lblCapacidadSuper.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblCapacidadSuper.Name = "lblCapacidadSuper";
            this.lblCapacidadSuper.Size = new System.Drawing.Size(75, 18);
            this.lblCapacidadSuper.TabIndex = 8;
            this.lblCapacidadSuper.Text = "capacidad";
            // 
            // lblPlayeroSuper
            // 
            this.lblPlayeroSuper.AutoSize = true;
            this.lblPlayeroSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayeroSuper.Location = new System.Drawing.Point(6, 18);
            this.lblPlayeroSuper.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblPlayeroSuper.Name = "lblPlayeroSuper";
            this.lblPlayeroSuper.Size = new System.Drawing.Size(56, 18);
            this.lblPlayeroSuper.TabIndex = 9;
            this.lblPlayeroSuper.Text = "playero";
            // 
            // lblMontoTotalPremium
            // 
            this.lblMontoTotalPremium.AutoSize = true;
            this.lblMontoTotalPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotalPremium.Location = new System.Drawing.Point(6, 123);
            this.lblMontoTotalPremium.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblMontoTotalPremium.Name = "lblMontoTotalPremium";
            this.lblMontoTotalPremium.Size = new System.Drawing.Size(84, 18);
            this.lblMontoTotalPremium.TabIndex = 10;
            this.lblMontoTotalPremium.Text = "montoTotal";
            // 
            // lblTotalLitrosPremium
            // 
            this.lblTotalLitrosPremium.AutoSize = true;
            this.lblTotalLitrosPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLitrosPremium.Location = new System.Drawing.Point(7, 102);
            this.lblTotalLitrosPremium.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblTotalLitrosPremium.Name = "lblTotalLitrosPremium";
            this.lblTotalLitrosPremium.Size = new System.Drawing.Size(73, 18);
            this.lblTotalLitrosPremium.TabIndex = 11;
            this.lblTotalLitrosPremium.Text = "totalLitros";
            // 
            // lblCantOperacionesPremium
            // 
            this.lblCantOperacionesPremium.AutoSize = true;
            this.lblCantOperacionesPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantOperacionesPremium.Location = new System.Drawing.Point(6, 81);
            this.lblCantOperacionesPremium.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblCantOperacionesPremium.Name = "lblCantOperacionesPremium";
            this.lblCantOperacionesPremium.Size = new System.Drawing.Size(121, 18);
            this.lblCantOperacionesPremium.TabIndex = 12;
            this.lblCantOperacionesPremium.Text = "cantOperaciones";
            // 
            // lblDisponiblePremium
            // 
            this.lblDisponiblePremium.AutoSize = true;
            this.lblDisponiblePremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponiblePremium.Location = new System.Drawing.Point(6, 60);
            this.lblDisponiblePremium.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblDisponiblePremium.Name = "lblDisponiblePremium";
            this.lblDisponiblePremium.Size = new System.Drawing.Size(74, 18);
            this.lblDisponiblePremium.TabIndex = 13;
            this.lblDisponiblePremium.Text = "disponible";
            // 
            // lblCapacidadPremium
            // 
            this.lblCapacidadPremium.AutoSize = true;
            this.lblCapacidadPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidadPremium.Location = new System.Drawing.Point(5, 39);
            this.lblCapacidadPremium.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblCapacidadPremium.Name = "lblCapacidadPremium";
            this.lblCapacidadPremium.Size = new System.Drawing.Size(75, 18);
            this.lblCapacidadPremium.TabIndex = 14;
            this.lblCapacidadPremium.Text = "capacidad";
            // 
            // lblPlayeroPremium
            // 
            this.lblPlayeroPremium.AutoSize = true;
            this.lblPlayeroPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayeroPremium.Location = new System.Drawing.Point(6, 18);
            this.lblPlayeroPremium.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblPlayeroPremium.Name = "lblPlayeroPremium";
            this.lblPlayeroPremium.Size = new System.Drawing.Size(56, 18);
            this.lblPlayeroPremium.TabIndex = 15;
            this.lblPlayeroPremium.Text = "playero";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPremium);
            this.Controls.Add(this.btnSuper);
            this.Controls.Add(this.btnDiesel);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}

