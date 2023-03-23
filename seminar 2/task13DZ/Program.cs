// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (номер цифры считается от левого края)
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Input number from 100:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 999) 
{
    Console.WriteLine("Error");
}
else 
{
    while (number > 999) 
    {
        number = number / 10;
    }
    Console.WriteLine(number % 10);
}
    
