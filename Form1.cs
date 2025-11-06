using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
