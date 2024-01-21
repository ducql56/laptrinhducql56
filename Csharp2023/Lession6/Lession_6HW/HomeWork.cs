using System;
using System.Collections.Generic;
using System.Globalization;
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
            int totalList = 0;
            foreach (int i in listNumber)
            { 
                Console.WriteLine(i);
                totalList += i;
                
            }

            var avgList = totalList / (listNumber.Count);
            Console.WriteLine($" Total list :{totalList}, Avglist {avgList}");
            Console.ReadKey();
        }
        public  static void DemoList2()
        {
            List<int> listNumber = new List<int>() { 1, 2, 4, 5, 9, 100, 200, 50, 279, 78,170,99 };
            List<int> oddNumberList = new List<int>();
            List<int> evenNumberList = new List<int>();
            List<int> primeList = new List<int>();
            int Diviso = 0;

           oddNumberList = listNumber.Where(k => k % 2 == 0).ToList();
           evenNumberList = listNumber.Where(k => k % 2 != 0).ToList();
            var totalOddList = oddNumberList.Sum();
            var totalEvenList = evenNumberList.Sum();
            foreach( int i in listNumber)
            {
                for (int j = 1; j < listNumber.Max(); j++)
                {
                    if (i % j == 0) 
                    {
                        Diviso++;
                    }
                    
                }
                if(Diviso == 2)
                {
                    primeList.Add(i);
                }
            }
            var totalPrice = primeList.Sum();

            Console.WriteLine($" Total Oddnumber: {totalOddList}, Total evenNumber:{evenNumberList}");
            Console.WriteLine($" total PriceList :  {totalPrice}");
            Console.ReadKey();
            return;
        }
    }

}
