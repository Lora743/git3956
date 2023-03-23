//  Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите число2");

//int num2 = Convert.ToInt32(Console.ReadLine());
//int res = num1 % num2;

if(number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Не кратно");
}
