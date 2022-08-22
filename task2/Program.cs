// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
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
        answer[i] = rnd.Next(0, 100);
    }
    return answer;
}

int SumElements(int[] a)
{
    
    int Sum = 0;
    for (int i = 1; i < a.Length; i = i + 2)
    {
            
        Sum = Sum + a[i];
    
    }
    return Sum;
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
System.Console.WriteLine(SumElements(array1));

System.Console.WriteLine();

