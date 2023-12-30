using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFunstion
{
    public class Sevice
    {
        public double Sum(double number1, double number2)
        {
            double Sum = number1 + number2;
            return Sum;
        }
        public double dienTich(double chieuDai, double chieuRong)
        {
            double dienTich = chieuDai * chieuRong;
            return dienTich;
        }
        public double CircleArea(double rec)
        {
            double CircleArea = rec * 3.14;
            return CircleArea;
        }
        public void CalCircleArea1(double bankinh,ref double Area)
        {
            Area = bankinh * bankinh * 3.14;
        }
        public void CalCircleArea2(double bankinh, double Area2)
        {
            Area2 = bankinh * bankinh * 3.14;
        }
        public double CacircleArea3(double length,double Width, out double perimiter)
        {
            double Area1 = length * Width;
            perimiter = (length + Width) * 2;
            return Area1;
        }
    }
}
