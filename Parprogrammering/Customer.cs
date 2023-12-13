using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering4
{
    internal class Customer
    {
        public string Name;
        public int Age;
        public int Money;

        public Customer(string name, int age, int money)
        {
            Name = name;
            Age = age;
            Money = money;

            bool BuyCar(int Price)
            {
                if (Price <= Money)
                {
                    Money -= Price;
                    return true;
                }
                else { return false; }
            }
        }
    }
}