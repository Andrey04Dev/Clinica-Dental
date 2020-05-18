using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Clases
{
    public class Tratamiento
    {
        CapaDatos.Clases.Tratamiento tratamiento;
        public Tratamiento()
        {
            tratamiento = new CapaDatos.Clases.Tratamiento();
        }

        public void searchTratamiento(CapaNegocio.Clases.Login session,
           System.Windows.Forms.ListView listView, String textdata)
        {
            tratamiento.searchTratamiento(session.getConnection(), listView, textdata);
        }

        public List<string> getDataTratamiento(CapaNegocio.Clases.Login session,
            System.Windows.Forms.ListView listView)
        {
            return tratamiento.getTratamiento(session.getConnection(), listView);
        }

        public bool editTratamiento(CapaNegocio.Clases.Login session, List<string> listData)
        {
            return tratamiento.editTratamiento(session.getConnection(), listData);
        }
    }
}
