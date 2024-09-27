namespace labInventario
{
    partial class FormEliminar
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
            txtEliminado = new TextBox();
            btnEliminado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 22);
            label1.Name = "label1";
            label1.Size = new Size(200, 15);
            label1.TabIndex = 0;
            label1.Text = "Escriba el codigo del item a eliminar.";
            // 
            // txtEliminado
            // 
            txtEliminado.Location = new Point(92, 65);
            txtEliminado.Name = "txtEliminado";
            txtEliminado.Size = new Size(100, 23);
            txtEliminado.TabIndex = 1;
            // 
            // btnEliminado
            // 
            btnEliminado.Location = new Point(104, 130);
            btnEliminado.Name = "btnEliminado";
            btnEliminado.Size = new Size(75, 23);
            btnEliminado.TabIndex = 2;
            btnEliminado.Text = "Eliminar";
            btnEliminado.UseVisualStyleBackColor = true;
            btnEliminado.Click += btnEliminado_Click;
            // 
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 188);
            Controls.Add(btnEliminado);
            Controls.Add(txtEliminado);
            Controls.Add(label1);
            Name = "FormEliminar";
            Text = "FormEliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEliminado;
        private Button btnEliminado;
    }
}