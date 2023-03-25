int SumNumbers(int n)
{
    if (n == 0) return 0;
    else return n % 10 + SumNumbers(n / 10);
}

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumNumbers(number);

Console.WriteLine(sum);
