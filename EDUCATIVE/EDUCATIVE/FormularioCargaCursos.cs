using EDUCATIVE.Models;
using Guna.UI2.WinForms;
using System.Linq.Expressions;

namespace EDUCATIVE
{
    public partial class FormularioCargaCursos : Form
    {
        private Usuario usuario;
        private List<Label> labels = new List<Label>();

        public FormularioCargaCursos(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            datosUsuarioLoad();
            // Crear una instancia del TableLayoutPanel
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                // Configurar el TableLayoutPanel para tener 3 filas y 3 columnas
                RowCount = 3,
                ColumnCount = 3
            };
            // Hacer que las filas y columnas ocupen el mismo espacio
            for (int i = 0; i < 3; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            }

            // Agregar controles a las celdas del TableLayoutPanel
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Dock = DockStyle.Fill;
                   
                    
                    pictureBox.Image = Image.FromFile("C:\\Users\\Fernan\\Downloads\\FONDO TUCBER.jpeg");
                    tableLayoutPanel.Controls.Add(pictureBox, j, i); 
                }
            }

            // Hacer que el TableLayoutPanel se acople al panel
            tableLayoutPanel.Dock = DockStyle.Fill;

            // Agregar el TableLayoutPanel al panel de Guna
            panelCursos.Controls.Add(tableLayoutPanel);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datosUsuarioLoad() {
            textoUsuario.Text = usuario.nombre_usuario;
            textoCorreo.Text = usuario.email;
            rolUsuario.Text = usuario.rol;

            if (usuario.rol == "instructor")
            {
                Guna2Button botonEditar = new Guna2Button
                {
                    Text = "Crear curso",
                    Size = new Size(100, 40),
                    Location = new Point(0, guna2Panel1.Height - 50), // Posicionarlo en la parte inferior izquierda
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Left, // Anclar el botón al fondo e izquierda del panel
                    FillColor = Color.FromArgb(60, 63, 81)

                };
                botonEditar.Click += BotonEditar_Click;



                guna2Panel1.Controls.Add(botonEditar);

            }
        }

        private void BotonEditar_Click(Object sender, EventArgs e)
        {
            //logica del boton editar
        }


    }
    
}
