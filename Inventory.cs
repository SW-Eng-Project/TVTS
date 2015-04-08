using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parse;
using System.Windows.Forms;

namespace TVTS
{
    public class Inventory
    {
        //Adds car information to database on Parse
        async public virtual Task addCar(Car car)
        {
            ParseObject newCar = new ParseObject("car");
            newCar["make"] = car.Make;
            newCar["model"] = car.Model;
            newCar["package"] = car.Pack;
            newCar["year"] = car.Year;
            newCar["isSold"] = car.IsSold;
            newCar["interior"] = car.Interior;
            newCar["exterior"] = car.Exterior;
            newCar["performance"] = car.Performance;
            newCar["safety"] = car.Safety;
            newCar["warranty"] = car.Warranty;
            newCar["price"] = car.Price;

            await newCar.SaveAsync();

        }

        //Finds all cars that matches make, model and year that was provided by user
        async public Task<List<ParseObject>> searchCar(string make, string model, int year, bool sold, ListBox listBox)
        {
             IEnumerable<ParseObject> carResults;

            if (sold == false)
            {
                var query = (from car in ParseObject.GetQuery("car")
                             where car.Get<string>("make") == make
                             where car.Get<string>("model") == model
                             where car.Get<int>("year") == year
                             where car.Get<bool>("isSold") == sold
                             select car);

                carResults = await query.FindAsync();

                showResults(carResults, listBox);
            }
            else
            {
                var query = (from car in ParseObject.GetQuery("car")
                             where car.Get<string>("make") == make
                             where car.Get<string>("model") == model
                             where car.Get<int>("year") == year
                             where car.Get<bool>("isSold") == sold
                             select car);

                carResults = await query.FindAsync();

                showResults(carResults, listBox);
            }

            return carResults.ToList();

        }


        public void showResults(IEnumerable<ParseObject> carResults, ListBox listBox)
        {
            if (carResults.Count() == 0)
            {
                listBox.Items.Add("No cars found");
            }
            else {

                foreach (var result in carResults)
                {
                    var result_make = result.Get<String>("make");
                    var result_model = result.Get<String>("model");
                    var result_year = result.Get<Int32>("year");
                    var result_package = result.Get<Int32>("package");
                    var result_interior = result.Get<String>("interior");
                    var result_exterior = result.Get<String>("exterior");
                    var result_perf = result.Get<String>("performance");
                    var result_safe = result.Get<String>("safety");
                    var result_warr = result.Get<String>("warranty");
                    var result_sold = result.Get<Boolean>("isSold");
                    var result_price = result.Get<Int32>("price");

                    String sold = "Not owned";

                    if (result_sold == true)
                    {
                        sold = "Owned";
                    }


                    listBox.Items.Add(result_make + " " + result_model + " " + result_year + " " +
                        result_package + " " + result_interior + " " + result_exterior + " " +
                        result_perf + " " + result_safe + " " + result_warr + " " + sold + " " + result_price);
                }
            }

        }












    }
}
