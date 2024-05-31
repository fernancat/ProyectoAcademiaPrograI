namespace EDUCATIVE.Formularios
{
    partial class Calificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calificaciones));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            btn_Minz = new Button();
            btn_MAX = new Button();
            btn_X = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            txt_Retroalimentacion = new TextBox();
            label7 = new Label();
            txt_Calificacion = new TextBox();
            label6 = new Label();
            comboBox_Cursos = new ComboBox();
            txt_BuscarId = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_BuscarEstudiante = new TextBox();
            panel3 = new Panel();
            button2 = new Button();
            btn_EliminarCalificacion = new Button();
            bt_Limpiar = new Button();
            button1 = new Button();
            dgb_Calificaciones = new DataGridView();
            Estudiante = new DataGridViewTextBoxColumn();
            Id_Estudiante = new DataGridViewTextBoxColumn();
            Curso = new DataGridViewTextBoxColumn();
            Calificacion = new DataGridViewTextBoxColumn();
            Retroalimentacion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgb_Calificaciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(45, 66, 91);
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 72);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 0;
            label1.Text = "ESTUDIANTE";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 66, 91);
            panel1.Controls.Add(btn_Minz);
            panel1.Controls.Add(btn_MAX);
            panel1.Controls.Add(btn_X);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1735, 91);
            panel1.TabIndex = 1;
            // 
            // btn_Minz
            // 
            btn_Minz.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Minz.BackColor = Color.FromArgb(45, 66, 91);
            btn_Minz.FlatAppearance.BorderSize = 0;
            btn_Minz.FlatStyle = FlatStyle.Flat;
            btn_Minz.Image = (Image)resources.GetObject("btn_Minz.Image");
            btn_Minz.Location = new Point(1359, 23);
            btn_Minz.Name = "btn_Minz";
            btn_Minz.Size = new Size(59, 42);
            btn_Minz.TabIndex = 6;
            btn_Minz.UseVisualStyleBackColor = false;
            btn_Minz.Click += btn_Minz_Click;
            // 
            // btn_MAX
            // 
            btn_MAX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_MAX.BackColor = Color.FromArgb(45, 66, 91);
            btn_MAX.FlatAppearance.BorderSize = 0;
            btn_MAX.FlatStyle = FlatStyle.Flat;
            btn_MAX.Image = (Image)resources.GetObject("btn_MAX.Image");
            btn_MAX.Location = new Point(1424, 23);
            btn_MAX.Name = "btn_MAX";
            btn_MAX.Size = new Size(59, 42);
            btn_MAX.TabIndex = 5;
            btn_MAX.UseVisualStyleBackColor = false;
            btn_MAX.Click += btn_MAX_Click;
            // 
            // btn_X
            // 
            btn_X.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_X.BackColor = Color.FromArgb(45, 66, 91);
            btn_X.FlatAppearance.BorderSize = 0;
            btn_X.FlatStyle = FlatStyle.Flat;
            btn_X.Image = (Image)resources.GetObject("btn_X.Image");
            btn_X.Location = new Point(1489, 23);
            btn_X.Name = "btn_X";
            btn_X.Size = new Size(59, 42);
            btn_X.TabIndex = 4;
            btn_X.UseVisualStyleBackColor = false;
            btn_X.Click += btn_X_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 68);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(45, 66, 91);
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(833, 25);
            label3.Name = "label3";
            label3.Size = new Size(195, 31);
            label3.TabIndex = 3;
            label3.Text = "CALIFICACIONES";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(45, 66, 91);
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(174, 25);
            label2.Name = "label2";
            label2.Size = new Size(139, 31);
            label2.TabIndex = 2;
            label2.Text = "EDUCATIVE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 66, 91);
            panel2.Controls.Add(txt_Retroalimentacion);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_Calificacion);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(comboBox_Cursos);
            panel2.Controls.Add(txt_BuscarId);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txt_BuscarEstudiante);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(1735, 299);
            panel2.TabIndex = 2;
            // 
            // txt_Retroalimentacion
            // 
            txt_Retroalimentacion.Location = new Point(463, 158);
            txt_Retroalimentacion.Multiline = true;
            txt_Retroalimentacion.Name = "txt_Retroalimentacion";
            txt_Retroalimentacion.Size = new Size(602, 110);
            txt_Retroalimentacion.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(45, 66, 91);
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(86, 159);
            label7.Name = "label7";
            label7.Size = new Size(337, 23);
            label7.TabIndex = 10;
            label7.Text = "RETROALIMENTACION DEL ESTUDIANTE";
            // 
            // txt_Calificacion
            // 
            txt_Calificacion.Location = new Point(1618, 68);
            txt_Calificacion.Name = "txt_Calificacion";
            txt_Calificacion.Size = new Size(105, 27);
            txt_Calificacion.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(45, 66, 91);
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1464, 72);
            label6.Name = "label6";
            label6.Size = new Size(127, 23);
            label6.TabIndex = 8;
            label6.Text = "CALIFICACION";
            // 
            // comboBox_Cursos
            // 
            comboBox_Cursos.FormattingEnabled = true;
            comboBox_Cursos.Items.AddRange(new object[] { "Java", "C#", "C++", "HTML y CSS", "JavaScript", "Sql", "Cocina", "Arte" });
            comboBox_Cursos.Location = new Point(1206, 68);
            comboBox_Cursos.Name = "comboBox_Cursos";
            comboBox_Cursos.Size = new Size(205, 28);
            comboBox_Cursos.TabIndex = 5;
            // 
            // txt_BuscarId
            // 
            txt_BuscarId.Location = new Point(769, 68);
            txt_BuscarId.Name = "txt_BuscarId";
            txt_BuscarId.Size = new Size(247, 27);
            txt_BuscarId.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(45, 66, 91);
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1106, 68);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 4;
            label4.Text = "CURSO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(45, 66, 91);
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(572, 72);
            label5.Name = "label5";
            label5.Size = new Size(149, 23);
            label5.TabIndex = 6;
            label5.Text = "ID ESTDUDIANTE";
            // 
            // txt_BuscarEstudiante
            // 
            txt_BuscarEstudiante.Location = new Point(238, 68);
            txt_BuscarEstudiante.Name = "txt_BuscarEstudiante";
            txt_BuscarEstudiante.Size = new Size(275, 27);
            txt_BuscarEstudiante.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 66, 91);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btn_EliminarCalificacion);
            panel3.Controls.Add(bt_Limpiar);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 390);
            panel3.Name = "panel3";
            panel3.Size = new Size(1735, 98);
            panel3.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(45, 66, 91);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(810, 0);
            button2.Name = "button2";
            button2.Size = new Size(351, 98);
            button2.TabIndex = 3;
            button2.Text = "ACTUALIZAR CALIFICACION";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_EliminarCalificacion
            // 
            btn_EliminarCalificacion.BackColor = Color.FromArgb(45, 66, 91);
            btn_EliminarCalificacion.FlatAppearance.BorderSize = 0;
            btn_EliminarCalificacion.FlatStyle = FlatStyle.Flat;
            btn_EliminarCalificacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_EliminarCalificacion.ForeColor = Color.White;
            btn_EliminarCalificacion.Location = new Point(463, -3);
            btn_EliminarCalificacion.Name = "btn_EliminarCalificacion";
            btn_EliminarCalificacion.Size = new Size(351, 98);
            btn_EliminarCalificacion.TabIndex = 2;
            btn_EliminarCalificacion.Text = "ELIMINAR CALIFICACION";
            btn_EliminarCalificacion.UseVisualStyleBackColor = false;
            btn_EliminarCalificacion.Click += btn_EliminarCalificacion_Click;
            // 
            // bt_Limpiar
            // 
            bt_Limpiar.BackColor = Color.FromArgb(45, 66, 91);
            bt_Limpiar.FlatAppearance.BorderSize = 0;
            bt_Limpiar.FlatStyle = FlatStyle.Flat;
            bt_Limpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            bt_Limpiar.ForeColor = Color.White;
            bt_Limpiar.Location = new Point(1157, 0);
            bt_Limpiar.Name = "bt_Limpiar";
            bt_Limpiar.Size = new Size(335, 98);
            bt_Limpiar.TabIndex = 1;
            bt_Limpiar.Text = "LIMPIAR";
            bt_Limpiar.UseVisualStyleBackColor = false;
            bt_Limpiar.Click += bt_Limpiar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(45, 66, 91);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(129, 0);
            button1.Name = "button1";
            button1.Size = new Size(337, 95);
            button1.TabIndex = 0;
            button1.Text = "AGREGAR CALIFICACION";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgb_Calificaciones
            // 
            dgb_Calificaciones.BackgroundColor = Color.FromArgb(42, 48, 60);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(42, 48, 60);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(42, 48, 52);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgb_Calificaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgb_Calificaciones.ColumnHeadersHeight = 29;
            dgb_Calificaciones.Columns.AddRange(new DataGridViewColumn[] { Estudiante, Id_Estudiante, Curso, Calificacion, Retroalimentacion, Estado });
            dgb_Calificaciones.Dock = DockStyle.Fill;
            dgb_Calificaciones.EnableHeadersVisualStyles = false;
            dgb_Calificaciones.Location = new Point(0, 488);
            dgb_Calificaciones.Name = "dgb_Calificaciones";
            dgb_Calificaciones.RowHeadersWidth = 51;
            dgb_Calificaciones.Size = new Size(1735, 205);
            dgb_Calificaciones.TabIndex = 4;
            // 
            // Estudiante
            // 
            Estudiante.HeaderText = "ESTUDIANTE";
            Estudiante.MinimumWidth = 6;
            Estudiante.Name = "Estudiante";
            Estudiante.Width = 260;
            // 
            // Id_Estudiante
            // 
            Id_Estudiante.HeaderText = "ID_ESTUDIANTE";
            Id_Estudiante.MinimumWidth = 6;
            Id_Estudiante.Name = "Id_Estudiante";
            Id_Estudiante.Width = 220;
            // 
            // Curso
            // 
            Curso.HeaderText = "CURSO";
            Curso.MinimumWidth = 6;
            Curso.Name = "Curso";
            Curso.Width = 220;
            // 
            // Calificacion
            // 
            Calificacion.HeaderText = "CALIFICACION";
            Calificacion.MinimumWidth = 6;
            Calificacion.Name = "Calificacion";
            Calificacion.Width = 220;
            // 
            // Retroalimentacion
            // 
            Retroalimentacion.HeaderText = "RETROALIMENTACION";
            Retroalimentacion.MinimumWidth = 6;
            Retroalimentacion.Name = "Retroalimentacion";
            Retroalimentacion.Width = 370;
            // 
            // Estado
            // 
            Estado.HeaderText = "ESTADO";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 200;
            // 
            // Calificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1735, 693);
            Controls.Add(dgb_Calificaciones);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Calificaciones";
            Text = "Calificaciones";
            Load += Calificaciones_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgb_Calificaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private TextBox txt_BuscarEstudiante;
        private Label label4;
        private ComboBox comboBox_Cursos;
        private Label label5;
        private TextBox txt_BuscarId;
        private Panel panel3;
        private Button button1;
        private Button btn_EliminarCalificacion;
        private Button bt_Limpiar;
        private TextBox txt_Calificacion;
        private Label label6;
        private Label label7;
        private TextBox txt_Retroalimentacion;
        private DataGridView dgb_Calificaciones;
        private DataGridViewTextBoxColumn Estudiante;
        private DataGridViewTextBoxColumn Id_Estudiante;
        private DataGridViewTextBoxColumn Curso;
        private DataGridViewTextBoxColumn Calificacion;
        private DataGridViewTextBoxColumn Retroalimentacion;
        private DataGridViewTextBoxColumn Estado;
        private Button button2;
        private Button btn_Minz;
        private Button btn_MAX;
        private Button btn_X;
    }
}