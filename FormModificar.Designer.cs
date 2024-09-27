namespace labInventario
{
    partial class FormModificar
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
            label1 = new Label();
            btnModificar = new Button();
            txtCodigoMod = new TextBox();
            txtStockMod = new TextBox();
            txtPrecioMod = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 20);
            label1.Name = "label1";
            label1.Size = new Size(279, 15);
            label1.TabIndex = 0;
            label1.Text = "Escriba el codigo del item y el nuevo stock o precio.";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(142, 152);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtCodigoMod
            // 
            txtCodigoMod.Location = new Point(131, 63);
            txtCodigoMod.Name = "txtCodigoMod";
            txtCodigoMod.Size = new Size(100, 23);
            txtCodigoMod.TabIndex = 2;
            // 
            // txtStockMod
            // 
            txtStockMod.Location = new Point(62, 105);
            txtStockMod.Name = "txtStockMod";
            txtStockMod.Size = new Size(100, 23);
            txtStockMod.TabIndex = 3;
            // 
            // txtPrecioMod
            // 
            txtPrecioMod.Location = new Point(193, 105);
            txtPrecioMod.Name = "txtPrecioMod";
            txtPrecioMod.Size = new Size(100, 23);
            txtPrecioMod.TabIndex = 4;
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 187);
            Controls.Add(txtPrecioMod);
            Controls.Add(txtStockMod);
            Controls.Add(txtCodigoMod);
            Controls.Add(btnModificar);
            Controls.Add(label1);
            Name = "FormModificar";
            Text = "FormModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnModificar;
        private TextBox txtCodigoMod;
        private TextBox txtStockMod;
        private TextBox txtPrecioMod;
    }
}