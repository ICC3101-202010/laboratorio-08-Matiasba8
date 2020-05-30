using Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_MatíasBustos.Controllers
{
    class LocalController
    {
        List<Local> Locales = new List<Local>();
        AppForm view;

        public LocalController()
        {
            Cine cine = new Cine(5, "Ricardo", 1, "10 am - 7pm","CINE");
            Restaurante restaurante = new Restaurante("si", "Vardoc", 2, "8am - 5pm","RESTAURANTE");
            Tienda tienda = new Tienda("Ropa", "Orlando", 3, "8:30 am - 6 pm","TIENDA");
            Locales.Add(cine);
            Locales.Add(restaurante);
            Locales.Add(tienda);

        }
        public List<Local> ReturnLocals()
        {
            return Locales;
        }
        public void AddLocal(Local local)
        {
            Locales.Add(local);
        }
        public int IdAssign()
        {
            return Locales.Count()+1;
        }


    }
}
