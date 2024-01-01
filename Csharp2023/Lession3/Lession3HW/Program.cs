int a;
Console.WriteLine("Input number a:");
a = int.Parse(Console.ReadLine());
if (a < 0)
{
    Console.WriteLine($"{0} is negative integers ", a);
}
if (a == 0)
{
    Console.WriteLine($"{0} is rezo", a);
}
if (a > 0)
{
    Console.WriteLine($"{0} is positive integer", a);
}
Console.ReadKey();
