// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Input day: ");
int day = Convert.ToInt32(Console.ReadLine());
var result = day == 7 ? ("Выходной") : ("Рабочий день");

if (day > 7) 
{
    Console.WriteLine("Error");
}
else 
{
    Console.WriteLine(result);
}
