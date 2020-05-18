using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Clases
{
    public class Imagenes
    {
        CapaDatos.Clases.Imagenes imagenes;

        public Imagenes()
        {
            imagenes = new CapaDatos.Clases.Imagenes();
        }

        public void searchImagenes(CapaNegocio.Clases.Login session,
            System.Windows.Forms.ListView listView, String textdata)
        {
            imagenes.searchImagenes(session.getConnection(), listView, textdata);
        }

        public List<string> getDataImagenes(CapaNegocio.Clases.Login session,
            System.Windows.Forms.ListView listView)
        {
            return imagenes.getImagenes(session.getConnection(), listView);
        }

        public bool editImagenes(CapaNegocio.Clases.Login session, List<string> listData)
        {
            return imagenes.editImagenes(session.getConnection(), listData);
        }
    }
}
