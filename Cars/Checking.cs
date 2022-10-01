using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Checking
    {
        List<Cars_Feature> list = new List<Cars_Feature>();
        public void CheckCode(string code)
        {
            Cars_Feature cars = new Cars_Feature();
            bool Answer = false;
            do 
            {
                foreach (Cars_Feature item in list)
                {
                    
                    if (item.CarCode == code)
                    {
                        Console.WriteLine("Please try again this code exist.");
                        code = Console.ReadLine();
                    }
                    else
                    {
                        Answer = true;
                        cars.CarCode = code;
                    }
                }
            } while (Answer == true);
        }
        public void CheckNumber(string number)
        {
            bool check = false;
            do
            {

            } while (check == true);
        }
    }

}
