namespace pruebaBD.Pantallas_Administrador
{
    partial class PantGESpadres
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregarPa = new System.Windows.Forms.Button();
            this.btnEliminarPa = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dataGridViewPadres = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPadres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DE PADRES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(44, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(319, 22);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(392, 73);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(349, 22);
            this.txtApellido.TabIndex = 6;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(44, 130);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(214, 22);
            this.txtDNI.TabIndex = 7;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(392, 129);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(190, 22);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // btnAgregarPa
            // 
            this.btnAgregarPa.Location = new System.Drawing.Point(144, 173);
            this.btnAgregarPa.Name = "btnAgregarPa";
            this.btnAgregarPa.Size = new System.Drawing.Size(197, 23);
            this.btnAgregarPa.TabIndex = 9;
            this.btnAgregarPa.Text = "Agregar";
            this.btnAgregarPa.UseVisualStyleBackColor = true;
            this.btnAgregarPa.Click += new System.EventHandler(this.btnAgregarPa_Click);
            // 
            // btnEliminarPa
            // 
            this.btnEliminarPa.Location = new System.Drawing.Point(412, 173);
            this.btnEliminarPa.Name = "btnEliminarPa";
            this.btnEliminarPa.Size = new System.Drawing.Size(191, 23);
            this.btnEliminarPa.TabIndex = 10;
            this.btnEliminarPa.Text = "Eliminar";
            this.btnEliminarPa.UseVisualStyleBackColor = true;
            this.btnEliminarPa.Click += new System.EventHandler(this.btnEliminarPa_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(13, 478);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(144, 23);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dataGridViewPadres
            // 
            this.dataGridViewPadres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPadres.Location = new System.Drawing.Point(44, 213);
            this.dataGridViewPadres.Name = "dataGridViewPadres";
            this.dataGridViewPadres.RowHeadersWidth = 51;
            this.dataGridViewPadres.RowTemplate.Height = 24;
            this.dataGridViewPadres.Size = new System.Drawing.Size(697, 240);
            this.dataGridViewPadres.TabIndex = 12;
            this.dataGridViewPadres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPadres_CellContentClick);
            // 
            // PantGESpadres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.dataGridViewPadres);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnEliminarPa);
            this.Controls.Add(this.btnAgregarPa);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PantGESpadres";
            this.Text = "PantGESpadres";
            this.Load += new System.EventHandler(this.PantGESpadres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPadres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregarPa;
        private System.Windows.Forms.Button btnEliminarPa;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dataGridViewPadres;
    }
}