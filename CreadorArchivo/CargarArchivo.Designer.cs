namespace CreadorArchivo
{
    partial class Cargar_Archivo
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
            datagrid_empleado = new DataGridView();
            btn_cargar_archivo = new Button();
            ((System.ComponentModel.ISupportInitialize)datagrid_empleado).BeginInit();
            SuspendLayout();
            // 
            // datagrid_empleado
            // 
            datagrid_empleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_empleado.Location = new Point(12, 88);
            datagrid_empleado.Name = "datagrid_empleado";
            datagrid_empleado.RowHeadersWidth = 51;
            datagrid_empleado.Size = new Size(776, 350);
            datagrid_empleado.TabIndex = 0;
            // 
            // btn_cargar_archivo
            // 
            btn_cargar_archivo.Location = new Point(12, 48);
            btn_cargar_archivo.Name = "btn_cargar_archivo";
            btn_cargar_archivo.Size = new Size(203, 34);
            btn_cargar_archivo.TabIndex = 1;
            btn_cargar_archivo.Text = "Cargar Archivo";
            btn_cargar_archivo.UseVisualStyleBackColor = true;
            btn_cargar_archivo.Click += btn_cargar_archivo_Click;
            // 
            // Cargar_Archivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cargar_archivo);
            Controls.Add(datagrid_empleado);
            Name = "Cargar_Archivo";
            Text = "Cargar_Archivo";
            ((System.ComponentModel.ISupportInitialize)datagrid_empleado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView datagrid_empleado;
        private Button btn_cargar_archivo;
    }
}