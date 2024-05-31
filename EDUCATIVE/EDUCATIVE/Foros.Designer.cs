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
            this.btn_X = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.btn_Miniz = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Cursos = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_BuscarForo = new System.Windows.Forms.Button();
            this.btn_AgraegarForo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox_Foros = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_EnviarRespuestas = new System.Windows.Forms.Button();
            this.txt_Respuestas = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox_Respuestas = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_X
            // 
            this.btn_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_X.Location = new System.Drawing.Point(1695, 13);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(47, 37);
            this.btn_X.TabIndex = 0;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = true;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Max.Location = new System.Drawing.Point(1642, 13);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(47, 37);
            this.btn_Max.TabIndex = 1;
            this.btn_Max.Text = "Max";
            this.btn_Max.UseVisualStyleBackColor = true;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_Miniz
            // 
            this.btn_Miniz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Miniz.Location = new System.Drawing.Point(1577, 13);
            this.btn_Miniz.Name = "btn_Miniz";
            this.btn_Miniz.Size = new System.Drawing.Size(47, 37);
            this.btn_Miniz.TabIndex = 2;
            this.btn_Miniz.Text = "Min";
            this.btn_Miniz.UseVisualStyleBackColor = true;
            this.btn_Miniz.Click += new System.EventHandler(this.btn_Miniz_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Miniz);
            this.panel1.Controls.Add(this.btn_X);
            this.panel1.Controls.Add(this.btn_Max);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1760, 128);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(935, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "FOROS DE DISCUSION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1050, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "FOROS DISPONIBLES:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.Location = new System.Drawing.Point(243, 35);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(254, 22);
            this.txt_Titulo.TabIndex = 4;
            this.txt_Titulo.TextChanged += new System.EventHandler(this.txt_Titulo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "TITULO DEL FORO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "DESCRIPCIÓN DEL FORO";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(12, 161);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(526, 64);
            this.txt_Descripcion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "CURSO";
            // 
            // comboBox_Cursos
            // 
            this.comboBox_Cursos.FormattingEnabled = true;
            this.comboBox_Cursos.Items.AddRange(new object[] {
            "CURSO 1",
            "CURSO 2",
            "CURSO 3",
            "CURSO 4"});
            this.comboBox_Cursos.Location = new System.Drawing.Point(146, 280);
            this.comboBox_Cursos.Name = "comboBox_Cursos";
            this.comboBox_Cursos.Size = new System.Drawing.Size(198, 24);
            this.comboBox_Cursos.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.btn_Eliminar);
            this.panel2.Controls.Add(this.btn_BuscarForo);
            this.panel2.Controls.Add(this.btn_AgraegarForo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox_Cursos);
            this.panel2.Controls.Add(this.txt_Titulo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_Descripcion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 656);
            this.panel2.TabIndex = 10;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(0, 561);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(558, 112);
            this.btn_Eliminar.TabIndex = 12;
            this.btn_Eliminar.Text = "ELIMINAR FORO";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_BuscarForo
            // 
            this.btn_BuscarForo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_BuscarForo.FlatAppearance.BorderSize = 0;
            this.btn_BuscarForo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.btn_BuscarForo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarForo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarForo.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarForo.Location = new System.Drawing.Point(0, 456);
            this.btn_BuscarForo.Name = "btn_BuscarForo";
            this.btn_BuscarForo.Size = new System.Drawing.Size(558, 112);
            this.btn_BuscarForo.TabIndex = 11;
            this.btn_BuscarForo.Text = "BUSCAR FORO";
            this.btn_BuscarForo.UseVisualStyleBackColor = false;
            // 
            // btn_AgraegarForo
            // 
            this.btn_AgraegarForo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_AgraegarForo.FlatAppearance.BorderSize = 0;
            this.btn_AgraegarForo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.btn_AgraegarForo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgraegarForo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgraegarForo.ForeColor = System.Drawing.Color.White;
            this.btn_AgraegarForo.Location = new System.Drawing.Point(0, 338);
            this.btn_AgraegarForo.Name = "btn_AgraegarForo";
            this.btn_AgraegarForo.Size = new System.Drawing.Size(558, 112);
            this.btn_AgraegarForo.TabIndex = 10;
            this.btn_AgraegarForo.Text = "AGREGAR FORO";
            this.btn_AgraegarForo.UseVisualStyleBackColor = false;
            this.btn_AgraegarForo.Click += new System.EventHandler(this.btn_AgraegarForo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox_Foros);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(558, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1202, 166);
            this.panel3.TabIndex = 11;
            // 
            // listBox_Foros
            // 
            this.listBox_Foros.BackColor = System.Drawing.Color.White;
            this.listBox_Foros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Foros.FormattingEnabled = true;
            this.listBox_Foros.ItemHeight = 16;
            this.listBox_Foros.Location = new System.Drawing.Point(0, 0);
            this.listBox_Foros.Name = "listBox_Foros";
            this.listBox_Foros.Size = new System.Drawing.Size(1202, 166);
            this.listBox_Foros.TabIndex = 7;
            this.listBox_Foros.SelectedIndexChanged += new System.EventHandler(this.listBox_Foros_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(34, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "RESPONDE EL FORO";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_EnviarRespuestas);
            this.panel4.Controls.Add(this.txt_Respuestas);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(558, 294);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1202, 218);
            this.panel4.TabIndex = 15;
            // 
            // btn_EnviarRespuestas
            // 
            this.btn_EnviarRespuestas.BackColor = System.Drawing.Color.White;
            this.btn_EnviarRespuestas.FlatAppearance.BorderSize = 0;
            this.btn_EnviarRespuestas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_EnviarRespuestas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EnviarRespuestas.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EnviarRespuestas.Location = new System.Drawing.Point(355, 165);
            this.btn_EnviarRespuestas.Name = "btn_EnviarRespuestas";
            this.btn_EnviarRespuestas.Size = new System.Drawing.Size(209, 41);
            this.btn_EnviarRespuestas.TabIndex = 16;
            this.btn_EnviarRespuestas.Text = "ENVIAR RESPUESTA";
            this.btn_EnviarRespuestas.UseVisualStyleBackColor = false;
            this.btn_EnviarRespuestas.Click += new System.EventHandler(this.btn_EnviarRespuestas_Click);
            // 
            // txt_Respuestas
            // 
            this.txt_Respuestas.Location = new System.Drawing.Point(355, 16);
            this.txt_Respuestas.Multiline = true;
            this.txt_Respuestas.Name = "txt_Respuestas";
            this.txt_Respuestas.Size = new System.Drawing.Size(1078, 143);
            this.txt_Respuestas.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(558, 512);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1202, 66);
            this.panel5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(649, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "REPUESTAS";
            // 
            // listBox_Respuestas
            // 
            this.listBox_Respuestas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Respuestas.FormattingEnabled = true;
            this.listBox_Respuestas.ItemHeight = 16;
            this.listBox_Respuestas.Location = new System.Drawing.Point(558, 578);
            this.listBox_Respuestas.Name = "listBox_Respuestas";
            this.listBox_Respuestas.Size = new System.Drawing.Size(1202, 206);
            this.listBox_Respuestas.TabIndex = 17;
            this.listBox_Respuestas.SelectedIndexChanged += new System.EventHandler(this.listBox_Respuestas_SelectedIndexChanged);
            // 
            // ForosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1760, 784);
            this.Controls.Add(this.listBox_Respuestas);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForosForm";
            this.Text = "Foros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.Button btn_Miniz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Cursos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_AgraegarForo;
        private System.Windows.Forms.Button btn_BuscarForo;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox_Foros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_Respuestas;
        private System.Windows.Forms.Button btn_EnviarRespuestas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox_Respuestas;
    }
}

