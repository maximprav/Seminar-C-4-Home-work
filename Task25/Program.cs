// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число A:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int B = int.Parse(Console.ReadLine());
int result = GetNumbers(A,B);
Console.WriteLine($"Итог {result}");

int GetNumbers(int numberA, int numberB)
{
    int count = 1;
    while(count<numberB)
    {
        int numberC = 
       numberC = numberA*numberA;  
       count++;
    }
    return count;
    }
