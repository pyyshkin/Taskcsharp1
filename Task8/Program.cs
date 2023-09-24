Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

for (int index = 1; index <= number; index++)
{
    if (index % 2 == 0)
    {
        Console.WriteLine($"{index}");
    }
}
