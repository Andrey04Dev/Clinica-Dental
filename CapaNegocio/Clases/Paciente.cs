using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Clases
{
    public class Paciente
    {
        CapaDatos.Clases.Paciente paciente;
        public Paciente()
        {
            paciente = new CapaDatos.Clases.Paciente();
        }

        public void searchPacientes(CapaNegocio.Clases.Login session, 
            System.Windows.Forms.ListView listView, String textdata)
        {
            paciente.searchPaciente(session.getConnection(), listView, textdata);
        }

        public List<string> getDataPaciente(CapaNegocio.Clases.Login session,
            System.Windows.Forms.ListView listView)
        {
            return paciente.getPaciente(session.getConnection(), listView);
        }

        public bool editPaciente(CapaNegocio.Clases.Login session, List<string> listData)
        {
            return paciente.editPaciente(session.getConnection(), listData);
        }

        public bool eliminarPaciente(CapaNegocio.Clases.Login session, string textdata)
        {
            return paciente.eliminarPaciente(session.getConnection(), textdata);
        }
    }
}
