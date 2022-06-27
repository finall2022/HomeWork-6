/*  Задача 1: Пользователь вводит с клавиатуры M чисел. 
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
 */

Console.WriteLine("Введите несколько чисел, для окончания введите 0");

int i = 0;
int count = 0;
while (i >= 0)
{
    string iNum = Console.ReadLine();
    int num = int.Parse(iNum);
    if (num == 0)
    {
        break;
    }
    if (num > 0)
    {
        count++;
        i++;
    }
}
Console.Write($"Чисел больше 0 - {count}");