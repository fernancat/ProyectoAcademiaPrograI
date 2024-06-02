namespace Foro
{
    partial class ForosForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label5 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panelPreguntaMaestro = new Panel();
            txtPregunta = new Guna.UI2.WinForms.Guna2TextBox();
            button1 = new Button();
            label3 = new Label();
            ComboBoxPreguntas = new Guna.UI2.WinForms.Guna2ComboBox();
            label6 = new Label();
            btn_EnviarRespuestas = new Button();
            txt_Respuestas = new TextBox();
            listBox1 = new ListBox();
            txt_Descripcion = new TextBox();
            foroLISTBOX = new Label();
            txt_Titulo = new TextBox();
            comboBox_Foros = new ComboBox();
            label2 = new Label();
            btn_AgraegarForo = new Button();
            btn_Eliminar = new Button();
            panelEdicion = new Panel();
            panelMaestroForo = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            panel4.SuspendLayout();
            panelPreguntaMaestro.SuspendLayout();
            panelEdicion.SuspendLayout();
            panelMaestroForo.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 18);
            label5.Name = "label5";
            label5.Size = new Size(199, 17);
            label5.TabIndex = 6;
            label5.Text = "PREGUNTAS DISPONIBLES";
            label5.Click += label5_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(295, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1465, 10);
            panel3.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.Controls.Add(panelPreguntaMaestro);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(ComboBoxPreguntas);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(295, 10);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1465, 153);
            panel4.TabIndex = 15;
            // 
            // panelPreguntaMaestro
            // 
            panelPreguntaMaestro.Controls.Add(txtPregunta);
            panelPreguntaMaestro.Controls.Add(button1);
            panelPreguntaMaestro.Location = new Point(357, 18);
            panelPreguntaMaestro.Name = "panelPreguntaMaestro";
            panelPreguntaMaestro.Size = new Size(251, 123);
            panelPreguntaMaestro.TabIndex = 21;
            // 
            // txtPregunta
            // 
            txtPregunta.CustomizableEdges = customizableEdges7;
            txtPregunta.DefaultText = "";
            txtPregunta.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPregunta.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPregunta.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPregunta.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPregunta.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPregunta.Font = new Font("Segoe UI", 9F);
            txtPregunta.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPregunta.Location = new Point(20, 88);
            txtPregunta.Margin = new Padding(3, 4, 3, 4);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.PasswordChar = '\0';
            txtPregunta.PlaceholderText = "";
            txtPregunta.SelectedText = "";
            txtPregunta.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPregunta.Size = new Size(213, 23);
            txtPregunta.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MV Boli", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(20, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(170, 41);
            button1.TabIndex = 18;
            button1.Text = "Agregar Pregunta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowText;
            label3.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 18);
            label3.Name = "label3";
            label3.Size = new Size(288, 26);
            label3.TabIndex = 20;
            label3.Text = "SELECCIONAR PREGUNTA";
            // 
            // ComboBoxPreguntas
            // 
            ComboBoxPreguntas.BackColor = Color.Transparent;
            ComboBoxPreguntas.CustomizableEdges = customizableEdges9;
            ComboBoxPreguntas.DrawMode = DrawMode.OwnerDrawFixed;
            ComboBoxPreguntas.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxPreguntas.FocusedColor = Color.FromArgb(94, 148, 255);
            ComboBoxPreguntas.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ComboBoxPreguntas.Font = new Font("Segoe UI", 10F);
            ComboBoxPreguntas.ForeColor = Color.FromArgb(68, 88, 112);
            ComboBoxPreguntas.ItemHeight = 30;
            ComboBoxPreguntas.Location = new Point(24, 63);
            ComboBoxPreguntas.Name = "ComboBoxPreguntas";
            ComboBoxPreguntas.ShadowDecoration.CustomizableEdges = customizableEdges10;
            ComboBoxPreguntas.Size = new Size(239, 36);
            ComboBoxPreguntas.TabIndex = 17;
            ComboBoxPreguntas.SelectedIndexChanged += ComboBoxPreguntas_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(295, 167);
            label6.Name = "label6";
            label6.Size = new Size(137, 26);
            label6.TabIndex = 9;
            label6.Text = "REPUESTAS";
            // 
            // btn_EnviarRespuestas
            // 
            btn_EnviarRespuestas.BackColor = Color.FromArgb(42, 40, 48);
            btn_EnviarRespuestas.FlatAppearance.BorderSize = 0;
            btn_EnviarRespuestas.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            btn_EnviarRespuestas.FlatStyle = FlatStyle.Flat;
            btn_EnviarRespuestas.Font = new Font("MV Boli", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EnviarRespuestas.Location = new Point(296, 197);
            btn_EnviarRespuestas.Margin = new Padding(3, 4, 3, 4);
            btn_EnviarRespuestas.Name = "btn_EnviarRespuestas";
            btn_EnviarRespuestas.Size = new Size(170, 41);
            btn_EnviarRespuestas.TabIndex = 16;
            btn_EnviarRespuestas.Text = "ENVIAR RESPUESTA";
            btn_EnviarRespuestas.UseVisualStyleBackColor = false;
            btn_EnviarRespuestas.Click += btn_EnviarRespuestas_Click;
            // 
            // txt_Respuestas
            // 
            txt_Respuestas.Location = new Point(295, 246);
            txt_Respuestas.Margin = new Padding(3, 4, 3, 4);
            txt_Respuestas.Multiline = true;
            txt_Respuestas.Name = "txt_Respuestas";
            txt_Respuestas.Size = new Size(191, 26);
            txt_Respuestas.TabIndex = 15;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(295, 316);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1125, 324);
            listBox1.TabIndex = 16;
            // 
            // txt_Descripcion
            // 
            txt_Descripcion.Location = new Point(16, 129);
            txt_Descripcion.Margin = new Padding(3, 4, 3, 4);
            txt_Descripcion.Multiline = true;
            txt_Descripcion.Name = "txt_Descripcion";
            txt_Descripcion.Size = new Size(163, 50);
            txt_Descripcion.TabIndex = 7;
            // 
            // foroLISTBOX
            // 
            foroLISTBOX.AutoSize = true;
            foroLISTBOX.BackColor = Color.Black;
            foroLISTBOX.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foroLISTBOX.ForeColor = Color.White;
            foroLISTBOX.Location = new Point(32, 21);
            foroLISTBOX.Name = "foroLISTBOX";
            foroLISTBOX.Size = new Size(69, 26);
            foroLISTBOX.TabIndex = 8;
            foroLISTBOX.Text = "FORO";
            // 
            // txt_Titulo
            // 
            txt_Titulo.Location = new Point(9, 41);
            txt_Titulo.Margin = new Padding(3, 4, 3, 4);
            txt_Titulo.Name = "txt_Titulo";
            txt_Titulo.Size = new Size(179, 27);
            txt_Titulo.TabIndex = 4;
            txt_Titulo.TextChanged += txt_Titulo_TextChanged;
            // 
            // comboBox_Foros
            // 
            comboBox_Foros.FormattingEnabled = true;
            comboBox_Foros.Items.AddRange(new object[] { "CURSO 1", "CURSO 2", "CURSO 3", "CURSO 4" });
            comboBox_Foros.Location = new Point(12, 83);
            comboBox_Foros.Margin = new Padding(3, 4, 3, 4);
            comboBox_Foros.Name = "comboBox_Foros";
            comboBox_Foros.Size = new Size(198, 28);
            comboBox_Foros.TabIndex = 9;
            comboBox_Foros.SelectedIndexChanged += comboBox_Foros_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 14);
            label2.Name = "label2";
            label2.Size = new Size(170, 23);
            label2.TabIndex = 5;
            label2.Text = "TITULO DEL FORO";
            label2.Click += label2_Click;
            // 
            // btn_AgraegarForo
            // 
            btn_AgraegarForo.BackColor = Color.FromArgb(42, 40, 48);
            btn_AgraegarForo.FlatAppearance.BorderSize = 0;
            btn_AgraegarForo.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 48, 52);
            btn_AgraegarForo.FlatStyle = FlatStyle.Flat;
            btn_AgraegarForo.Font = new Font("MV Boli", 6F, FontStyle.Bold);
            btn_AgraegarForo.ForeColor = Color.White;
            btn_AgraegarForo.Location = new Point(3, 205);
            btn_AgraegarForo.Margin = new Padding(3, 4, 3, 4);
            btn_AgraegarForo.Name = "btn_AgraegarForo";
            btn_AgraegarForo.Size = new Size(106, 48);
            btn_AgraegarForo.TabIndex = 10;
            btn_AgraegarForo.Text = "AGREGAR FORO";
            btn_AgraegarForo.UseVisualStyleBackColor = false;
            btn_AgraegarForo.Click += btn_AgraegarForo_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = Color.FromArgb(42, 40, 48);
            btn_Eliminar.FlatAppearance.BorderSize = 0;
            btn_Eliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 48, 52);
            btn_Eliminar.FlatStyle = FlatStyle.Flat;
            btn_Eliminar.Font = new Font("MV Boli", 8F, FontStyle.Bold);
            btn_Eliminar.ForeColor = Color.White;
            btn_Eliminar.Location = new Point(127, 214);
            btn_Eliminar.Margin = new Padding(3, 4, 3, 4);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(119, 34);
            btn_Eliminar.TabIndex = 12;
            btn_Eliminar.Text = "ELIMINAR FORO";
            btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // panelEdicion
            // 
            panelEdicion.BackColor = Color.White;
            panelEdicion.Controls.Add(panelMaestroForo);
            panelEdicion.Controls.Add(comboBox_Foros);
            panelEdicion.Controls.Add(foroLISTBOX);
            panelEdicion.Dock = DockStyle.Left;
            panelEdicion.Location = new Point(0, 0);
            panelEdicion.Margin = new Padding(3, 4, 3, 4);
            panelEdicion.Name = "panelEdicion";
            panelEdicion.Size = new Size(295, 980);
            panelEdicion.TabIndex = 10;
            // 
            // panelMaestroForo
            // 
            panelMaestroForo.Controls.Add(txt_Titulo);
            panelMaestroForo.Controls.Add(btn_Eliminar);
            panelMaestroForo.Controls.Add(label1);
            panelMaestroForo.Controls.Add(btn_AgraegarForo);
            panelMaestroForo.Controls.Add(label2);
            panelMaestroForo.Controls.Add(txt_Descripcion);
            panelMaestroForo.CustomizableEdges = customizableEdges11;
            panelMaestroForo.Location = new Point(3, 145);
            panelMaestroForo.Name = "panelMaestroForo";
            panelMaestroForo.ShadowDecoration.CustomizableEdges = customizableEdges12;
            panelMaestroForo.Size = new Size(287, 257);
            panelMaestroForo.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 88);
            label1.Name = "label1";
            label1.Size = new Size(222, 23);
            label1.TabIndex = 17;
            label1.Text = "DESCRIPCION DEL FORO";
            // 
            // ForosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1760, 980);
            Controls.Add(txt_Respuestas);
            Controls.Add(btn_EnviarRespuestas);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panelEdicion);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ForosForm";
            Text = "Foros";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelPreguntaMaestro.ResumeLayout(false);
            panelEdicion.ResumeLayout(false);
            panelEdicion.PerformLayout();
            panelMaestroForo.ResumeLayout(false);
            panelMaestroForo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panelPreguntaMaestro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_Respuestas;
        private System.Windows.Forms.Button btn_EnviarRespuestas;
        private Label label6;
        private ListBox listBox1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxPreguntas;
        private Button button1;
        private Guna.UI2.WinForms.Guna2TextBox txtPregunta;
        private TextBox txt_Descripcion;
        private Label label3;
        private Label foroLISTBOX;
        private TextBox txt_Titulo;
        private ComboBox comboBox_Foros;
        private Label label2;
        private Button btn_AgraegarForo;
        private Button btn_Eliminar;
        private Panel panelEdicion;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel panelMaestroForo;
    }
}

