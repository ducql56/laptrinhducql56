using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace LearnOOP
{
    public class Vehicle
    {
        public string Name;
        
        public int price
        {
            get { return price; }
            set
            {
                if (value < 100 || value > 1000)
                {
                    throw new Exception("price is valid");
                }
                else
                {
                    price = value;
                }
            }
        }
        public string Info
        {
            get
            {
                return $"name: {Name}, price: {price}";
            }
        }


    }


}
