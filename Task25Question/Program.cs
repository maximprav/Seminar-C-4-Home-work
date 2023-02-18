// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число A:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int B = int.Parse(Console.ReadLine());

int Mult(int A, int B)
{
    int count = 1;
    int result = 1;
    while (count <= B)
    {
        result = result * A;
        count++;
    }
    return count;
    Console.Write($"Ответ {result}");
}

int mult = Mult(A, B);
Console.WriteLine(mult);