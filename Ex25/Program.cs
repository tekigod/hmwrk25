// Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.
// Например:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

static int pow(int num1, int num2)
{
if (num2 == 1)
return num1;
else
if (num2 % 2 == 0)
return pow(num1, num2 / 2) * pow(num1, num2 / 2);
else
return pow(num1, (num2-1) / 2) * pow(num1, (num2-1) / 2)*num1;
}
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Первое число в натуральной степени второго = {0}", pow(num1, num2));
Console.ReadKey();
