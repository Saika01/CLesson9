// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Input M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine());

if(m>n) NumberInLineBigToSmall(m,n);
else NumberInLineSmallToBig(m,n);

void NumberInLineBigToSmall(int number1, int number2)
{
    if(number2 == number1) 
    {
        Console.Write(number1);
        return;
    }
    Console.Write($"{number1} ");
    NumberInLineBigToSmall(number1-1, number2);
}

void NumberInLineSmallToBig(int number1, int number2)
{
    if(number1 == number2) 
    {
        Console.Write(number1);
        return;
    }
    Console.Write($"{number1} ");
    NumberInLineSmallToBig(number1+1, number2);
}
