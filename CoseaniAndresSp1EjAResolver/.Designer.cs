namespace CoseaniAndresSp1EjAResolver
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.cmdInicioDeSesion = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(131, 64);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(353, 31);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = " Bienvenido a Sintepart SRL";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(508, 53);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(68, 58);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.WaitOnLoad = true;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // cmdInicioDeSesion
            // 
            this.cmdInicioDeSesion.Location = new System.Drawing.Point(137, 164);
            this.cmdInicioDeSesion.Name = "cmdInicioDeSesion";
            this.cmdInicioDeSesion.Size = new System.Drawing.Size(141, 67);
            this.cmdInicioDeSesion.TabIndex = 2;
            this.cmdInicioDeSesion.Text = "Iniciar Sesion";
            this.cmdInicioDeSesion.UseVisualStyleBackColor = true;
            this.cmdInicioDeSesion.Click += new System.EventHandler(this.cmdInicioDeSesion_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Location = new System.Drawing.Point(431, 164);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(141, 67);
            this.cmdCerrar.TabIndex = 3;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 344);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdInicioDeSesion);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.Logo);
            this.Name = "Form1";
            this.Text = "SINTEPART SRL";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button cmdInicioDeSesion;
        private System.Windows.Forms.Button cmdCerrar;
    }
}

