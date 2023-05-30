using System.Windows.Forms;

namespace ExamenWindowsFormsTarde
{
    partial class FormLista
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
            this.buttonDetalles = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.listViewJugadores = new System.Windows.Forms.ListView();
            this.columnHeaderNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPosicion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAltura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonDetalles
            // 
            this.buttonDetalles.Location = new System.Drawing.Point(12, 282);
            this.buttonDetalles.Name = "buttonDetalles";
            this.buttonDetalles.Size = new System.Drawing.Size(75, 23);
            this.buttonDetalles.TabIndex = 8;
            this.buttonDetalles.Text = "Detalles";
            this.buttonDetalles.UseVisualStyleBackColor = true;
            this.buttonDetalles.Click += new System.EventHandler(this.buttonDetalles_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(93, 282);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 9;
            this.buttonAgregar.Text = "Añadir";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(174, 282);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // listViewJugadores
            // 
            this.listViewJugadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNombre,
            this.columnHeaderPosicion,
            this.columnHeaderAltura});
            this.listViewJugadores.HideSelection = false;
            this.listViewJugadores.Location = new System.Drawing.Point(12, 12);
            this.listViewJugadores.MultiSelect = false;
            this.listViewJugadores.Name = "listViewJugadores";
            this.listViewJugadores.Size = new System.Drawing.Size(355, 264);
            this.listViewJugadores.TabIndex = 11;
            this.listViewJugadores.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeaderNombre
            // 
            this.columnHeaderNombre.Text = "Nombre";
            // 
            // columnHeaderPosicion
            // 
            this.columnHeaderPosicion.Text = "Posicion";
            // 
            // columnHeaderAltura
            // 
            this.columnHeaderAltura.Text = "Altura";
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 317);
            this.Controls.Add(this.listViewJugadores);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonDetalles);
            this.Name = "FormLista";
            this.Text = "Lista de Jugadores";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDetalles;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ListView listViewJugadores;
        private ColumnHeader columnHeaderNombre;
        private ColumnHeader columnHeaderPosicion;
        private ColumnHeader columnHeaderAltura;
    }
}