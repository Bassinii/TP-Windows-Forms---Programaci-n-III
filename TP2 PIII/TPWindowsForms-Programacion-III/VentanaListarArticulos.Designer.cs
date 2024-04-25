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
            this.gdvListadoDeArticulos = new System.Windows.Forms.DataGridView();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdvListadoDeArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvListadoDeArticulos
            // 
            this.gdvListadoDeArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvListadoDeArticulos.Location = new System.Drawing.Point(4, 4);
            this.gdvListadoDeArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.gdvListadoDeArticulos.Name = "gdvListadoDeArticulos";
            this.gdvListadoDeArticulos.RowHeadersWidth = 51;
            this.gdvListadoDeArticulos.RowTemplate.Height = 24;
            this.gdvListadoDeArticulos.Size = new System.Drawing.Size(568, 237);
            this.gdvListadoDeArticulos.TabIndex = 0;
            this.gdvListadoDeArticulos.SelectionChanged += new System.EventHandler(this.gdvListadoDeArticulos_SelectionChanged);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(577, 4);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(466, 237);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 1;
            this.pictureBoxImagen.TabStop = false;
            // 
            // VentanaListarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 340);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.gdvListadoDeArticulos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VentanaListarArticulos";
            this.Text = "ListarArticulos";
            this.Load += new System.EventHandler(this.ListarArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvListadoDeArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvListadoDeArticulos;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
    }
}