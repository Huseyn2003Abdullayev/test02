using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cars.EnumsCollections;

namespace Cars
{
    public class Car
    {
        public string? Code { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public Types Type { get; set; }
        public int ModelYear { get; set; }
        public Colours Colour { get; set; }
        public int Cost { get; set; }
       

        //public override string ToString()
        //{
        //    string Car_Information = string.Empty;

        //    Car_Information = Car_Information + this.Code.PadRight(5, ' ') + "|";
        //    Car_Information = Car_Information + this.Brand.PadRight(20, ' ') + "|";
        //    Car_Information = Car_Information + this.Model.PadRight(15, ' ') + "|";
        //    Car_Information = Car_Information + this.Type.PadRight(15, ' ') + "|";
        //    Car_Information = Car_Information + this.ModelYear.ToString().PadRight(4, ' ') + "|";
        //    Car_Information = Car_Information + this.Colour.PadRight(10, ' ') + "|";
        //    Car_Information = Car_Information + this.Cost.ToString().PadRight(5, ' ') + "|";

        //    return Car_Information;
        //}
    }
}
