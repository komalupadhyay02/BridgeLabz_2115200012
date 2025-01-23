using System;
class MyProject{
static void Main(String[] Args){
Console.WriteLine("enter the base");
double baseN=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter the exponent");
double exponent=Convert.ToDouble(Console.ReadLine());
double num=Math.Pow(baseN, exponent);
Console.WriteLine($"the number is: {num}");
}
}