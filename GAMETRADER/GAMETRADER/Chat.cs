using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GAMETRADER
{
    public class Chat
    {
        public int IDnotificacion { get; set; }
        public int ID { get; set; }
        public string Titulo { get; set; }
        public Estados estado { get; set; }
        public List<string> Mensajes { get; set; }

        public Chat (int iD, string titulo, Estados estado, List<string> mensajes, int iDnotificacion)
        {
            this.ID = iD;
            this.Titulo = titulo;
            this.estado = estado;
            this.Mensajes = mensajes;
            IDnotificacion = iDnotificacion;    
        }
    }
}
