//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using LearnFunstion;

Sevice sevice = new Sevice();
double result = sevice.Sum(7, 9);


double S = sevice.dienTich(9,8);
Double dienTichTron = sevice.CircleArea(8);

double circleArea1 = 5;
sevice.CalCircleArea1(6,ref circleArea1);
//
double circleArea2 = 5;
sevice.CalCircleArea2(6, circleArea2);

//double Recperimiter=0;
//double RecArea = sevice.CacircleArea3(7, 9, out Recperimiter);
//double RecArea1 = sevice.CacircleArea3(7, 9, out _ );

//const string updateMessege = " update Product Success";
//const string deleteMessege = " delete Product Success";
string iphone= "iPhone14";
Console.WriteLine(string.Format(Commom_Constant.UpdateMessege,iphone));
Console.WriteLine(string.Format(Commom_Constant.DeleteMessege,iphone));




Console.ReadKey();


