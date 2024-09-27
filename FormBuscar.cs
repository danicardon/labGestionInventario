using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace labInventario
{
    public partial class FormBuscar : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\dcardon\source\repos\labInventario\database\labInventarioDB.accdb;Persist Security Info=False;";

        public FormBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoBuscador.Text))
            {
                MessageBox.Show("Por favor, ingrese un código de producto para buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    // Consulta SQL para buscar productos por código
                    string query = @"SELECT Codigo, Nombre, Descripcion, Precio, Stock, Categoria 
                                     FROM Productos 
                                     WHERE Codigo = @Codigo";

                    using (OleDbCommand comando = new OleDbCommand(query, connection))
                    {
                        comando.Parameters.AddWithValue("@Codigo", txtCodigoBuscador.Text);

                        using (OleDbDataAdapter adaptador = new OleDbDataAdapter(comando))
                        {
                            DataTable dataTable = new DataTable();
                            adaptador.Fill(dataTable);

                            // Si se encuentran resultados, llenamos el grid
                            if (dataTable.Rows.Count > 0)
                            {
                                dg2.DataSource = dataTable;

                                // Ajustar los nombres de las columnas si es necesario
                                dg2.Columns["Codigo"].HeaderText = "Código";
                                dg2.Columns["Nombre"].HeaderText = "Nombre";
                                dg2.Columns["Descripcion"].HeaderText = "Descripción";
                                dg2.Columns["Precio"].HeaderText = "Precio";
                                dg2.Columns["Stock"].HeaderText = "Stock";
                                dg2.Columns["Categoria"].HeaderText = "Categoría";

                                // Formatear la columna de Precio
                                dg2.Columns["Precio"].DefaultCellStyle.Format = "C2";
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún producto con el código proporcionado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dg2.DataSource = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
