// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int ReadNumber(string message);
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int N = ReadNumber("Введите число");
for(int i = 1; i <= N; i++)
{
    Console.WriteLine(i * i + ", ");
}
Console.WriteLine(N * N + ".");

