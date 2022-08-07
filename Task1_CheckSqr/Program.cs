// Зфдфча 1. "Является ли первое число квадратом второго"
using static System.Console;
Write("Введите первое число ");
int namberA = int.Parse(ReadLine());
Write("Введите второе число ");
int namberB = int.Parse(ReadLine());
if(namberA==namberB*namberB)
{
    WriteLine("Является");
}
else
{
    WriteLine("Не является");
}
