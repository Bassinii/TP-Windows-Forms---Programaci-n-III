namespace TPWindowsFormsProgramacionIII
{
    partial class VentanaListarArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaListarArticulos));
            this.gdvListadoDeArticulos = new System.Windows.Forms.DataGridView();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.comboBoxPrecio = new System.Windows.Forms.ComboBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelFiltrarR = new System.Windows.Forms.Label();
            this.textBoxFiltrarR = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.cantidadImagen = new System.Windows.Forms.Label();
            this.lblReestablecerFiltros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdvListadoDeArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvListadoDeArticulos
            // 
            this.gdvListadoDeArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdvListadoDeArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvListadoDeArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gdvListadoDeArticulos.Location = new System.Drawing.Point(4, 58);
            this.gdvListadoDeArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.gdvListadoDeArticulos.MultiSelect = false;
            this.gdvListadoDeArticulos.Name = "gdvListadoDeArticulos";
            this.gdvListadoDeArticulos.RowHeadersWidth = 51;
            this.gdvListadoDeArticulos.RowTemplate.Height = 24;
            this.gdvListadoDeArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdvListadoDeArticulos.Size = new System.Drawing.Size(751, 289);
            this.gdvListadoDeArticulos.TabIndex = 0;
            this.gdvListadoDeArticulos.SelectionChanged += new System.EventHandler(this.gdvListadoDeArticulos_SelectionChanged);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(760, 58);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(260, 228);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 1;
            this.pictureBoxImagen.TabStop = false;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(783, 431);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(227, 75);
            this.buttonAgregar.TabIndex = 4;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(527, 444);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(228, 48);
            this.buttonModificar.TabIndex = 3;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(288, 444);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(217, 48);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click_1);
            // 
            // buttonAtras
            // 
            this.buttonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtras.Location = new System.Drawing.Point(26, 444);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(216, 48);
            this.buttonAtras.TabIndex = 1;
            this.buttonAtras.Text = "Atras";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(23, 374);
            this.lbCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(52, 13);
            this.lbCategoria.TabIndex = 5;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(246, 374);
            this.lbPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(37, 13);
            this.lbPrecio.TabIndex = 7;
            this.lbPrecio.Text = "Precio";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(79, 371);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoria.TabIndex = 6;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(486, 371);
            this.textBoxFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(121, 20);
            this.textBoxFiltro.TabIndex = 10;
            // 
            // comboBoxPrecio
            // 
            this.comboBoxPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrecio.FormattingEnabled = true;
            this.comboBoxPrecio.Location = new System.Drawing.Point(293, 371);
            this.comboBoxPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPrecio.Name = "comboBoxPrecio";
            this.comboBoxPrecio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrecio.TabIndex = 8;
            this.comboBoxPrecio.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrecio_SelectedIndexChanged);
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Location = new System.Drawing.Point(453, 374);
            this.lbFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(29, 13);
            this.lbFiltro.TabIndex = 9;
            this.lbFiltro.Text = "Filtro";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(647, 365);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(80, 31);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelFiltrarR
            // 
            this.labelFiltrarR.AutoSize = true;
            this.labelFiltrarR.Location = new System.Drawing.Point(149, 29);
            this.labelFiltrarR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFiltrarR.Name = "labelFiltrarR";
            this.labelFiltrarR.Size = new System.Drawing.Size(32, 13);
            this.labelFiltrarR.TabIndex = 12;
            this.labelFiltrarR.Text = "Filtrar";
            // 
            // textBoxFiltrarR
            // 
            this.textBoxFiltrarR.Location = new System.Drawing.Point(217, 27);
            this.textBoxFiltrarR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFiltrarR.Name = "textBoxFiltrarR";
            this.textBoxFiltrarR.Size = new System.Drawing.Size(197, 20);
            this.textBoxFiltrarR.TabIndex = 13;
            this.textBoxFiltrarR.TextChanged += new System.EventHandler(this.textBoxFiltrarR_TextChanged);
            this.textBoxFiltrarR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiltrarR_KeyPress);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(801, 303);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(68, 31);
            this.btnAnterior.TabIndex = 14;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(922, 303);
            this.btnsiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(76, 31);
            this.btnsiguiente.TabIndex = 15;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // cantidadImagen
            // 
            this.cantidadImagen.AutoSize = true;
            this.cantidadImagen.Location = new System.Drawing.Point(888, 27);
            this.cantidadImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cantidadImagen.Name = "cantidadImagen";
            this.cantidadImagen.Size = new System.Drawing.Size(0, 13);
            this.cantidadImagen.TabIndex = 16;
            this.cantidadImagen.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblReestablecerFiltros
            // 
            this.lblReestablecerFiltros.AutoSize = true;
            this.lblReestablecerFiltros.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblReestablecerFiltros.Location = new System.Drawing.Point(23, 405);
            this.lblReestablecerFiltros.Name = "lblReestablecerFiltros";
            this.lblReestablecerFiltros.Size = new System.Drawing.Size(100, 13);
            this.lblReestablecerFiltros.TabIndex = 17;
            this.lblReestablecerFiltros.Text = "Reestablecer Filtros";
            this.lblReestablecerFiltros.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // VentanaListarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1022, 518);
            this.Controls.Add(this.lblReestablecerFiltros);
            this.Controls.Add(this.cantidadImagen);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.textBoxFiltrarR);
            this.Controls.Add(this.labelFiltrarR);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.comboBoxPrecio);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.gdvListadoDeArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 562);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1022, 557);
            this.Name = "VentanaListarArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarArticulos";
            this.Load += new System.EventHandler(this.ListarArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvListadoDeArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvListadoDeArticulos;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.ComboBox comboBoxPrecio;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelFiltrarR;
        private System.Windows.Forms.TextBox textBoxFiltrarR;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Label cantidadImagen;
        private System.Windows.Forms.Label lblReestablecerFiltros;
    }
}