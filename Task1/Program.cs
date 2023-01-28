// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Mul(int numA, int numB)
{
    int mul = 1;

    for (int i = 0; i < numB; i++)
    {
        mul = mul * numA;
    }

    return mul;
}

System.Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine($"Число {A} в степени {B} = {Mul(A,B)}");