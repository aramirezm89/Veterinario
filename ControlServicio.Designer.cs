namespace Veterinario
{
    partial class ControlServicio
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
            this.components = new System.ComponentModel.Container();
            this.GboxCtrlCli = new System.Windows.Forms.GroupBox();
            this.CboSelecCli = new System.Windows.Forms.ComboBox();
            this.LblNombreCserv = new System.Windows.Forms.Label();
            this.GboDatoMasc = new System.Windows.Forms.GroupBox();
            this.CboSelecMasc = new System.Windows.Forms.ComboBox();
            this.LblNomMasc = new System.Windows.Forms.Label();
            this.GboCtrlServ = new System.Windows.Forms.GroupBox();
            this.DateTimeVacuna = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPago = new System.Windows.Forms.TextBox();
            this.LblTotalPago = new System.Windows.Forms.Label();
            this.LblFechaVac = new System.Windows.Forms.Label();
            this.RbNoVac = new System.Windows.Forms.RadioButton();
            this.RbSiVac = new System.Windows.Forms.RadioButton();
            this.LblProgVac = new System.Windows.Forms.Label();
            this.LblServ = new System.Windows.Forms.Label();
            this.CboSelecServ = new System.Windows.Forms.ComboBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.LblDetRev = new System.Windows.Forms.Label();
            this.BtnGDatos = new System.Windows.Forms.Button();
            this.BtnCServ = new System.Windows.Forms.Button();
            this.listaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteMascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GboxCtrlCli.SuspendLayout();
            this.GboDatoMasc.SuspendLayout();
            this.GboCtrlServ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteMascotaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GboxCtrlCli
            // 
            this.GboxCtrlCli.Controls.Add(this.CboSelecCli);
            this.GboxCtrlCli.Controls.Add(this.LblNombreCserv);
            this.GboxCtrlCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxCtrlCli.Location = new System.Drawing.Point(27, 38);
            this.GboxCtrlCli.Name = "GboxCtrlCli";
            this.GboxCtrlCli.Size = new System.Drawing.Size(518, 98);
            this.GboxCtrlCli.TabIndex = 0;
            this.GboxCtrlCli.TabStop = false;
            this.GboxCtrlCli.Text = "Datos del Cliente";
            // 
            // CboSelecCli
            // 
            this.CboSelecCli.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaBindingSource, "Nombre", true));
            this.CboSelecCli.FormattingEnabled = true;
            this.CboSelecCli.Location = new System.Drawing.Point(151, 38);
            this.CboSelecCli.Name = "CboSelecCli";
            this.CboSelecCli.Size = new System.Drawing.Size(307, 26);
            this.CboSelecCli.TabIndex = 1;
            // 
            // LblNombreCserv
            // 
            this.LblNombreCserv.AutoSize = true;
            this.LblNombreCserv.Location = new System.Drawing.Point(17, 38);
            this.LblNombreCserv.Name = "LblNombreCserv";
            this.LblNombreCserv.Size = new System.Drawing.Size(73, 18);
            this.LblNombreCserv.TabIndex = 0;
            this.LblNombreCserv.Text = "Nombre:";
            // 
            // GboDatoMasc
            // 
            this.GboDatoMasc.Controls.Add(this.CboSelecMasc);
            this.GboDatoMasc.Controls.Add(this.LblNomMasc);
            this.GboDatoMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboDatoMasc.Location = new System.Drawing.Point(27, 177);
            this.GboDatoMasc.Name = "GboDatoMasc";
            this.GboDatoMasc.Size = new System.Drawing.Size(518, 98);
            this.GboDatoMasc.TabIndex = 1;
            this.GboDatoMasc.TabStop = false;
            this.GboDatoMasc.Text = "Datos de la Mascota";
            // 
            // CboSelecMasc
            // 
            this.CboSelecMasc.FormattingEnabled = true;
            this.CboSelecMasc.Location = new System.Drawing.Point(151, 38);
            this.CboSelecMasc.Name = "CboSelecMasc";
            this.CboSelecMasc.Size = new System.Drawing.Size(307, 26);
            this.CboSelecMasc.TabIndex = 1;
            this.CboSelecMasc.Text = "Seleccione Mascota";
            // 
            // LblNomMasc
            // 
            this.LblNomMasc.AutoSize = true;
            this.LblNomMasc.Location = new System.Drawing.Point(17, 38);
            this.LblNomMasc.Name = "LblNomMasc";
            this.LblNomMasc.Size = new System.Drawing.Size(73, 18);
            this.LblNomMasc.TabIndex = 0;
            this.LblNomMasc.Text = "Nombre:";
            // 
            // GboCtrlServ
            // 
            this.GboCtrlServ.Controls.Add(this.DateTimeVacuna);
            this.GboCtrlServ.Controls.Add(this.label1);
            this.GboCtrlServ.Controls.Add(this.TxtPago);
            this.GboCtrlServ.Controls.Add(this.LblTotalPago);
            this.GboCtrlServ.Controls.Add(this.LblFechaVac);
            this.GboCtrlServ.Controls.Add(this.RbNoVac);
            this.GboCtrlServ.Controls.Add(this.RbSiVac);
            this.GboCtrlServ.Controls.Add(this.LblProgVac);
            this.GboCtrlServ.Controls.Add(this.LblServ);
            this.GboCtrlServ.Controls.Add(this.CboSelecServ);
            this.GboCtrlServ.Controls.Add(this.txtDetalle);
            this.GboCtrlServ.Controls.Add(this.LblDetRev);
            this.GboCtrlServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboCtrlServ.Location = new System.Drawing.Point(27, 305);
            this.GboCtrlServ.Name = "GboCtrlServ";
            this.GboCtrlServ.Size = new System.Drawing.Size(633, 339);
            this.GboCtrlServ.TabIndex = 2;
            this.GboCtrlServ.TabStop = false;
            this.GboCtrlServ.Text = "Control Servicio";
            // 
            // DateTimeVacuna
            // 
            this.DateTimeVacuna.Location = new System.Drawing.Point(201, 248);
            this.DateTimeVacuna.Name = "DateTimeVacuna";
            this.DateTimeVacuna.Size = new System.Drawing.Size(367, 24);
            this.DateTimeVacuna.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Si la respuesta es si:";
            // 
            // TxtPago
            // 
            this.TxtPago.Location = new System.Drawing.Point(201, 296);
            this.TxtPago.Name = "TxtPago";
            this.TxtPago.Size = new System.Drawing.Size(294, 24);
            this.TxtPago.TabIndex = 10;
            this.TxtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPago_KeyPress);
            // 
            // LblTotalPago
            // 
            this.LblTotalPago.AutoSize = true;
            this.LblTotalPago.Location = new System.Drawing.Point(26, 296);
            this.LblTotalPago.Name = "LblTotalPago";
            this.LblTotalPago.Size = new System.Drawing.Size(112, 18);
            this.LblTotalPago.TabIndex = 9;
            this.LblTotalPago.Text = "Total a pagar:";
            // 
            // LblFechaVac
            // 
            this.LblFechaVac.AutoSize = true;
            this.LblFechaVac.Location = new System.Drawing.Point(22, 253);
            this.LblFechaVac.Name = "LblFechaVac";
            this.LblFechaVac.Size = new System.Drawing.Size(128, 18);
            this.LblFechaVac.TabIndex = 8;
            this.LblFechaVac.Text = "Fecha Vacunas:";
            // 
            // RbNoVac
            // 
            this.RbNoVac.AutoSize = true;
            this.RbNoVac.Location = new System.Drawing.Point(339, 177);
            this.RbNoVac.Name = "RbNoVac";
            this.RbNoVac.Size = new System.Drawing.Size(51, 22);
            this.RbNoVac.TabIndex = 6;
            this.RbNoVac.TabStop = true;
            this.RbNoVac.Text = "No";
            this.RbNoVac.UseVisualStyleBackColor = true;
            this.RbNoVac.CheckedChanged += new System.EventHandler(this.RbNoVac_CheckedChanged);
            // 
            // RbSiVac
            // 
            this.RbSiVac.AutoSize = true;
            this.RbSiVac.Location = new System.Drawing.Point(239, 177);
            this.RbSiVac.Name = "RbSiVac";
            this.RbSiVac.Size = new System.Drawing.Size(44, 22);
            this.RbSiVac.TabIndex = 5;
            this.RbSiVac.TabStop = true;
            this.RbSiVac.Text = "Si\r\n";
            this.RbSiVac.UseVisualStyleBackColor = true;
            this.RbSiVac.CheckedChanged += new System.EventHandler(this.RbSiVac_CheckedChanged);
            // 
            // LblProgVac
            // 
            this.LblProgVac.AutoSize = true;
            this.LblProgVac.Location = new System.Drawing.Point(38, 177);
            this.LblProgVac.Name = "LblProgVac";
            this.LblProgVac.Size = new System.Drawing.Size(156, 18);
            this.LblProgVac.TabIndex = 4;
            this.LblProgVac.Text = "Programa Vacunas:";
            // 
            // LblServ
            // 
            this.LblServ.AutoSize = true;
            this.LblServ.Location = new System.Drawing.Point(38, 135);
            this.LblServ.Name = "LblServ";
            this.LblServ.Size = new System.Drawing.Size(74, 18);
            this.LblServ.TabIndex = 3;
            this.LblServ.Text = "Servicio:";
            // 
            // CboSelecServ
            // 
            this.CboSelecServ.FormattingEnabled = true;
            this.CboSelecServ.Location = new System.Drawing.Point(201, 132);
            this.CboSelecServ.Name = "CboSelecServ";
            this.CboSelecServ.Size = new System.Drawing.Size(257, 26);
            this.CboSelecServ.TabIndex = 2;
            this.CboSelecServ.Text = "Seleccione Servicio:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(201, 33);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(367, 81);
            this.txtDetalle.TabIndex = 1;
            // 
            // LblDetRev
            // 
            this.LblDetRev.AutoSize = true;
            this.LblDetRev.Location = new System.Drawing.Point(26, 46);
            this.LblDetRev.Name = "LblDetRev";
            this.LblDetRev.Size = new System.Drawing.Size(152, 18);
            this.LblDetRev.TabIndex = 0;
            this.LblDetRev.Text = "Detalle de revisión:";
            // 
            // BtnGDatos
            // 
            this.BtnGDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGDatos.Location = new System.Drawing.Point(601, 57);
            this.BtnGDatos.Name = "BtnGDatos";
            this.BtnGDatos.Size = new System.Drawing.Size(147, 58);
            this.BtnGDatos.TabIndex = 3;
            this.BtnGDatos.Text = "Guardar Datos";
            this.BtnGDatos.UseVisualStyleBackColor = true;
            this.BtnGDatos.Click += new System.EventHandler(this.BtnGDatos_Click);
            // 
            // BtnCServ
            // 
            this.BtnCServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCServ.Location = new System.Drawing.Point(601, 140);
            this.BtnCServ.Name = "BtnCServ";
            this.BtnCServ.Size = new System.Drawing.Size(147, 58);
            this.BtnCServ.TabIndex = 4;
            this.BtnCServ.Text = "Consultar Control/Servicio";
            this.BtnCServ.UseVisualStyleBackColor = true;
            this.BtnCServ.Click += new System.EventHandler(this.BtnCServ_Click);
            // 
            // listaBindingSource
            // 
            this.listaBindingSource.DataSource = typeof(Veterinario.lista);
            // 
            // listaBindingSource1
            // 
            this.listaBindingSource1.DataSource = typeof(Veterinario.lista);
            // 
            // clienteMascotaBindingSource
            // 
            this.clienteMascotaBindingSource.DataSource = typeof(Veterinario.Cliente_Mascota);
            // 
            // ControlServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 719);
            this.Controls.Add(this.BtnCServ);
            this.Controls.Add(this.BtnGDatos);
            this.Controls.Add(this.GboCtrlServ);
            this.Controls.Add(this.GboDatoMasc);
            this.Controls.Add(this.GboxCtrlCli);
            this.Name = "ControlServicio";
            this.Text = "ControlServicio";
            this.Load += new System.EventHandler(this.ControlServicio_Load);
            this.GboxCtrlCli.ResumeLayout(false);
            this.GboxCtrlCli.PerformLayout();
            this.GboDatoMasc.ResumeLayout(false);
            this.GboDatoMasc.PerformLayout();
            this.GboCtrlServ.ResumeLayout(false);
            this.GboCtrlServ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteMascotaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GboxCtrlCli;
        private System.Windows.Forms.Label LblNombreCserv;
        private System.Windows.Forms.GroupBox GboDatoMasc;
        private System.Windows.Forms.ComboBox CboSelecMasc;
        private System.Windows.Forms.Label LblNomMasc;
        private System.Windows.Forms.GroupBox GboCtrlServ;
        private System.Windows.Forms.TextBox TxtPago;
        private System.Windows.Forms.Label LblTotalPago;
        private System.Windows.Forms.Label LblFechaVac;
        private System.Windows.Forms.RadioButton RbNoVac;
        private System.Windows.Forms.RadioButton RbSiVac;
        private System.Windows.Forms.Label LblProgVac;
        private System.Windows.Forms.Label LblServ;
        private System.Windows.Forms.ComboBox CboSelecServ;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label LblDetRev;
        private System.Windows.Forms.Button BtnGDatos;
        private System.Windows.Forms.Button BtnCServ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource listaBindingSource;
        private System.Windows.Forms.BindingSource listaBindingSource1;
        private System.Windows.Forms.BindingSource clienteMascotaBindingSource;
        private System.Windows.Forms.ComboBox CboSelecCli;
        private System.Windows.Forms.DateTimePicker DateTimeVacuna;
    }
}