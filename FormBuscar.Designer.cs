namespace labInventario
{
    partial class FormBuscar
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
            dg2 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnBuscarItem = new Button();
            txtCodigoBuscador = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg2).BeginInit();
            SuspendLayout();
            // 
            // dg2
            // 
            dg2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg2.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Descripcion, Stock, Precio, Categoria });
            dg2.Location = new Point(39, 139);
            dg2.Name = "dg2";
            dg2.Size = new Size(638, 269);
            dg2.TabIndex = 8;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 23);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 9;
            label1.Text = "Buscador de items";
            // 
            // btnBuscarItem
            // 
            btnBuscarItem.Location = new Point(216, 56);
            btnBuscarItem.Name = "btnBuscarItem";
            btnBuscarItem.Size = new Size(75, 23);
            btnBuscarItem.TabIndex = 10;
            btnBuscarItem.Text = "Buscar";
            btnBuscarItem.UseVisualStyleBackColor = true;
            btnBuscarItem.Click += btnBuscarItem_Click;
            // 
            // txtCodigoBuscador
            // 
            txtCodigoBuscador.Location = new Point(91, 53);
            txtCodigoBuscador.Name = "txtCodigoBuscador";
            txtCodigoBuscador.Size = new Size(100, 23);
            txtCodigoBuscador.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 56);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 12;
            label2.Text = "Codigo";
            // 
            // FormBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 421);
            Controls.Add(label2);
            Controls.Add(txtCodigoBuscador);
            Controls.Add(btnBuscarItem);
            Controls.Add(label1);
            Controls.Add(dg2);
            Name = "FormBuscar";
            Text = "FormBuscar";
            ((System.ComponentModel.ISupportInitialize)dg2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dg2;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Categoria;
        private Label label1;
        private Button btnBuscarItem;
        private TextBox txtCodigoBuscador;
        private Label label2;
    }
}