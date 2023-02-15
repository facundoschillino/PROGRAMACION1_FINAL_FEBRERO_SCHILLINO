using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMETRADER
{
    public class NotificacionGAMETRADER: Notificacion
    {
        public string Link { get; set; }
        public NotificacionGAMETRADER(int id, string titulo, string descripcion, int idreceptor, DateTime fechaEmision, DateTime fecharecepcion,string link  )
        {
            this.ID = id;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.FechaRecepcion = fecharecepcion;
            this.FechaEnvio = fechaEmision;
            this.IDReceptor = idreceptor;
            this.Link = link;
        }

    }
}
