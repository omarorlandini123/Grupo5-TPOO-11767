namespace pruebaBD.Pantallas_Administrador
{
    partial class PantGEScursosgrupos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtNomGrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminarGrupo = new System.Windows.Forms.Button();
            this.btnAGregarGRupo = new System.Windows.Forms.Button();
            this.dataGridViewGrupo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarCurso = new System.Windows.Forms.Button();
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            this.textNomCruso = new System.Windows.Forms.TextBox();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.txtNomGrupo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnEliminarGrupo);
            this.panel1.Controls.Add(this.btnAGregarGRupo);
            this.panel1.Controls.Add(this.dataGridViewGrupo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 267);
            this.panel1.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(4, 237);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(134, 23);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtNomGrupo
            // 
            this.txtNomGrupo.Location = new System.Drawing.Point(95, 87);
            this.txtNomGrupo.Name = "txtNomGrupo";
            this.txtNomGrupo.Size = new System.Drawing.Size(199, 22);
            this.txtNomGrupo.TabIndex = 5;
            this.txtNomGrupo.TextChanged += new System.EventHandler(this.txtNomGrupo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del Gupo";
            // 
            // btnEliminarGrupo
            // 
            this.btnEliminarGrupo.Location = new System.Drawing.Point(130, 187);
            this.btnEliminarGrupo.Name = "btnEliminarGrupo";
            this.btnEliminarGrupo.Size = new System.Drawing.Size(120, 28);
            this.btnEliminarGrupo.TabIndex = 3;
            this.btnEliminarGrupo.Text = "Eliminar";
            this.btnEliminarGrupo.UseVisualStyleBackColor = true;
            this.btnEliminarGrupo.Click += new System.EventHandler(this.btnEliminarGrupo_Click);
            // 
            // btnAGregarGRupo
            // 
            this.btnAGregarGRupo.Location = new System.Drawing.Point(130, 139);
            this.btnAGregarGRupo.Name = "btnAGregarGRupo";
            this.btnAGregarGRupo.Size = new System.Drawing.Size(120, 26);
            this.btnAGregarGRupo.TabIndex = 2;
            this.btnAGregarGRupo.Text = "Agregar";
            this.btnAGregarGRupo.UseVisualStyleBackColor = true;
            this.btnAGregarGRupo.Click += new System.EventHandler(this.btnAGregarGRupo_Click);
            // 
            // dataGridViewGrupo
            // 
            this.dataGridViewGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupo.Location = new System.Drawing.Point(408, 63);
            this.dataGridViewGrupo.Name = "dataGridViewGrupo";
            this.dataGridViewGrupo.RowHeadersWidth = 51;
            this.dataGridViewGrupo.RowTemplate.Height = 24;
            this.dataGridViewGrupo.Size = new System.Drawing.Size(355, 176);
            this.dataGridViewGrupo.TabIndex = 1;
            this.dataGridViewGrupo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGrupo_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "GESTION DE GRUPOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION DE CURSOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del curso";
            // 
            // btnAgregarCurso
            // 
            this.btnAgregarCurso.Location = new System.Drawing.Point(133, 119);
            this.btnAgregarCurso.Name = "btnAgregarCurso";
            this.btnAgregarCurso.Size = new System.Drawing.Size(120, 27);
            this.btnAgregarCurso.TabIndex = 3;
            this.btnAgregarCurso.Text = "Agregar";
            this.btnAgregarCurso.UseVisualStyleBackColor = true;
            this.btnAgregarCurso.Click += new System.EventHandler(this.btnAgregarCurso_Click);
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.Location = new System.Drawing.Point(133, 179);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(120, 23);
            this.btnEliminarCurso.TabIndex = 4;
            this.btnEliminarCurso.Text = "Eliminar";
            this.btnEliminarCurso.UseVisualStyleBackColor = true;
            this.btnEliminarCurso.Click += new System.EventHandler(this.btnEliminarCurso_Click);
            // 
            // textNomCruso
            // 
            this.textNomCruso.Location = new System.Drawing.Point(98, 74);
            this.textNomCruso.Name = "textNomCruso";
            this.textNomCruso.Size = new System.Drawing.Size(199, 22);
            this.textNomCruso.TabIndex = 5;
            this.textNomCruso.TextChanged += new System.EventHandler(this.textNomCruso_TextChanged);
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Location = new System.Drawing.Point(411, 55);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.RowHeadersWidth = 51;
            this.dataGridViewCursos.RowTemplate.Height = 24;
            this.dataGridViewCursos.Size = new System.Drawing.Size(355, 170);
            this.dataGridViewCursos.TabIndex = 6;
            this.dataGridViewCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PantGEScursosgrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.dataGridViewCursos);
            this.Controls.Add(this.textNomCruso);
            this.Controls.Add(this.btnEliminarCurso);
            this.Controls.Add(this.btnAgregarCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "PantGEScursosgrupos";
            this.Text = "PantGEScursosgrupos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarCurso;
        private System.Windows.Forms.Button btnEliminarCurso;
        private System.Windows.Forms.TextBox textNomCruso;
        private System.Windows.Forms.DataGridView dataGridViewCursos;
        private System.Windows.Forms.DataGridView dataGridViewGrupo;
        private System.Windows.Forms.TextBox txtNomGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarGrupo;
        private System.Windows.Forms.Button btnAGregarGRupo;
        private System.Windows.Forms.Button btnRegresar;
    }
}