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
        private ConvertingManager convertingManager = new ConvertingManager();
        FileOperations fileOperations = new FileOperations();
         List<Cars_Feature> list = new List<Cars_Feature>();
        readonly string path_ = @"C:\Users\user\Desktop\Cars.txt";
        public CarsDataManager()
        {
            //OpenFileAndReadToList();
            fileOperations.OpenFileAndReadToList(list);
            DisplayAllCars();
        }
        public void DisplayCarsByCost()
        {
            Console.WriteLine("What do you want?");
            Console.WriteLine("1.From low to high.");
            Console.WriteLine("2.From high to low.");
            string? Answer = Console.ReadLine();
            if (Answer == "1")
            {
                list = list.OrderBy(x => x.CarCost).ToList();
            }
       else if(Answer == "2")
       {
                list = list.OrderByDescending(x => x.CarCost).ToList();
       }
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
            if(Carbrand != "no")
            {
                list = list.Where(x => x.CarBrand == Carbrand).ToList();
            }
            if (CarModel != "no")
            {
                list = list.Where(x => x.CarModel == CarModel).ToList();
            }
            if (CarType != "no")
            {
                list = list.Where(x => x.CarType == CarType).ToList();
            }
            if (CarModelYear != 0)
            {
                list = list.Where(x => x.CarModelYear == CarModelYear).ToList();
            }
            if (CarColour != "no")
            {
                list = list.Where(x => x.CarColour == CarColour).ToList();
            }
            if (CarCost != 0)
            {
                list = list.Where(x => x.CarCost == CarCost).ToList();
            }
            DisplayAllCars();
            list = list.Where(x => x.CarCost > 0).ToList();
        }
        public void DisplayAllCars()
        {
            string StrList = convertingManager.ConvertListToString(list);
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
            Checking checking = new Checking();
            EnumOperation enumOperation = new EnumOperation();
            Cars_Feature cars = new Cars_Feature();
            Console.WriteLine("Please insert code of car.");
            cars.CarCode = Console.ReadLine();
            checking.CheckCode(cars.CarCode);
            Console.WriteLine("Please insert brand of car.");
            cars.CarBrand = Console.ReadLine();
            Console.WriteLine("Please insert model of car.");
            cars.CarModel = Console.ReadLine();
            Console.WriteLine("Choose type of car.");
            Console.WriteLine("1.Sedan.");
            Console.WriteLine("2.Jeep.");
            Console.WriteLine("3.Liftback.");
            Console.WriteLine("4.Hetchback.");
            int choosenTypeNumber = Convert.ToInt32(Console.ReadLine());
            enumOperation.Type(choosenTypeNumber);
            Console.WriteLine("Please insert model year of car.");
            checking.CheckNumber(cars.CarModelYear);
            Console.WriteLine("Choose colour of car.");
            Console.WriteLine("1.Red.");
            Console.WriteLine("2.Green.");
            Console.WriteLine("3.Yellow.");
            Console.WriteLine("4.White.");
            Console.WriteLine("5.Black.");
            int choosenColourNumber = Convert.ToInt32(Console.ReadLine());
            enumOperation.Colour(choosenColourNumber);
            Console.WriteLine("Please insert cost of car.");
            checking.CheckNumber(cars.CarCost);
            list.Add(cars);
            string Str_Product = convertingManager.ConvertToString(cars);
            // OpenFileAndWrite(Str_Product);
            fileOperations.OpenFileAndWrite(Str_Product);
            DisplayAllCars();
        }
        public void UpdateCar()
        {
            Checking checking = new Checking();
            Cars_Feature cars = new Cars_Feature();
            Console.WriteLine("Please type car's code which want to update.");
            string Code_Update = Console.ReadLine();
            SelectbyCode(Code_Update);
            Console.WriteLine("Please enter new brand of car.");
            string NewBrand = Console.ReadLine();
            Console.WriteLine("Please enter new model of car.");
            string  NewModel = Console.ReadLine();
            Console.WriteLine("Please enter new type of car.");
            string NewType = Console.ReadLine();
            int NewModelyear = 0;
            Console.WriteLine("Please enter new  year of car.");
            checking.CheckNumber(NewModelyear);
            Console.WriteLine("Please enter new colour of car.");
            string NewColour = Console.ReadLine();
            int NewCost = 0;
            Console.WriteLine("Please enter new cost of car.");
            checking.CheckNumber(NewCost);

            cars.CarBrand = NewBrand;
            cars.CarModel = NewModel;
            cars.CarType = NewType;
            cars.CarModelYear = NewModelyear;
            cars.CarColour = NewColour;
            cars.CarCode = Code_Update;
            list.Add(cars);
            string StrList = convertingManager.ConvertListToString(list);
            //OpenFileAndUpdate(StrList);
            fileOperations.OpenFileAndUpdate(StrList);
            DisplayAllCars();
        }
        public void DeleteCar()
        {
            DisplayAllCars();
            Console.WriteLine(" Please type car's code which want to delete.");
            string Code_Delete = Console.ReadLine();
            SelectbyCode(Code_Delete);
            string StrList = convertingManager.ConvertListToString(list);
            //OpenFileAndUpdate(StrList);
            fileOperations.OpenFileAndUpdate(StrList);
            DisplayAllCars();
        }
        //Cars_Feature ConvertStringToObject(string str)
        //{
        //    Cars_Feature cars = new Cars_Feature();
        //    string[] words = str.Split('|');
        //    cars.CarCode = words[0];
        //    cars.CarBrand = words[1];
        //    cars.CarModel = words[2];
        //    cars.CarType = words[3];
        //    cars.CarModelYear = Convert.ToInt32(words[4]);
        //    cars.CarColour = words[5];
        //    cars.CarCost = Convert.ToInt32(words[4]);
        //    return cars;
        //}
        //string ConvertToString(Cars_Feature cars)
        //{
        //    string Str_Car = string.Empty;
        //    Str_Car = Str_Car + cars.CarCode.PadRight(5, ' ') + "|";
        //    Str_Car = Str_Car + cars.CarBrand.PadRight(20, ' ')  + "|";
        //    Str_Car = Str_Car + cars.CarModel.PadRight(15, ' ')  + "|";
        //    Str_Car = Str_Car + cars.CarType.PadRight(15, ' ') + "|";
        //    Str_Car = Str_Car + cars.CarModelYear.ToString().PadRight(4, ' ') + "|";
        //    Str_Car = Str_Car + cars.CarColour.PadRight(10, ' ') + "|";
        //    Str_Car = Str_Car + cars.CarCost.ToString().PadRight(8, ' ') + "|";
        //    return Str_Car;
        //}
        //string ConvertListToString(List<Cars_Feature> list)
        //{
        //    string Str_Car = string.Empty;
        //    int index = 0;
        //    foreach (var item in list)
        //    {
        //        index = list.IndexOf(item);
        //    }
        //    foreach (var item in list)
        //    {
        //        int index2 = list.IndexOf(item);
        //        Str_Car = Str_Car + item.CarCode.PadRight(5, ' ') + "|";
        //        Str_Car = Str_Car + item.CarBrand.PadRight(20, ' ') + "|";
        //        Str_Car = Str_Car + item.CarModel.PadRight(15, ' ') + "|";
        //        Str_Car = Str_Car + item.CarType.PadRight(15, ' ') + "|";
        //        Str_Car = Str_Car + item.CarModelYear.ToString().PadRight(4, ' ') + "|";
        //        Str_Car = Str_Car + item.CarColour.PadRight(10, ' ') + "|";
        //        if (index2 == index)
        //        {
        //            Str_Car = Str_Car + item.CarCost.ToString().PadRight(8, ' ') + "|";
        //        }
        //        else
        //        {
        //            Str_Car = Str_Car + item.CarCost.ToString().PadRight(8, ' ') + "|" + "\n";
        //        }
        //    }
        //    return Str_Car;
        //}
        //public void OpenFileAndWrite(string Str_Car)
        //{
        //    // string Path = "@example.txt";
        //    using StreamWriter sw = new(path_, append: true);
        //    sw.WriteLine(Str_Car);
        //}
        //public void OpenFileAndUpdate(string Str_Car)
        //{
        //    // string Path = "@example.txt";
        //    File.Delete(path_);
        //    // Path.Remove(Convert.ToInt32(Path));
        //    OpenFileAndWrite(Str_Car);
        //}
        //public void OpenFileAndReadToList(List<Cars_Feature> list)
        //{
        //    string[] line = File.ReadAllLines(path_);

        //    foreach (var item in line)
        //    {
        //        Cars_Feature car = convertingManager.ConvertStringToObject(item);
        //        list.Add(car);
        //    }
        //}
    }
}
