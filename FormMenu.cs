using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace labInventario
{
    public partial class FormMenu : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\dcardon\source\repos\labInventario\database\labInventarioDB.accdb;Persist Security Info=False;";

        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT p.Codigo, p.Nombre, p.Descripcion, p.Precio, p.Stock, c.Nombre AS Categoria
                                     FROM Productos p
                                     LEFT JOIN Categorias c ON p.CategoriaID = c.CategoriaID";

                    using (OleDbCommand comando = new OleDbCommand(query, connection))
                    {
                        using (OleDbDataAdapter adaptador = new OleDbDataAdapter(comando))
                        {
                            DataTable dataTable = new DataTable();
                            adaptador.Fill(dataTable);
                            dg1.DataSource = dataTable;
                        }
                    }

                    // Ajustar los nombres de las columnas si es necesario
                    dg1.Columns["Codigo"].HeaderText = "Código";
                    dg1.Columns["Descripcion"].HeaderText = "Descripción";
                    // Opcional: Formatear la columna de Precio si es necesario
                    dg1.Columns["Precio"].DefaultCellStyle.Format = "C2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dg1.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtener la ruta de la base de datos para usarla como ubicación de guardado
                string dbFolderPath = Path.GetDirectoryName(connectionString.Split('=')[2]);
                string excelFilePath = Path.Combine(dbFolderPath, "InventarioExportado.xlsx");

                // Crear una nueva aplicación de Excel
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

                // Exportar encabezados de columnas
                for (int i = 0; i < dg1.Columns.Count; i++)
                {
                    excelWorksheet.Cells[1, i + 1] = dg1.Columns[i].HeaderText;
                }

                // Exportar filas y columnas (contenido del DataGridView)
                for (int rowIndex = 0; rowIndex < dg1.Rows.Count; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < dg1.Columns.Count; colIndex++)
                    {
                        excelWorksheet.Cells[rowIndex + 2, colIndex + 1] = dg1.Rows[rowIndex].Cells[colIndex].Value?.ToString();
                    }
                }

                // Guardar el archivo Excel
                excelWorkbook.SaveAs(excelFilePath);
                excelWorkbook.Close();
                excelApp.Quit();

                MessageBox.Show($"Datos exportados exitosamente a {excelFilePath}", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}