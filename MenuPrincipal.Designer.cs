namespace pruebaBD
{
    partial class MenuPrincipal
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
            this.BtnAdministrador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProfesor = new System.Windows.Forms.Button();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.btnPadre = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdministrador
            // 
            this.BtnAdministrador.Location = new System.Drawing.Point(100, 96);
            this.BtnAdministrador.Name = "BtnAdministrador";
            this.BtnAdministrador.Size = new System.Drawing.Size(147, 32);
            this.BtnAdministrador.TabIndex = 0;
            this.BtnAdministrador.Text = "ADMINISTRADOR";
            this.BtnAdministrador.UseVisualStyleBackColor = true;
            this.BtnAdministrador.Click += new System.EventHandler(this.BtnAdministrador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnProfesor
            // 
            this.btnProfesor.Location = new System.Drawing.Point(100, 155);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Size = new System.Drawing.Size(147, 34);
            this.btnProfesor.TabIndex = 2;
            this.btnProfesor.Text = "PROFESOR";
            this.btnProfesor.UseVisualStyleBackColor = true;
            this.btnProfesor.Click += new System.EventHandler(this.btnProfesor_Click);
            // 
            // btnAlumno
            // 
            this.btnAlumno.Location = new System.Drawing.Point(100, 211);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(147, 39);
            this.btnAlumno.TabIndex = 3;
            this.btnAlumno.Text = "ESTUDIANTE";
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // btnPadre
            // 
            this.btnPadre.Location = new System.Drawing.Point(100, 275);
            this.btnPadre.Name = "btnPadre";
            this.btnPadre.Size = new System.Drawing.Size(147, 37);
            this.btnPadre.TabIndex = 4;
            this.btnPadre.Text = "PADRE";
            this.btnPadre.UseVisualStyleBackColor = true;
            this.btnPadre.Click += new System.EventHandler(this.btnPadre_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 365);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(101, 23);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 400);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnPadre);
            this.Controls.Add(this.btnAlumno);
            this.Controls.Add(this.btnProfesor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAdministrador);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdministrador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProfesor;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Button btnPadre;
        private System.Windows.Forms.Button btnRegresar;
    }
}