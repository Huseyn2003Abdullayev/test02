using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AppDataServer
    {

        public List<Product> Select()
        {
            List<Product> list = OpenFileAndReadToList("");

            return list;
        }

        public List<Product> SelectByCode(string code)
        {
            List<Product> list = OpenFileAndReadToList("");

            return list;
        }

        public void Insert(string filePath)
        {
            Product product = new Product();

            product.Name = "";
            product.Code = "";
            product.Price = Convert.ToDouble("");
            product.Quantity = Convert.ToInt32("");


            string str_product = ConvertObjectToString(product);
            OpenFileAndWrite(str_product, filePath);
        }

        public void Update(string filePath, string code, Product updated_product)
        {
            List<Product> new_updated_list = OpenFileAndReadToList(filePath);
            foreach (Product item in new_updated_list)
            {
                if (item.Code == code)
                {
                    item.Name = updated_product.Name;
                    item.Price = updated_product.Price;
                    item.Quantity = updated_product.Quantity;
                }
            }

            foreach (Product item in new_updated_list)
            {
                string n  = ConvertObjectToString(item);
                OpenFileAndWrite(n, "temp_" + filePath);
            }

            RefReshFile(filePath);

        }
        public void Delete(string filePath, string code, Product updated_product)
        {
            List<Product> new_updated_list = OpenFileAndReadToList(filePath);

            bool tapdim = false;
            Product tapdigimitem = null;
            foreach (Product item in new_updated_list)
            {
                if (item.Code == code)
                {
                    tapdim = true;
                    tapdigimitem = item;
                }
            }

            new_updated_list.Remove(tapdigimitem);

            foreach (Product item in new_updated_list)
            {
                string n = ConvertObjectToString(item);
                OpenFileAndWrite(n, "temp_" + filePath);
            }

            RefReshFile(filePath);
        }


        void OpenFileAndWrite(string str_product, string filePath)
        {
            using (StreamWriter sw = File.AppendText(AppDomain.CurrentDomain.BaseDirectory + filePath))
            {
                sw.WriteLine(str_product);
            }
        }


        List<Product> OpenFileAndReadToList(string filePath)
        {
            List<Product> list = new List<Product>();

            string[] line = File.ReadAllLines(filePath);

            foreach (var item in line)
            {
                Product product = ConvertStringToObject(item);
                list.Add(product);
            }

            return list;

        }

        Product ConvertStringToObject(string str)
        {
            Product product = new Product();
            string[] words = str.Split('|');
            product.Name = words[0];
            product.Code = words[1];
            product.Price = Convert.ToDouble(words[2]);
            product.Quantity = Convert.ToInt32(words[3]);
            return product;
        }

        string ConvertObjectToString(Product product)
        {
            string str_product = string.Empty;
            str_product = str_product + product.Name + "|";
            str_product = str_product + product.Code + "|";
            str_product = str_product + product.Price.ToString() + "|";
            str_product = str_product + product.Quantity.ToString() + "|";

            return str_product;
        }

        void RefReshFile(string filePath)
        {
            // eger temp_ filePath varsa failpath faylini sil ve temp_ failpath i adine deyish
        }

    }
}
