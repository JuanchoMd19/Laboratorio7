namespace Laboratorio7
{
    partial class Form1
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
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.btnOrdenarCuotaMantenimiento = new System.Windows.Forms.Button();
            this.btnOrdenarMayorMenor = new System.Windows.Forms.Button();
            this.dgvMaxCuota = new System.Windows.Forms.DataGridView();
            this.dgvMinCuota = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaxCuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinCuota)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(12, 12);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowHeadersWidth = 51;
            this.dgvReporte.RowTemplate.Height = 24;
            this.dgvReporte.Size = new System.Drawing.Size(602, 188);
            this.dgvReporte.TabIndex = 0;
            // 
            // btnOrdenarCuotaMantenimiento
            // 
            this.btnOrdenarCuotaMantenimiento.Location = new System.Drawing.Point(12, 206);
            this.btnOrdenarCuotaMantenimiento.Name = "btnOrdenarCuotaMantenimiento";
            this.btnOrdenarCuotaMantenimiento.Size = new System.Drawing.Size(603, 23);
            this.btnOrdenarCuotaMantenimiento.TabIndex = 1;
            this.btnOrdenarCuotaMantenimiento.Text = "Ordenar por medio de cuota de mantenimiento ";
            this.btnOrdenarCuotaMantenimiento.UseVisualStyleBackColor = true;
            this.btnOrdenarCuotaMantenimiento.Click += new System.EventHandler(this.btnOrdenarCuotaMantenimiento_Click);
            // 
            // btnOrdenarMayorMenor
            // 
            this.btnOrdenarMayorMenor.Location = new System.Drawing.Point(13, 235);
            this.btnOrdenarMayorMenor.Name = "btnOrdenarMayorMenor";
            this.btnOrdenarMayorMenor.Size = new System.Drawing.Size(602, 23);
            this.btnOrdenarMayorMenor.TabIndex = 2;
            this.btnOrdenarMayorMenor.Text = "3 cuotras de mantenimiento más altas y las 3 más bajas";
            this.btnOrdenarMayorMenor.UseVisualStyleBackColor = true;
            this.btnOrdenarMayorMenor.Click += new System.EventHandler(this.btnOrdenarMayorMenor_Click);
            // 
            // dgvMaxCuota
            // 
            this.dgvMaxCuota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaxCuota.Location = new System.Drawing.Point(14, 264);
            this.dgvMaxCuota.Name = "dgvMaxCuota";
            this.dgvMaxCuota.RowHeadersWidth = 51;
            this.dgvMaxCuota.RowTemplate.Height = 24;
            this.dgvMaxCuota.Size = new System.Drawing.Size(307, 150);
            this.dgvMaxCuota.TabIndex = 3;
            // 
            // dgvMinCuota
            // 
            this.dgvMinCuota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMinCuota.Location = new System.Drawing.Point(326, 264);
            this.dgvMinCuota.Name = "dgvMinCuota";
            this.dgvMinCuota.RowHeadersWidth = 51;
            this.dgvMinCuota.RowTemplate.Height = 24;
            this.dgvMinCuota.Size = new System.Drawing.Size(284, 150);
            this.dgvMinCuota.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.dgvMinCuota);
            this.Controls.Add(this.dgvMaxCuota);
            this.Controls.Add(this.btnOrdenarMayorMenor);
            this.Controls.Add(this.btnOrdenarCuotaMantenimiento);
            this.Controls.Add(this.dgvReporte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaxCuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMinCuota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Button btnOrdenarCuotaMantenimiento;
        private System.Windows.Forms.Button btnOrdenarMayorMenor;
        private System.Windows.Forms.DataGridView dgvMaxCuota;
        private System.Windows.Forms.DataGridView dgvMinCuota;
    }
}

