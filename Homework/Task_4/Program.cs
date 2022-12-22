using static System.Console;
Clear();
Write("Введите число ");
int number = Convert.ToInt32(ReadLine());
int evenNumber = 2;

while(evenNumber <= number)
{
    Write(evenNumber + " ");
    evenNumber = evenNumber + 2;
}