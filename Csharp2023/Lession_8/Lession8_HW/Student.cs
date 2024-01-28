using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace Lession8_HW
{
     public  class Student
    {
        public Student()
        {
            string name;
            int Age;
            double score;
        }
        
        public static void InputStudent()

        { 
           
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine(" Input your name: ");
                 string name = Console.ReadLine();
                Console.WriteLine(" input the Age: ");
                int Age;
                bool checkAge = int.TryParse(Console.ReadLine(), out Age);
                double score;
                while (!checkAge)
                {
                    Console.WriteLine(" Reinput your Age:");
                    checkAge = int.TryParse(Console.ReadLine(), out Age);
                }
                bool checkScore = double.TryParse(Console.ReadLine(), out score);
                while (!checkScore)
                {
                    if (score < 0 && score > 10)
                    {
                        Console.WriteLine(" Reinput the score :");
                        checkScore = double.TryParse(Console.ReadLine(), out score);

                    }
                    Console.WriteLine(" Reinput the score :");
                    checkScore = double.TryParse(Console.ReadLine(), out score);

                }
                Console.WriteLine($" name:{name},age :{Age}, score {score}");
                Console.WriteLine("Do you wanto input y/n:");
                string value = Console.ReadLine();
                if (value == "y")
                {
                    isContinue = true;
                }
                else
                {
                    isContinue = false;
                }
                return;

        }  }
     }
}
