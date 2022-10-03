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
        FileOperations fileOperations = new FileOperations();
        public Checking()
        {
            fileOperations.OpenFileAndReadToList(list);
        }
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
                    }
                }
            } while (Answer == false);
        }
        public void CheckNumber(int number)
        {
            bool check = false;
            do
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please insert number.");
                    check = true;
                }
                finally
                {
                    if(check == true)
                    {
                        check = false;
                    }
                    else if (check == false)
                    {
                        check = true;
                    }

                }
            } while (check == false);
        }
    }

}
