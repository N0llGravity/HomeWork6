/*// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int count = 0;
Console.WriteLine();
Console.WriteLine("Start entering numbers one by one. When you're done print (stop).");
while(1>0)
{
    string? input = Console.ReadLine();
    if(input == "stop")
        break;
    
    int number = Convert.ToInt32(input);
    if(number > 0)
        count++;
}
Console.WriteLine();
Console.WriteLine($"Count of positives numbes are {count}");
*/

/*//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double[] IntersectionPoint(double k1,double b1, double k2, double b2)
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    double[] coordinatesArray = new double[2];
    coordinatesArray[0] = x;
    coordinatesArray[1] = y;
    return coordinatesArray;
}


Console.WriteLine("input k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2 && b1 == b2)
    Console.WriteLine("lines are coincide");
else if(k1 == k2)
    Console.WriteLine("lines are parallel");
else
{
    double[] answer = IntersectionPoint(k1, b1, k2, b2);
    Console.WriteLine( $"Coordinates of intersection point is ({answer[0]}: {answer[1]})");
}
*/