// Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// Например: 
// 452 -> 11
// 82 -> 10
// 9012 -> 12

    public class Ex27
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0, reminder;
           
            while (number > 0)
            {
                reminder = number % 10;
                sum = sum + reminder;
                number = number / 10;
            }
            
            Console.WriteLine($"Сумма цифр заданного числа = {sum}");
            Console.ReadKey();
        }
    }