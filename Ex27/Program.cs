// Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// Например: 
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;  
  public class Zadanie27  
   {  
     public static void Main(string[] args)  
      {  
       int  n,sum=0,m;         
       Console.Write("Введите число: ");      
       n= int.Parse(Console.ReadLine());     
       while(n>0)      
       {      
        m = n % 10;      
        sum = sum + m;      
        n = n / 10;      
       }      
       Console.Write("Сумма цифр заданного числа = "+sum);       
     }  
  }  