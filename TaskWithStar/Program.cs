// найдите х5, при котором х1^5+x2^5+x3^5+x4^5 = x5^5

for (int i = 4; i < 201; i++)
{
    double result = 276 + Math.Pow(i, 5);
    //Console.WriteLine(i);
    //Console.WriteLine(result);
    double x5 = Math.Pow(result, 0.2);
    //Console.WriteLine(x5);
    if (Math.Round(x5, 6)*1000000%1000000 == 0)
        Console.WriteLine($"x1 = 1, x2 = 2, x3 = 3, x4 = {i}, x5 = {Math.Round(x5,4)}");
        Console.WriteLine();
}
