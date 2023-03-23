// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

Console.WriteLine("Введите число");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число2");

int num2 = Convert.ToInt32(Console.ReadLine());
int res = num1 % num2;

if(res != 0)
{
    Console.WriteLine(res);
}
else Console.WriteLine("Второе число кратно первому");

//int lastDigit = number % 10;
//int firstDigit = number / 100;
//int res = firstDigit*10 + lastDigit;
//if(firstDigit > lastDigit)
//{
//    Console.WriteLine($"max {firstDigit}, min {lastDigit}");
//}
//else{
//    Console.WriteLine($"max {firstDigit}, min {lastDigit}");
//}

Console.WriteLine(res);
