﻿// Задача 10: 
// Напишите программу, которая:
// 1. Принимает на вход трёхзначное число;
// 2. На выходе показывает вторую цифру этого числа.

// // 456 --> 5
// // 782 --> 8
// // 918 --> 1
Console.Clear();
void TaskText()
{
    System.Console.WriteLine("Задача 10:\nНапишите программу, которая: \n1. Принимает на входе трёхзначное число; \n2. На выходе показывает вторую цифру этого числа.\nПример:\n456 --> 5 \n782 --> 8 \n918 --> 1");
}
TaskText();
// -------Task 10 Homework 2-------------------------------------
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    Console.WriteLine(number /10%10);
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число. Повторите попытку...");
}