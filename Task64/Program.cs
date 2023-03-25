void NumberLine(int num)
{
    Console.Write($"{num}, ");
    if(num == 0) return;
    NumberLine(num-1);
}

Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine());

NumberLine(n);
