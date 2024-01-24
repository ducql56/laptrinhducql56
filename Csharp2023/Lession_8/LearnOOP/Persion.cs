using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP
{
    public  class Persion
    {
        public Persion()
        {
            template = "studenm name:{0},Student Age {1}";
        }
        public Persion(string name1, int age1,string Adress)
        {
            name1 = Name;
            age1 = Age;
            Adress = address;
            
        }
        public string Name;//data menber
        public int Age;//data menber
        private string address;// ko acsses duoc doi tuong ben ngoa
        private readonly string template = " Studenr Name: {0},student Age :{1}";
        private double score;
        public double Score
        {
            get { return score; }

            set {
                if (value < 0 &&value > 50)
                {
                    throw new Exception("score in valid");
                }
                else
                {

                    score = value * 2;
                }
            }
        }

        public double Score2 { get; set; }
        public string Info
        {
            get
            {
                return $"name: {Name}, age :{Age}, Adress: {address},score:{score}";
}
        }
        public string Info1=>$"name :{Name},age :{Age}, Adress: {address},score:{score}";

        public void GetInfo()// menthod
        {
            Console.WriteLine(string.Format(template, Name, Age));
        }
    }
}
