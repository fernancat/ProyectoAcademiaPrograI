namespace Info
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            Nombres = new TextBox();
            Enviar = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            SuspendLayout();
            // 
            // sqlConnection1
            // 
            sqlConnection1.AccessTokenCallback = null;
            sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // Nombres
            // 
            Nombres.BackColor = Color.Black;
            Nombres.ForeColor = SystemColors.Info;
            Nombres.Location = new Point(77, 69);
            Nombres.Name = "Nombres";
            Nombres.Size = new Size(276, 23);
            Nombres.TabIndex = 0;
            Nombres.Text = "Escribe tu consulta";
            // 
            // Enviar
            // 
            Enviar.BackColor = Color.Transparent;
            Enviar.BorderRadius = 8;
            Enviar.CustomizableEdges = customizableEdges1;
            Enviar.DisabledState.BorderColor = Color.DarkGray;
            Enviar.DisabledState.CustomBorderColor = Color.DarkGray;
            Enviar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Enviar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Enviar.FillColor = Color.FromArgb(255, 192, 255);
            Enviar.Font = new Font("Segoe UI", 9F);
            Enviar.ForeColor = Color.White;
            Enviar.Location = new Point(448, 60);
            Enviar.Name = "Enviar";
            Enviar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Enviar.Size = new Size(180, 45);
            Enviar.TabIndex = 3;
            Enviar.Text = "Enviar";
            Enviar.Click += Enviar_Click_1;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Navy;
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.Location = new Point(0, 297);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(800, 153);
            guna2Panel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2Panel1);
            Controls.Add(Enviar);
            Controls.Add(Nombres);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private TextBox Nombres;
        private Guna.UI2.WinForms.Guna2Button Enviar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
