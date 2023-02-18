// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] myArray;
myArray = new int[8];
int index = 0;
int size = myArray.Length;

while (index<size)
{
    myArray[index] = new Random().Next(0, 100);
    Console.Write(myArray[index] + " ");
    index++;
}

//array[i] = new Random().Next(0, 2);
