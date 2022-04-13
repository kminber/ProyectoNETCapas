
namespace Presentacion
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
            this.btnPrueba = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnAltaLibros = new System.Windows.Forms.Button();
            this.btnModificacionLibros = new System.Windows.Forms.Button();
            this.btnEliminacionLibros = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultaDeLibros = new System.Windows.Forms.Button();
            this.btnConsultaDeLibrosUnidades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(69, 12);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(171, 80);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "Prueba de conexión";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(135, 95);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "label1";
            this.lblResultado.Visible = false;
            // 
            // btnAltaLibros
            // 
            this.btnAltaLibros.Location = new System.Drawing.Point(69, 137);
            this.btnAltaLibros.Name = "btnAltaLibros";
            this.btnAltaLibros.Size = new System.Drawing.Size(171, 80);
            this.btnAltaLibros.TabIndex = 2;
            this.btnAltaLibros.Text = "Alta de Libros";
            this.btnAltaLibros.UseVisualStyleBackColor = true;
            this.btnAltaLibros.Click += new System.EventHandler(this.btnAltaLibros_Click);
            // 
            // btnModificacionLibros
            // 
            this.btnModificacionLibros.Location = new System.Drawing.Point(313, 137);
            this.btnModificacionLibros.Name = "btnModificacionLibros";
            this.btnModificacionLibros.Size = new System.Drawing.Size(171, 80);
            this.btnModificacionLibros.TabIndex = 3;
            this.btnModificacionLibros.Text = "Modificación de Libros";
            this.btnModificacionLibros.UseVisualStyleBackColor = true;
            this.btnModificacionLibros.Click += new System.EventHandler(this.btnModificacionLibros_Click);
            // 
            // btnEliminacionLibros
            // 
            this.btnEliminacionLibros.Location = new System.Drawing.Point(547, 137);
            this.btnEliminacionLibros.Name = "btnEliminacionLibros";
            this.btnEliminacionLibros.Size = new System.Drawing.Size(171, 80);
            this.btnEliminacionLibros.TabIndex = 4;
            this.btnEliminacionLibros.Text = "Eliminación de Libros";
            this.btnEliminacionLibros.UseVisualStyleBackColor = true;
            this.btnEliminacionLibros.Click += new System.EventHandler(this.btnEliminacionLibros_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnConsultaDeLibros
            // 
            this.btnConsultaDeLibros.Location = new System.Drawing.Point(313, 12);
            this.btnConsultaDeLibros.Name = "btnConsultaDeLibros";
            this.btnConsultaDeLibros.Size = new System.Drawing.Size(171, 80);
            this.btnConsultaDeLibros.TabIndex = 6;
            this.btnConsultaDeLibros.Text = "Consulta de libros";
            this.btnConsultaDeLibros.UseVisualStyleBackColor = true;
            this.btnConsultaDeLibros.Click += new System.EventHandler(this.btnConsultaDeLibros_Click);
            // 
            // btnConsultaDeLibrosUnidades
            // 
            this.btnConsultaDeLibrosUnidades.Location = new System.Drawing.Point(547, 12);
            this.btnConsultaDeLibrosUnidades.Name = "btnConsultaDeLibrosUnidades";
            this.btnConsultaDeLibrosUnidades.Size = new System.Drawing.Size(171, 80);
            this.btnConsultaDeLibrosUnidades.TabIndex = 7;
            this.btnConsultaDeLibrosUnidades.Text = "Consulta de libros unidades";
            this.btnConsultaDeLibrosUnidades.UseVisualStyleBackColor = true;
            this.btnConsultaDeLibrosUnidades.Click += new System.EventHandler(this.btnConsultaDeLibrosUnidades_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.btnConsultaDeLibrosUnidades);
            this.Controls.Add(this.btnConsultaDeLibros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminacionLibros);
            this.Controls.Add(this.btnModificacionLibros);
            this.Controls.Add(this.btnAltaLibros);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnPrueba);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAltaLibros;
        private System.Windows.Forms.Button btnModificacionLibros;
        private System.Windows.Forms.Button btnEliminacionLibros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultaDeLibros;
        private System.Windows.Forms.Button btnConsultaDeLibrosUnidades;
    }
}

