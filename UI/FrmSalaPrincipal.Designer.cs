namespace UI
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
            this.dtgv_Partidas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Partidas)).BeginInit();
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
            // dtgv_Partidas
            // 
            this.dtgv_Partidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Partidas.Location = new System.Drawing.Point(12, 41);
            this.dtgv_Partidas.Name = "dtgv_Partidas";
            this.dtgv_Partidas.ReadOnly = true;
            this.dtgv_Partidas.RowTemplate.Height = 25;
            this.dtgv_Partidas.Size = new System.Drawing.Size(1148, 434);
            this.dtgv_Partidas.TabIndex = 1;
            this.dtgv_Partidas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Partidas_CellDoubleClick);
            // 
            // FrmSalaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 653);
            this.Controls.Add(this.dtgv_Partidas);
            this.Controls.Add(this.btn_crearNuevaSala);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSalaPrincipal";
            this.Text = "Salon de Partidas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Partidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_crearNuevaSala;
        private System.Windows.Forms.DataGridView dtgv_Partidas;
    }
}
