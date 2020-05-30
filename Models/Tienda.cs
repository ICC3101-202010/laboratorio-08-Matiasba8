using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Tienda:Local
    {
        private string category;

        public Tienda(string category, string ownerName, int id, string horarioAtencion,string localType) : base(ownerName, id, horarioAtencion,localType)
        {
            this.category = category;
            OwnerName = ownerName;
            Id = id;
            HorarioAtencion = horarioAtencion;
            LocalType = localType;
        }
    }
}
