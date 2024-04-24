namespace TPWindowsFormsProgramacionIII
{
    partial class ListarArticulos
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
            ((System.ComponentModel.ISupportInitialize)(this.gdvListadoDeArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvListadoDeArticulos
            // 
            this.gdvListadoDeArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvListadoDeArticulos.Location = new System.Drawing.Point(6, 5);
            this.gdvListadoDeArticulos.Name = "gdvListadoDeArticulos";
            this.gdvListadoDeArticulos.RowHeadersWidth = 51;
            this.gdvListadoDeArticulos.RowTemplate.Height = 24;
            this.gdvListadoDeArticulos.Size = new System.Drawing.Size(758, 292);
            this.gdvListadoDeArticulos.TabIndex = 0;
            // 
            // ListarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gdvListadoDeArticulos);
            this.Name = "ListarArticulos";
            this.Text = "ListarArticulos";
            ((System.ComponentModel.ISupportInitialize)(this.gdvListadoDeArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvListadoDeArticulos;
    }
}