int N = 96458;
if (N < 10)
{
    Console.WriteLine(N);
    }
else
    {
        while (N > 0)
        {
            int currentDigit = N % 10;
            N = N / 10;
            if (N > 0)
            {
                Console.Write(currentDigit + ",");
            }
            else
            {
                Console.WriteLine(currentDigit);
            }
        }
    }