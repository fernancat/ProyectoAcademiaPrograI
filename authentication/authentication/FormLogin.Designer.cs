namespace authentication
{
    partial class FormLogin
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
            label1 = new Label();
            usuarioTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            contraseñaTxt = new TextBox();
            Loguear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 47);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // usuarioTxt
            // 
            usuarioTxt.Location = new Point(311, 114);
            usuarioTxt.Name = "usuarioTxt";
            usuarioTxt.Size = new Size(125, 27);
            usuarioTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 121);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 181);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // contraseñaTxt
            // 
            contraseñaTxt.Location = new Point(311, 178);
            contraseñaTxt.Name = "contraseñaTxt";
            contraseñaTxt.Size = new Size(125, 27);
            contraseñaTxt.TabIndex = 3;
            // 
            // Loguear
            // 
            Loguear.Location = new Point(308, 270);
            Loguear.Name = "Loguear";
            Loguear.Size = new Size(94, 29);
            Loguear.TabIndex = 5;
            Loguear.Text = "Iniciar Sesión";
            Loguear.UseVisualStyleBackColor = true;
            Loguear.Click += Loguear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Loguear);
            Controls.Add(label3);
            Controls.Add(contraseñaTxt);
            Controls.Add(label2);
            Controls.Add(usuarioTxt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usuarioTxt;
        private Label label2;
        private Label label3;
        private TextBox contraseñaTxt;
        private Button Loguear;
    }
}
