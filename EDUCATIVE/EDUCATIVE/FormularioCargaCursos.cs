using Guna.UI2.WinForms;
using System.Linq.Expressions;

namespace EDUCATIVE
{
    public partial class FormularioCargaCursos : Form
    {
        private List<Label> labels = new List<Label>();

        public FormularioCargaCursos()
        {
            InitializeComponent();
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
    }
}
