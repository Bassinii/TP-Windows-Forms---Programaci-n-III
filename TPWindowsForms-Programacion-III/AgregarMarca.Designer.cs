namespace TPWindowsFormsProgramacionIII
{
    partial class AgregarMarca
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
            this.texbAgregarMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texbAgregarMarca
            // 
            this.texbAgregarMarca.Location = new System.Drawing.Point(94, 135);
            this.texbAgregarMarca.Name = "texbAgregarMarca";
            this.texbAgregarMarca.Size = new System.Drawing.Size(197, 22);
            this.texbAgregarMarca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese nueva Marca:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAceptarM
            // 
            this.btnAceptarM.Location = new System.Drawing.Point(143, 193);
            this.btnAceptarM.Name = "btnAceptarM";
            this.btnAceptarM.Size = new System.Drawing.Size(99, 55);
            this.btnAceptarM.TabIndex = 3;
            this.btnAceptarM.Text = "Aceptar";
            this.btnAceptarM.UseVisualStyleBackColor = true;
            this.btnAceptarM.Click += new System.EventHandler(this.btnAceptarM_Click);
            // 
            // AgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 329);
            this.Controls.Add(this.btnAceptarM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texbAgregarMarca);
            this.Name = "AgregarMarca";
            this.Text = "AgregarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texbAgregarMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptarM;
    }
}