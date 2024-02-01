using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Infratructure.Student;

namespace Infratructure
{
    public class School
    {
        internal List<Englishstudent> Students { get; set; }
        public void Addstudent(Englishstudent std)
        {
            Students.Add(std);

        }
        public double SumAgve()
        {
            //double sum = 0;
            //foreach (var item in Students)
            //{
            //    sum += item.Math;
            //}
            return Students.Sum(s => s.Math);
        }
        public class GenericSchool<TStudent> where TStudent : Student
        {
            internal List<TStudent> Students { get; set; }
            public void AddStudent(TStudent std)
            {
                Students.Add(std);
            }
            public double SumAvgScore()
            {
                return Students.Sum(s => s.Math);
            }
        }
                //double sum = 0;
                //foreach (var item in Students)
                //{
                //    sum += item.Math;
                //}
                return Students.Sum(s => s.Math);
            }




        }
}
