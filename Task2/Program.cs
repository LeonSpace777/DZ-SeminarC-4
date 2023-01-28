// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int number)
{
    int sum = 0;

    while (number > 0)
{
    int num = number % 10;
    sum = sum + num;
    number = number / 10;
}
    return sum;
}

System.Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"Сумма цифр числа {number} равна ");

System.Console.WriteLine(Sum(number));