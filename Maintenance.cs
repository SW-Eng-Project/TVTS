using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVTS
{
    public class Maintenance
    {
        public string Description { get; set; }
        public int CarId { get; set; }
        public DateTime MaintenanceDay { get; set; }

        public Maintenance(int carId)
        {
            CarId = carId;
            //
            // TODO: Add constructor logic here
            //
        }
    }
}
