
namespace Transparent_Form
{
    partial class FormularioMaterialProfesor
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel3 = new Panel();
            boton_Borrar_Material = new Button();
            btn_Actualizar_Material = new Button();
            Contenido = new TextBox();
            label5 = new Label();
            label1 = new Label();
            DataGridView_course = new Guna.UI2.WinForms.Guna2DataGridView();
            label7 = new Label();
            panel2 = new Panel();
            comboxTipo = new Guna.UI2.WinForms.Guna2ComboBox();
            boton_crearMaterial = new Button();
            panel1 = new Panel();
            button_search = new Button();
            textBox_search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView_course).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(42, 40, 48);
            panel3.Location = new Point(13, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(909, 10);
            panel3.TabIndex = 32;
            // 
            // boton_Borrar_Material
            // 
            boton_Borrar_Material.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            boton_Borrar_Material.BackColor = Color.Red;
            boton_Borrar_Material.FlatStyle = FlatStyle.Flat;
            boton_Borrar_Material.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boton_Borrar_Material.ForeColor = Color.White;
            boton_Borrar_Material.Location = new Point(808, 188);
            boton_Borrar_Material.Name = "boton_Borrar_Material";
            boton_Borrar_Material.Size = new Size(118, 39);
            boton_Borrar_Material.TabIndex = 29;
            boton_Borrar_Material.Text = "Borrar";
            boton_Borrar_Material.UseVisualStyleBackColor = false;
            boton_Borrar_Material.Click += boton_Borrar_Material_Click;
            // 
            // btn_Actualizar_Material
            // 
            btn_Actualizar_Material.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Actualizar_Material.BackColor = Color.OrangeRed;
            btn_Actualizar_Material.FlatStyle = FlatStyle.Flat;
            btn_Actualizar_Material.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Actualizar_Material.ForeColor = Color.White;
            btn_Actualizar_Material.Location = new Point(684, 188);
            btn_Actualizar_Material.Name = "btn_Actualizar_Material";
            btn_Actualizar_Material.Size = new Size(118, 39);
            btn_Actualizar_Material.TabIndex = 28;
            btn_Actualizar_Material.Text = "Actualizar";
            btn_Actualizar_Material.UseVisualStyleBackColor = false;
            btn_Actualizar_Material.Click += btn_Actualizar_Material_Click;
            // 
            // Contenido
            // 
            Contenido.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Contenido.Location = new Point(21, 150);
            Contenido.Multiline = true;
            Contenido.Name = "Contenido";
            Contenido.Size = new Size(486, 71);
            Contenido.TabIndex = 25;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(17, 126);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 16;
            label5.Text = "Contenido";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(21, 36);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 15;
            label1.Text = "Tipo";
            label1.Click += label1_Click;
            // 
            // DataGridView_course
            // 
            DataGridView_course.AllowUserToAddRows = false;
            DataGridView_course.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_course.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_course.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_course.ColumnHeadersHeight = 24;
            DataGridView_course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_course.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_course.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_course.Location = new Point(13, 100);
            DataGridView_course.Name = "DataGridView_course";
            DataGridView_course.RowHeadersVisible = false;
            DataGridView_course.RowHeadersWidth = 51;
            DataGridView_course.RowTemplate.Height = 80;
            DataGridView_course.Size = new Size(909, 276);
            DataGridView_course.TabIndex = 18;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_course.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_course.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridView_course.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_course.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_course.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_course.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView_course.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_course.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_course.ThemeStyle.HeaderStyle.Height = 24;
            DataGridView_course.ThemeStyle.ReadOnly = false;
            DataGridView_course.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_course.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_course.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView_course.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_course.ThemeStyle.RowsStyle.Height = 80;
            DataGridView_course.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_course.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_course.CellContentClick += DataGridView_course_CellContentClick;
            DataGridView_course.Click += DataGridView_course_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(370, 13);
            label7.Name = "label7";
            label7.Size = new Size(251, 31);
            label7.TabIndex = 0;
            label7.Text = "Material del Curso";
            // 
            // panel2
            // 
            panel2.Controls.Add(comboxTipo);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(boton_Borrar_Material);
            panel2.Controls.Add(boton_crearMaterial);
            panel2.Controls.Add(btn_Actualizar_Material);
            panel2.Controls.Add(Contenido);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 378);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 235);
            panel2.TabIndex = 20;
            // 
            // comboxTipo
            // 
            comboxTipo.BackColor = Color.Transparent;
            comboxTipo.CustomizableEdges = customizableEdges1;
            comboxTipo.DrawMode = DrawMode.OwnerDrawFixed;
            comboxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxTipo.FocusedColor = Color.FromArgb(94, 148, 255);
            comboxTipo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            comboxTipo.Font = new Font("Segoe UI", 10F);
            comboxTipo.ForeColor = Color.FromArgb(68, 88, 112);
            comboxTipo.ItemHeight = 30;
            comboxTipo.Items.AddRange(new object[] { "Documento", "Presentacion", "Video" });
            comboxTipo.Location = new Point(17, 74);
            comboxTipo.Name = "comboxTipo";
            comboxTipo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            comboxTipo.Size = new Size(274, 36);
            comboxTipo.TabIndex = 35;
            // 
            // boton_crearMaterial
            // 
            boton_crearMaterial.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            boton_crearMaterial.BackColor = Color.Navy;
            boton_crearMaterial.FlatStyle = FlatStyle.Flat;
            boton_crearMaterial.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boton_crearMaterial.ForeColor = Color.White;
            boton_crearMaterial.Location = new Point(560, 188);
            boton_crearMaterial.Name = "boton_crearMaterial";
            boton_crearMaterial.Size = new Size(118, 39);
            boton_crearMaterial.TabIndex = 28;
            boton_crearMaterial.Text = "Crear ";
            boton_crearMaterial.UseVisualStyleBackColor = false;
            boton_crearMaterial.Click += boton_crearMaterial_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 40, 48);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 51);
            panel1.TabIndex = 19;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.Orange;
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(805, 55);
            button_search.Name = "button_search";
            button_search.Size = new Size(118, 39);
            button_search.TabIndex = 35;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(643, 62);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(156, 30);
            textBox_search.TabIndex = 34;
            // 
            // FormularioMaterialProfesor
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 613);
            Controls.Add(button_search);
            Controls.Add(textBox_search);
            Controls.Add(DataGridView_course);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FormularioMaterialProfesor";
            Text = "ManageCourseForm";
            Load += ManageCourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView_course).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button boton_Borrar_Material;
        private System.Windows.Forms.Button btn_Actualizar_Material;
        private System.Windows.Forms.TextBox Contenido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_course;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button boton_crearMaterial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private Guna.UI2.WinForms.Guna2ComboBox comboxTipo;
    }
}