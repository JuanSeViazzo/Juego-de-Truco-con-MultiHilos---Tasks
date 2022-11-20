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
            this.cmbJugadorUno = new System.Windows.Forms.ComboBox();
            this.cmbJugadorDos = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btn_GuardarMazo = new System.Windows.Forms.Button();
            this.btn_CargarMazo = new System.Windows.Forms.Button();
            this.btn_NuevoJugador = new System.Windows.Forms.Button();
            this.btn_Estadisticas = new System.Windows.Forms.Button();
            this.btnEstadisticasJugadores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Partidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crearNuevaSala
            // 
            this.btn_crearNuevaSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_crearNuevaSala.Location = new System.Drawing.Point(161, 393);
            this.btn_crearNuevaSala.Name = "btn_crearNuevaSala";
            this.btn_crearNuevaSala.Size = new System.Drawing.Size(122, 40);
            this.btn_crearNuevaSala.TabIndex = 0;
            this.btn_crearNuevaSala.Text = "Crear Nueva Sala";
            this.btn_crearNuevaSala.UseVisualStyleBackColor = false;
            this.btn_crearNuevaSala.Click += new System.EventHandler(this.btn_crearNuevaSala_Click);
            // 
            // dtgv_Partidas
            // 
            this.dtgv_Partidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtgv_Partidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Partidas.Location = new System.Drawing.Point(12, 12);
            this.dtgv_Partidas.Name = "dtgv_Partidas";
            this.dtgv_Partidas.ReadOnly = true;
            this.dtgv_Partidas.RowTemplate.Height = 25;
            this.dtgv_Partidas.Size = new System.Drawing.Size(569, 323);
            this.dtgv_Partidas.TabIndex = 1;
            this.dtgv_Partidas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Partidas_CellDoubleClick);
            // 
            // cmbJugadorUno
            // 
            this.cmbJugadorUno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJugadorUno.FormattingEnabled = true;
            this.cmbJugadorUno.Location = new System.Drawing.Point(24, 410);
            this.cmbJugadorUno.Name = "cmbJugadorUno";
            this.cmbJugadorUno.Size = new System.Drawing.Size(121, 23);
            this.cmbJugadorUno.TabIndex = 2;
            // 
            // cmbJugadorDos
            // 
            this.cmbJugadorDos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJugadorDos.FormattingEnabled = true;
            this.cmbJugadorDos.Location = new System.Drawing.Point(24, 450);
            this.cmbJugadorDos.Name = "cmbJugadorDos";
            this.cmbJugadorDos.Size = new System.Drawing.Size(121, 23);
            this.cmbJugadorDos.TabIndex = 3;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(69, 353);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 25);
            this.lblError.TabIndex = 4;
            // 
            // btn_GuardarMazo
            // 
            this.btn_GuardarMazo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_GuardarMazo.Location = new System.Drawing.Point(471, 440);
            this.btn_GuardarMazo.Name = "btn_GuardarMazo";
            this.btn_GuardarMazo.Size = new System.Drawing.Size(122, 40);
            this.btn_GuardarMazo.TabIndex = 5;
            this.btn_GuardarMazo.Text = "Guardar Mazo";
            this.btn_GuardarMazo.UseVisualStyleBackColor = false;
            this.btn_GuardarMazo.Click += new System.EventHandler(this.btn_GuardarMazo_Click);
            // 
            // btn_CargarMazo
            // 
            this.btn_CargarMazo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CargarMazo.Location = new System.Drawing.Point(471, 393);
            this.btn_CargarMazo.Name = "btn_CargarMazo";
            this.btn_CargarMazo.Size = new System.Drawing.Size(122, 40);
            this.btn_CargarMazo.TabIndex = 6;
            this.btn_CargarMazo.Text = "Cargar Mazo";
            this.btn_CargarMazo.UseVisualStyleBackColor = false;
            this.btn_CargarMazo.Click += new System.EventHandler(this.btn_CargarMazo_Click);
            // 
            // btn_NuevoJugador
            // 
            this.btn_NuevoJugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_NuevoJugador.Location = new System.Drawing.Point(161, 442);
            this.btn_NuevoJugador.Name = "btn_NuevoJugador";
            this.btn_NuevoJugador.Size = new System.Drawing.Size(122, 40);
            this.btn_NuevoJugador.TabIndex = 7;
            this.btn_NuevoJugador.Text = "Nuevo Jugador";
            this.btn_NuevoJugador.UseVisualStyleBackColor = false;
            this.btn_NuevoJugador.Click += new System.EventHandler(this.btn_NuevoJugador_Click);
            // 
            // btn_Estadisticas
            // 
            this.btn_Estadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Estadisticas.Location = new System.Drawing.Point(316, 393);
            this.btn_Estadisticas.Name = "btn_Estadisticas";
            this.btn_Estadisticas.Size = new System.Drawing.Size(122, 40);
            this.btn_Estadisticas.TabIndex = 8;
            this.btn_Estadisticas.Text = "Historial Partidas";
            this.btn_Estadisticas.UseVisualStyleBackColor = false;
            this.btn_Estadisticas.Click += new System.EventHandler(this.btn_Estadisticas_Click);
            // 
            // btnEstadisticasJugadores
            // 
            this.btnEstadisticasJugadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEstadisticasJugadores.Location = new System.Drawing.Point(316, 439);
            this.btnEstadisticasJugadores.Name = "btnEstadisticasJugadores";
            this.btnEstadisticasJugadores.Size = new System.Drawing.Size(122, 40);
            this.btnEstadisticasJugadores.TabIndex = 9;
            this.btnEstadisticasJugadores.Text = "Estadisticas Jugadores";
            this.btnEstadisticasJugadores.UseVisualStyleBackColor = false;
            this.btnEstadisticasJugadores.Click += new System.EventHandler(this.btnEstadisticasJugadores_Click);
            // 
            // FrmSalaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(605, 494);
            this.Controls.Add(this.btnEstadisticasJugadores);
            this.Controls.Add(this.btn_Estadisticas);
            this.Controls.Add(this.btn_NuevoJugador);
            this.Controls.Add(this.btn_CargarMazo);
            this.Controls.Add(this.btn_GuardarMazo);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cmbJugadorDos);
            this.Controls.Add(this.cmbJugadorUno);
            this.Controls.Add(this.dtgv_Partidas);
            this.Controls.Add(this.btn_crearNuevaSala);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSalaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salon de Partidas";
            this.Load += new System.EventHandler(this.FrmSalaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Partidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crearNuevaSala;
        private System.Windows.Forms.DataGridView dtgv_Partidas;
        private System.Windows.Forms.ComboBox cmbJugadorUno;
        private System.Windows.Forms.ComboBox cmbJugadorDos;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btn_GuardarMazo;
        private System.Windows.Forms.Button btn_CargarMazo;
        private System.Windows.Forms.Button btn_NuevoJugador;
        private System.Windows.Forms.Button btn_Estadisticas;
        private System.Windows.Forms.Button btnEstadisticasJugadores;
    }
}
