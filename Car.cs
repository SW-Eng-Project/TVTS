using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVTS
{
    public class Car
    {
  
        public string Make { get; set; }
        public string Model { get; set; }
        public string Premium { get; set; }
        public int Year { get; set; }
        public bool IsSold { get; set; }
        public string Interior { get; set; }
        public string Exterior { get; set; }
        public string Performance { get; set; }
        public string Safety { get; set; }
        public string Warranty { get; set; }
        public int Price { get; set; }
        public List<Maintenance> Maintenances;

        public Car(string[] line)
        {
            //
            // TODO: Add constructor logic here
            //
            Make = line[0];
            Model = line[1];
            Premium = line[2];
            Year = int.Parse(line[3]);
            IsSold = Boolean.Parse(line[4]);
            Interior = line[5];
            Exterior = line[6];
            Performance = line[7];
            Safety = line[8];
            Warranty = line[9];
            Price = int.Parse(line[10]);
            Maintenances = new List<Maintenance>();
        }

        public void AddMaintenance(Maintenance item)
        {
            Maintenances.Add(item);
        }
    }

    
}
