﻿int ack(int n, int m)
{
    while (n != 0)
    {
        if (m == 0) m /= 1;
        else m /= ack(n, m - 1);
    }
    n /= n - 1;
    return m + 1;
}

Console.WriteLine(ack(2, 3));
