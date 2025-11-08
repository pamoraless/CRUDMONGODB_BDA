using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUDMONGODB_BDA
{
    public partial class Form1 : Form
    {
        IMongoCollection<usuarios> usuariosCollection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            usuariosCollection = database.GetCollection<usuarios>("usuarios");

            LoadUsersData();
        }

        //Función para cargar los datos
        private void LoadUsersData()
        {
            var filterDefinition = Builders<usuarios>.Filter.Empty;
            var Usuarios = usuariosCollection.Find(filterDefinition).ToList();
            GridViewUsers.DataSource = Usuarios;
        }

        private void CrearUsuario()
        {
            var usuario = new usuarios
            {
                NameUsuario = textName.Text,
                UserName = textUsername.Text,
                CorreoUser = textCorreo.Text,
                PasswordUsuario = textContrasena.Text,
                BioUser = textBio.Text,
                FechaNacimientoUser = dateFechaNacimiento.Value,
                SeguidoresUser = int.Parse(textSeguidores.Text),
                SeguidosUser = int.Parse(textSeguidos.Text),
                LikesUser = int.Parse(textLikes.Text),
                PostsUser = int.Parse(textPosts.Text)
            };

            usuariosCollection.InsertOne(usuario);

            MessageBox.Show("Usuario agregado con éxito!");

            LoadUsersData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CrearUsuario();
        }

        private void EliminarUsuario()
        {
            try
            {
                string id = textId.Text.Trim();

                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Ingrese el ID del usuario.");
                    return;
                }

                var filter = Builders<usuarios>.Filter.Eq(u => u.UsuarioId, id);

                var result = usuariosCollection.DeleteOne(filter);

                if (result.DeletedCount > 0)
                {
                    MessageBox.Show("Usuario eliminado correctamente.");
                    LoadUsersData();
                }
                else
                {
                    MessageBox.Show("No se encontró usuario con ese ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
        }

        private void GridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = GridViewUsers.Rows[e.RowIndex].Cells["UsuarioId"].Value.ToString();
                textId.Text = id;
            }
        }
    }
}
