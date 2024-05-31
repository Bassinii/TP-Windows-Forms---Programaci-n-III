namespace TPWindowsFormsProgramacionIII
{
    partial class VentanaMarcaslistar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaMarcaslistar));
            this.btnAgragar = new System.Windows.Forms.Button();
            this.btnModifM = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtgMarcas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgragar
            // 
            this.btnAgragar.Location = new System.Drawing.Point(33, 25);
            this.btnAgragar.Name = "btnAgragar";
            this.btnAgragar.Size = new System.Drawing.Size(97, 49);
            this.btnAgragar.TabIndex = 0;
            this.btnAgragar.Text = "Agregar";
            this.btnAgragar.UseVisualStyleBackColor = true;
            this.btnAgragar.Click += new System.EventHandler(this.btnAgragar_Click);
            // 
            // btnModifM
            // 
            this.btnModifM.Location = new System.Drawing.Point(166, 25);
            this.btnModifM.Name = "btnModifM";
            this.btnModifM.Size = new System.Drawing.Size(113, 49);
            this.btnModifM.TabIndex = 1;
            this.btnModifM.Text = "Modificar";
            this.btnModifM.UseVisualStyleBackColor = true;
            this.btnModifM.Click += new System.EventHandler(this.btnModifM_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(319, 25);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 49);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgMarcas
            // 
            this.dtgMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMarcas.Location = new System.Drawing.Point(24, 93);
            this.dtgMarcas.Name = "dtgMarcas";
            this.dtgMarcas.RowHeadersWidth = 51;
            this.dtgMarcas.RowTemplate.Height = 24;
            this.dtgMarcas.Size = new System.Drawing.Size(413, 360);
            this.dtgMarcas.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentanaMarcaslistar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgMarcas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModifM);
            this.Controls.Add(this.btnAgragar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaMarcaslistar";
            this.Text = " Marcas";
            this.Load += new System.EventHandler(this.VentanaMarcaslistar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgragar;
        private System.Windows.Forms.Button btnModifM;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dtgMarcas;
        private System.Windows.Forms.Button button1;
    }
}