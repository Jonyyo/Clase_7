
namespace CARRO
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttoninicio = new System.Windows.Forms.Button();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.buttonAltoTotal = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelEstadoVelocidad = new System.Windows.Forms.Label();
            this.buttonCambio = new System.Windows.Forms.Button();
            this.labelCambio = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblRuta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnReproducir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttoninicio
            // 
            this.buttoninicio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttoninicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttoninicio.Location = new System.Drawing.Point(75, 35);
            this.buttoninicio.Name = "buttoninicio";
            this.buttoninicio.Size = new System.Drawing.Size(123, 47);
            this.buttoninicio.TabIndex = 0;
            this.buttoninicio.Text = "Crear Carro";
            this.buttoninicio.UseVisualStyleBackColor = false;
            this.buttoninicio.Click += new System.EventHandler(this.buttoninicio_Click);
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEncender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncender.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEncender.Location = new System.Drawing.Point(224, 35);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(129, 47);
            this.buttonEncender.TabIndex = 1;
            this.buttonEncender.Text = "Encender/Apagar Carro";
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Visible = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAcelerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcelerar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAcelerar.Location = new System.Drawing.Point(12, 98);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(111, 39);
            this.buttonAcelerar.TabIndex = 2;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = false;
            this.buttonAcelerar.Visible = false;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // buttonAltoTotal
            // 
            this.buttonAltoTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAltoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAltoTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAltoTotal.Location = new System.Drawing.Point(129, 98);
            this.buttonAltoTotal.Name = "buttonAltoTotal";
            this.buttonAltoTotal.Size = new System.Drawing.Size(127, 39);
            this.buttonAltoTotal.TabIndex = 3;
            this.buttonAltoTotal.Text = "Freno";
            this.buttonAltoTotal.UseVisualStyleBackColor = false;
            this.buttonAltoTotal.Visible = false;
            this.buttonAltoTotal.Click += new System.EventHandler(this.buttonAltoTotal_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEstado.Location = new System.Drawing.Point(390, 77);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(0, 18);
            this.labelEstado.TabIndex = 4;
            // 
            // labelEstadoVelocidad
            // 
            this.labelEstadoVelocidad.AutoSize = true;
            this.labelEstadoVelocidad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEstadoVelocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoVelocidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEstadoVelocidad.Location = new System.Drawing.Point(390, 119);
            this.labelEstadoVelocidad.Name = "labelEstadoVelocidad";
            this.labelEstadoVelocidad.Size = new System.Drawing.Size(0, 18);
            this.labelEstadoVelocidad.TabIndex = 5;
            // 
            // buttonCambio
            // 
            this.buttonCambio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCambio.Location = new System.Drawing.Point(262, 98);
            this.buttonCambio.Name = "buttonCambio";
            this.buttonCambio.Size = new System.Drawing.Size(111, 39);
            this.buttonCambio.TabIndex = 6;
            this.buttonCambio.Text = "Cambio";
            this.buttonCambio.UseVisualStyleBackColor = false;
            this.buttonCambio.Visible = false;
            this.buttonCambio.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCambio.Location = new System.Drawing.Point(390, 172);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(0, 18);
            this.labelCambio.TabIndex = 7;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(25, 204);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(240, 127);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargar.Location = new System.Drawing.Point(25, 356);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(95, 31);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Visible = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(578, 397);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(0, 13);
            this.lblRuta.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // btnReproducir
            // 
            this.btnReproducir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReproducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReproducir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReproducir.Location = new System.Drawing.Point(170, 356);
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.Size = new System.Drawing.Size(95, 31);
            this.btnReproducir.TabIndex = 11;
            this.btnReproducir.Text = "Reproducir";
            this.btnReproducir.UseVisualStyleBackColor = false;
            this.btnReproducir.Visible = false;
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.btnReproducir);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.labelCambio);
            this.Controls.Add(this.buttonCambio);
            this.Controls.Add(this.labelEstadoVelocidad);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.buttonAltoTotal);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.buttoninicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoninicio;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Button buttonAltoTotal;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelEstadoVelocidad;
        private System.Windows.Forms.Button buttonCambio;
        private System.Windows.Forms.Label labelCambio;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnReproducir;
    }
}

