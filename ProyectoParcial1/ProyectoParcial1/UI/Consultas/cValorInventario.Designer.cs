namespace ProyectoParcial1.UI.Consultas
{
    partial class cValorInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cValorInventario));
            this.label1 = new System.Windows.Forms.Label();
            this.ValorTotalInventario_textBox = new System.Windows.Forms.TextBox();
            this.Actualizar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Total de Inventario";
            // 
            // ValorTotalInventario_textBox
            // 
            this.ValorTotalInventario_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTotalInventario_textBox.Location = new System.Drawing.Point(32, 107);
            this.ValorTotalInventario_textBox.Name = "ValorTotalInventario_textBox";
            this.ValorTotalInventario_textBox.Size = new System.Drawing.Size(279, 53);
            this.ValorTotalInventario_textBox.TabIndex = 1;
            // 
            // Actualizar_button
            // 
            this.Actualizar_button.Image = global::ProyectoParcial1.Properties.Resources.Sync_Icon;
            this.Actualizar_button.Location = new System.Drawing.Point(329, 107);
            this.Actualizar_button.Name = "Actualizar_button";
            this.Actualizar_button.Size = new System.Drawing.Size(58, 53);
            this.Actualizar_button.TabIndex = 2;
            this.Actualizar_button.UseVisualStyleBackColor = true;
            // 
            // cValorInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 203);
            this.Controls.Add(this.Actualizar_button);
            this.Controls.Add(this.ValorTotalInventario_textBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cValorInventario";
            this.Text = "Ver Valor Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValorTotalInventario_textBox;
        private System.Windows.Forms.Button Actualizar_button;
    }
}