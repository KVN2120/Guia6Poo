namespace Ejercicio2
{
    partial class Menu
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
            this.btnempleado = new System.Windows.Forms.Button();
            this.btnestudiante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(366, 109);
            this.button1.Size = new System.Drawing.Size(171, 83);
            // 
            // btnempleado
            // 
            this.btnempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleado.Location = new System.Drawing.Point(12, 109);
            this.btnempleado.Name = "btnempleado";
            this.btnempleado.Size = new System.Drawing.Size(171, 83);
            this.btnempleado.TabIndex = 1;
            this.btnempleado.Text = "Empleado";
            this.btnempleado.UseVisualStyleBackColor = true;
            this.btnempleado.Click += new System.EventHandler(this.btnempleado_Click);
            // 
            // btnestudiante
            // 
            this.btnestudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestudiante.Location = new System.Drawing.Point(189, 109);
            this.btnestudiante.Name = "btnestudiante";
            this.btnestudiante.Size = new System.Drawing.Size(171, 83);
            this.btnestudiante.TabIndex = 2;
            this.btnestudiante.Text = "Estudiante";
            this.btnestudiante.UseVisualStyleBackColor = true;
            this.btnestudiante.Click += new System.EventHandler(this.btnestudiante_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 341);
            this.Controls.Add(this.btnestudiante);
            this.Controls.Add(this.btnempleado);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnempleado, 0);
            this.Controls.SetChildIndex(this.btnestudiante, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnempleado;
        private System.Windows.Forms.Button btnestudiante;
    }
}