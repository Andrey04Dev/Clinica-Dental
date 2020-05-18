using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Clases
{
    public class Reportes
    {
        CapaDatos.Clases.Reportes reportes;

        public Reportes()
        {
            reportes = new CapaDatos.Clases.Reportes();
        }

        public DataSet getReportesSQL( CapaNegocio.Clases.Login session, List<string> listvalues, string numrpt)
        {
            return reportes.getReportSQL(session.getConnection(), listvalues, numrpt);
        }
    }
}
