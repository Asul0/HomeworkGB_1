using static System.Console;
Clear();
Write("Введите число а ");
int a = Convert.ToInt32(ReadLine());
Write("Введите число b ");
int b = Convert.ToInt32(ReadLine());

if (a > b)
{
    WriteLine($"max = {a}");
    WriteLine($"min = {b}");
}
else
{
    WriteLine($"max = {b}");
    WriteLine($"min = {a}");
}

