/*  Задача 1: Пользователь вводит с клавиатуры M чисел. 
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
 */

Console.Write("Сколько чисел вы хотите ввести? ");
string iLenght = Console.ReadLine();
int lenght = int.Parse(iLenght);
Console.WriteLine("Введите числа");
int[] arrN = new int[lenght];
int index = 0;
int count = 0;
for (index = 0; index < lenght; index++)
{
    string iNum = Console.ReadLine();
    int num = int.Parse(iNum);
    arrN[index] = num;
    if (num > 0)
    {
        count++;
    }
}
Console.Write($"Чисел больше 0 - {count}");