using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    internal class ProductManager
    {
        readonly List<Products> list = new List<Products>();
        public void DisplayAllProducts()
        {
            string StrList = ConvertListToString(list);
            Console.WriteLine(StrList);
        }
        public List<Products> SelectbyCode(string code)
        {
           // List<Products> list = new List<Products>();
            Products product = new Products();
            foreach (Products item in list)
            {
                if (item.Code == code)
                {
                    product.Code = item.Code;
                    product.Name = item.Name;
                    product.Quantity = item.Quantity;
                    product.Cost = item.Cost;
                    product = item;
                    list.Remove(product);
                    //int Index = list.IndexOf(item);
                    //list.RemoveAt(Index);
                }
            }
            return list;
        }

        public void InsertProduct()
        {
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
        public void UpdateProduct()
        {
            Products product = new Products();
            Console.WriteLine("Please type code which want to update.");
            string Code_Update = Console.ReadLine();
            SelectbyCode(Code_Update);
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
        public void DeleteProduct()
        {
            DisplayAllProducts();
            Console.WriteLine("Please type code which want to delete.");
            string Code_Delete = Console.ReadLine();
            SelectbyCode(Code_Delete);
            string StrList = ConvertListToString(list);
            OpenFileAndUpdate(StrList);
        }
        //Product ConvertStringToObject(string str)
        //{
        //    Product product = new Product();
        //    string[] words = str.Split('|');
        //    product.name = words[0];
        //    product.quantity = Convert.ToInt32(words[1]);
        //    product.code = words[2];
        //    product.cost = Convert.ToInt32(words[3]);
        //    return product;

        //}
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
                Str_Product = Str_Product + item.Cost.ToString() + "|"+"\n";
            }
            return Str_Product;
        }
        public void OpenFileAndWrite(string Str_Product)
        {
            string Path = "@example.txt";
            using StreamWriter sw = new(AppDomain.CurrentDomain.BaseDirectory + Path, append: true);
            sw.WriteLine(Str_Product);
        }
        public void OpenFileAndUpdate(string Str_Product)
        {
            string Path = "@example.txt";
            File.Delete(Path);
            // Path.Remove(Convert.ToInt32(Path));
            OpenFileAndWrite(Str_Product);
        }
    }
}
