using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearLoop
{
    public static class service// ham su dung cho moi ung dung, doi tuong ko huy
    {
        public static void LearForLoop()
        {
            for (int  i=1;  i<=13 ; i++)

            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
        }
        public static void LearForloop2()
        {
            for(int i = 1; i <= 100; i++)
            {
                if((i%3==0)&& (i % 2 != 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
        //public static void LearWhileLoop()
        //{
        //    int i = 1;
        //    while (i < 10)
        //    {
        //        Console.WriteLine(i);
        //        i++;
        //    }
        //}
        //public static void InputName()
        //{
        //    string name;
        //    string Adress;

        //    Console.WriteLine("Input the Name:");
        //    name = Console.ReadLine();
        //    Console.WriteLine("Input the Adress:");
        //    Adress = Console.ReadLine();
        //    Console.WriteLine(" Reinput?");
        //    string y = string.Empty;
        //    while(y)
        //    { 
        //        Console.WriteLine(" name: "+name);
        //        Console.WriteLine(" Adress: " + Adress);
        //        name = Console.ReadLine();
        //        Adress = Console.ReadLine();
        //    }
        //}
        public static void Inputuser()
        {
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("Input your Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Input your adress:");
                string adress = Console.ReadLine();
                Console.WriteLine("Input your Age");
                int Age;
       bool checkAge   =int.TryParse(Console.ReadLine(), out Age);
                while (!checkAge)
                {
                    Console.WriteLine(" Reinput your Age:");
                 checkAge=       int.TryParse(Console.ReadLine(), out Age);
                }
                Console.WriteLine($" name:{name} ,adress:{adress} ,Age {Age}");
                Console.WriteLine("Do you want to y/n");
                string value = Console.ReadLine();
                if(value == "y")
                {
                    isContinue = true;
                }
                else
                {
                    isContinue = false;
                }

            }
        }
        public static void Score()
        {
            double scoreMath, scoreLecture, scoreEng;
         
            Console.WriteLine("Input your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Input the Score Math:");
            bool checkScoremath = double.TryParse(Console.ReadLine(), out scoreMath);
            while (!checkScoremath)
            {
                if (scoreMath < 0 && scoreMath > 10)
                    {
                    Console.WriteLine(" Reinput the score Math:");
                    checkScoremath = double.TryParse(Console.ReadLine(), out scoreMath);

                }
                Console.WriteLine(" Reinput the score Math:");
                checkScoremath= double.TryParse(Console.ReadLine(), out scoreMath);
            }
            Console.WriteLine("Input the Score Lecture:");
            bool checkScoreLecture = double.TryParse(Console.ReadLine(), out scoreLecture);
            while (!checkScoreLecture)

            {
                if (scoreLecture < 0 && scoreLecture > 10)
                {
                    Console.WriteLine(" Reinput the score lectture:");
                    checkScoremath = double.TryParse(Console.ReadLine(), out scoreLecture);

                }
                Console.WriteLine(" Reinput the score lecture:");
                checkScoreLecture = double.TryParse(Console.ReadLine(), out scoreLecture);
            }
            bool checkScoreEng = double.TryParse(Console.ReadLine(), out scoreEng);
            while (!checkScoreEng)
            {
                if (scoreEng < 0 && scoreEng > 10)
                {
                    Console.WriteLine(" Reinput the score englissh:");
                    checkScoremath = double.TryParse(Console.ReadLine(), out scoreEng);

                }
                Console.WriteLine(" Reinput the score English:");
                checkScoreEng = double.TryParse(Console.ReadLine(), out scoreEng);
            }
            Console.WriteLine($" name {name},ScoreMath  {scoreMath},ScoreLecture {scoreLecture},ScoreEng {scoreEng}");
        }
        public static void InputStudent()
        {
            Console.WriteLine("input the name");
            string name = Console.ReadLine();

            Console.WriteLine("Input your math score");
            ValidateScore(out double mathScore);

            Console.WriteLine("Input your literature score");
            ValidateScore(out double literatureScore);

            Console.WriteLine("Input your english score");
            ValidateScore(out double englishScore);

            Console.WriteLine($"Name: {name}, math: {mathScore}, literature: {literatureScore}, english: {englishScore} ");

        }// don't repeat yourselt(dry)

        public static void ValidateScore(out double score)
        {
            bool check =
                double.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 10;

            while (!check)
            {
                Console.WriteLine("score must be between 0 - 10");
                check = double.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 10;
            }
        }


    }
}
