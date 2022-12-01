int[] array = new int[8];
for (int index = 0; index < 8; index++)
{
    array[index] = new Random().Next(0, 100);
    Console.Write($"{array[index]} ");
}
