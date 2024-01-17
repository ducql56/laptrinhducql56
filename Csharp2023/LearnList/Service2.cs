using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnList
{
    public class Service2

    {
        public List<int> numbers = new List<int>() { 1, 2, 3, 4, 6, 7, 11, 90 };
        public void DemoLinQ()
        {
            List<int> oddNumber = new List<int>();
            //for(int i = 0; i < number.Count; i++)
            //{
            //    if(number[i]%2!=0)
            //    {
            //        oddNumber.Add(number[i]);
            //    }
            //}
            //foreach(int number in numbers)
            //{
            //    if (number % 2 != 0)
            //    {
            //        oddNumber.Add(number);
            //    }
            //}
            oddNumber = numbers.Where(x => x % 2 != 0&&  x % 3== 0).ToList();

            
            
            
            
        }
        public void Arrange()
        {
            var accentDingNUmber = numbers.OrderBy(x => x).ToList();
            var Accentdingnumber = numbers.OrderByDescending(x => x).ToList();

        }

    }
}
