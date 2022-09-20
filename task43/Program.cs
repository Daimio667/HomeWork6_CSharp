// Task 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Enter coordinate b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter coordinate k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x=0;
double y=0;
if (b1==b2 & k1==k2) Console.WriteLine("Direct match");
else if (k1==k2) Console.WriteLine("The lines are parallel to each other");
else 
{
    x =(b2-b1)/(k1-k2);
    y =k1*x+b1;
    Console.WriteLine("Intersection point : "+" ("+ x+" ;"+y+ ")");
}