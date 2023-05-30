namespace ExamenWindowsFormsTarde
{
    partial class FormDetalles
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelPosicion = new System.Windows.Forms.Label();
            this.textBoxPosicion = new System.Windows.Forms.TextBox();
            this.labelAltura = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.labelEquipo = new System.Windows.Forms.Label();
            this.textBoxEquipo = new System.Windows.Forms.TextBox();
            this.labelPuntos = new System.Windows.Forms.Label();
            this.textBoxPuntos = new System.Windows.Forms.TextBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 9);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(59, 16);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(12, 28);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(252, 22);
            this.textBoxNombre.TabIndex = 1;
            // 
            // labelPosicion
            // 
            this.labelPosicion.AutoSize = true;
            this.labelPosicion.Location = new System.Drawing.Point(12, 73);
            this.labelPosicion.Name = "labelPosicion";
            this.labelPosicion.Size = new System.Drawing.Size(62, 16);
            this.labelPosicion.TabIndex = 2;
            this.labelPosicion.Text = "Posicion:";
            // 
            // textBoxPosicion
            // 
            this.textBoxPosicion.Location = new System.Drawing.Point(12, 92);
            this.textBoxPosicion.Name = "textBoxPosicion";
            this.textBoxPosicion.ReadOnly = true;
            this.textBoxPosicion.Size = new System.Drawing.Size(252, 22);
            this.textBoxPosicion.TabIndex = 3;
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(12, 146);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(44, 16);
            this.labelAltura.TabIndex = 4;
            this.labelAltura.Text = "Altura:";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(12, 165);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.ReadOnly = true;
            this.textBoxAltura.Size = new System.Drawing.Size(100, 22);
            this.textBoxAltura.TabIndex = 5;
            // 
            // labelEquipo
            // 
            this.labelEquipo.AutoSize = true;
            this.labelEquipo.Location = new System.Drawing.Point(12, 224);
            this.labelEquipo.Name = "labelEquipo";
            this.labelEquipo.Size = new System.Drawing.Size(53, 16);
            this.labelEquipo.TabIndex = 6;
            this.labelEquipo.Text = "Equipo:";
            // 
            // textBoxEquipo
            // 
            this.textBoxEquipo.Location = new System.Drawing.Point(12, 243);
            this.textBoxEquipo.Name = "textBoxEquipo";
            this.textBoxEquipo.ReadOnly = true;
            this.textBoxEquipo.Size = new System.Drawing.Size(252, 22);
            this.textBoxEquipo.TabIndex = 7;
            // 
            // labelPuntos
            // 
            this.labelPuntos.AutoSize = true;
            this.labelPuntos.Location = new System.Drawing.Point(12, 300);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(119, 16);
            this.labelPuntos.TabIndex = 8;
            this.labelPuntos.Text = "Puntos por partido:";
            // 
            // textBoxPuntos
            // 
            this.textBoxPuntos.Location = new System.Drawing.Point(15, 319);
            this.textBoxPuntos.Name = "textBoxPuntos";
            this.textBoxPuntos.ReadOnly = true;
            this.textBoxPuntos.Size = new System.Drawing.Size(100, 22);
            this.textBoxPuntos.TabIndex = 9;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(118, 402);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 10;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // FormDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.textBoxPuntos);
            this.Controls.Add(this.labelPuntos);
            this.Controls.Add(this.textBoxEquipo);
            this.Controls.Add(this.labelEquipo);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.textBoxPosicion);
            this.Controls.Add(this.labelPosicion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Name = "FormDetalles";
            this.Text = "Detalles del Jugador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelPosicion;
        private System.Windows.Forms.TextBox textBoxPosicion;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Label labelEquipo;
        private System.Windows.Forms.TextBox textBoxEquipo;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.TextBox textBoxPuntos;
        private System.Windows.Forms.Button buttonCerrar;
    }
}