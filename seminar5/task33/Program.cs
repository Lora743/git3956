// Напишите программу замена элементов массива: полож. элементы замените на соответствующие отриц., и наоборот.
//[-4.-8.8.2] -> [4.8.-8.-2]

int[] GetRandomArray(int Length, int leftRange, int righRange)
{
    int[] array = new int[Length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, righRange + 1);
    }

    return array;
}

void InvertElements(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}

int Length0fArray = 12;
int leftBorder = -9;
int righBorder = 9;

int[] myArray = GetRandomArray(Length0fArray, leftBorder, righBorder);

Console.WriteLine($"[{string.Join(",", myArray)}]");
InvertElements(myArray);

Console.WriteLine($"[{string.Join(",", myArray)}]");
