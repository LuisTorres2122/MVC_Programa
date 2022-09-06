
namespace Prueba
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
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.navegador1 = new Vista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(227, 395);
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.Size = new System.Drawing.Size(775, 248);
            this.dgv_tabla.TabIndex = 1;
            this.dgv_tabla.Tag = "empleados";
            // 
            // navegador1
            // 
            this.navegador1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.navegador1.Location = new System.Drawing.Point(12, 23);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(147, 660);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            this.navegador1.Click += new System.EventHandler(this.navegador1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 695);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.navegador1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Vista.Navegador navegador1;
        private System.Windows.Forms.DataGridView dgv_tabla;
    }
}

