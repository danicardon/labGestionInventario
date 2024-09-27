using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace labInventario
{
    public partial class FormAgregar : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\dcardon\source\repos\labInventario\database\labInventarioDB.accdb;Persist Security Info=False;";

        public FormAgregar()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        string query = @"INSERT INTO Productos (Codigo, Nombre, Descripcion, Precio, Stock, Categoria) 
                                         VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @Stock, @Categoria)";

                        using (OleDbCommand comando = new OleDbCommand(query, connection))
                        {
                            comando.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                            comando.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                            comando.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text));
                            comando.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));
                            comando.Parameters.AddWithValue("@Categoria", txtCategoria.Text);

                            int result = comando.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out _))
            {
                MessageBox.Show("El precio debe ser un valor numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtStock.Text, out _))
            {
                MessageBox.Show("El stock debe ser un número entero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtCategoria.Clear();
        }
    }
}