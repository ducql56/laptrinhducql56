using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infratructure
{
    public  abstract  class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Math { get; set; }
        public double Litteratue { get; set; }
     

        public Student(string name, int age, double math, double literature)
        {
            Name = name;
            Age = age;
            Math = math;
            Litteratue = literature;
        }

    public string Getinfo()
        {
            return $"name: {Name}, age :{Age}, Avg: {caculor()}";
        }
        protected abstract double caculor();
       

        public class Englishstudent : Student
        {
            public double English { get; set; }
            public Englishstudent(string name, int age, double math, double literature,double  english)
                : base(name, age, math, literature)
            {
                English = english;
            }
        }
        protected override double caculor()
        {
            return (Math + Litteratue + English * 2) / 4;
        }
      
        protected  override double caculor()
        {
            return (Math + Litteratue);
        }
    }
}
