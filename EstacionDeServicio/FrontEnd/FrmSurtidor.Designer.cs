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
            this.lblSurtidor = new System.Windows.Forms.Label();
            this.numLitros = new System.Windows.Forms.NumericUpDown();
            this.btnSurtir = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMontoSurtido = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.lblCobrado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numLitros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSurtidor
            // 
            this.lblSurtidor.AutoSize = true;
            this.lblSurtidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurtidor.Location = new System.Drawing.Point(109, 21);
            this.lblSurtidor.Name = "lblSurtidor";
            this.lblSurtidor.Size = new System.Drawing.Size(104, 24);
            this.lblSurtidor.TabIndex = 0;
            this.lblSurtidor.Text = "Surtidor X";
            this.lblSurtidor.Click += new System.EventHandler(this.lblSurtidor_Click);
            // 
            // numLitros
            // 
            this.numLitros.Location = new System.Drawing.Point(247, 162);
            this.numLitros.Name = "numLitros";
            this.numLitros.Size = new System.Drawing.Size(78, 22);
            this.numLitros.TabIndex = 1;
            // 
            // btnSurtir
            // 
            this.btnSurtir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSurtir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurtir.Location = new System.Drawing.Point(12, 221);
            this.btnSurtir.Name = "btnSurtir";
            this.btnSurtir.Size = new System.Drawing.Size(80, 35);
            this.btnSurtir.TabIndex = 2;
            this.btnSurtir.Text = "Surtir";
            this.btnSurtir.UseVisualStyleBackColor = false;
            this.btnSurtir.Click += new System.EventHandler(this.btnSurtir_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(98, 221);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(116, 35);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCobrar.Enabled = false;
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Location = new System.Drawing.Point(220, 221);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(102, 35);
            this.btnCobrar.TabIndex = 4;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(238, 293);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(87, 35);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 138);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblPrecio.Size = new System.Drawing.Size(49, 24);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "precio";
            // 
            // lblMontoSurtido
            // 
            this.lblMontoSurtido.AutoSize = true;
            this.lblMontoSurtido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoSurtido.Location = new System.Drawing.Point(12, 161);
            this.lblMontoSurtido.Name = "lblMontoSurtido";
            this.lblMontoSurtido.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblMontoSurtido.Size = new System.Drawing.Size(135, 24);
            this.lblMontoSurtido.TabIndex = 7;
            this.lblMontoSurtido.Text = "Mont surtido: $0,00";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.Location = new System.Drawing.Point(12, 92);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblCapacidad.Size = new System.Drawing.Size(147, 24);
            this.lblCapacidad.TabIndex = 8;
            this.lblCapacidad.Text = "capacidad: xxxx litros";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.Location = new System.Drawing.Point(12, 115);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblDisponible.Size = new System.Drawing.Size(139, 24);
            this.lblDisponible.TabIndex = 9;
            this.lblDisponible.Text = "disponible: xxx litros";
            this.lblDisponible.Click += new System.EventHandler(this.lblDisponible_Click);
            // 
            // lblCobrado
            // 
            this.lblCobrado.AutoSize = true;
            this.lblCobrado.Location = new System.Drawing.Point(9, 268);
            this.lblCobrado.Name = "lblCobrado";
            this.lblCobrado.Size = new System.Drawing.Size(0, 17);
            this.lblCobrado.TabIndex = 10;
            // 
            // FrmSurtidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 340);
            this.Controls.Add(this.lblCobrado);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblMontoSurtido);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnSurtir);
            this.Controls.Add(this.numLitros);
            this.Controls.Add(this.lblSurtidor);
            this.Name = "FrmSurtidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSurtidor";
            ((System.ComponentModel.ISupportInitialize)(this.numLitros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSurtidor;
        private System.Windows.Forms.NumericUpDown numLitros;
        private System.Windows.Forms.Button btnSurtir;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMontoSurtido;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label lblCobrado;
    }
}