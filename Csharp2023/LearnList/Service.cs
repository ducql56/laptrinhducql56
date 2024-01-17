using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnList
{
    public static class Service
    {
       public static void DemoList()
        {
            List<int> lstNumber = new List<int>();
            lstNumber.Add(6);
            lstNumber.Add(9);
            lstNumber.Add(34);
            lstNumber.Add(7);
            lstNumber.Remove(9);
            Console.ReadKey();
            List<string> students = new List<string>() { "nam", "lan", "tuab" };
            students[0] = "nam";
            string std1 = students[^1];
            string std2 = students[students.Count - 1];
            Console.ReadKey();
        }
        public static void EngVietDic(string Keyword)
        {
            List<string> fruits = new List<string>() { "chair", "table", "fruit", "tree", "paint" };
            List<string>hoaQua = new List<string>() { "ghe", "ban", "trai cay", "cay", "son" };
           for(int i=0;i<fruits.Count; i++)
            {
                if (fruits[i].Equals(Keyword, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($" tu can nhap:{hoaQua[i]}");
                    return;
                }
                else
                    Console.WriteLine("ban da nhap sai");
            }
            Console.ReadKey();
        }
            
            

        
    }
}
