using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroProspectos.Modelos
{
    public class MdlRegistroDocumentos
    {
        public int idProspecto { get; set; }
        public byte[] documento { get; set; }
        public string extension { get; set; }
        public string nombreDocumento { get; set; }
    }
}
