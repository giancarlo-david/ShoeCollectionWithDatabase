using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeCollectionWithDatabase
{
    public class Shoe
    {
        private string brand;
        private string model;
        private string colorway;
        private decimal size;

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public string Colorway { get => colorway; set => colorway = value; }
        public decimal Size { get => size; set => size = value; }

        public override string ToString()
        {
            return brand + " " + model + " " + colorway;
        }
    }
}
