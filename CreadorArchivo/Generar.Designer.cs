namespace CreadorArchivo
{
    partial class Generar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_generar = new Button();
            btn_vista_cargar = new Button();
            SuspendLayout();
            // 
            // btn_generar
            // 
            btn_generar.Location = new Point(12, 12);
            btn_generar.Name = "btn_generar";
            btn_generar.Size = new Size(317, 48);
            btn_generar.TabIndex = 0;
            btn_generar.Text = "Generar Archivo";
            btn_generar.UseVisualStyleBackColor = true;
            btn_generar.Click += btn_generar_Click;
            // 
            // btn_vista_cargar
            // 
            btn_vista_cargar.Location = new Point(12, 90);
            btn_vista_cargar.Name = "btn_vista_cargar";
            btn_vista_cargar.Size = new Size(317, 29);
            btn_vista_cargar.TabIndex = 1;
            btn_vista_cargar.Text = "Programa Cargar";
            btn_vista_cargar.UseVisualStyleBackColor = true;
            btn_vista_cargar.Click += btn_vista_cargar_Click;
            // 
            // Generar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 131);
            Controls.Add(btn_vista_cargar);
            Controls.Add(btn_generar);
            Name = "Generar";
            Text = "Generador";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_generar;
        private Button btn_vista_cargar;
    }
}
