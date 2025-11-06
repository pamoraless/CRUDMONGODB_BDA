using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace CRUDMONGODB_BDA
{
    [Serializable]
    public class usuarios
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string UsuarioId { get; set; }

        [BsonElement("name"), BsonRepresentation(BsonType.String)]
        public string NameUsuario { get; set; }

        [BsonElement("username"), BsonRepresentation(BsonType.String)]
        public string UserName { get; set; }

        [BsonElement("correo"), BsonRepresentation(BsonType.String)]
        public string CorreoUser { get; set; }

        [BsonElement("contrasena"), BsonRepresentation(BsonType.String)]
        public string PasswordUsuario { get; set; }

        [BsonElement("bio"), BsonRepresentation(BsonType.String)]
        public string BioUser { get; set; }

        [BsonElement("fecha_nacimiento"), BsonRepresentation(BsonType.DateTime)]
        public DateTime FechaNacimientoUser { get; set; }

        [BsonElement("seguidores"), BsonRepresentation(BsonType.Int32)]
        public int SeguidoresUser { get; set; }

        [BsonElement("seguidos"), BsonRepresentation(BsonType.Int32)]
        public int SeguidosUser { get; set; }

        [BsonElement("likes"), BsonRepresentation(BsonType.Int32)]
        public int LikesUser { get; set; }

        //posts se maneja como int para evitar la complicación de crear otra colección de posts
        [BsonElement("posts"), BsonRepresentation(BsonType.Int32)]
        public int PostsUser { get; set; }
    }
}