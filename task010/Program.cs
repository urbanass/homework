void Main(string[] args)
{
    int n = 584;
    int d = GetSecondDigit(n);
    Console.WriteLine(d);
    Console.ReadKey();
}

     int GetSecondDigit(int k)
{
    while (k >= 100) k /= 10;
    int d = k % 10;
    return d;
}
Main(args);
Console.WriteLine();