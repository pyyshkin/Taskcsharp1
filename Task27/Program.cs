// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumAllNumber(int number)
{
    int result=0;
    while (number>0)
    {
        result+=number%10;
        number=number/10;
    }
    return result;
}

Console.WriteLine("Ввелите число:");
int number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел цифры {number}-> {SumAllNumber(number)}");
