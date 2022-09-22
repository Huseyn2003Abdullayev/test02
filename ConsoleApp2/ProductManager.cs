using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp2
{
    class ProductManager
    {
        readonly List<Product> list = new List<Product>();
        public List<Product> DisplayAllProducts()
        {
            return null;
        }
        public List<Product> SelectbyCode (string code)
        {
            Product product = new Product();
            foreach (var item in list)
            {
                if (item.code == code)
                {
                    list.Remove(product);                    
                    
                }
            }
            return list;
        }

        public void InsertProduct()
        {
            Product product = new Product();
            //List<Product> list = new List<Product>();
            Console.WriteLine("Please insert name of product.");
            product.name = Console.ReadLine();
            Console.WriteLine("Please insert quantity of product.");
            product.quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert code of product.");
            product.code = Console.ReadLine();
            Console.WriteLine("Please insert cost of product.");
            product.cost = Convert.ToInt32(Console.ReadLine());
            list.Add(product);
            string Str_Product = ConvertToString(product);
            OpenFileAndWrite(Str_Product);
        }
        public void UpdateProduct()
        {
            Product product = new Product();
            Console.WriteLine("Please type code which want to update.");
            string Code_Update = Console.ReadLine();
            SelectbyCode(Code_Update);
            Console.WriteLine("Please enter new name of product.");
            string newName = Console.ReadLine();
            Console.WriteLine("Please enter new quantity of product.");
            string newQuantity = Console.ReadLine();
            Console.WriteLine("Please enter new cost of product.");
            string newcost = Console.ReadLine();
            product.name = newName;
            product.quantity = Convert.ToInt32(newQuantity);
            product.code = Code_Update;
            product.cost = Convert.ToInt32(newcost);
            list.Add(product);
            string StrList = ConvertListToString(list);
            OpenFileAndUpdate(StrList);
        }
        public void DeleteProduct()
        {    
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
        string ConvertToString(Product product )
        {
            string Str_Product = string.Empty;
            Str_Product = Str_Product + product.name + "|";
            Str_Product = Str_Product + product.quantity.ToString() + "|";
            Str_Product = Str_Product + product.code + "|";
            Str_Product = Str_Product + product.cost.ToString() + "|";
            return Str_Product;
        }
        string ConvertListToString(List<Product> list)
        {
            string Str_Product = string.Empty;
            foreach (var item in list)
            {
                Str_Product = Str_Product + item.name + "|";
                Str_Product = Str_Product + item.quantity.ToString() + "|";
                Str_Product = Str_Product + item.code + "|";
                Str_Product = Str_Product + item.cost.ToString() + "|";
            }
            return Str_Product;
        }
        public void OpenFileAndWrite(string Str_Product)
        {
            string Path = "@example.txt";
            using StreamWriter sw = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + Path);
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
