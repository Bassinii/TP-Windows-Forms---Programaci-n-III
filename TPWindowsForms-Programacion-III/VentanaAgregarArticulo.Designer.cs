
namespace TPWindowsFormsProgramacionIII
{
    partial class VentanaAgregarArticulo
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
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelIDMarca = new System.Windows.Forms.Label();
            this.labelIDCategoria = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(19, 78);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(54, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "NOMBRE";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(19, 106);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(80, 13);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "DESCRIPCION";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(110, 75);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(188, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(110, 106);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(188, 20);
            this.textBoxDescripcion.TabIndex = 5;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(178, 352);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(134, 34);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(38, 352);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(134, 34);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(19, 45);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(49, 13);
            this.labelCodigo.TabIndex = 8;
            this.labelCodigo.Text = "CODIGO";
            // 
            // labelIDMarca
            // 
            this.labelIDMarca.AutoSize = true;
            this.labelIDMarca.Location = new System.Drawing.Point(19, 141);
            this.labelIDMarca.Name = "labelIDMarca";
            this.labelIDMarca.Size = new System.Drawing.Size(59, 13);
            this.labelIDMarca.TabIndex = 9;
            this.labelIDMarca.Text = "ID MARCA";
            // 
            // labelIDCategoria
            // 
            this.labelIDCategoria.AutoSize = true;
            this.labelIDCategoria.Location = new System.Drawing.Point(19, 172);
            this.labelIDCategoria.Name = "labelIDCategoria";
            this.labelIDCategoria.Size = new System.Drawing.Size(83, 13);
            this.labelIDCategoria.TabIndex = 10;
            this.labelIDCategoria.Text = "ID CATEGORIA";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(19, 207);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(47, 13);
            this.labelPrecio.TabIndex = 11;
            this.labelPrecio.Text = "PRECIO";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(110, 42);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(188, 20);
            this.textBoxCodigo.TabIndex = 12;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(110, 134);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(188, 20);
            this.textBoxMarca.TabIndex = 13;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(110, 169);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(188, 20);
            this.textBoxCategoria.TabIndex = 14;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(110, 204);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(188, 20);
            this.textBoxPrecio.TabIndex = 15;
            // 
            // VentanaAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 423);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelIDCategoria);
            this.Controls.Add(this.labelIDMarca);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Name = "VentanaAgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelIDMarca;
        private System.Windows.Forms.Label labelIDCategoria;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.TextBox textBoxPrecio;
    }
}