using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearIfElse
{
    public class sevice
    {
        public string EvaluaStudent(double score)
        {
            string result = "";
            if (score == 5)
            {
                result = "average";

            }
            if (score <5)
            {
                result = "bad";

            }


            return result;
        }
        public bool CheckLunarYear(int year)
        {
            if (year < 0)
            {
                return false;
            }

            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (year % 4 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public bool CheckLunarYear1(int year)
        {
            if ((year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
            {
                return true;
            }
            return false;
        }

        public bool CheckLunarYear2(int year)
        {
            return (year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);
        }

        public bool CheckLunarYear3(int year)
            => (year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);
    }

}
