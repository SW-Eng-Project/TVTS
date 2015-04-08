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
        public int Pack { get; set; }
        public int Year { get; set; }
        public bool IsSold { get; set; }
        public string Interior { get; set; }
        public string Exterior { get; set; }
        public string Performance { get; set; }
        public string Safety { get; set; }
        public string Warranty { get; set; }
        public int Price { get; set; }
        public string Buyer { get; set; }
        public int Odometer { get; set; }
        public DateTime DateTimeSale { get; set; }
        public IDictionary<string, object> Maintenance { get; set; }

        enum Package
        {
            Base,
            Premium,
            Sport
        };

        public Car(string[] line)
        {
            //
            // TODO: Add constructor logic here
            //
            Make = line[0];
            Model = line[1];
            Pack = int.Parse(line[2]);
            Year = int.Parse(line[3]);
            IsSold = Boolean.Parse(line[4]);
            Interior = line[5];
            Exterior = line[6];
            Warranty = line[7];
            Price = int.Parse(line[8]);
            Buyer = line[9];
            Odometer = int.Parse(line[10]);


            
        }

    }

    
}
