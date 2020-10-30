namespace Testclass
{
    partial class Form1
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
            this.Videojuegos = new System.Windows.Forms.Button();
            this.ResidentEvil = new System.Windows.Forms.Button();
            this.Halo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Videojuegos
            // 
            this.Videojuegos.Location = new System.Drawing.Point(326, 57);
            this.Videojuegos.Name = "Videojuegos";
            this.Videojuegos.Size = new System.Drawing.Size(144, 57);
            this.Videojuegos.TabIndex = 0;
            this.Videojuegos.Text = "Videojuegos";
            this.Videojuegos.UseVisualStyleBackColor = true;
            this.Videojuegos.Click += new System.EventHandler(this.Videojuegos_Click);
            // 
            // ResidentEvil
            // 
            this.ResidentEvil.Location = new System.Drawing.Point(326, 146);
            this.ResidentEvil.Name = "ResidentEvil";
            this.ResidentEvil.Size = new System.Drawing.Size(144, 57);
            this.ResidentEvil.TabIndex = 1;
            this.ResidentEvil.Text = "ResidentEvil";
            this.ResidentEvil.UseVisualStyleBackColor = true;
            this.ResidentEvil.Click += new System.EventHandler(this.ResidentEvil_Click);
            // 
            // Halo
            // 
            this.Halo.Location = new System.Drawing.Point(326, 236);
            this.Halo.Name = "Halo";
            this.Halo.Size = new System.Drawing.Size(144, 55);
            this.Halo.TabIndex = 2;
            this.Halo.Text = "Halo";
            this.Halo.UseVisualStyleBackColor = true;
            this.Halo.Click += new System.EventHandler(this.Halo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 353);
            this.Controls.Add(this.Halo);
            this.Controls.Add(this.ResidentEvil);
            this.Controls.Add(this.Videojuegos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Videojuegos;
        private System.Windows.Forms.Button ResidentEvil;
        private System.Windows.Forms.Button Halo;
    }
}

