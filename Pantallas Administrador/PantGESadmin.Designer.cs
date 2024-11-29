using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace pruebaBD.Pantallas_Administrador
{
    partial class PantGESadmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGAdmAgregar = new System.Windows.Forms.Button();
            this.btnGAdmEliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGANombre = new System.Windows.Forms.TextBox();
            this.txtGAApellido = new System.Windows.Forms.TextBox();
            this.txtGACod = new System.Windows.Forms.TextBox();
            this.txtGADNI = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGAregresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION ADMINISTRADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // btnGAdmAgregar
            // 
            this.btnGAdmAgregar.Location = new System.Drawing.Point(159, 168);
            this.btnGAdmAgregar.Name = "btnGAdmAgregar";
            this.btnGAdmAgregar.Size = new System.Drawing.Size(114, 28);
            this.btnGAdmAgregar.TabIndex = 4;
            this.btnGAdmAgregar.Text = "Agregar";
            this.btnGAdmAgregar.UseVisualStyleBackColor = true;
            this.btnGAdmAgregar.Click += new System.EventHandler(this.btnGAdmAgregar_Click);
            // 
            // btnGAdmEliminar
            // 
            this.btnGAdmEliminar.Location = new System.Drawing.Point(439, 168);
            this.btnGAdmEliminar.Name = "btnGAdmEliminar";
            this.btnGAdmEliminar.Size = new System.Drawing.Size(98, 28);
            this.btnGAdmEliminar.TabIndex = 5;
            this.btnGAdmEliminar.Text = "Eliminar";
            this.btnGAdmEliminar.UseVisualStyleBackColor = true;
            this.btnGAdmEliminar.Click += new System.EventHandler(this.btnGAdmEliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "DNI";
            // 
            // txtGANombre
            // 
            this.txtGANombre.Location = new System.Drawing.Point(23, 68);
            this.txtGANombre.Name = "txtGANombre";
            this.txtGANombre.Size = new System.Drawing.Size(326, 22);
            this.txtGANombre.TabIndex = 7;
            this.txtGANombre.TextChanged += new System.EventHandler(this.txtGANombre_TextChanged);
            // 
            // txtGAApellido
            // 
            this.txtGAApellido.Location = new System.Drawing.Point(381, 68);
            this.txtGAApellido.Name = "txtGAApellido";
            this.txtGAApellido.Size = new System.Drawing.Size(336, 22);
            this.txtGAApellido.TabIndex = 8;
            this.txtGAApellido.TextChanged += new System.EventHandler(this.txtGAApellido_TextChanged);
            // 
            // txtGACod
            // 
            this.txtGACod.Location = new System.Drawing.Point(28, 123);
            this.txtGACod.Name = "txtGACod";
            this.txtGACod.Size = new System.Drawing.Size(198, 22);
            this.txtGACod.TabIndex = 9;
            this.txtGACod.TextChanged += new System.EventHandler(this.txtGACod_TextChanged);
            // 
            // txtGADNI
            // 
            this.txtGADNI.Location = new System.Drawing.Point(381, 123);
            this.txtGADNI.Name = "txtGADNI";
            this.txtGADNI.Size = new System.Drawing.Size(199, 22);
            this.txtGADNI.TabIndex = 10;
            this.txtGADNI.TextChanged += new System.EventHandler(this.txtGADNI_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(610, 271);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnGAregresar
            // 
            this.btnGAregresar.Location = new System.Drawing.Point(23, 513);
            this.btnGAregresar.Name = "btnGAregresar";
            this.btnGAregresar.Size = new System.Drawing.Size(105, 23);
            this.btnGAregresar.TabIndex = 12;
            this.btnGAregresar.Text = "REGRESAR";
            this.btnGAregresar.UseVisualStyleBackColor = true;
            this.btnGAregresar.Click += new System.EventHandler(this.btnGAregresar_Click);
            // 
            // PantGESadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 555);
            this.Controls.Add(this.btnGAregresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtGADNI);
            this.Controls.Add(this.txtGACod);
            this.Controls.Add(this.txtGAApellido);
            this.Controls.Add(this.txtGANombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGAdmEliminar);
            this.Controls.Add(this.btnGAdmAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "PantGESadmin";
            this.Text = "PantGESadmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGAdmAgregar;
        private System.Windows.Forms.Button btnGAdmEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGANombre;
        private System.Windows.Forms.TextBox txtGAApellido;
        private System.Windows.Forms.TextBox txtGACod;
        private System.Windows.Forms.TextBox txtGADNI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button btnGAregresar;
    }
}