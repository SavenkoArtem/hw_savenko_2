// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.
Console.WriteLine("Enter a float number");
decimal num = Convert.ToDecimal(Console.ReadLine()!);

int intPart = (int)((decimal)(num));

decimal floatPart = num - intPart;

int count = 0;
int limit_digit = intPart;

while (limit_digit != 0)
{
    count++;
    limit_digit = limit_digit / 10;
}

if (count > 1)
{
    intPart =  (intPart / Convert.ToInt32(Math.Pow(10, (count - 1)))) * Convert.ToInt32(Math.Pow(10, (count - 2))) +
            intPart % Convert.ToInt32(Math.Pow(10, (count - 2)));

    decimal res = intPart + floatPart;
    Console.WriteLine(res);
}
else {
    Console.WriteLine("No");
}