// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


int number = Random.Shared.Next(100, 1000);
Console.WriteLine(number);
int lastDigit = number % 100 - number % 10;
//int firstDigit = number / 100;
//int res = firstDigit*10 + lastDigit;

Console.WriteLine(lastDigit);