using System;
using System.Linq;
Console.Clear();
Console.Write("Введите количество чисел M: ");
int size = int.Parse(Console.ReadLine());
int[] N = new int[size].Select(x=>new Random().Next(-10,10)).ToArray();
Console.WriteLine(String.Join(" ", N ));
int M = N.Where(x=>x>0).Count();
Console.Write($"Сколько чисел больше 0? -> {M} " ); 