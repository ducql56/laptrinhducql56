using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    public class HW3A
    {
        public void InputNumber()
        {
            Console.WriteLine(" Input Number:");

            try
            {
                string value = Console.ReadLine();
                int number = int.Parse(value);

                if (number == 0)
                {
                    Console.WriteLine(" the  number is 0");
                }
                else if (number > 0)
                {
                    Console.WriteLine(" The number is posstive number");
                }
                else if (number < 0)
                {
                    Console.WriteLine(" the number is");
                }
            }
            catch (Exception ex) {
                //Console.WriteLine(" da co loi xay ra:");
                Console.WriteLine(ex.Message);
            }
        }

        public void InputNumber1()
        {
            Console.WriteLine(" Input Number:");

            
          
             string value = Console.ReadLine();

                
            bool check = int.TryParse(value, out int number);

            if (check == false)
            {
                Console.WriteLine("Number is not correct");
                return;
            }
            if (number == 0)
                {
                    Console.WriteLine(" the  number is 0");
                }
                else if (number > 0)
                {
                    Console.WriteLine(" The number is posstive number");
                }
                else if (number < 0)
                {
                    Console.WriteLine(" the number is");
                }
            
        }
    }
    
}
