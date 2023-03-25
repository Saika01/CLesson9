Console.WriteLine("Input M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n) 
{
    Console.WriteLine(NumberInLineBigToSmall(m, n));
}
else 
{
    Console.WriteLine(NumberInLineSmallToBig(m, n));
}

int NumberInLineBigToSmall(int number1, int number2)
{
    if (number2 == number1) return number1;
    int sum = NumberInLineBigToSmall(number1 - 1, number2);
    sum += number1; 
    return sum;
}

int NumberInLineSmallToBig(int number1, int number2)
{
    if (number2 == number1) return number1; 
    int sum = NumberInLineSmallToBig(number1 + 1, number2);
    sum += number1; 
    return sum;
}

