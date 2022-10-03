using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class EnumOperation
    {
        Cars_Feature cars = new Cars_Feature();
        public void Colour(int number)
        {
             number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case ((int)colours.Red):
                    cars.CarColour = Convert.ToString(colours.Red);
                    break;
                case ((int)colours.Green):
                    cars.CarColour = Convert.ToString(colours.Green);
                    break;
                case ((int)colours.Yellow):
                    cars.CarColour = Convert.ToString(colours.Yellow);
                    break;
                case ((int)colours.White):
                    cars.CarColour = Convert.ToString(colours.White);
                    break;
                case ((int)colours.Black):
                    cars.CarColour = Convert.ToString(colours.Black);
                    break;
            }
        }
        public void Type(int number)
        {
            number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case ((int)types.Sedan):
                    cars.CarType = types.Sedan.ToString();
                    break;
                case ((int)types.Jeep):
                    cars.CarType = types.Jeep.ToString();
                    break;
                case ((int)types.Liftback):
                    cars.CarType = types.Liftback.ToString();
                    break;
                case ((int)types.Hetchbek):
                    cars.CarType = types.Hetchbek.ToString();
                    break;
            }
        }
        public enum colours
        {
            Red = 1,
            Green = 2,
            Yellow = 3,
            White = 4,
            Black = 5
        }
        public enum types
        {
            Sedan = 1,
            Jeep = 2,
            Liftback = 3,
            Hetchbek = 4
        }
    }
}
