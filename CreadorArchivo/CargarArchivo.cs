using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreadorArchivo
{
    public partial class Cargar_Archivo : Form
    {
        public Cargar_Archivo()
        {
            InitializeComponent();
        }

        private void btn_cargar_archivo_Click(object sender, EventArgs e)
        {
            CargarArchivoEnDataGridView();
        }

        private void CargarArchivoEnDataGridView()
        {
            // Ruta del archivo generado por el método GenerarArchivo
            string filePath = "C:\\Archivo\\empleados.txt";

            // Verifica si el archivo existe
            if (!File.Exists(filePath))
            {
                MessageBox.Show("El archivo no existe.");
                return;
            }

            // Crear un DataTable para almacenar los datos
            DataTable dataTable = new DataTable();

            // Definir las columnas del DataTable
            dataTable.Columns.Add("Cédula", typeof(string));
            dataTable.Columns.Add("Salario", typeof(string));

            try
            {
                // Leer el archivo línea por línea
                string[] lines = File.ReadAllLines(filePath);

                // Validar que el archivo no esté vacío
                if (lines.Length == 0)
                {
                    MessageBox.Show("El archivo está vacío.");
                    return;
                }

                // Ignorar la primera línea (encabezado)
                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];

                    // Separar los datos por coma
                    string[] data = line.Split(',');

                    // Validar que la línea tenga dos columnas (cedula, salario)
                    if (data.Length == 2)
                    {
                        dataTable.Rows.Add(data[0], data[1]);
                    }
                }

                // Mostrar los datos en el DataGridView
                datagrid_empleado.DataSource = dataTable;

                //Alerta
                MessageBox.Show("Archivo Cargado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al leer el archivo: {ex.Message}");
            }
        }
    }
}
