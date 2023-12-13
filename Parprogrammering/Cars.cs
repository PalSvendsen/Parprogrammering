using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering4
{
    internal class Cars
    {
        public string Brand;
        public int ModelYear;
        public string Licenseplate;
        public int Kilomters;
        public int Price;
        public Cars(string brand, int modelyear, string licenseplate, int kilomters, int price)
        {
            Brand = brand;
            ModelYear = modelyear;
            Licenseplate = licenseplate;
            Kilomters = kilomters;
            Price = price;
        }
    }
}