Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());

NumberLine(number);

void NumberLine(int num)
{
    if(num == 0) return;
    NumberLine(num-1);
    Console.Write($"{num} ");
}
