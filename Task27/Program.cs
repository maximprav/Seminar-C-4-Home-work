// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());

if (N>0)
{
    Console.WriteLine($"Сумма цифр числа {N} равна {GetSumNums(N)}");
}
else
{
    Console.WriteLine("Задано неверное число");
}


int GetSumNums(int number)
{
    int sum = 0;
    int num = number;
    while (num >= 1)
    {
        int result = num%10;
        sum = sum + result;
        num = num/10;
    }
    return sum;
    Console.WriteLine(sum);
}