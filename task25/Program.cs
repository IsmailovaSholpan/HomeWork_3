// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень числа: ");
int step = Convert.ToInt32(Console.ReadLine());

int count = 1;
int pow = 1;
if (step <= 0)
{
    Console.WriteLine("Степень числа должна быть выше 0");
}
else
{
    while (count <= step)
    {
        
        pow = pow * number;
        count = count + 1;
    }
Console.WriteLine($"{number}, {step} -> {pow}");}