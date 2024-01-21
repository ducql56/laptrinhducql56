using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_6HW
{
    public static class HomeWork
    {
       public static void DemoList1()
        {
            List<int> listNumber = new List<int>() { 1, 2, 4, 5, 9, 100, 200, 50, 279, 78 };
            listNumber.Add(200);
            listNumber.Remove(9);
            foreach (int i in listNumber)
            {
                Console.WriteLine(i);
            }
            var totalList = listNumber.Sum();
            var avgList = listNumber.Average();
            Console.WriteLine($" Total list :{totalList}, Avglist {avgList}");
            Console.ReadKey();
        }
        public  static void DemoList2()
        {
            List<int> listNumber = new List<int>() { 1, 2, 4, 5, 9, 100, 200, 50, 279, 78,170,99 };
            List<int> oddNumberList = new List<int>();
            List<int> evenNumberList = new List<int>();

           oddNumberList= listNumber.Where(k => k % 2 == 0).ToList();
           evenNumberList = listNumber.Where(k => k % 2 != 0).ToList();
            var totalOddList = oddNumberList.Sum();
            var totalEvenList = evenNumberList.Sum();
            Console.WriteLine($" Total Oddnumber: {totalOddList}, Total evenNumber:{evenNumberList}");

            Console.ReadKey();
        }
    }

}
