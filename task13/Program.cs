// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или
// сообщает, что третьей цифры нет.Через строку решать


Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());

int count = 0;
int counter = num;

while (counter != 0)
{
    count++;
    counter = counter / 10;
}

if (count < 3)
{
    Console.WriteLine("This number was not 3 digit ");
}
else {    
    num = (num / Convert.ToInt32(Math.Pow(10, count - 3))) % 10;
    Console.WriteLine(num);    
}



