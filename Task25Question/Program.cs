// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число A:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int B = int.Parse(Console.ReadLine());
int finalResult = Mult(A, B);
Console.WriteLine(finalResult);

int Mult(int num1, int num2)
{
    int count = 1;
    int result = num1;
    while (count < num2)
    {
        result = result * num1;
        count++;
    }
    return count;
    Console.Write($"Ответ {result}");
}