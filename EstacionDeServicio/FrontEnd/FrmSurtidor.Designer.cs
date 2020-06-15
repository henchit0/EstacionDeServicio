namespace EstacionDeServicio.FrontEnd
{
    partial class FrmSurtidor
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSurtidor));
			this.lblSurtidor = new System.Windows.Forms.Label();
			this.numLitros = new System.Windows.Forms.NumericUpDown();
			this.btnFinalizar = new System.Windows.Forms.Button();
			this.btnCobrar = new System.Windows.Forms.Button();
			this.btnVolver = new System.Windows.Forms.Button();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.lblMontoSurtido = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.lblCapacidad = new System.Windows.Forms.Label();
			this.lblDisponible = new System.Windows.Forms.Label();
			this.lblCobrado = new System.Windows.Forms.Label();
			this.gbxSurtidor = new System.Windows.Forms.GroupBox();
			this.gbxSurtidos = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gbxTanque = new System.Windows.Forms.GroupBox();
			this.btnSurtir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numLitros)).BeginInit();
			this.gbxSurtidor.SuspendLayout();
			this.gbxSurtidos.SuspendLayout();
			this.gbxTanque.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblSurtidor
			// 
			this.lblSurtidor.AutoSize = true;
			this.lblSurtidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSurtidor.Location = new System.Drawing.Point(12, 28);
			this.lblSurtidor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSurtidor.Name = "lblSurtidor";
			this.lblSurtidor.Size = new System.Drawing.Size(42, 25);
			this.lblSurtidor.TabIndex = 0;
			this.lblSurtidor.Text = "TC";
			this.lblSurtidor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblSurtidor.Click += new System.EventHandler(this.lblSurtidor_Click);
			// 
			// numLitros
			// 
			this.numLitros.BackColor = System.Drawing.SystemColors.GrayText;
			this.numLitros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numLitros.Enabled = false;
			this.numLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numLitros.ForeColor = System.Drawing.Color.DarkBlue;
			this.numLitros.Location = new System.Drawing.Point(6, 19);
			this.numLitros.Name = "numLitros";
			this.numLitros.Size = new System.Drawing.Size(41, 26);
			this.numLitros.TabIndex = 1;
			// 
			// btnFinalizar
			// 
			this.btnFinalizar.BackColor = System.Drawing.Color.Brown;
			this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFinalizar.Enabled = false;
			this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFinalizar.Location = new System.Drawing.Point(295, 234);
			this.btnFinalizar.Name = "btnFinalizar";
			this.btnFinalizar.Size = new System.Drawing.Size(103, 47);
			this.btnFinalizar.TabIndex = 3;
			this.btnFinalizar.Text = "Finalizar";
			this.btnFinalizar.UseVisualStyleBackColor = false;
			this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
			// 
			// btnCobrar
			// 
			this.btnCobrar.BackColor = System.Drawing.Color.SlateBlue;
			this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCobrar.Enabled = false;
			this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCobrar.Location = new System.Drawing.Point(154, 303);
			this.btnCobrar.Name = "btnCobrar";
			this.btnCobrar.Size = new System.Drawing.Size(244, 47);
			this.btnCobrar.TabIndex = 4;
			this.btnCobrar.Text = "Cobrar";
			this.btnCobrar.UseVisualStyleBackColor = false;
			this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.Color.SlateBlue;
			this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.Location = new System.Drawing.Point(467, 336);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(65, 28);
			this.btnVolver.TabIndex = 5;
			this.btnVolver.Text = "Volver";
			this.btnVolver.UseVisualStyleBackColor = false;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// lblPrecio
			// 
			this.lblPrecio.AutoSize = true;
			this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecio.ForeColor = System.Drawing.Color.Navy;
			this.lblPrecio.Location = new System.Drawing.Point(6, 101);
			this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.lblPrecio.Size = new System.Drawing.Size(77, 29);
			this.lblPrecio.TabIndex = 6;
			this.lblPrecio.Text = "precio";
			this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
			// 
			// lblMontoSurtido
			// 
			this.lblMontoSurtido.AutoSize = true;
			this.lblMontoSurtido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMontoSurtido.ForeColor = System.Drawing.Color.Navy;
			this.lblMontoSurtido.Location = new System.Drawing.Point(340, 103);
			this.lblMontoSurtido.Name = "lblMontoSurtido";
			this.lblMontoSurtido.Size = new System.Drawing.Size(150, 25);
			this.lblMontoSurtido.TabIndex = 7;
			this.lblMontoSurtido.Text = "Monto: $0,00";
			// 
			// timer
			// 
			this.timer.Interval = 500;
			this.timer.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblCapacidad
			// 
			this.lblCapacidad.AutoSize = true;
			this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCapacidad.ForeColor = System.Drawing.Color.Navy;
			this.lblCapacidad.Location = new System.Drawing.Point(6, 28);
			this.lblCapacidad.Margin = new System.Windows.Forms.Padding(3);
			this.lblCapacidad.Name = "lblCapacidad";
			this.lblCapacidad.Size = new System.Drawing.Size(120, 25);
			this.lblCapacidad.TabIndex = 8;
			this.lblCapacidad.Text = "capacidad";
			// 
			// lblDisponible
			// 
			this.lblDisponible.AutoSize = true;
			this.lblDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDisponible.ForeColor = System.Drawing.Color.Navy;
			this.lblDisponible.Location = new System.Drawing.Point(6, 67);
			this.lblDisponible.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDisponible.Name = "lblDisponible";
			this.lblDisponible.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.lblDisponible.Size = new System.Drawing.Size(120, 29);
			this.lblDisponible.TabIndex = 9;
			this.lblDisponible.Text = "disponible";
			this.lblDisponible.Click += new System.EventHandler(this.lblDisponible_Click);
			// 
			// lblCobrado
			// 
			this.lblCobrado.AutoSize = true;
			this.lblCobrado.Location = new System.Drawing.Point(7, 218);
			this.lblCobrado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCobrado.Name = "lblCobrado";
			this.lblCobrado.Size = new System.Drawing.Size(0, 13);
			this.lblCobrado.TabIndex = 10;
			// 
			// gbxSurtidor
			// 
			this.gbxSurtidor.Controls.Add(this.gbxTanque);
			this.gbxSurtidor.Controls.Add(this.gbxSurtidos);
			this.gbxSurtidor.Controls.Add(this.lblSurtidor);
			this.gbxSurtidor.Controls.Add(this.lblMontoSurtido);
			this.gbxSurtidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxSurtidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.gbxSurtidor.Location = new System.Drawing.Point(16, 12);
			this.gbxSurtidor.Name = "gbxSurtidor";
			this.gbxSurtidor.Size = new System.Drawing.Size(516, 208);
			this.gbxSurtidor.TabIndex = 11;
			this.gbxSurtidor.TabStop = false;
			this.gbxSurtidor.Text = "Surtidor";
			// 
			// gbxSurtidos
			// 
			this.gbxSurtidos.BackColor = System.Drawing.SystemColors.GrayText;
			this.gbxSurtidos.Controls.Add(this.label1);
			this.gbxSurtidos.Controls.Add(this.numLitros);
			this.gbxSurtidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxSurtidos.ForeColor = System.Drawing.Color.Navy;
			this.gbxSurtidos.Location = new System.Drawing.Point(345, 136);
			this.gbxSurtidos.Name = "gbxSurtidos";
			this.gbxSurtidos.Size = new System.Drawing.Size(145, 62);
			this.gbxSurtidos.TabIndex = 10;
			this.gbxSurtidos.TabStop = false;
			this.gbxSurtidos.Text = "Surtidos";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(53, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "lts";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// gbxTanque
			// 
			this.gbxTanque.BackColor = System.Drawing.SystemColors.GrayText;
			this.gbxTanque.Controls.Add(this.lblDisponible);
			this.gbxTanque.Controls.Add(this.lblPrecio);
			this.gbxTanque.Controls.Add(this.lblCapacidad);
			this.gbxTanque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxTanque.ForeColor = System.Drawing.Color.Navy;
			this.gbxTanque.Location = new System.Drawing.Point(17, 56);
			this.gbxTanque.Name = "gbxTanque";
			this.gbxTanque.Size = new System.Drawing.Size(286, 142);
			this.gbxTanque.TabIndex = 11;
			this.gbxTanque.TabStop = false;
			this.gbxTanque.Text = "Tanque";
			// 
			// btnSurtir
			// 
			this.btnSurtir.BackColor = System.Drawing.Color.Green;
			this.btnSurtir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSurtir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSurtir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSurtir.Location = new System.Drawing.Point(154, 234);
			this.btnSurtir.Name = "btnSurtir";
			this.btnSurtir.Size = new System.Drawing.Size(105, 47);
			this.btnSurtir.TabIndex = 2;
			this.btnSurtir.Text = "Surtir";
			this.btnSurtir.UseVisualStyleBackColor = false;
			this.btnSurtir.Click += new System.EventHandler(this.btnSurtir_Click);
			// 
			// FrmSurtidor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.ClientSize = new System.Drawing.Size(543, 375);
			this.Controls.Add(this.gbxSurtidor);
			this.Controls.Add(this.lblCobrado);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.btnCobrar);
			this.Controls.Add(this.btnFinalizar);
			this.Controls.Add(this.btnSurtir);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FrmSurtidor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmSurtidor";
			((System.ComponentModel.ISupportInitialize)(this.numLitros)).EndInit();
			this.gbxSurtidor.ResumeLayout(false);
			this.gbxSurtidor.PerformLayout();
			this.gbxSurtidos.ResumeLayout(false);
			this.gbxSurtidos.PerformLayout();
			this.gbxTanque.ResumeLayout(false);
			this.gbxTanque.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSurtidor;
        private System.Windows.Forms.NumericUpDown numLitros;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMontoSurtido;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label lblCobrado;
		private System.Windows.Forms.GroupBox gbxSurtidor;
		private System.Windows.Forms.GroupBox gbxSurtidos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbxTanque;
		private System.Windows.Forms.Button btnSurtir;
	}
}