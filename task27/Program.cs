// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = number;
int sum = 0;

if (number < 0)
{ Console.WriteLine($"Число должно быть больше 0"); }
else
{
    while (count > 0)
    {
        sum = sum + count % 10;
        count = count / 10;
    }
    Console.WriteLine($"{number} -> {sum}");
};
