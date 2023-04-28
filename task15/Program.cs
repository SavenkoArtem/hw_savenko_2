// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 | num == 7)
{
    Console.WriteLine("Yes");
}
else if (num < 1 | num > 7)
{
    Console.WriteLine("Enter number from 1 to 7");
}
else
{
    Console.WriteLine("No");
}
