namespace EDUCATIVE
{
    partial class FormularioDelCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioDelCurso));
            Panel_BarraTitulo = new Panel();
            btn_Restaurar = new Button();
            btn_Cerrar = new Button();
            button4 = new Button();
            btm_Maximizar = new Button();
            panel1 = new Panel();
            PanelMenu = new Panel();
            btn_Retroalimentacion = new Button();
            btn_Calificaciones = new Button();
            btn_Foros = new Button();
            Btn_Tareas = new Button();
            btn_Evaluaciones = new Button();
            btn_Contenido = new Button();
            PaneLMenuLateral = new Panel();
            button1 = new Button();
            btn_ModificarCurso = new Button();
            Panel_BarraTitulo.SuspendLayout();
            panel1.SuspendLayout();
            PanelMenu.SuspendLayout();
            PaneLMenuLateral.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_BarraTitulo
            // 
            Panel_BarraTitulo.BackColor = Color.FromArgb(43, 45, 55);
            Panel_BarraTitulo.Controls.Add(btn_Restaurar);
            Panel_BarraTitulo.Controls.Add(btn_Cerrar);
            Panel_BarraTitulo.Controls.Add(button4);
            Panel_BarraTitulo.Controls.Add(btm_Maximizar);
            Panel_BarraTitulo.Dock = DockStyle.Top;
            Panel_BarraTitulo.Location = new Point(0, 0);
            Panel_BarraTitulo.Name = "Panel_BarraTitulo";
            Panel_BarraTitulo.Size = new Size(1239, 80);
            Panel_BarraTitulo.TabIndex = 0;
            Panel_BarraTitulo.Paint += Panel_BarraTitulo_Paint;
            // 
            // btn_Restaurar
            // 
            btn_Restaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Restaurar.BackColor = Color.FromArgb(43, 45, 55);
            btn_Restaurar.FlatAppearance.BorderSize = 0;
            btn_Restaurar.FlatStyle = FlatStyle.Flat;
            btn_Restaurar.Image = (Image)resources.GetObject("btn_Restaurar.Image");
            btn_Restaurar.Location = new Point(1062, 12);
            btn_Restaurar.Name = "btn_Restaurar";
            btn_Restaurar.Size = new Size(84, 49);
            btn_Restaurar.TabIndex = 5;
            btn_Restaurar.UseVisualStyleBackColor = false;
            btn_Restaurar.Visible = false;
            btn_Restaurar.Click += btn_Restaurar_Click;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Cerrar.BackColor = Color.FromArgb(43, 45, 55);
            btn_Cerrar.Cursor = Cursors.Hand;
            btn_Cerrar.FlatAppearance.BorderColor = Color.FromArgb(43, 45, 55);
            btn_Cerrar.FlatAppearance.BorderSize = 0;
            btn_Cerrar.FlatStyle = FlatStyle.Flat;
            btn_Cerrar.ForeColor = SystemColors.ButtonHighlight;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.Location = new Point(1152, 12);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(84, 49);
            btn_Cerrar.TabIndex = 4;
            btn_Cerrar.Text = "X";
            btn_Cerrar.UseVisualStyleBackColor = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(43, 45, 55);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(972, 12);
            button4.Name = "button4";
            button4.Size = new Size(84, 49);
            button4.TabIndex = 6;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btm_Maximizar
            // 
            btm_Maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btm_Maximizar.BackColor = Color.FromArgb(43, 46, 55);
            btm_Maximizar.Cursor = Cursors.Hand;
            btm_Maximizar.FlatAppearance.BorderSize = 0;
            btm_Maximizar.FlatStyle = FlatStyle.Flat;
            btm_Maximizar.Image = (Image)resources.GetObject("btm_Maximizar.Image");
            btm_Maximizar.Location = new Point(1062, 12);
            btm_Maximizar.Name = "btm_Maximizar";
            btm_Maximizar.Size = new Size(84, 49);
            btm_Maximizar.TabIndex = 3;
            btm_Maximizar.UseVisualStyleBackColor = false;
            btm_Maximizar.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(163, 73, 164);
            panel1.Controls.Add(PanelMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1239, 61);
            panel1.TabIndex = 1;
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(40, 42, 52);
            PanelMenu.Controls.Add(btn_Retroalimentacion);
            PanelMenu.Controls.Add(btn_Calificaciones);
            PanelMenu.Controls.Add(btn_Foros);
            PanelMenu.Controls.Add(Btn_Tareas);
            PanelMenu.Controls.Add(btn_Evaluaciones);
            PanelMenu.Controls.Add(btn_Contenido);
            PanelMenu.Dock = DockStyle.Top;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(1239, 61);
            PanelMenu.TabIndex = 2;
            // 
            // btn_Retroalimentacion
            // 
            btn_Retroalimentacion.Anchor = AnchorStyles.Top;
            btn_Retroalimentacion.BackColor = Color.FromArgb(42, 40, 48);
            btn_Retroalimentacion.FlatAppearance.BorderColor = Color.FromArgb(42, 40, 48);
            btn_Retroalimentacion.FlatAppearance.BorderSize = 0;
            btn_Retroalimentacion.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 200);
            btn_Retroalimentacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_Retroalimentacion.FlatStyle = FlatStyle.Flat;
            btn_Retroalimentacion.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Retroalimentacion.ForeColor = Color.Transparent;
            btn_Retroalimentacion.Location = new Point(1250, 0);
            btn_Retroalimentacion.Name = "btn_Retroalimentacion";
            btn_Retroalimentacion.Size = new Size(320, 62);
            btn_Retroalimentacion.TabIndex = 10;
            btn_Retroalimentacion.Text = "RETROALIMENTACION";
            btn_Retroalimentacion.UseVisualStyleBackColor = false;
            btn_Retroalimentacion.Click += btn_Retroalimentacion_Click;
            // 
            // btn_Calificaciones
            // 
            btn_Calificaciones.Anchor = AnchorStyles.Top;
            btn_Calificaciones.BackColor = Color.FromArgb(42, 40, 48);
            btn_Calificaciones.FlatAppearance.BorderColor = Color.FromArgb(42, 40, 48);
            btn_Calificaciones.FlatAppearance.BorderSize = 0;
            btn_Calificaciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 200);
            btn_Calificaciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_Calificaciones.FlatStyle = FlatStyle.Flat;
            btn_Calificaciones.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Calificaciones.ForeColor = Color.Transparent;
            btn_Calificaciones.Location = new Point(1018, 3);
            btn_Calificaciones.Name = "btn_Calificaciones";
            btn_Calificaciones.Size = new Size(236, 61);
            btn_Calificaciones.TabIndex = 9;
            btn_Calificaciones.Text = "CALIFICACIONES";
            btn_Calificaciones.UseVisualStyleBackColor = false;
            btn_Calificaciones.Click += btn_Calificaciones_Click;
            // 
            // btn_Foros
            // 
            btn_Foros.Anchor = AnchorStyles.Top;
            btn_Foros.BackColor = Color.FromArgb(42, 40, 48);
            btn_Foros.FlatAppearance.BorderColor = Color.FromArgb(42, 40, 48);
            btn_Foros.FlatAppearance.BorderSize = 0;
            btn_Foros.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 200);
            btn_Foros.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_Foros.FlatStyle = FlatStyle.Flat;
            btn_Foros.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Foros.ForeColor = Color.Transparent;
            btn_Foros.Location = new Point(821, 1);
            btn_Foros.Name = "btn_Foros";
            btn_Foros.Size = new Size(197, 58);
            btn_Foros.TabIndex = 8;
            btn_Foros.Text = "FOROS";
            btn_Foros.UseVisualStyleBackColor = false;
            // 
            // Btn_Tareas
            // 
            Btn_Tareas.Anchor = AnchorStyles.Top;
            Btn_Tareas.BackColor = Color.FromArgb(42, 40, 48);
            Btn_Tareas.FlatAppearance.BorderColor = Color.FromArgb(42, 40, 48);
            Btn_Tareas.FlatAppearance.BorderSize = 0;
            Btn_Tareas.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 200);
            Btn_Tareas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            Btn_Tareas.FlatStyle = FlatStyle.Flat;
            Btn_Tareas.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Tareas.ForeColor = Color.Transparent;
            Btn_Tareas.Location = new Point(617, 0);
            Btn_Tareas.Name = "Btn_Tareas";
            Btn_Tareas.Size = new Size(207, 62);
            Btn_Tareas.TabIndex = 7;
            Btn_Tareas.Text = "TAREAS";
            Btn_Tareas.UseVisualStyleBackColor = false;
            Btn_Tareas.Click += Btn_Tareas_Click;
            // 
            // btn_Evaluaciones
            // 
            btn_Evaluaciones.Anchor = AnchorStyles.Top;
            btn_Evaluaciones.BackColor = Color.FromArgb(42, 40, 48);
            btn_Evaluaciones.FlatAppearance.BorderColor = Color.FromArgb(42, 40, 48);
            btn_Evaluaciones.FlatAppearance.BorderSize = 0;
            btn_Evaluaciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 200);
            btn_Evaluaciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_Evaluaciones.FlatStyle = FlatStyle.Flat;
            btn_Evaluaciones.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Evaluaciones.ForeColor = Color.Transparent;
            btn_Evaluaciones.Location = new Point(357, 0);
            btn_Evaluaciones.Name = "btn_Evaluaciones";
            btn_Evaluaciones.Size = new Size(264, 62);
            btn_Evaluaciones.TabIndex = 6;
            btn_Evaluaciones.Text = "EVALUACIONES";
            btn_Evaluaciones.UseVisualStyleBackColor = false;
            btn_Evaluaciones.Click += btn_Evaluaciones_Click;
            // 
            // btn_Contenido
            // 
            btn_Contenido.Anchor = AnchorStyles.Top;
            btn_Contenido.BackColor = Color.FromArgb(42, 40, 48);
            btn_Contenido.FlatAppearance.BorderColor = Color.FromArgb(42, 40, 48);
            btn_Contenido.FlatAppearance.BorderSize = 0;
            btn_Contenido.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 200);
            btn_Contenido.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_Contenido.FlatStyle = FlatStyle.Flat;
            btn_Contenido.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Contenido.ForeColor = Color.Transparent;
            btn_Contenido.Location = new Point(63, -1);
            btn_Contenido.Name = "btn_Contenido";
            btn_Contenido.Size = new Size(296, 62);
            btn_Contenido.TabIndex = 5;
            btn_Contenido.Text = "CONTENIDO";
            btn_Contenido.UseVisualStyleBackColor = false;
            // 
            // PaneLMenuLateral
            // 
            PaneLMenuLateral.BackColor = Color.FromArgb(42, 40, 48);
            PaneLMenuLateral.Controls.Add(button1);
            PaneLMenuLateral.Controls.Add(btn_ModificarCurso);
            PaneLMenuLateral.Dock = DockStyle.Left;
            PaneLMenuLateral.Location = new Point(0, 141);
            PaneLMenuLateral.Name = "PaneLMenuLateral";
            PaneLMenuLateral.Size = new Size(409, 509);
            PaneLMenuLateral.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(42, 40, 48);
            button1.FlatAppearance.BorderColor = Color.FromArgb(42, 40, 48);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 200);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(0, 79);
            button1.Name = "button1";
            button1.Size = new Size(408, 73);
            button1.TabIndex = 4;
            button1.Text = "REPORTES Y ANALISIS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btn_ModificarCurso
            // 
            btn_ModificarCurso.BackColor = Color.FromArgb(42, 40, 48);
            btn_ModificarCurso.FlatAppearance.BorderColor = Color.FromArgb(42, 40, 48);
            btn_ModificarCurso.FlatAppearance.BorderSize = 0;
            btn_ModificarCurso.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 80, 200);
            btn_ModificarCurso.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btn_ModificarCurso.FlatStyle = FlatStyle.Flat;
            btn_ModificarCurso.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ModificarCurso.ForeColor = Color.Transparent;
            btn_ModificarCurso.Location = new Point(0, 0);
            btn_ModificarCurso.Name = "btn_ModificarCurso";
            btn_ModificarCurso.Size = new Size(408, 83);
            btn_ModificarCurso.TabIndex = 3;
            btn_ModificarCurso.Text = "MODIFICAR CURSO";
            btn_ModificarCurso.UseVisualStyleBackColor = false;
            btn_ModificarCurso.Click += btn_ModificarCurso_Click;
            // 
            // FormularioDelCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 650);
            Controls.Add(PaneLMenuLateral);
            Controls.Add(panel1);
            Controls.Add(Panel_BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioDelCurso";
            Text = "FormularioDelCurso";
            Load += FormularioDelCurso_Load;
            Panel_BarraTitulo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            PanelMenu.ResumeLayout(false);
            PaneLMenuLateral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_BarraTitulo;
        private Panel panel1;
        private Panel PanelMenu;
        private Panel PaneLMenuLateral;
        private Button button4;
        private Button btn_Restaurar;
        private Button btn_Cerrar;
        private Button btm_Maximizar;
        private Button btn_ModificarCurso;
        private Button button1;
        private Button btn_Retroalimentacion;
        private Button btn_Calificaciones;
        private Button btn_Foros;
        private Button Btn_Tareas;
        private Button btn_Evaluaciones;
        private Button btn_Contenido;
    }
}