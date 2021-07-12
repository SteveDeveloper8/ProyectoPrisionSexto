using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        private int id;
        private string nombres;
        private string apellidos;
        private string username;
        private string contrasena;
        private Rol rol= new Rol();


        public Usuario(int id, string nombres, string apellidos, string username, string contrasena, Rol rol)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.username = username;
            this.contrasena = contrasena;
            this.rol = rol;
        }

        public Usuario()
        {
        }

        public Usuario(string nombres, string apellidos, string username, string contrasena, Rol rol)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.username = username;
            this.contrasena = contrasena;
            Rol = rol;
            
        }

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Username { get => username; set => username = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public Rol Rol { get => rol; set => rol = value; }

    }

}
