//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int a = 2;
int b = 3;
int c = 7;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);

int d = 44;
int e = 5;
int f = 78;

int max1 = d;

if (d > max1) max1 = d;
if (e > max1) max1 = e;
if (f > max1) max1 = f;

Console.Write("max1 = ");
Console.WriteLine(max1);

int g = 22;
int h = 3;
int j = 9;

int max2 = g;

if (g > max2) max2 = g;
if (h > max2) max2 = h;
if (j > max2) max2 = j;

Console.Write("max2 = ");
Console.WriteLine(max2);
