﻿namespace UI
{
    partial class FrmSalaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_crearNuevaSala = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crearNuevaSala
            // 
            this.btn_crearNuevaSala.Location = new System.Drawing.Point(321, 528);
            this.btn_crearNuevaSala.Name = "btn_crearNuevaSala";
            this.btn_crearNuevaSala.Size = new System.Drawing.Size(122, 40);
            this.btn_crearNuevaSala.TabIndex = 0;
            this.btn_crearNuevaSala.Text = "Crear Nueva Sala";
            this.btn_crearNuevaSala.UseVisualStyleBackColor = true;
            this.btn_crearNuevaSala.Click += new System.EventHandler(this.btn_crearNuevaSala_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(189, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(392, 402);
            this.dataGridView1.TabIndex = 1;
            // 
            // FrmSalaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 637);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_crearNuevaSala);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSalaPrincipal";
            this.Text = "Salon de Partidas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_crearNuevaSala;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
