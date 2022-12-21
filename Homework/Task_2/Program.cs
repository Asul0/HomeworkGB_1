using static System.Console;
Clear();
Write("Введите число а ");
int a = Convert.ToInt32(ReadLine());
Write("Введите число b ");
int b = Convert.ToInt32(ReadLine());
Write("Введите число c ");
int c = Convert.ToInt32(ReadLine());
int max = a;

if (b > a)
{
    max = b;
}
if (c > max)
{
    max = c;
}
WriteLine(max);
