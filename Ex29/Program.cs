// Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.
// Например: 
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] arr = new int[8]; 
int i;  
  
Console.WriteLine("Введите 8 элементов массива:");  
    for(i=0; i<8; i++)  
    {  
	    Console.Write("элемент {0} = ",i);
	    arr[i] = Convert.ToInt32(Console.ReadLine());  		
    }  
  
    Console.Write("Числа: ");  
    for(i=0; i<8; i++)  
    {  
        Console.Write("{0}  ", arr[i]);  
    } 
    Console.Write("\n");	
