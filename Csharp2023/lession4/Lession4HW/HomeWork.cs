using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4HW
{
    public class HomeWork
    {
        public string Gettriangle(int edgeA, int edgeB, int edgeC)
        {

            string Messege = string.Empty;
            if ((edgeA + edgeB < edgeC) || (edgeC + edgeB < edgeA) || (edgeC + edgeA < edgeB))
            {
                Messege = ("This is not Triangle");

            }
            else if ((edgeA == edgeB) || (edgeB == edgeC) || (edgeC == edgeA))
            {
                Messege = ("This is  isosceles triangle");

            }
            else if ((Math.Pow(edgeA, 2) + Math.Pow(edgeB, 2) == Math.Pow(edgeC, 2)) || (Math.Pow(edgeC, 2) + Math.Pow(edgeB, 2) == Math.Pow(edgeA, 2)) || (Math.Pow(edgeC, 2) + Math.Pow(edgeA, 2) == Math.Pow(edgeB, 2)))
            {
                Messege = ("This is right triangle");
            }
            else
                Messege = "This is regular triangle";
            return Messege;
        }
    }
}
