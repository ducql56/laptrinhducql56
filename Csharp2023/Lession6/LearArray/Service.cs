using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearArray
{
    public  static class Service
    {
        public static void DemoArray()
        {
            int[] arrNumber = new int[5];
            arrNumber[0] = 6;
            arrNumber[1] = 8;
            arrNumber[2] = 9;
            arrNumber[3] = 3;
            arrNumber[4] = 5;
            string[] fruits = new string[5] { "tao", "le", "xoai", "cam", "na" };
            string[] word = { "pen", "house", "mouse" };
            Console.WriteLine(word[1]);
            int lent = word.Length;


            
        }
        public static void DemoArray1()
        {
            string[] fruits = new string[5] { "tao", "le", "xoai", "cam", "na" };
            int lent = fruits.Length;
            try
            {
                for (int i = 0; i <= (lent); i++)
                {
                    Console.WriteLine(fruits[i]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine((ex.Message));
            }
            Console.ReadKey();
        }
        public static void DemoArray2()
        {
            string[] fruitsViet = new string[5] { "tao", "chuoi", "xoai", "cam", "mit",};
            string[] fruitsEng = new string[6] { "Apple", "Banana", "Mango", "Orange", "Jack fruit" ,"Watter Lemon"};


        }

        public static void EngVietDic(string keyword)
        {
            string[] arrEng = new string[5] { "chair", "table", "fruit", "tree", "paint" };
            string[] arrVie = new string[5] { "ghe", "ban", "trai cay", "cay", "son" };
            for (int i = 0; i < arrEng.Length; i++)
            {
                if (arrEng[i].Equals(keyword,StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Tu co nghia tieng viet la: {arrVie[i]}");
                    return;
                }

            }
            Console.WriteLine($"Khong tim thay ket qua");

        }


    }
}
