
namespace Trabajo_4
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
            this.btCargar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.txtEjercicio = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.Dt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dt)).BeginInit();
            this.SuspendLayout();
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(31, 135);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(75, 23);
            this.btCargar.TabIndex = 0;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(31, 164);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 1;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // txtSemana
            // 
            this.txtSemana.Location = new System.Drawing.Point(31, 31);
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(100, 20);
            this.txtSemana.TabIndex = 2;
            // 
            // txtEjercicio
            // 
            this.txtEjercicio.Location = new System.Drawing.Point(31, 70);
            this.txtEjercicio.Name = "txtEjercicio";
            this.txtEjercicio.Size = new System.Drawing.Size(100, 20);
            this.txtEjercicio.TabIndex = 3;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(31, 109);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 4;
            // 
            // Dt
            // 
            this.Dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt.Location = new System.Drawing.Point(160, 26);
            this.Dt.Name = "Dt";
            this.Dt.Size = new System.Drawing.Size(421, 136);
            this.Dt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Semana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ejercicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Peso";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(174, 174);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 9;
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(31, 193);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 10;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 324);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dt);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtEjercicio);
            this.Controls.Add(this.txtSemana);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.TextBox txtSemana;
        private System.Windows.Forms.TextBox txtEjercicio;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.DataGridView Dt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button btLimpiar;
    }
}

