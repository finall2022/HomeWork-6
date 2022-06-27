/*  Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */
//Функция нахождения точки x
double findX(int b1Temp, int k1Temp, int b2Temp, int k2Temp)
{
    double b1b2 = b1Temp - b2Temp;
    double k1k2 = k2Temp - k1Temp;
    double xTemp = b1b2 / k1k2;
    return xTemp;
}

//Функция нахождения точки y
double findY(int b2Temp, int k2Temp, double xTemp)
{
    double yTemp = k2Temp * xTemp + b2Temp;
    return yTemp;
}

Console.WriteLine("Введите координаты точек двух прямых");
Console.Write("b1 = ");
string ib1 = Console.ReadLine();
int b1 = int.Parse(ib1);
Console.Write("k1 = ");
string ik1 = Console.ReadLine();
int k1 = int.Parse(ik1);
Console.Write("b2 = ");
string ib2 = Console.ReadLine();
int b2 = int.Parse(ib2);
Console.Write("k2 = ");
string ik2 = Console.ReadLine();
int k2 = int.Parse(ik2);

double x = findX(b1, k1, b2, k2);
double y = findY(b2, k2, x);

Console.Write($"Координаты точки пересечения прямых ({x:f2};{y:f2})");