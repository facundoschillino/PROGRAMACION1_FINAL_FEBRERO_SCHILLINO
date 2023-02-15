using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMETRADER
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Nickname { get; set; }
        public string Constraseña { get; set; }
        public int NumeroTelefono { get; set; }
        public List<Juegos> Juegos { get; set; }
        public List<int> Amigos { get; set; }
        
        public Usuario (int id, string nombre, string correo, string nickcname, string pswrd, int NumTelefono, List<Juegos>juegos, List<int> amigos)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Correo = correo;
            this.Constraseña = pswrd;
            this.Nickname = nickcname;
            this.NumeroTelefono = NumTelefono;
            this.Juegos = juegos;
            this.Amigos = amigos;
        }
    }
}
