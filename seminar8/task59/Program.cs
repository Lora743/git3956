// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Наименьший элемент - 1, на выходе получим
//следующий массив:
//9 2 3
//4 2 4
//2 6 7


int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int righBorder = 10)
{
    int[,] matrix = new int[rows, columns];
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, righBorder + 1);
        }
    }
    var varriable = new Dictionary<int, int>();
    varriable[2] = 5;
    varriable[1] =5234523;
    varriable[10] = 23563645;

    foreach(var pair in varriable)
    {
        System.Console.WriteLine($"Ключ = {pair.Key}, значение = {pair.Value}");
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
   void PrintRepeats(int[,] matrix)
{
    int[] repeats = new int[10];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            //int index = matrix[i, j];
            repeats[matrix[i, j]]++;
        }
    }
    for (int i =0; i < repeats.Length; i++)
    {
        Console.WriteLine($"{i} повторяеться {repeats[i]} pas");
    }
}     
int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
PrintRepeats(myMatrix);