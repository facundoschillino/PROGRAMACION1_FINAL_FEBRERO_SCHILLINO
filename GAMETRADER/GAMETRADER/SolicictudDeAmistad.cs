using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMETRADER
{
    public class SolicictudDeAmistad :Notificacion
    {
        public DateTime FechaExpiracion { get; set; }
        public int IDEmisor { get; set; }
        public virtual int NumeroChat { get; set; }

        public SolicictudDeAmistad(int id, string titulo, string descripcion, int idreceptor, DateTime fechaEmision, DateTime fecharecepcion, int idemisor, int nroChat, DateTime Fechaexpiracion)
        {
            this.ID = id;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.FechaRecepcion = fecharecepcion;
            this.FechaEnvio = fechaEmision;
            this.IDReceptor = idreceptor;
            this.IDEmisor = idemisor;
            this.NumeroChat = nroChat;
            this.FechaExpiracion = Fechaexpiracion;
        }
    }
}
