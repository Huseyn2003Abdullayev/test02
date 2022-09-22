using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    internal class ProductDataService
    {

        readonly string path_ = @"C:\Users\user\Desktop\data_product_list.txt";
        List<Products> list = new List<Products>();

        public ProductDataService()
        {
            OpenFileAndReadToList(path_);
        }



        public void DisplayAllProduct() {
            string StrList = ConvertListToString(list);
            Console.WriteLine(StrList);
        }

        public void Insert() {
            Products product = new Products();
            //List<Product> list = new List<Product>();
            Console.WriteLine("Please insert name of product.");
            product.Name = Console.ReadLine();
            Console.WriteLine("Please insert quantity of product.");
            product.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert code of product.");
            product.Code = Console.ReadLine();
            Console.WriteLine("Please insert cost of product.");
            product.Cost = Convert.ToInt32(Console.ReadLine());
            list.Add(product);
            string Str_Product = ConvertToString(product);
            OpenFileAndWrite(Str_Product);
        }
        public void Update()
        {

            Products product = new Products();
            Console.WriteLine("Please type code which want to update.");
            string Code_Update = Console.ReadLine();
            RemoveItemFromList(Code_Update);
            Console.WriteLine("Please enter new name of product.");
            string newName = Console.ReadLine();
            Console.WriteLine("Please enter new quantity of product.");
            string newQuantity = Console.ReadLine();
            Console.WriteLine("Please enter new cost of product.");
            string newcost = Console.ReadLine();
            product.Name = newName;
            product.Quantity = Convert.ToInt32(newQuantity);
            product.Code = Code_Update;
            product.Cost = Convert.ToInt32(newcost);
            list.Add(product);
            string StrList = ConvertListToString(list);
            OpenFileAndUpdate(StrList);
        }

        void RemoveItemFromList(string code) {

            var itemToRemove = list.SingleOrDefault(r => r.Code == code);
            if (itemToRemove != null)
                list.Remove(itemToRemove);
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
            foreach (var item in list)
            {
                Str_Product = Str_Product + item.Name + "|";
                Str_Product = Str_Product + item.Quantity.ToString() + "|";
                Str_Product = Str_Product + item.Code + "|";
                Str_Product = Str_Product + item.Cost.ToString() + "|" + "\n";
            }
            return Str_Product;
        }
        public void OpenFileAndWrite(string Str_Product)
        {
            
            using StreamWriter sw = new(path_, append: true);
            sw.WriteLine(Str_Product);
        }
        public void OpenFileAndUpdate(string Str_Product)
        {
            
            File.Delete(path_);
            // Path.Remove(Convert.ToInt32(Path));
            OpenFileAndWrite(Str_Product);
        }

        void OpenFileAndReadToList(string filePath)
        {
            string[] line = File.ReadAllLines(filePath);

            foreach (var item in line)
            {
                Products product = ConvertStringToObject(item);
                list.Add(product);
            }
        }

        Products ConvertStringToObject(string str)
        {
            Products product = new Products();
            string[] words = str.Split('|');
            product.Name = words[0];
            product.Code = words[1];
            product.Cost = Convert.ToInt32(words[2]);
            product.Quantity = Convert.ToInt32(words[3]);
            return product;
        }

    }


}
