//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine($"Введите числа A и В =");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
if (B == 0)
    Console.WriteLine($"Число А в степени {B} = 1");
else 
{
    for (int i = 1; i < B; i++)
    A = A*A;
}
Console.WriteLine($"Число А в степени {B} = {A}");