// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

int number = Random.Shared.Next(10, 1000);
Console.WriteLine(number);
int lastDigit = number % 10;
int firstDigit = number / 100;
int res = firstDigit*10 + lastDigit;
//if(firstDigit > lastDigit)
//{
//    Console.WriteLine($"max {firstDigit}, min {lastDigit}");
//}
//else{
//    Console.WriteLine($"max {firstDigit}, min {lastDigit}");
//}

Console.WriteLine(res);
