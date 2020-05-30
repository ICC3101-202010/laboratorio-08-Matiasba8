using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Local
    {
        protected string ownerName;
        protected int id;
        protected string horarioAtencion;
        protected string localType;

        

        public Local(string ownerName, int id, string horarioAtencion, string localType)
        {
            this.OwnerName = ownerName;
            this.Id = id;
            this.HorarioAtencion = horarioAtencion;
            this.LocalType = localType;
        }

        public string OwnerName { get => ownerName; set => ownerName = value; }
        public int Id { get => id; set => id = value; }
        public string HorarioAtencion { get => horarioAtencion; set => horarioAtencion = value; }
        public string LocalType { get => localType; set => localType = value; }
    }
}
