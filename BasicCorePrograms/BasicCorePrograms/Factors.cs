﻿public void FindPrimeFactors(int N)
{

    while (N % 2 == 0)
    {
        Console.Write(2 + " ");
        N /= 2;
    }
    for (int i = 3; i <= Math.Sqrt(N); i += 2)
    {
        while (N % i == 0)
        {
            Console.Write(i + " ");
            N /= i;
        }
    }

    if (N > 2)
        Console.Write(N);
} 
} 

public static void Main(String[] args)
{
    int N = 315;
    Console.WriteLine("Following are the prime factors of " + N);
    FindPrimeFactors(N);
}
}