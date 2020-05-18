using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Forms
{
    public class EFactura
    {
        public string nombre { get; set; }
        public int cedula { get; set; }
        public DateTime fechaFaturacion { get; set; }

        public List<EArticulo> Detail = new List<EArticulo>();
    }
}
