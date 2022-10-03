using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class FileOperations 
    {
        private ConvertingManager convertingManager = new ConvertingManager();
        public List<Cars_Feature> list = new List<Cars_Feature>();
        readonly string path_ = @"C:\Users\user\Desktop\Cars.txt";
        public void OpenFileAndWrite(string Str_Car)
        {
            // string Path = "@example.txt";
            using StreamWriter sw = new(path_, append: true);
            sw.WriteLine(Str_Car);
        }
        public void OpenFileAndUpdate(string Str_Car)
        {
            // string Path = "@example.txt";
            File.Delete(path_);
            // Path.Remove(Convert.ToInt32(Path));
            OpenFileAndWrite(Str_Car);
        }
        public void OpenFileAndReadToList(List<Cars_Feature> list)
        {
            string[] line = File.ReadAllLines(path_);

            foreach (var item in line)
            {
                Cars_Feature car = convertingManager.ConvertStringToObject(item);
                list.Add(car);
            }
        }
    }
}
