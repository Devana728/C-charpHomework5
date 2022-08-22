//Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int Prompt(string message)
{
    System.Console.Write(message); //вывести сообщение
    string readValue = Console.ReadLine(); //считывает с консоли строку
    int result = int.Parse(readValue); // преобразует строку в целое число
    return result; //возвращает результат
}

// генерация массива
int[] CreatArray(int length)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(100, 999);
    }
    return answer;
}

int CountElements(int[] a)
{
    
    int Count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i]%2 == 0)
        {
            
            Count++;
        }
    }
    return Count;
}

//вывод массива в строку
void printArray(int[] answer)
{
    int count = 0;
    while (count < answer.Length)
    {
        System.Console.Write($"{answer[count]}\t");
        count++;
    }
    System.Console.WriteLine();
}

int[] array1 = CreatArray(10);
printArray(array1);
System.Console.WriteLine(CountElements(array1));

System.Console.WriteLine();
