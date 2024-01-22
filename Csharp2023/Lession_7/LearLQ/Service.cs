using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearLQ
{
    public class Service
    {
        public List<int> _lstNumber = new List<int>() { 1, 2, 4, 5, 8, 90, 100, 67 };

        public void Demo()
        {
            // lay cho le
            var firstOddnumber = _lstNumber.FirstOrDefault(s => s % 2 == 0);
            var lastOddnumber = _lstNumber.LastOrDefault (s => s % 2 == 0);
            // lay 3 phan tu tu danh sach
            var ThreeElenm = _lstNumber.Take(3).ToList();
            var ThreeElenm2 = _lstNumber.Skip(3).Take(3).ToList();


        }
    }
}
