﻿// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

Console.WriteLine ("Введите первое число A");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите первое число B");
int numberB = Convert.ToInt32(Console.ReadLine());

int find(int numberA, int numberB)
{
   int result = 1;
   for(int i=1; i <= numberB; i++)
{
   result = result * numberA;
}
return result;
}
int findNumber = find(numberA, numberB);
Console.WriteLine(findNumber);

