namespace pruebaBD.Pantallas_Administrador
{
    partial class MenuAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAadmin = new System.Windows.Forms.Button();
            this.bynAprofesor = new System.Windows.Forms.Button();
            this.btnAestudiante = new System.Windows.Forms.Button();
            this.btnAcursogrupo = new System.Windows.Forms.Button();
            this.btnMAGregresar = new System.Windows.Forms.Button();
            this.btnGAPadre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU DE GESTION";
            // 
            // BtnAadmin
            // 
            this.BtnAadmin.Location = new System.Drawing.Point(107, 47);
            this.BtnAadmin.Name = "BtnAadmin";
            this.BtnAadmin.Size = new System.Drawing.Size(129, 23);
            this.BtnAadmin.TabIndex = 1;
            this.BtnAadmin.Text = "ADMINISTRADOR";
            this.BtnAadmin.UseVisualStyleBackColor = true;
            this.BtnAadmin.Click += new System.EventHandler(this.BtnAadmin_Click);
            // 
            // bynAprofesor
            // 
            this.bynAprofesor.Location = new System.Drawing.Point(107, 90);
            this.bynAprofesor.Name = "bynAprofesor";
            this.bynAprofesor.Size = new System.Drawing.Size(129, 23);
            this.bynAprofesor.TabIndex = 2;
            this.bynAprofesor.Text = "PROFESOR";
            this.bynAprofesor.UseVisualStyleBackColor = true;
            this.bynAprofesor.Click += new System.EventHandler(this.bynAprofesor_Click);
            // 
            // btnAestudiante
            // 
            this.btnAestudiante.Location = new System.Drawing.Point(107, 138);
            this.btnAestudiante.Name = "btnAestudiante";
            this.btnAestudiante.Size = new System.Drawing.Size(129, 23);
            this.btnAestudiante.TabIndex = 3;
            this.btnAestudiante.Text = "ESTUDIANTE";
            this.btnAestudiante.UseVisualStyleBackColor = true;
            this.btnAestudiante.Click += new System.EventHandler(this.btnAestudiante_Click);
            // 
            // btnAcursogrupo
            // 
            this.btnAcursogrupo.Location = new System.Drawing.Point(107, 223);
            this.btnAcursogrupo.Name = "btnAcursogrupo";
            this.btnAcursogrupo.Size = new System.Drawing.Size(129, 44);
            this.btnAcursogrupo.TabIndex = 4;
            this.btnAcursogrupo.Text = "CURSOS Y GRUPOS";
            this.btnAcursogrupo.UseVisualStyleBackColor = true;
            this.btnAcursogrupo.Click += new System.EventHandler(this.btnAcursogrupo_Click);
            // 
            // btnMAGregresar
            // 
            this.btnMAGregresar.Location = new System.Drawing.Point(12, 297);
            this.btnMAGregresar.Name = "btnMAGregresar";
            this.btnMAGregresar.Size = new System.Drawing.Size(98, 23);
            this.btnMAGregresar.TabIndex = 5;
            this.btnMAGregresar.Text = "REGRESAR";
            this.btnMAGregresar.UseVisualStyleBackColor = true;
            this.btnMAGregresar.Click += new System.EventHandler(this.btnMAGregresar_Click);
            // 
            // btnGAPadre
            // 
            this.btnGAPadre.Location = new System.Drawing.Point(107, 180);
            this.btnGAPadre.Name = "btnGAPadre";
            this.btnGAPadre.Size = new System.Drawing.Size(129, 23);
            this.btnGAPadre.TabIndex = 6;
            this.btnGAPadre.Text = "Padres";
            this.btnGAPadre.UseVisualStyleBackColor = false;
            this.btnGAPadre.Click += new System.EventHandler(this.btnGAPadre_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 330);
            this.Controls.Add(this.btnGAPadre);
            this.Controls.Add(this.btnMAGregresar);
            this.Controls.Add(this.btnAcursogrupo);
            this.Controls.Add(this.btnAestudiante);
            this.Controls.Add(this.bynAprofesor);
            this.Controls.Add(this.BtnAadmin);
            this.Controls.Add(this.label1);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAadmin;
        private System.Windows.Forms.Button bynAprofesor;
        private System.Windows.Forms.Button btnAestudiante;
        private System.Windows.Forms.Button btnAcursogrupo;
        private System.Windows.Forms.Button btnMAGregresar;
        private System.Windows.Forms.Button btnGAPadre;
    }
}