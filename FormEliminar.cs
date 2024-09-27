using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace labInventario
{
    public partial class FormEliminar : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\dcardon\source\repos\labInventario\database\labInventarioDB.accdb;Persist Security Info=False;";

        public FormEliminar()
        {
            InitializeComponent();
        }

        private void btnEliminado_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Productos WHERE Codigo = @Codigo";

                        using (OleDbCommand comando = new OleDbCommand(query, connection))
                        {
                            comando.Parameters.AddWithValue("@Codigo", txtEliminado.Text);

                            int result = comando.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtEliminado.Clear();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún producto con el código especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtEliminado.Text))
            {
                MessageBox.Show("Por favor, ingrese un código de producto para eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}