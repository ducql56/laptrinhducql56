using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearCommon
{
    public class Service
    {
        public static void Demo()
        {
            string str = "hello";
            int lenght = str.Length;
            string str2 = "World";
            string Result = string.Concat(str, str2);
            string upscale = str.ToUpper();
            string ccgg = str.ToLower();
            string str6 = "Hello World";
            string substr = str6.Substring(6);

            string str9 = "aple,banana,orange";
            string[] st10 = str9.Split(',');
            string str11 = "Hello Word";
            string replv = str11.Replace("World", "university");
            string str13 = " Hello  Word   ";
            string strimd = str13.Trim();
            string str14 = "Hello Word";
            int firstindex = str14.IndexOf("o");
            int lastindex = str14.LastIndexOf("o");




        }
        public static void Demo2()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("hello");
            sb.Append("world");
            sb.Insert(5, "betyfull");
            sb.Remove(6, 10);
            StringBuilder sb2 = new StringBuilder("hellllo worlddd");
            sb.Replace("hellllo", "vietnam");




        }
        public static void DemeDatetime()
        {
            var today = DateTime.Today;
            
            DateTime sepefics = new DateTime(2022, 1, 1);
            DateTime futudate = DateTime.Now.AddDays(-8);
            DateTime earldate = new DateTime(2022, 1, 1);
            DateTime laterldate = new DateTime(2022, 1, 10);
            TimeSpan Difirenrt = laterldate.Subtract(earldate);
            string formatdate = today.ToString("dd/mm/yyyy");
            string f = "gg";

        }
        public static void DemoMath()
        {
            int isloluate = Math.Abs(-8);
            
            double power = Math.Pow(2, 3);
            int maxValue = Math.Max(10, 20);
            int minValue = Math.Min (10, 20);
            double piValue = Math.PI;
            double Evalue = Math.E;
            double Sinvale=Math.Sin(double.Pi/
        }
    }
}
