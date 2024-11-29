namespace pruebaBD.Pantallas
{
    partial class PantVistaProfesor
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnMenuVisProfe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Profesores = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodAlumno = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtCaliicacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodNota = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewNotasProfesor = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotasProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 527);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnMenuVisProfe
            // 
            this.btnMenuVisProfe.Location = new System.Drawing.Point(713, 527);
            this.btnMenuVisProfe.Name = "btnMenuVisProfe";
            this.btnMenuVisProfe.Size = new System.Drawing.Size(75, 23);
            this.btnMenuVisProfe.TabIndex = 1;
            this.btnMenuVisProfe.Text = "Menu";
            this.btnMenuVisProfe.UseVisualStyleBackColor = true;
            this.btnMenuVisProfe.Click += new System.EventHandler(this.btnMenuVisProfe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Profesores);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 32);
            this.panel1.TabIndex = 2;
            // 
            // Profesores
            // 
            this.Profesores.AutoSize = true;
            this.Profesores.BackColor = System.Drawing.Color.Beige;
            this.Profesores.Location = new System.Drawing.Point(29, 9);
            this.Profesores.Name = "Profesores";
            this.Profesores.Size = new System.Drawing.Size(58, 16);
            this.Profesores.TabIndex = 0;
            this.Profesores.Text = "Profesor";
            this.Profesores.Click += new System.EventHandler(this.Profesores_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "CodAlumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Califiicación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Curso";
            // 
            // txtCodAlumno
            // 
            this.txtCodAlumno.Location = new System.Drawing.Point(204, 78);
            this.txtCodAlumno.Name = "txtCodAlumno";
            this.txtCodAlumno.Size = new System.Drawing.Size(176, 22);
            this.txtCodAlumno.TabIndex = 6;
            this.txtCodAlumno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(396, 78);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(188, 22);
            this.txtCurso.TabIndex = 7;
            this.txtCurso.TextChanged += new System.EventHandler(this.txtCurso_TextChanged);
            // 
            // txtCaliicacion
            // 
            this.txtCaliicacion.Location = new System.Drawing.Point(593, 78);
            this.txtCaliicacion.Name = "txtCaliicacion";
            this.txtCaliicacion.Size = new System.Drawing.Size(180, 22);
            this.txtCaliicacion.TabIndex = 8;
            this.txtCaliicacion.TextChanged += new System.EventHandler(this.txtCaliicacion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código";
            // 
            // txtCodNota
            // 
            this.txtCodNota.Location = new System.Drawing.Point(13, 78);
            this.txtCodNota.Name = "txtCodNota";
            this.txtCodNota.Size = new System.Drawing.Size(171, 22);
            this.txtCodNota.TabIndex = 10;
            this.txtCodNota.TextChanged += new System.EventHandler(this.txtCodNota_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(432, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridViewNotasProfesor
            // 
            this.dataGridViewNotasProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotasProfesor.Location = new System.Drawing.Point(12, 148);
            this.dataGridViewNotasProfesor.Name = "dataGridViewNotasProfesor";
            this.dataGridViewNotasProfesor.RowHeadersWidth = 51;
            this.dataGridViewNotasProfesor.RowTemplate.Height = 24;
            this.dataGridViewNotasProfesor.Size = new System.Drawing.Size(776, 373);
            this.dataGridViewNotasProfesor.TabIndex = 13;
            this.dataGridViewNotasProfesor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNotasProfesor_CellContentClick);
            // 
            // PantVistaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.dataGridViewNotasProfesor);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtCodNota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCaliicacion);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtCodAlumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMenuVisProfe);
            this.Controls.Add(this.btnRegresar);
            this.Name = "PantVistaProfesor";
            this.Text = "PantVistaProfesor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotasProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnMenuVisProfe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Profesores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodAlumno;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtCaliicacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodNota;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridViewNotasProfesor;
    }
}