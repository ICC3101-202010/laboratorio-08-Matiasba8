using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cine:Local
    {
        private int salas;

        public Cine(int salas, string ownerName, int id, string horarioAtencion,string localType) : base(ownerName, id, horarioAtencion,localType)
        {
            this.salas = salas;
            OwnerName = ownerName;
            Id = id;
            HorarioAtencion = horarioAtencion;
            LocalType = localType;
        }
    }
}
