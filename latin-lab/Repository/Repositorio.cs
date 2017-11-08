using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace latin_lab.Repository
{
    public class Repositorio
    {
        ClinicaDBEntities context = new ClinicaDBEntities();

        //public IEnumerable<Distritos> listarDistritos()
        //{
        //    using (ClinicaDBEntities context = new ClinicaDBEntities()) ;
        //    IEnumerable<Distritos> distritos = context.Distritos.Select(x => x.nombreDistrito).ToList();
        //    return distritos;
        //}
    }
}