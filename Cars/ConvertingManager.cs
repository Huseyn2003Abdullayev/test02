using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class ConvertingManager
    {
       public Cars_Feature ConvertStringToObject(string str)
        {
            Cars_Feature cars = new Cars_Feature();
            string[] words = str.Split('|');
            cars.CarCode = words[0];
            cars.CarBrand = words[1];
            cars.CarModel = words[2];
            cars.CarType = words[3];
            cars.CarModelYear = Convert.ToInt32(words[4]);
            cars.CarColour = words[5];
            cars.CarCost = Convert.ToInt32(words[4]);
            return cars;
        }
       public string ConvertToString(Cars_Feature cars)
        {
            string Str_Car = string.Empty;
            Str_Car = Str_Car + cars.CarCode.PadRight(5, ' ') + "|";
            Str_Car = Str_Car + cars.CarBrand.PadRight(20, ' ') + "|";
            Str_Car = Str_Car + cars.CarModel.PadRight(15, ' ') + "|";
            Str_Car = Str_Car + cars.CarType.PadRight(15, ' ') + "|";
            Str_Car = Str_Car + cars.CarModelYear.ToString().PadRight(4, ' ') + "|";
            Str_Car = Str_Car + cars.CarColour.PadRight(10, ' ') + "|";
            Str_Car = Str_Car + cars.CarCost.ToString().PadRight(8, ' ') + "|";
            return Str_Car;
        }
       public string ConvertListToString(List<Cars_Feature> list)
        {
            string Str_Car = string.Empty;
            int index = 0;
            foreach (var item in list)
            {
                index = list.IndexOf(item);
            }
            foreach (var item in list)
            {
                int index2 = list.IndexOf(item);
                Str_Car = Str_Car + item.CarCode.PadRight(5, ' ') + "|";
                Str_Car = Str_Car + item.CarBrand.PadRight(20, ' ') + "|";
                Str_Car = Str_Car + item.CarModel.PadRight(15, ' ') + "|";
                Str_Car = Str_Car + item.CarType.PadRight(15, ' ') + "|";
                Str_Car = Str_Car + item.CarModelYear.ToString().PadRight(4, ' ') + "|";
                Str_Car = Str_Car + item.CarColour.PadRight(10, ' ') + "|";
                if (index2 == index)
                {
                    Str_Car = Str_Car + item.CarCost.ToString().PadRight(8, ' ') + "|";
                }
                else
                {
                    Str_Car = Str_Car + item.CarCost.ToString().PadRight(8, ' ') + "|" + "\n";
                }
            }
            return Str_Car;
        }
    }
}
