using EDUCATIVE.DAOModels;
using EDUCATIVE.Models;
using Guna.UI2.WinForms;
using INNICIO;
using Mysqlx.Expr;
using System.Collections;
using System.Linq.Expressions;

namespace EDUCATIVE
{
    public partial class FormularioCargaCursos : Form
    {
        private Usuario usuario;
        private List<Label> labels = new List<Label>();
        Guna2CirclePictureBox pictureBoxUsuarioMod;
        ArrayList camposManejo;

        public FormularioCargaCursos(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            datosUsuarioLoad();

            if (usuario.rol.Equals("Estudiante"))
            {
                crearCurso.Visible = false;
            }



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

        private void datosUsuarioLoad()
        {
            textoUsuario.Text = usuario.nombre_usuario;
            textoCorreo.Text = usuario.email;
            rolUsuario.Text = usuario.rol;
            if (usuario.FotoPerfil != null && usuario.FotoPerfil.Length > 0)
            {
                using (MemoryStream stream = new MemoryStream(usuario.FotoPerfil))
                {
                    FotoDePerfil.Image = Image.FromStream(stream);
                }
            }
            else
            {

            }




        }



        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            panelCursos.Controls.Clear();

            // Crear y configurar los controles para editar perfil
            Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2CirclePictureBox.Location = new Point(90, 20);
            guna2CirclePictureBox.Size = new Size(100, 100);
            guna2CirclePictureBox.BackColor = Color.Transparent;
            guna2CirclePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUsuarioMod = guna2CirclePictureBox;

            Button btnCambiarFoto = new Button();
            btnCambiarFoto.Text = "Cambiar Foto de Perfil";
            btnCambiarFoto.Location = new Point(20, 130);
            btnCambiarFoto.BackColor = Color.FromArgb(64, 64, 64);
            btnCambiarFoto.ForeColor = Color.White;
            btnCambiarFoto.Click += BtnCambiarFoto_Click;
            Label lblNombre = new Label();
            lblNombre.Text = "Nombre:";
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(20, 170);

            TextBox txtNombre = new TextBox();
            txtNombre.Location = new Point(120, 170);
            txtNombre.Size = new Size(200, 20);
            txtNombre.BackColor = Color.FromArgb(64, 64, 64);
            txtNombre.ForeColor = Color.White;
            txtNombre.Text = usuario.nombre_usuario;

            Label lblApellidos = new Label();
            lblApellidos.Text = "Apellidos:";
            lblApellidos.ForeColor = Color.White;
            lblApellidos.Location = new Point(20, 200);

            TextBox txtApellidos = new TextBox();
            txtApellidos.Location = new Point(120, 200);
            txtApellidos.Size = new Size(200, 20);
            txtApellidos.BackColor = Color.FromArgb(64, 64, 64);
            txtApellidos.ForeColor = Color.White;
            txtApellidos.Text = usuario.apellidos;

            Label lblEmail = new Label();
            lblEmail.Text = "Correo electrónico:";
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(20, 230);


            TextBox txtEmail = new TextBox();
            txtEmail.Location = new Point(120, 230);
            txtEmail.Size = new Size(200, 20);
            txtEmail.BackColor = Color.FromArgb(64, 64, 64);
            txtEmail.ForeColor = Color.White;
            txtEmail.Text = usuario.email;

            Button btnGuardarCambios = new Button();
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.Location = new Point(20, 260);
            btnGuardarCambios.BackColor = Color.FromArgb(64, 64, 64);
            btnGuardarCambios.ForeColor = Color.White;
            btnGuardarCambios.Click += BtnGuardarCambios_Click; // Manejador de evento para guardar cambios

            // Agregar los controles al panel
            panelCursos.Controls.Add(guna2CirclePictureBox);
            panelCursos.Controls.Add(btnCambiarFoto);
            panelCursos.Controls.Add(lblNombre);
            panelCursos.Controls.Add(txtNombre);
            panelCursos.Controls.Add(lblApellidos);
            panelCursos.Controls.Add(txtApellidos);
            panelCursos.Controls.Add(lblEmail);
            panelCursos.Controls.Add(txtEmail);
            panelCursos.Controls.Add(btnGuardarCambios);


            camposManejo = new ArrayList() { txtNombre, txtApellidos, txtEmail };

            // Centrar todo el contenido en el panel

        }




        private void BtnCambiarFoto_Click(object sender, EventArgs e)
        {
            // Mostrar el cuadro de diálogo para seleccionar una imagen
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaImagen = openFileDialog.FileName;

                // Aquí puedes implementar la lógica para cargar la imagen en el Guna2CirclePictureBox
                pictureBoxUsuarioMod.Image = Image.FromFile(rutaImagen);
            }
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            ArrayList textoFormateadoCampos = manejoCampos(camposManejo);
            String nuevoNombre = (String)textoFormateadoCampos[0];
            string nuevosApellidos = (String)textoFormateadoCampos[1];
            string nuevoEmail = (String)textoFormateadoCampos[2];



            // Convertir la imagen de perfil a un arreglo de bytes
            byte[] fotoPerfilBytes = null;
            if (pictureBoxUsuarioMod.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    pictureBoxUsuarioMod.Image.Save(stream, pictureBoxUsuarioMod.Image.RawFormat);
                    fotoPerfilBytes = stream.ToArray();
                }
            }

            usuarioDAO usuarioDAO = new usuarioDAO();

            if (pictureBoxUsuarioMod.Image != null)
            {
                if (usuarioDAO.EditarPerfil(usuario.Id, nuevoNombre, nuevosApellidos, nuevoEmail, fotoPerfilBytes))
                {
                    MessageBox.Show("Perfil actualizado correctamente");

                    usuario.nombre_usuario = nuevoNombre;
                    usuario.apellidos = nuevosApellidos;
                    usuario.email = nuevoEmail;
                    usuario.FotoPerfil = fotoPerfilBytes;
                    using (MemoryStream stream = new MemoryStream(usuario.FotoPerfil))
                    {
                        FotoDePerfil.Image = Image.FromStream(stream);
                    }
                    datosUsuarioLoad();

                }
                else
                {
                    // Mostrar un mensaje de error si la actualización falló
                    MessageBox.Show("Error al actualizar el perfil");
                }
            }
            else
            {
                MessageBox.Show("Debes especificar una foto de perfil");
            }




        }

        private void crearCurso_Click(object sender, EventArgs e)
        {
            // Limpiar todos los controles dentro del panelCursos
            panelCursos.Controls.Clear();

            // Crear y configurar los controles para crear un curso
            Label lblTitulo = new Label();
            lblTitulo.Text = "Título:";
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 20);

            TextBox txtTitulo = new TextBox();
            txtTitulo.Location = new Point(120, 20);
            txtTitulo.Size = new Size(200, 20);
            txtTitulo.BackColor = Color.FromArgb(64, 64, 64);
            txtTitulo.ForeColor = Color.White;

            Label lblDescripcion = new Label();
            lblDescripcion.Text = "Descripción:";
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(20, 50);

            TextBox txtDescripcion = new TextBox();
            txtDescripcion.Multiline = true;
            txtDescripcion.Location = new Point(120, 50);
            txtDescripcion.Size = new Size(200, 100);
            txtDescripcion.BackColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.ForeColor = Color.White;

            Guna2CirclePictureBox gunaCircleBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            gunaCircleBox.Location = new Point(350, 20);
            gunaCircleBox.Size = new Size(100, 100);
            gunaCircleBox.BackColor = Color.Transparent;
            gunaCircleBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUsuarioMod = gunaCircleBox;

            Button btnSeleccionarImagen = new Button();
            btnSeleccionarImagen.Text = "Seleccionar Imagen";
            btnSeleccionarImagen.Location = new Point(350, 130);
            btnSeleccionarImagen.BackColor = Color.FromArgb(64, 64, 64);
            btnSeleccionarImagen.ForeColor = Color.White;
            btnSeleccionarImagen.Click += BtnCambiarFoto_Click; // Manejador de evento para seleccionar imagen

            Button btnGuardarCurso = new Button();
            btnGuardarCurso.Text = "Guardar Curso";
            btnGuardarCurso.Location = new Point(20, 190);
            btnGuardarCurso.BackColor = Color.FromArgb(64, 64, 64);
            btnGuardarCurso.ForeColor = Color.White;
            btnGuardarCurso.Click += BtnGuardarCurso_Click; // Manejador de evento para guardar curso

            // Agregar los controles al panel
            panelCursos.Controls.Add(lblTitulo);
            panelCursos.Controls.Add(txtTitulo);
            panelCursos.Controls.Add(lblDescripcion);
            panelCursos.Controls.Add(txtDescripcion);
            panelCursos.Controls.Add(gunaCircleBox);
            panelCursos.Controls.Add(btnSeleccionarImagen);
            panelCursos.Controls.Add(btnGuardarCurso);

            camposManejo = new ArrayList() { txtTitulo, txtDescripcion };

        }

        private void BtnGuardarCurso_Click(object sender, EventArgs e)
        {
            ArrayList textoFormateadoCampos = manejoCampos(camposManejo);
            string titulo = (String)textoFormateadoCampos[0];
            string descripcion = (String)textoFormateadoCampos[1];

            byte[] fotoPerfilBytes = null;
            if (pictureBoxUsuarioMod.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    pictureBoxUsuarioMod.Image.Save(stream, pictureBoxUsuarioMod.Image.RawFormat);
                    fotoPerfilBytes = stream.ToArray();
                }
            }

            CursosDAOcs cursosDAO = new CursosDAOcs();

            if (pictureBoxUsuarioMod.Image != null)
            {
                if (cursosDAO.CrearCurso(titulo,descripcion,fotoPerfilBytes))
                {
                    MessageBox.Show("Curso Creado correctamente");

                }
                else
                {
                    // Mostrar un mensaje de error si la actualización falló
                    MessageBox.Show("Se ha creado el curso Correctamente");
                }
            }
            else
            {
                MessageBox.Show("Debes especificar una foto para el curso");
            }


        }


        private ArrayList manejoCampos(ArrayList lista)
        {
            ArrayList campos = new ArrayList();
            foreach (TextBox elementos in camposManejo)
            {
                campos.Add(elementos.Text);
            }
            return campos;

        }

        private void CargarCursos_Click(object sender, EventArgs e)
        {
            panelCursos.Controls.Clear(); // Limpia el panel antes de agregar nuevos cursos

            CursosDAOcs cursosDAO = new CursosDAOcs();
            List<Curso> cursos = cursosDAO.ObtenerCursosDisponibles();

            int posY = 10; // Posición inicial en el eje Y

            foreach (var curso in cursos)
            {
                // Crear un Panel para cada curso
                Panel panelCurso = new Panel
                {
                    Width = panelCursos.ClientSize.Width - 25, // Ajustar el ancho del panel padre
                    Height = 150, // Puedes ajustar esta altura según tus necesidades
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(10, posY),
                    Margin = new Padding(10),
                    BackColor = Color.FromArgb(64, 64, 64)
                };

                // Crear un PictureBox para mostrar la imagen del curso
                PictureBox pictureBoxCurso = new PictureBox
                {
                    Image = Image.FromStream(new MemoryStream(curso.ImagenCurso)),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 100,
                    Height = 100,
                    Location = new Point(10, 10)
                };

                // Crear un Label para el título del curso
                Label lblTitulo = new Label
                {
                    Text = curso.Titulo,
                    AutoSize = true,
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    Location = new Point(120, 10),
                    ForeColor = Color.White
                };

                // Crear un Label para la descripción del curso
                Label lblDescripcion = new Label
                {
                    Text = curso.Descripcion,
                    AutoSize = false,
                    Width = panelCurso.Width - 130,
                    Height = 80,
                    Location = new Point(120, 40),
                    ForeColor = Color.White
                };

                // Agregar controles al Panel del curso
                panelCurso.Controls.Add(pictureBoxCurso);
                panelCurso.Controls.Add(lblTitulo);
                panelCurso.Controls.Add(lblDescripcion);

                // Agregar el panel del curso al Panel principal
                panelCursos.Controls.Add(panelCurso);

                // Ajustar la posición para el próximo curso
                posY += panelCurso.Height + 10;

                // Agregar un evento Click al panel para abrir el formulario del curso
                panelCurso.Click += (s, args) =>
                {
                    FormularioDelCurso formDelCurso = new FormularioDelCurso(curso.Id);
                    formDelCurso.Show();
                };
            }

            // Ajustar el tamaño del panel principal si es necesario
            if (posY > panelCursos.ClientSize.Height)
            {
                panelCursos.AutoScroll = true;
            }
            else
            {
                panelCursos.AutoScroll = false;
            }
        }



    }

}
