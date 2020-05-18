using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Clases
{
    public class Expediente
    {
        CapaDatos.Clases.Expediente expediente;
        public Expediente(){
            expediente= new CapaDatos.Clases.Expediente();
        }

        public void searchExpediente(CapaNegocio.Clases.Login session, System.Windows.Forms.ListView listView, String textdata)
        {
            expediente.searchExpediente(session.getConnection(), listView, textdata);
        }

        public List<string> getExpediente(CapaNegocio.Clases.Login session, System.Windows.Forms.ListView listView)
        {
            return expediente.getExpediente(session.getConnection(), listView);
        }
    }
}
