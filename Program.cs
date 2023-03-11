// домашнее задание к семинару 1

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

int a, b, c, max;
Console.Write($"Введите а: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите b: ");
int.TryParse(Console.ReadLine()!, out b);
Console.Write($"Введите c: ");
int.TryParse(Console.ReadLine()!, out c);

if (a > b)
{
    if (a > c)
    {
        max = a;
    }
    else
    {
        max = c;
    }
}
else
{
    if (b > c)
    {
        max = b;
    }
    else
    {
        max = c;
    }
}

Console.Write($"max = {max}");