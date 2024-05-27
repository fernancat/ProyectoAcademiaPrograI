namespace EDUCATIVE
{
    partial class FormularioCargaCursos
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCargaCursos));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            rolUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            textoCorreo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            textoUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            panelCursos = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(40, 42, 52);
            guna2Panel1.Controls.Add(rolUsuario);
            guna2Panel1.Controls.Add(guna2GradientButton1);
            guna2Panel1.Controls.Add(textoCorreo);
            guna2Panel1.Controls.Add(textoUsuario);
            guna2Panel1.Controls.Add(guna2CirclePictureBox1);
            guna2Panel1.CustomizableEdges = customizableEdges11;
            guna2Panel1.Location = new Point(3, 2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel1.Size = new Size(241, 639);
            guna2Panel1.TabIndex = 0;
            // 
            // rolUsuario
            // 
            rolUsuario.BackColor = Color.Transparent;
            rolUsuario.ForeColor = Color.White;
            rolUsuario.Location = new Point(61, 216);
            rolUsuario.Name = "rolUsuario";
            rolUsuario.Size = new Size(25, 22);
            rolUsuario.TabIndex = 3;
            rolUsuario.Text = "Rol";
            // 
            // guna2GradientButton1
            // 
            guna2GradientButton1.CustomizableEdges = customizableEdges8;
            guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton1.FillColor = Color.FromArgb(60, 63, 81);
            guna2GradientButton1.FillColor2 = Color.FromArgb(40, 42, 52);
            guna2GradientButton1.Font = new Font("Segoe UI", 9F);
            guna2GradientButton1.ForeColor = Color.White;
            guna2GradientButton1.Location = new Point(20, 271);
            guna2GradientButton1.Name = "guna2GradientButton1";
            guna2GradientButton1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2GradientButton1.Size = new Size(127, 31);
            guna2GradientButton1.TabIndex = 3;
            guna2GradientButton1.Text = "Editar Perfil";
            // 
            // textoCorreo
            // 
            textoCorreo.BackColor = Color.Transparent;
            textoCorreo.ForeColor = Color.White;
            textoCorreo.Location = new Point(56, 171);
            textoCorreo.Name = "textoCorreo";
            textoCorreo.Size = new Size(96, 22);
            textoCorreo.TabIndex = 2;
            textoCorreo.Text = "correoUsuario";
            // 
            // textoUsuario
            // 
            textoUsuario.BackColor = Color.Transparent;
            textoUsuario.ForeColor = Color.White;
            textoUsuario.Location = new Point(56, 124);
            textoUsuario.Name = "textoUsuario";
            textoUsuario.Size = new Size(53, 22);
            textoUsuario.TabIndex = 1;
            textoUsuario.Text = "Usuario";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.FillColor = SystemColors.WindowFrame;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.InitialImage = (Image)resources.GetObject("guna2CirclePictureBox1.InitialImage");
            guna2CirclePictureBox1.Location = new Point(56, 21);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(80, 80);
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
            guna2CirclePictureBox1.Click += guna2CirclePictureBox1_Click;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges13;
            guna2ControlBox1.FillColor = Color.Transparent;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(1068, 12);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2ControlBox1.Size = new Size(56, 36);
            guna2ControlBox1.TabIndex = 1;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // panelCursos
            // 
            panelCursos.BackColor = Color.FromArgb(40, 42, 52);
            panelCursos.FillColor = Color.FromArgb(40, 42, 52);
            panelCursos.Location = new Point(263, 54);
            panelCursos.Name = "panelCursos";
            panelCursos.ShadowColor = Color.Black;
            panelCursos.Size = new Size(817, 560);
            panelCursos.TabIndex = 2;
            panelCursos.Paint += guna2ShadowPanel1_Paint;
            // 
            // FormularioCargaCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 63, 81);
            ClientSize = new Size(1136, 644);
            Controls.Add(panelCursos);
            Controls.Add(guna2ControlBox1);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioCargaCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlLabel textoCorreo;
        private Guna.UI2.WinForms.Guna2HtmlLabel textoUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel rolUsuario;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelCursos;
    }
}
