namespace Veterinario
{
    partial class Menu
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
            this.BtnClienteMascota = new System.Windows.Forms.Button();
            this.BtnConsultarControlServicio = new System.Windows.Forms.Button();
            this.BtnIngresarControlServicio = new System.Windows.Forms.Button();
            this.BtnEliminarControlServicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClienteMascota
            // 
            this.BtnClienteMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClienteMascota.Location = new System.Drawing.Point(96, 67);
            this.BtnClienteMascota.Name = "BtnClienteMascota";
            this.BtnClienteMascota.Size = new System.Drawing.Size(194, 65);
            this.BtnClienteMascota.TabIndex = 0;
            this.BtnClienteMascota.Text = "Ingresar Cliente y Mascota";
            this.BtnClienteMascota.UseVisualStyleBackColor = true;
            this.BtnClienteMascota.Click += new System.EventHandler(this.BtnClienteMascota_Click);
            // 
            // BtnConsultarControlServicio
            // 
            this.BtnConsultarControlServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarControlServicio.Location = new System.Drawing.Point(255, 190);
            this.BtnConsultarControlServicio.Name = "BtnConsultarControlServicio";
            this.BtnConsultarControlServicio.Size = new System.Drawing.Size(194, 65);
            this.BtnConsultarControlServicio.TabIndex = 1;
            this.BtnConsultarControlServicio.Text = "Consultar Control/Servicio";
            this.BtnConsultarControlServicio.UseVisualStyleBackColor = true;
            this.BtnConsultarControlServicio.Click += new System.EventHandler(this.BtnConsultarControlServicio_Click);
            // 
            // BtnIngresarControlServicio
            // 
            this.BtnIngresarControlServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresarControlServicio.Location = new System.Drawing.Point(437, 67);
            this.BtnIngresarControlServicio.Name = "BtnIngresarControlServicio";
            this.BtnIngresarControlServicio.Size = new System.Drawing.Size(194, 65);
            this.BtnIngresarControlServicio.TabIndex = 2;
            this.BtnIngresarControlServicio.Text = "Ingresar Control/Servicio";
            this.BtnIngresarControlServicio.UseVisualStyleBackColor = true;
            this.BtnIngresarControlServicio.Click += new System.EventHandler(this.BtnIngresarControlServicio_Click);
            // 
            // BtnEliminarControlServicio
            // 
            this.BtnEliminarControlServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarControlServicio.Location = new System.Drawing.Point(255, 299);
            this.BtnEliminarControlServicio.Name = "BtnEliminarControlServicio";
            this.BtnEliminarControlServicio.Size = new System.Drawing.Size(194, 65);
            this.BtnEliminarControlServicio.TabIndex = 3;
            this.BtnEliminarControlServicio.Text = "Eliminar Control/Servicio";
            this.BtnEliminarControlServicio.UseVisualStyleBackColor = true;
            this.BtnEliminarControlServicio.Click += new System.EventHandler(this.BtnEliminarControlServicio_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEliminarControlServicio);
            this.Controls.Add(this.BtnIngresarControlServicio);
            this.Controls.Add(this.BtnConsultarControlServicio);
            this.Controls.Add(this.BtnClienteMascota);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClienteMascota;
        private System.Windows.Forms.Button BtnConsultarControlServicio;
        private System.Windows.Forms.Button BtnIngresarControlServicio;
        private System.Windows.Forms.Button BtnEliminarControlServicio;
    }
}

