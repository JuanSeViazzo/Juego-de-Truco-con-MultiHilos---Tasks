namespace UI
{
    partial class FrmPartida
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
            this.btnOcultar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(22, 558);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(104, 23);
            this.btnOcultar.TabIndex = 3;
            this.btnOcultar.Text = "button1";
            this.btnOcultar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(287, 558);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Finalizar Partida";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 593);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.rtbJugada);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPartida";
            this.Text = "Sala de Truco";
            this.Load += new System.EventHandler(this.FrmPartidaUno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbJugada;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.Button btnCancelar;
    }
}