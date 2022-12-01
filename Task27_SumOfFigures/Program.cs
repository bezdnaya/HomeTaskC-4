// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число N =");
string strN = Console.ReadLine();
int N = Convert.ToInt32(strN);
int Sum = 0;
for (int i = 0; i < strN.Length; i++)
{
    Sum = Sum + N%10;
    N = N/10;
}
Console.WriteLine ($"Cумма всех цифр в этом числе {Sum}");