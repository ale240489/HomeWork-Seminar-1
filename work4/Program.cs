/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/


Console.WriteLine("Введите число N");
int num = int.Parse(Console.ReadLine());

if(num >= 1) // Для положительных чисел
{   Console.WriteLine("Четные числа"); 
   for(int i = 1; i <= num; i++)
{
    if(i % 2 == 0)
        Console.Write($"{i} ");
}}


else  // Для отрицательных чисел
{    Console.WriteLine("Четные числа");  
    for(int i = 1; i >= num; i--)
{
    if(i % 2 == 0)
        Console.Write($"{i} ");
}}
