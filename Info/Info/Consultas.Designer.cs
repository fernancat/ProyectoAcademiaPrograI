namespace Info
{
    partial class Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            Nombres = new TextBox();
            Enviar = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel1 = new Panel();
            label1 = new Label();
            btonA = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sqlConnection1
            // 
            sqlConnection1.AccessTokenCallback = null;
            sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // Nombres
            // 
            Nombres.BackColor = Color.FromArgb(36, 7, 80);
            Nombres.ForeColor = SystemColors.Info;
            Nombres.Location = new Point(61, 205);
            Nombres.Name = "Nombres";
            Nombres.Size = new Size(287, 23);
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
            Enviar.FillColor = Color.FromArgb(1, 32, 78);
            Enviar.Font = new Font("Segoe UI", 9F);
            Enviar.ForeColor = Color.White;
            Enviar.Location = new Point(444, 183);
            Enviar.Name = "Enviar";
            Enviar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Enviar.Size = new Size(180, 45);
            Enviar.TabIndex = 3;
            Enviar.Text = "Enviar";
            Enviar.Click += Enviar_Click_1;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(1, 32, 78);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.Controls.Add(panel1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.Location = new Point(0, 297);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(800, 153);
            guna2Panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(183, 53);
            label2.Name = "label2";
            label2.Size = new Size(495, 16);
            label2.TabIndex = 6;
            label2.Text = "En nuestra plataforma, estamos aquí para ayudarte en todo lo que necesites.";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(-693, 30);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(3, 2);
            guna2HtmlLabel1.TabIndex = 6;
            guna2HtmlLabel1.Text = null;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(12, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(126, 115);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(306, 9);
            label1.Name = "label1";
            label1.Size = new Size(511, 111);
            label1.TabIndex = 5;
            label1.Text = "Consultas";
            // 
            // btonA
            // 
            btonA.BackColor = Color.Transparent;
            btonA.BorderRadius = 8;
            btonA.CustomizableEdges = customizableEdges5;
            btonA.DisabledState.BorderColor = Color.DarkGray;
            btonA.DisabledState.CustomBorderColor = Color.DarkGray;
            btonA.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btonA.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btonA.FillColor = Color.FromArgb(1, 32, 78);
            btonA.Font = new Font("Segoe UI", 9F);
            btonA.ForeColor = Color.White;
            btonA.Location = new Point(444, 246);
            btonA.Name = "btonA";
            btonA.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btonA.Size = new Size(180, 45);
            btonA.TabIndex = 6;
            btonA.Text = "Jugar";
            btonA.Click += this.btonA_Click;
            // 
            // Consultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btonA);
            Controls.Add(label1);
            Controls.Add(guna2Panel1);
            Controls.Add(Nombres);
            Controls.Add(Enviar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Consultas";
            Text = "Form1";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private TextBox Nombres;
        private Guna.UI2.WinForms.Guna2Button Enviar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btonA;
    }
}
