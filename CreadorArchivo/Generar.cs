using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;

namespace CreadorArchivo
{
    public partial class Generar : Form
    {
        private string _connectionString = "Server=JDAYTONA;Database=ferreteria;Trusted_Connection=True;TrustServerCertificate=True;";

        public Generar()
        {
            InitializeComponent();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            GenerarArchivo();
        }

        private void GenerarArchivo()
        {
            // Define la cadena de conexión
            string query = "SELECT cedula, salario FROM empleado";

            // Define el nombre del archivo
            string filePath = "C:\\Archivo\\empleados.txt";

            DateTime fechaNomina = DateTime.Now;

            //Encabezado
            string encabezado = $"40239519644,{fechaNomina:dd-MM-yyyy}";

            // Abre la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Ejecuta la consulta
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Crea o sobrescribe el archivo .txt
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine(encabezado);
                        // Lee los datos y escribe en el archivo
                        while (reader.Read())
                        {
                            string cedula = reader["cedula"].ToString();
                            string salario = reader["salario"].ToString();

                            writer.WriteLine($"{cedula},{salario}");
                        }
                    }
                }
            }

            MessageBox.Show("Archivo generado correctamente.");
        }

        private void btn_vista_cargar_Click(object sender, EventArgs e)
        {
            Cargar_Archivo formulario = new(); 
            formulario.Show();
        }
    }

}
