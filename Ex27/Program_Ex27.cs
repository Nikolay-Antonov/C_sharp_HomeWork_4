// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{

    int counter = Convert.ToString(number).Length;
    
    int result = 0;

    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

int sum = SumNumber(number);
Console.WriteLine("Сумма цифр в числе: " + sum);
