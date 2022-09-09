using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            ProductManager productManager = new ProductManager();
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            Top:
            Console.WriteLine("Hello "+ name + ".");
            Console.WriteLine("1.Insert product.");
            Console.WriteLine("2.Update product.");
            Console.WriteLine("3.Delete product.");
            string OperationNumber = Console.ReadLine();
            switch(Convert.ToInt32(OperationNumber))
            {
                case 1 :
                    productManager.InsertProduct();
                    break;
                case 2 :
                    productManager.UpdateProduct();
                    break;
                case 3 :
                    productManager.DeleteProduct();
                    break;
            }
            Answer:
            Console.WriteLine("What do you want? leave or continue");
            string Answer = Console.ReadLine();
            if (Answer == "continue")
            {
                goto Top;
            }
            else if (Answer == "leave")
            {
                goto End;
            }
            else
            {
                Console.WriteLine("You type wrong word.Please try again.");
                goto Answer;
            }
        End:
            Console.ReadKey();
        }
    }
}
