namespace UI
{
    partial class FrmPartidaUno
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
            this.rtbJugada = new System.Windows.Forms.RichTextBox();
            this.btn_iniciarPartida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbJugada
            // 
            this.rtbJugada.Location = new System.Drawing.Point(22, 12);
            this.rtbJugada.Name = "rtbJugada";
            this.rtbJugada.ReadOnly = true;
            this.rtbJugada.Size = new System.Drawing.Size(369, 534);
            this.rtbJugada.TabIndex = 2;
            this.rtbJugada.Text = "";
            // 
            // btn_iniciarPartida
            // 
            this.btn_iniciarPartida.Location = new System.Drawing.Point(121, 552);
            this.btn_iniciarPartida.Name = "btn_iniciarPartida";
            this.btn_iniciarPartida.Size = new System.Drawing.Size(138, 23);
            this.btn_iniciarPartida.TabIndex = 3;
            this.btn_iniciarPartida.Text = "Iniciar Partida";
            this.btn_iniciarPartida.UseVisualStyleBackColor = true;
            this.btn_iniciarPartida.Click += new System.EventHandler(this.btn_iniciarPartida_Click);
            // 
            // FrmPartidaUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 584);
            this.Controls.Add(this.btn_iniciarPartida);
            this.Controls.Add(this.rtbJugada);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPartidaUno";
            this.Text = "Sala de Truco";
            this.Load += new System.EventHandler(this.FrmPartidaUno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbJugada;
        private System.Windows.Forms.Button btn_iniciarPartida;
    }
}