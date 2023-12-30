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
    }
}
