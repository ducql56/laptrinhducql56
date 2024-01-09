using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuhocfunstion
{
    internal class hoc
    {
        public double sum(double aa,double bb,double cc)
        {
            double sum = aa + bb + cc;
            return sum;
        } 
        public double Delta(double a,double b, ref double c)
        {
            double Delta = (b * b) - (4 * a * c);
            if (Delta < 0)
            {
                Console.WriteLine(" phuong trinh vo nghiem");
            }
            if (Delta == 0)
            {
                Console.WriteLine(" phuong trinh co nghiem kep");
                double x = (-b) / (2 * a);
                Console.WriteLine(" nghiem pt la:{0}:"+x);
            }
            if (Delta > 0)
            {
                Console.WriteLine(" phuong trinh co 2  nghiem");
                double x1 = ((-b) - Math.Sqrt(Delta)) / (4 * a);
                double x2 = ((-b) + Math.Sqrt(Delta)) / (4 * a);
                Console.WriteLine($"  x1:{x1} x2:{x2}");

            }
            return Delta;
        }
    }
}
