/* Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.*/

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Нажмите Enter");
Console.ReadLine();
int value = new Random().Next(100, 999);
Console.WriteLine(value);

int numberTwo = value % 100 / 10;
Console.WriteLine(numberTwo);