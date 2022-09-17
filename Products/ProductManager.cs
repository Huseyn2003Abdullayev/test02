using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    internal class ProductManager
    {
         List<Products> list = new List<Products>();
        readonly string path_ = @"C:\Users\user\Desktop\data_product_list.txt";
        public ProductManager()
        {
            OpenFileAndReadToList();
            DisplayAllProducts();
        }
        public void DisplayAllProducts()
        {
            string StrList = ConvertListToString(list);
            Console.WriteLine(StrList);
        }
        public void SelectbyCode(string code)
        {
            var itemToRemove = list.SingleOrDefault(r => r.Code == code);
            if (itemToRemove != null)
                list.Remove(itemToRemove);
        }

        public void InsertProduct()
        {
            Products product = new Products();
            //List<Product> list = new List<Product>();
            Console.WriteLine("Please insert name of product.");
            product.Name = Console.ReadLine();
            Replace1:
            try
            { 
            Console.WriteLine("Please insert quantity of product.");
            product.Quantity = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please insert number.");
                goto Replace1;
            }
            Console.WriteLine("Please insert code of product.");
            Replace:
            product.Code = Console.ReadLine();
            foreach (Products item in list)
            {
                if (item.Code == product.Code)
                {
                    Console.WriteLine("Please try again this number exist.");
                    goto Replace;
                }
            }
            try
            { 
            Console.WriteLine("Please insert cost of product.");
            product.Cost = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please insert number.");
            }
            list.Add(product);
            string Str_Product = ConvertToString(product);
            OpenFileAndWrite(Str_Product);
            DisplayAllProducts();
        }
        public void UpdateProduct()
        {
            Products product = new Products();
            Console.WriteLine("Please type code which want to update.");
            string Code_Update = Console.ReadLine();
            SelectbyCode(Code_Update);
            Console.WriteLine("Please enter new name of product.");
            string newName = Console.ReadLine();
            int newQuantity = 0;
            Replace3:
            try
            { 
            Console.WriteLine("Please enter new quantity of product.");
             newQuantity = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please insert number.");
                goto Replace3;
            }
            int newCost = 0;
            Replace4:
            try
            { 
            Console.WriteLine("Please enter new cost of product.");
             newCost = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please insert number.");
                goto Replace4;
            }

            product.Name = newName;
            product.Quantity = newQuantity;
            product.Code = Code_Update;
            product.Cost = newCost;
            list.Add(product);
            string StrList = ConvertListToString(list);
            OpenFileAndUpdate(StrList);
            DisplayAllProducts();
        }
        public void DeleteProduct()
        {
            DisplayAllProducts();
            Console.WriteLine(" Please type code which want to delete.");
            string Code_Delete = Console.ReadLine();
            SelectbyCode(Code_Delete);
            string StrList = ConvertListToString(list);
            OpenFileAndUpdate(StrList);
            DisplayAllProducts();
        }
        Products ConvertStringToObject(string str)
        {
            Products product = new Products();           
            string[] words = str.Split('|');
            product.Name = words[0];
            product.Quantity = Convert.ToInt32(words[1]);
            product.Code = words[2];
            product.Cost = Convert.ToInt32(words[3]);
            return product;
        }
        string ConvertToString(Products product)
        {
            string Str_Product = string.Empty;
            Str_Product = Str_Product + product.Name + "|";
            Str_Product = Str_Product + product.Quantity.ToString() + "|";
            Str_Product = Str_Product + product.Code + "|";
            Str_Product = Str_Product + product.Cost.ToString() + "|";
            return Str_Product;
        }
        string ConvertListToString(List<Products> list)
        {
            string Str_Product = string.Empty;
            int index = 0;
            foreach (var item in list)
            {
                index = list.IndexOf(item);
            }
            foreach (var item in list)
            {
               int index2 = list.IndexOf(item);
                Str_Product = Str_Product + item.Name + "|";
                Str_Product = Str_Product + item.Quantity.ToString() + "|";
                Str_Product = Str_Product + item.Code + "|";
                //Str_Product = Str_Product + item.Cost.ToString() + "|";
                if (index2 == index)
                {
                    Str_Product = Str_Product + item.Cost.ToString() + "|";
                }
                else 
                {
                    Str_Product = Str_Product + item.Cost.ToString() + "|" + "\n";
                }
            }
            return Str_Product;
        }
        public void OpenFileAndWrite(string Str_Product)
        {
           // string Path = "@example.txt";
            using StreamWriter sw = new( path_, append: true);
            sw.WriteLine(Str_Product);
        }
        public void OpenFileAndUpdate(string Str_Product)
        {
           // string Path = "@example.txt";
            File.Delete(path_);
            // Path.Remove(Convert.ToInt32(Path));
            OpenFileAndWrite(Str_Product);
        }
        void OpenFileAndReadToList()
        {
            string[] line = File.ReadAllLines(path_);

            foreach (var item in line)
            {
                Products product = ConvertStringToObject(item);
                list.Add(product);
            }
        }
    }
}
