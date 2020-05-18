using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Clases
{
    public class Anamnesis
    {
        CapaDatos.Clases.Anamnesis anamnesis;
        public Anamnesis()
        {
            anamnesis = new CapaDatos.Clases.Anamnesis();
        }

        public void searchAnamnesis(CapaNegocio.Clases.Login session,
           System.Windows.Forms.ListView listView, String textdata)
        {
            anamnesis.searchAnamnesis(session.getConnection(), listView, textdata);
        }

        public List<string> getDataAnamnesis(CapaNegocio.Clases.Login session,
            System.Windows.Forms.ListView listView)
        {
            return anamnesis.getAnamnesis(session.getConnection(), listView);
        }

        public bool editAnamnesis(CapaNegocio.Clases.Login session, List<string> listData)
        {
            return anamnesis.editAnamenesis(session.getConnection(), listData);
        }
    }
}
