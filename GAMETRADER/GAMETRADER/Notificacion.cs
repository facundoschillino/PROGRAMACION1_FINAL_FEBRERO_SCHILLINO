using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMETRADER
{
    public abstract class Notificacion
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int IDReceptor { get; set; }
        public DateTime FechaEnvio { get; set; }
        public DateTime FechaRecepcion { get; set; }

    }
}
