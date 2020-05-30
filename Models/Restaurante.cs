using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Restaurante:Local
    {
        private string MesaExclusiva;

        public Restaurante(string mesaExclusiva, string ownerName, int id, string horarioAtencion,string localType) : base(ownerName, id, horarioAtencion,localType)
        {
            MesaExclusiva = mesaExclusiva;
            OwnerName = OwnerName;
            Id = id;
            HorarioAtencion = horarioAtencion;
            LocalType = localType;

        }
    }
}
