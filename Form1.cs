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

        private void EditarUsuario()
        {
            try
            {
                var id = textId.Text.Trim();
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Debes ingresar el ID del usuario que deseas editar.");
                    return;
                }

                var filter = Builders<usuarios>.Filter.Eq(u => u.UsuarioId, id);

                var updateDef = Builders<usuarios>.Update;
                var updates = new List<UpdateDefinition<usuarios>>();

                if (!string.IsNullOrWhiteSpace(textName.Text))
                    updates.Add(updateDef.Set(u => u.NameUsuario, textName.Text));

                if (!string.IsNullOrWhiteSpace(textUsername.Text))
                    updates.Add(updateDef.Set(u => u.UserName, textUsername.Text));

                if (!string.IsNullOrWhiteSpace(textCorreo.Text))
                    updates.Add(updateDef.Set(u => u.CorreoUser, textCorreo.Text));

                if (!string.IsNullOrWhiteSpace(textContrasena.Text))
                    updates.Add(updateDef.Set(u => u.PasswordUsuario, textContrasena.Text));

                if (!string.IsNullOrWhiteSpace(textBio.Text))
                    updates.Add(updateDef.Set(u => u.BioUser, textBio.Text));

                // Fecha: siempre se actualiza
                updates.Add(updateDef.Set(u => u.FechaNacimientoUser, dateFechaNacimiento.Value.Date));

                if (!string.IsNullOrWhiteSpace(textSeguidores.Text))
                    updates.Add(updateDef.Set(u => u.SeguidoresUser, int.Parse(textSeguidores.Text)));

                if (!string.IsNullOrWhiteSpace(textSeguidos.Text))
                    updates.Add(updateDef.Set(u => u.SeguidosUser, int.Parse(textSeguidos.Text)));

                if (!string.IsNullOrWhiteSpace(textLikes.Text))
                    updates.Add(updateDef.Set(u => u.LikesUser, int.Parse(textLikes.Text)));

                if (!string.IsNullOrWhiteSpace(textPosts.Text))
                    updates.Add(updateDef.Set(u => u.PostsUser, int.Parse(textPosts.Text)));

                if (updates.Count == 0)
                {
                    MessageBox.Show("No hay campos para actualizar.");
                    return;
                }

                var update = updateDef.Combine(updates);
                usuariosCollection.UpdateOne(filter, update);

                MessageBox.Show("Usuario actualizado correctamente.");
                LoadUsersData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar usuario: " + ex.Message);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarUsuario();
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
