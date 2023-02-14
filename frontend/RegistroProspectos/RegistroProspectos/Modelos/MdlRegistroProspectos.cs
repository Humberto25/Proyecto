using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroProspectos.Modelos
{
    public class MdlRegistroProspectos
    {
        public int id { get; set; }
        public string nombreProspecto { get; set; }
        public string primerAp { get; set; }
        public string segundoAp { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string colonia { get; set; }
        public int codigoPostal { get; set; }
        public string telefono { get; set; }
        public string rfc { get; set; }
        public string estatus { get; set; }
        public string observaciones { get; set; }
    }
}
