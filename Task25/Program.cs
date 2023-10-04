// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree(int numberA, int numberB)
{
    int degree=1;
    for (int i = 0; i < numberB; i++)
    {
        degree*=numberA;
    }
    return degree;
}

bool ValidateExponent(int numberB)
{
    if (numberB<0)
    {
        Console.WriteLine("Степень меньше нуля");
        return false;
    }
    return true;
}

Console.WriteLine("Введите первое число:");
int numberA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB=Convert.ToInt32(Console.ReadLine());

if (ValidateExponent(numberB))
{
    Console.WriteLine($"Число {numberA} в степени {numberB} равно -> {Degree(numberA, numberB)}");
}