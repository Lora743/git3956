// Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [12345] -> 583
// [6736] -> 3621


int[] GetRandomArray(int Length, int leftRange, int righRange)
{
    int[] array = new int[Length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, righRange + 1);
    }

    return array;
}
// true - findNumbe найден в array
// false - findNumbe НЕ найден в array
bool IsElementInArray(int[] array, int findNumber)
{
    bool result = false;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == findNumber)
        {
            result = true;
            break;
        }
    }
    return result;
}


int Length0fArray = 12;
int leftBorder = -9;
int righBorder = 9;
int finding = 5;

int[] myArray = GetRandomArray(Length0fArray, leftBorder, righBorder);

Console.WriteLine($"[{string.Join(",", myArray)}]");
bool res = IsElementInArray(myArray, finding);
Console.WriteLine(res);
