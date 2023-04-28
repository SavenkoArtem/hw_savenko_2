// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа. Через строку решать нельзя.
Random rnd = new Random();
int num = rnd.Next(100, 1000);
Console.WriteLine($"Random number = {num}");

num = (num / 10) % 10;

Console.WriteLine(num);