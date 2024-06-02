namespace EDUCATIVE.Formularios.FormsDelCurso
{
    partial class FormularioEvaluacionEstudiante
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            PanelPreguntas = new Panel();
            SuspendLayout();
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.CustomizableEdges = customizableEdges1;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Location = new Point(26, 50);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ComboBox1.Size = new Size(267, 36);
            guna2ComboBox1.TabIndex = 0;
            guna2ComboBox1.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 1;
            label1.Text = "SELECCIONA LA EVALUACION";
            // 
            // PanelPreguntas
            // 
            PanelPreguntas.Location = new Point(26, 113);
            PanelPreguntas.Name = "PanelPreguntas";
            PanelPreguntas.Size = new Size(446, 279);
            PanelPreguntas.TabIndex = 2;
            // 
            // FormularioEvaluacionEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelPreguntas);
            Controls.Add(label1);
            Controls.Add(guna2ComboBox1);
            Name = "FormularioEvaluacionEstudiante";
            Text = "FormularioEvaluacionEstudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Label label1;
        private Panel PanelPreguntas;
    }
}