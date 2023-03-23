//Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7, min = 5
//a = 2 b = 10 -> max = 10, min = 2
//c = -9 d = -3 -> max = -3, min = -9

int a = 5;
int b = 7;

int max = a;
int min = b;

if (a > max) max = a;
if (b > max) max = b;
if (a < min) min = a;
if (b < min) min = b;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);

int c = 2;
int d = 10;

int max1 = c;
int min1 = d;

if (c > max1) max1 = c;
if (d > max1) max1 = d;
if (c < min1) min1 = c;
if (d < min1) min1 = d;

Console.Write("max1 = ");
Console.WriteLine(max1);
Console.Write("min1 = ");
Console.WriteLine(min1);

int e = -9;
int f = -3;

int max2 = e;
int min2 = f;

if (e > max2) max2 = e;
if (f > max2) max2 = f;
if (e < min2) min2 = e;
if (f < min2) min2 = f;

Console.Write("max2 = ");
Console.WriteLine(max2);
Console.Write("min2 = ");
Console.WriteLine(min2);
