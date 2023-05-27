/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int i = 1;
bool not = true;

Console.WriteLine("Впишыте число:");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Чётное число от 1 до " + numberA);
while (i <= numberA)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("Нечётное число");
}

