using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace labInventario
{
    public partial class FormModificar : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\dcardon\source\repos\labInventario\database\labInventarioDB.accdb;Persist Security Info=False;";

        public FormModificar()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();

                        // Consulta SQL para modificar Precio o Stock en base al Código
                        string query = @"UPDATE Productos 
                                         SET Precio = @Precio, Stock = @Stock 
                                         WHERE Codigo = @Codigo";

                        using (OleDbCommand comando = new OleDbCommand(query, connection))
                        {
                            comando.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecioMod.Text));
                            comando.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStockMod.Text));
                            comando.Parameters.AddWithValue("@Codigo", txtCodigoMod.Text);

                            int result = comando.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Producto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el producto con el código especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            // Verifica si el código, precio y stock son válidos
            if (string.IsNullOrWhiteSpace(txtCodigoMod.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioMod.Text) ||
                string.IsNullOrWhiteSpace(txtStockMod.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecioMod.Text, out _))
            {
                MessageBox.Show("El precio debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtStockMod.Text, out _))
            {
                MessageBox.Show("El stock debe ser un número entero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            txtCodigoMod.Clear();
            txtPrecioMod.Clear();
            txtStockMod.Clear();
        }
    }
}
