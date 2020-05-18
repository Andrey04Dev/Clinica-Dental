using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Clases
{
    public class Odontograma
    {
        CapaDatos.Clases.Odontograma odontograma;
        public Odontograma()
        {
            odontograma = new CapaDatos.Clases.Odontograma();
        }
        public void searchOdontograma(CapaNegocio.Clases.Login session,
            System.Windows.Forms.ListView listView, String textdata)
        {
            odontograma.searchOdontograma(session.getConnection(), listView, textdata);
        }

        public List<string> getDataOdontograma(CapaNegocio.Clases.Login session,
            System.Windows.Forms.ListView listView)
        {
            return odontograma.getOdontograma(session.getConnection(), listView);
        }

        public bool editOdontograma(CapaNegocio.Clases.Login session, List<string> listData)
        {
            return odontograma.editOdontograma(session.getConnection(), listData);
        }
    }
}

