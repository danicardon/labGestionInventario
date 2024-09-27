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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            btnModificar.Location = new Point(130, 180);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtCodigoMod
            // 
            txtCodigoMod.Location = new Point(41, 78);
            txtCodigoMod.Name = "txtCodigoMod";
            txtCodigoMod.Size = new Size(100, 23);
            txtCodigoMod.TabIndex = 2;
            // 
            // txtStockMod
            // 
            txtStockMod.Location = new Point(198, 78);
            txtStockMod.Name = "txtStockMod";
            txtStockMod.Size = new Size(100, 23);
            txtStockMod.TabIndex = 3;
            // 
            // txtPrecioMod
            // 
            txtPrecioMod.Location = new Point(198, 122);
            txtPrecioMod.Name = "txtPrecioMod";
            txtPrecioMod.Size = new Size(100, 23);
            txtPrecioMod.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 60);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "Nuevo stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 104);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 6;
            label3.Text = "Nuevo precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 60);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 7;
            label4.Text = "Codigo";
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 237);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private Label label4;
    }
}