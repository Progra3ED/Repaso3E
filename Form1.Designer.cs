namespace Repaso3E
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonMayorMenor = new System.Windows.Forms.Button();
            this.labelMayor1 = new System.Windows.Forms.Label();
            this.labelMenor1 = new System.Windows.Forms.Label();
            this.labelPropietario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(32, 323);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(158, 79);
            this.buttonMostrar.TabIndex = 1;
            this.buttonMostrar.Text = "Mostrar Resumen";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Enabled = false;
            this.buttonOrdenar.Location = new System.Drawing.Point(230, 323);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(149, 79);
            this.buttonOrdenar.TabIndex = 2;
            this.buttonOrdenar.Text = "Ordenar";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // buttonMayorMenor
            // 
            this.buttonMayorMenor.Enabled = false;
            this.buttonMayorMenor.Location = new System.Drawing.Point(436, 323);
            this.buttonMayorMenor.Name = "buttonMayorMenor";
            this.buttonMayorMenor.Size = new System.Drawing.Size(169, 79);
            this.buttonMayorMenor.TabIndex = 3;
            this.buttonMayorMenor.Text = "Mostrar Mayor y Menor";
            this.buttonMayorMenor.UseVisualStyleBackColor = true;
            this.buttonMayorMenor.Click += new System.EventHandler(this.buttonMayorMenor_Click);
            // 
            // labelMayor1
            // 
            this.labelMayor1.AutoSize = true;
            this.labelMayor1.Location = new System.Drawing.Point(822, 98);
            this.labelMayor1.Name = "labelMayor1";
            this.labelMayor1.Size = new System.Drawing.Size(35, 13);
            this.labelMayor1.TabIndex = 4;
            this.labelMayor1.Text = "label1";
            // 
            // labelMenor1
            // 
            this.labelMenor1.AutoSize = true;
            this.labelMenor1.Location = new System.Drawing.Point(825, 157);
            this.labelMenor1.Name = "labelMenor1";
            this.labelMenor1.Size = new System.Drawing.Size(35, 13);
            this.labelMenor1.TabIndex = 5;
            this.labelMenor1.Text = "label2";
            // 
            // labelPropietario
            // 
            this.labelPropietario.AutoSize = true;
            this.labelPropietario.Location = new System.Drawing.Point(822, 74);
            this.labelPropietario.Name = "labelPropietario";
            this.labelPropietario.Size = new System.Drawing.Size(35, 13);
            this.labelPropietario.TabIndex = 6;
            this.labelPropietario.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 566);
            this.Controls.Add(this.labelPropietario);
            this.Controls.Add(this.labelMenor1);
            this.Controls.Add(this.labelMayor1);
            this.Controls.Add(this.buttonMayorMenor);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Button buttonMayorMenor;
        private System.Windows.Forms.Label labelMayor1;
        private System.Windows.Forms.Label labelMenor1;
        private System.Windows.Forms.Label labelPropietario;
    }
}

