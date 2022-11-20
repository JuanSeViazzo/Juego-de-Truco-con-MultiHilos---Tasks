namespace UI
{
    partial class FrmEstadisticasJugadores
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
            this.dtgEstadisticas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEstadisticas
            // 
            this.dtgEstadisticas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstadisticas.Location = new System.Drawing.Point(12, 59);
            this.dtgEstadisticas.Name = "dtgEstadisticas";
            this.dtgEstadisticas.ReadOnly = true;
            this.dtgEstadisticas.RowTemplate.Height = 25;
            this.dtgEstadisticas.Size = new System.Drawing.Size(959, 382);
            this.dtgEstadisticas.TabIndex = 1;
            // 
            // FrmEstadisticasJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(983, 575);
            this.Controls.Add(this.dtgEstadisticas);
            this.Name = "FrmEstadisticasJugadores";
            this.Text = "Estadisticas Jugadores";
            this.Load += new System.EventHandler(this.FrmEstadisticasJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstadisticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEstadisticas;
    }
}