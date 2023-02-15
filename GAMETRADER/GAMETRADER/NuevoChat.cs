using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMETRADER
{
    public class NuevoChat:Notificacion
    {
        public int IDEmisor { get; set; }
        public int NroChat { get; set; }

        public NuevoChat(int id, string titulo, string descripcion, int idreceptor, DateTime fechaEmision, DateTime fecharecepcion, int idemisor, int nroChat)
        {
            this.ID = id;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.FechaRecepcion = fecharecepcion;
            this.FechaEnvio = fechaEmision;
            this.IDReceptor = idreceptor;
            this.IDEmisor = idemisor;
            this.NroChat = nroChat;
        }
    }
}
