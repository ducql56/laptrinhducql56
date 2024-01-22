using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearLInQ
{
    public  class Service
    {

        public List<int> _lstNumber = new List<int>() { 1, 2, 4, 5, 8, 90, 100, 67,7 };

        public void Demo()
        {
            // lay cho le
            var firstOddnumber = _lstNumber.FirstOrDefault(s => s % 2 == 0);
            var lastOddnumber = _lstNumber.LastOrDefault(s => s % 2 == 0);
            // lay 3 phan tu tu danh sach
            var ThreeElenm = _lstNumber.Take(3).ToList();
            var ThreeElenm2 = _lstNumber.Skip(3).Take(3).ToList();
            // lay lisst 3 so le
            var oddNumberThress = _lstNumber.Take(3).Where(x => x % 2 != 0).OrderBy (x => x).Take(3).ToList();
            //select
            var select1 = _lstNumber.Select(x => x * x).ToList();
            var select2 = _lstNumber.Select(x => $"number-{x}").ToList();
            //thong ke
            var distrinst = _lstNumber.Distinct().ToList();
            var Sum = _lstNumber.Sum();
            var Avg = _lstNumber.Average();
            var min = _lstNumber.Min();
            var max = _lstNumber.Max();

            var arrigahte = _lstNumber.Aggregate((s1, s2) => s1 + s2);


        }
    }
}
