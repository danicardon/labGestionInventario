using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace labInventario
{
    public partial class FormMenu : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dcardon\source\repos\labInventario\database\labInventarioDB.accdb;Persist Security Info=False;";

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

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dg1.DataSource = dataTable;
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
    }
}