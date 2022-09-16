// Task 34. Задайте массив заполненный 
//случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//void InputArray(int [] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    array[i] = new Random().Next(100,200);
//}
//int[] n = new int[10];
//InputArray(n);
//Console.WriteLine("["+string.Join(",", n)+"]");
//int res = 0;
//for (int z=0; z<n.Length; z++)
//{
//    if (n[z] % 2 ==0) res++;
//}

//Console.WriteLine(res);

//Task 36. Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//void InputArray(int [] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    array[i] = new Random().Next(100,200);
//}
//int [] array = new int [10];
//InputArray(array);
//Console.WriteLine("["+ string.Join(",", array)+"]");
//void Sumnumbers (int [] array)
//     {
//       int summa = 0;
//       for (int i=0; i<array.Length; i++)
//       {
//        if (array[i]%2!=0)
//        summa=summa+array[i];
//       }
//    Console.WriteLine("Odd numbers sum is "+summa);
//     }

//Sumnumbers(array);

//Task 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void InputArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1,11);
}
int [] array = new int [10];
InputArray(array);
Console.WriteLine("["+ string.Join(",", array)+"]");

    int min = array[0]; 
    for (int i=0; i<array.Length; i++)
        {
            if (array[i] < min)
            min = array[i];
        }
   
     Console.WriteLine("Minimum numbers is "+ min);
int max = array[0]; 
    for (int i=0; i<array.Length; i++)
        {
            if (array[i] > max)
            max = array[i];
        }
    Console.WriteLine("Maximum number is "+ max);
    Console.WriteLine(max-min);
