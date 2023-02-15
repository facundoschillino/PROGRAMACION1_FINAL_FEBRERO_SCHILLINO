using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMETRADER
{
    public class NuevoJuegocs:NotificacionGAMETRADER
    {
        public DateTime FechaDisponibilidad { get; set; }
        public NuevoJuegocs(int id, string titulo, string descripcion, int idreceptor, DateTime fechaEmision, DateTime fecharecepcion, string link, DateTime fechadisponible) 
        : base(id, titulo, descripcion, idreceptor, fechaEmision, fecharecepcion, link)
        {
            this.ID = id;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.FechaRecepcion = fecharecepcion;
            this.FechaEnvio = fechaEmision;
            this.IDReceptor = idreceptor;
            this.Link = link;
            this.FechaDisponibilidad = fechadisponible; 
        }

        
        
    }
}
