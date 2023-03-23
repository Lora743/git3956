// Задайте  массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отриц. и полож. элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
//сумма полож. чисел равна 29, сумма отр. равна -20.

int[] GetRandomArray()
{
    int Length = 12;
    int leftRange = -9;
    int righRange = 9;

    int[] array = new int[Length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, righRange + 1);
    }

    return array;
}

(int, int) SumPositiveAndNegativeElements(int[] array)
{
    int SumPositive = 0;
    int SumNegative = 0;

    for(int i =0; i < array.Length; i++)
    {
        if(array[i] > 0) // если наш элемент полож.
        {
            SumPositive = SumPositive + array[i];
            //sumPositive += array[i];
        }
        else if(array[i] < 0)
        {
            SumNegative = SumNegative + array[i];
        }
    }

    return (SumPositive, SumNegative);
}

int[] myArray = GetRandomArray();
(int SumPositive, int SumNegative) = SumPositiveAndNegativeElements(myArray);
Console.WriteLine($"Сумма пол. элементов = {SumPositive}");
Console.WriteLine($"Сумма отриц. элементов = {SumNegative}");

