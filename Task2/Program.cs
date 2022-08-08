// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа:");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());

int max = 1;

if (2 > max)
{
    max = 2;
}

if (3 > max)
{
    max = 3;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + max);