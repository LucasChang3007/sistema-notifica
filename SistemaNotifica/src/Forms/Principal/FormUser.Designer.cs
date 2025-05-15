namespace SistemaNotifica.src.Forms.Principal
{
    partial class FormUser
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
            btnUsuario = new Label();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.AutoSize = true;
            btnUsuario.Location = new Point(331, 84);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(108, 20);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "TELA USUARIO";
            btnUsuario.Click += label1_Click;
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUser";
            Text = "FormUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnUsuario;
    }
}