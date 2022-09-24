using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cars
{
    internal class CarsDataManager
    {
        List<Cars_Feature> list = new List<Cars_Feature>();
        readonly string path_ = @"C:\Users\user\Desktop\Cars.txt";
        public CarsDataManager()
        {
            OpenFileAndReadToList();
            DisplayAllCars();
        }
        public void DisplayCarsByFilters()
        {
            Cars_Feature cars = new Cars_Feature();
            Console.WriteLine("Please type car's brand which want to see.");
            Console.WriteLine("If you don't want type anything please type no.");
            string Carbrand = Console.ReadLine();
            Console.WriteLine("Please type car's model which want to see.");
            Console.WriteLine("If you don't want type anything please type no.");
            string CarModel = Console.ReadLine();
            Console.WriteLine("Please type car's type which want to see.");
            Console.WriteLine("If you don't want type anything please type no.");
            string CarType = Console.ReadLine();
            Console.WriteLine("Please type model's year which want to see.");
            Console.WriteLine("If you don't want type anything please type 0.");
            int CarModelYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type car's colour which want to see.");
            Console.WriteLine("If you don't want type anything please type no.");
            string CarColour = Console.ReadLine();
            Console.WriteLine("Please type car's cost which want to see.");
            Console.WriteLine("If you don't want type anything please type 0.");
            int CarCost = Convert.ToInt32(Console.ReadLine());
            foreach (var item in list)
            {
                if(item.CarBrand == Carbrand)
                {
                    if(item.CarModel == CarModel )
                    {
                        if(item.CarType == CarType)
                        {
                            if(item.CarModelYear == CarModelYear)
                            {
                                if(item.CarColour == CarColour)
                                {
                                    if(item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if(CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if(CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                            if(CarModelYear == 0)
                            {
                                if (item.CarColour == CarColour)
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if (CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                        }
                        if(CarType == "no")
                        {
                            if (item.CarModelYear == CarModelYear)
                            {
                                if (item.CarColour == CarColour)
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if (CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                            if (CarModelYear == 0)
                            {
                                if (item.CarColour == CarColour)
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if (CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                        }
                    }
                    if (CarModel == "no")
                    {
                        if (item.CarType == CarType)
                        {
                            if (item.CarModelYear == CarModelYear)
                            {
                                if (item.CarColour == CarColour)
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if (CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                            if (CarModelYear == 0)
                            {
                                if (item.CarColour == CarColour)
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if (CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                        }
                        if (CarType == "no")
                        {
                            if (item.CarModelYear == CarModelYear)
                            {
                                if (item.CarColour == CarColour)
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if (CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                            if (CarModelYear == 0)
                            {
                                if (item.CarColour == CarColour)
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if (CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                        }
                    }
                }
                if(Carbrand == "no")
                {
                    if (item.CarModel == CarModel)
                    {
                        if (item.CarType == CarType)
                        {
                            if (item.CarModelYear == CarModelYear)
                            {
                                if (item.CarColour == CarColour)
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if (CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                            if (CarModelYear == 0)
                            {
                                if (item.CarColour == CarColour)
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if (CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                        }
                        if (CarType == "no")
                        {
                            if (item.CarModelYear == CarModelYear)
                            {
                                if (item.CarColour == CarColour)
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if (CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                            if (CarModelYear == 0)
                            {
                                if (item.CarColour == CarColour)
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if (CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                        }
                    }
                    if (CarModel == "no")
                    {
                        if (item.CarType == CarType)
                        {
                            if (item.CarModelYear == CarModelYear)
                            {
                                if (item.CarColour == CarColour)
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if (CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                            if (CarModelYear == 0)
                            {
                                if (item.CarColour == CarColour)
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if (CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                        }
                        if (CarType == "no")
                        {
                            if (item.CarModelYear == CarModelYear)
                            {
                                if (item.CarColour == CarColour)
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if (CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                            if (CarModelYear == 0)
                            {
                                if (item.CarColour == CarColour)
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                                if (CarColour == "no")
                                {
                                    if (item.CarCost >= CarCost)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                    if (CarCost == 0)
                                    {
                                        Console.Write(item.CarCode + "|");
                                        Console.Write(item.CarBrand + "|");
                                        Console.Write(item.CarModel + "|");
                                        Console.Write(item.CarType + "|");
                                        Console.Write(item.CarModelYear + "|");
                                        Console.Write(item.CarColour + "|");
                                        Console.Write(item.CarCost + "|" + "\n");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public void DisplayAllCars()
        {
            string StrList = ConvertListToString(list);
            Console.WriteLine(StrList);
        }
        public void SelectbyCode(string code)
        {
            var itemToRemove = list.SingleOrDefault(r => r.CarCode == code);
            if (itemToRemove != null)
                list.Remove(itemToRemove);
        }

        public void InsertCar()
        {
            Cars_Feature cars = new Cars_Feature();
            Console.WriteLine("Please insert code of car.");
        Replace:
            cars.CarCode = Console.ReadLine();
            foreach (Cars_Feature item in list)
            {
                if (item.CarCode == cars.CarCode)
                {
                    Console.WriteLine("Please try again this code exist.");
                    goto Replace;
                }
            }
            Console.WriteLine("Please insert brand of car.");
            cars.CarBrand = Console.ReadLine();
            Console.WriteLine("Please insert model of car.");
            cars.CarModel = Console.ReadLine();
            Console.WriteLine("Please insert type of car.");
            cars.CarType = Console.ReadLine();
        Replace5:
            try
            {
                Console.WriteLine("Please insert model year of car.");
                cars.CarModelYear = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please insert number.");
                goto Replace5;
            }
            Console.WriteLine("Please insert colour of car.");
            cars.CarColour = Console.ReadLine();
        Replace2:
            try
            {
                Console.WriteLine("Please insert cost of car.");
                cars.CarCost = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please insert number.");
                goto Replace2;
            }
            list.Add(cars);
            string Str_Product = ConvertToString(cars);
            OpenFileAndWrite(Str_Product);
            DisplayAllCars();
        }
        public void UpdateCar()
        {
            Cars_Feature cars = new Cars_Feature();
            Console.WriteLine("Please type car's code which want to update.");
            string Code_Update = Console.ReadLine();
            SelectbyCode(Code_Update);
            Console.WriteLine("Please enter new brand of car.");
            string NewBrand = Console.ReadLine();
            Console.WriteLine("Please enter new model of car.");
            string NewModel = Console.ReadLine();
            Console.WriteLine("Please enter new type of car.");
            string NewType = Console.ReadLine();
            int NewModelyear = 0;
        Replace3:
            try
            {
                Console.WriteLine("Please enter new  year of car.");
                NewModelyear = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please insert number.");
                goto Replace3;
            }
            Console.WriteLine("Please enter new colour of car.");
            string NewColour = Console.ReadLine();
            int NewCost = 0;
        Replace4:
            try
            {
                Console.WriteLine("Please enter new cost of car.");
                NewCost = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please insert number.");
                goto Replace4;
            }

            cars.CarBrand = NewBrand;
            cars.CarModel = NewModel;
            cars.CarType = NewType;
            cars.CarModelYear = NewModelyear;
            cars.CarColour = NewColour;
            cars.CarCode = Code_Update;
            list.Add(cars);
            string StrList = ConvertListToString(list);
            OpenFileAndUpdate(StrList);
            DisplayAllCars();
        }
        public void DeleteCar()
        {
            DisplayAllCars();
            Console.WriteLine(" Please type car's code which want to delete.");
            string Code_Delete = Console.ReadLine();
            SelectbyCode(Code_Delete);
            string StrList = ConvertListToString(list);
            OpenFileAndUpdate(StrList);
            DisplayAllCars();
        }
        Cars_Feature ConvertStringToObject(string str)
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
        string ConvertToString(Cars_Feature cars)
        {
            string Str_Car = string.Empty;
            Str_Car = Str_Car + cars.CarCode + "|";
            Str_Car = Str_Car + cars.CarBrand + "|";
            Str_Car = Str_Car + cars.CarModel + "|";
            Str_Car = Str_Car + cars.CarModelYear.ToString() + "|";
            Str_Car = Str_Car + cars.CarColour + "|";
            Str_Car = Str_Car + cars.CarCost.ToString() + "|";
            return Str_Car;
        }
        string ConvertListToString(List<Cars_Feature> list)
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
                Str_Car = Str_Car + item.CarCode + "|";
                Str_Car = Str_Car + item.CarBrand + "|";
                Str_Car = Str_Car + item.CarModel + "|";
                Str_Car = Str_Car + item.CarType + "|";
                Str_Car = Str_Car + item.CarModelYear.ToString() + "|";
                Str_Car = Str_Car + item.CarColour + "|";
                if (index2 == index)
                {
                    Str_Car = Str_Car + item.CarCost.ToString() + "|";
                }
                else
                {
                    Str_Car = Str_Car + item.CarCost.ToString() + "|" + "\n";
                }
            }
            return Str_Car;
        }
        public void OpenFileAndWrite(string Str_Car)
        {
            // string Path = "@example.txt";
            using StreamWriter sw = new(path_, append: true);
            sw.WriteLine(Str_Car);
        }
        public void OpenFileAndUpdate(string Str_Car)
        {
            // string Path = "@example.txt";
            File.Delete(path_);
            // Path.Remove(Convert.ToInt32(Path));
            OpenFileAndWrite(Str_Car);
        }
        void OpenFileAndReadToList()
        {
            string[] line = File.ReadAllLines(path_);

            foreach (var item in line)
            {
                Cars_Feature car = ConvertStringToObject(item);
                list.Add(car);
            }
        }
    }
}
