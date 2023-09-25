
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number>100 && number<=1000)
{
    int secondNumber=number/10%10;
    Console.WriteLine($"Вторая цифра ->{secondNumber}");
}
else
{
    Console.WriteLine("Введенно неправильное значение");
}