using static System.Console;
// Задача 0
Clear();
Write("Введите число: ");
int namber=int.Parse(ReadLine());
int sqr=namber*namber;
int sqr1=Convert.ToInt32(Math.Pow(namber,2));
WriteLine($"Квадрат числа {namber} = {sqr}");
WriteLine($"Квадрат числа {namber} = {sqr1}");