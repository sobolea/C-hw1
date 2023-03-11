// домашнее задание к семинару 1

/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3  */

int a, b, min, max;
Console.Write($"Введите а: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите b: ");
int.TryParse(Console.ReadLine()!, out b);

if (a > b)
{
    max = a;
    min = b;
}
else
{
    min = a;
    max = b;
}

Console.Write($"max = {max}, min = {min}");