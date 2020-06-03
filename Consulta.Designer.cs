namespace Veterinario
{
    partial class Consulta
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
            this.GBOConsCli = new System.Windows.Forms.GroupBox();
            this.CboTodosCli = new System.Windows.Forms.ComboBox();
            this.LblNomTodCli = new System.Windows.Forms.Label();
            this.GboConsMasc = new System.Windows.Forms.GroupBox();
            this.CboTodMasc = new System.Windows.Forms.ComboBox();
            this.LblNomTodMas = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GboResult = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.GBOConsCli.SuspendLayout();
            this.GboConsMasc.SuspendLayout();
            this.GboResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBOConsCli
            // 
            this.GBOConsCli.Controls.Add(this.CboTodosCli);
            this.GBOConsCli.Controls.Add(this.LblNomTodCli);
            this.GBOConsCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOConsCli.Location = new System.Drawing.Point(12, 31);
            this.GBOConsCli.Name = "GBOConsCli";
            this.GBOConsCli.Size = new System.Drawing.Size(518, 76);
            this.GBOConsCli.TabIndex = 1;
            this.GBOConsCli.TabStop = false;
            this.GBOConsCli.Text = "Datos del Cliente";
            // 
            // CboTodosCli
            // 
            this.CboTodosCli.FormattingEnabled = true;
            this.CboTodosCli.Location = new System.Drawing.Point(151, 38);
            this.CboTodosCli.Name = "CboTodosCli";
            this.CboTodosCli.Size = new System.Drawing.Size(307, 26);
            this.CboTodosCli.TabIndex = 1;
            this.CboTodosCli.Text = "Todos";
            // 
            // LblNomTodCli
            // 
            this.LblNomTodCli.AutoSize = true;
            this.LblNomTodCli.Location = new System.Drawing.Point(17, 38);
            this.LblNomTodCli.Name = "LblNomTodCli";
            this.LblNomTodCli.Size = new System.Drawing.Size(73, 18);
            this.LblNomTodCli.TabIndex = 0;
            this.LblNomTodCli.Text = "Nombre:";
            // 
            // GboConsMasc
            // 
            this.GboConsMasc.Controls.Add(this.CboTodMasc);
            this.GboConsMasc.Controls.Add(this.LblNomTodMas);
            this.GboConsMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboConsMasc.Location = new System.Drawing.Point(12, 142);
            this.GboConsMasc.Name = "GboConsMasc";
            this.GboConsMasc.Size = new System.Drawing.Size(518, 76);
            this.GboConsMasc.TabIndex = 2;
            this.GboConsMasc.TabStop = false;
            this.GboConsMasc.Text = "Datos de la Mascota";
            // 
            // CboTodMasc
            // 
            this.CboTodMasc.FormattingEnabled = true;
            this.CboTodMasc.Location = new System.Drawing.Point(151, 38);
            this.CboTodMasc.Name = "CboTodMasc";
            this.CboTodMasc.Size = new System.Drawing.Size(307, 26);
            this.CboTodMasc.TabIndex = 1;
            this.CboTodMasc.Text = "Todos";
            // 
            // LblNomTodMas
            // 
            this.LblNomTodMas.AutoSize = true;
            this.LblNomTodMas.Location = new System.Drawing.Point(17, 38);
            this.LblNomTodMas.Name = "LblNomTodMas";
            this.LblNomTodMas.Size = new System.Drawing.Size(73, 18);
            this.LblNomTodMas.TabIndex = 0;
            this.LblNomTodMas.Text = "Nombre:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(669, 48);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(181, 61);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // GboResult
            // 
            this.GboResult.Controls.Add(this.dataGridView1);
            this.GboResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboResult.Location = new System.Drawing.Point(32, 323);
            this.GboResult.Name = "GboResult";
            this.GboResult.Size = new System.Drawing.Size(1334, 262);
            this.GboResult.TabIndex = 2;
            this.GboResult.TabStop = false;
            this.GboResult.Text = "Resultados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1256, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(669, 162);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 61);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 609);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.GboResult);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.GboConsMasc);
            this.Controls.Add(this.GBOConsCli);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.GBOConsCli.ResumeLayout(false);
            this.GBOConsCli.PerformLayout();
            this.GboConsMasc.ResumeLayout(false);
            this.GboConsMasc.PerformLayout();
            this.GboResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBOConsCli;
        private System.Windows.Forms.ComboBox CboTodosCli;
        private System.Windows.Forms.Label LblNomTodCli;
        private System.Windows.Forms.GroupBox GboConsMasc;
        private System.Windows.Forms.ComboBox CboTodMasc;
        private System.Windows.Forms.Label LblNomTodMas;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox GboResult;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar;
    }
}