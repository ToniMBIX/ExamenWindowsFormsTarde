namespace ExamenWindowsFormsTarde
{
    partial class FormAnadir
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.maskedTextBoxNombre = new System.Windows.Forms.MaskedTextBox();
            this.labelPosicion = new System.Windows.Forms.Label();
            this.comboBoxPosicion = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxAltura = new System.Windows.Forms.MaskedTextBox();
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelEquipo = new System.Windows.Forms.Label();
            this.maskedTextBoxEquipo = new System.Windows.Forms.MaskedTextBox();
            this.buttonAnadir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 9);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(189, 16);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre completo del jugador:";
            // 
            // maskedTextBoxNombre
            // 
            this.maskedTextBoxNombre.Location = new System.Drawing.Point(15, 28);
            this.maskedTextBoxNombre.Name = "maskedTextBoxNombre";
            this.maskedTextBoxNombre.Size = new System.Drawing.Size(311, 22);
            this.maskedTextBoxNombre.TabIndex = 1;
            this.maskedTextBoxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxNombre_Validating);
            // 
            // labelPosicion
            // 
            this.labelPosicion.AutoSize = true;
            this.labelPosicion.Location = new System.Drawing.Point(12, 69);
            this.labelPosicion.Name = "labelPosicion";
            this.labelPosicion.Size = new System.Drawing.Size(139, 16);
            this.labelPosicion.TabIndex = 2;
            this.labelPosicion.Text = "Posición en el equipo:";
            // 
            // comboBoxPosicion
            // 
            this.comboBoxPosicion.FormattingEnabled = true;
            this.comboBoxPosicion.Items.AddRange(new object[] {
            "Base",
            "Escolta",
            "Alero",
            "Ala-pívot",
            "Pívot"});
            this.comboBoxPosicion.Location = new System.Drawing.Point(15, 88);
            this.comboBoxPosicion.Name = "comboBoxPosicion";
            this.comboBoxPosicion.Size = new System.Drawing.Size(155, 24);
            this.comboBoxPosicion.TabIndex = 3;
            this.comboBoxPosicion.Validated += new System.EventHandler(this.comboBoxPosicion_Validated);
            // 
            // maskedTextBoxAltura
            // 
            this.maskedTextBoxAltura.Location = new System.Drawing.Point(15, 149);
            this.maskedTextBoxAltura.Mask = "9.99";
            this.maskedTextBoxAltura.Name = "maskedTextBoxAltura";
            this.maskedTextBoxAltura.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxAltura.TabIndex = 4;
            this.maskedTextBoxAltura.ValidatingType = typeof(int);
            this.maskedTextBoxAltura.Validated += new System.EventHandler(this.maskedTextBoxAltura_Validated);
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(12, 130);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(115, 16);
            this.labelAltura.TabIndex = 5;
            this.labelAltura.Text = "Altura del jugador:";
            // 
            // labelEquipo
            // 
            this.labelEquipo.AutoSize = true;
            this.labelEquipo.Location = new System.Drawing.Point(12, 200);
            this.labelEquipo.Name = "labelEquipo";
            this.labelEquipo.Size = new System.Drawing.Size(53, 16);
            this.labelEquipo.TabIndex = 6;
            this.labelEquipo.Text = "Equipo:";
            // 
            // maskedTextBoxEquipo
            // 
            this.maskedTextBoxEquipo.Location = new System.Drawing.Point(15, 219);
            this.maskedTextBoxEquipo.Name = "maskedTextBoxEquipo";
            this.maskedTextBoxEquipo.Size = new System.Drawing.Size(155, 22);
            this.maskedTextBoxEquipo.TabIndex = 7;
            this.maskedTextBoxEquipo.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxEquipo_Validating);
            // 
            // buttonAnadir
            // 
            this.buttonAnadir.Location = new System.Drawing.Point(52, 280);
            this.buttonAnadir.Name = "buttonAnadir";
            this.buttonAnadir.Size = new System.Drawing.Size(75, 23);
            this.buttonAnadir.TabIndex = 8;
            this.buttonAnadir.Text = "Añadir";
            this.buttonAnadir.UseVisualStyleBackColor = true;
            this.buttonAnadir.Click += new System.EventHandler(this.buttonAnadir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(153, 280);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormAnadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 325);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAnadir);
            this.Controls.Add(this.maskedTextBoxEquipo);
            this.Controls.Add(this.labelEquipo);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.maskedTextBoxAltura);
            this.Controls.Add(this.comboBoxPosicion);
            this.Controls.Add(this.labelPosicion);
            this.Controls.Add(this.maskedTextBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Name = "FormAnadir";
            this.Text = "Añadir Jugador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNombre;
        private System.Windows.Forms.Label labelPosicion;
        private System.Windows.Forms.ComboBox comboBoxPosicion;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAltura;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label labelEquipo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEquipo;
        private System.Windows.Forms.Button buttonAnadir;
        private System.Windows.Forms.Button buttonCancelar;
    }
}

