void Main(string[] args)
{
    int n = 12345;
    if (n > 100)
    {
        int d = GetSecondDigit(n);
        Console.WriteLine(d);
    }
    else Console.WriteLine("нет третей цифры");
    //Console.ReadKey();
}
    int GetSecondDigit(int k)
{
    while (k >= 1000)
    {
        k /= 10;
    }
    int d = k % 10;
    return d;
}
Main(args);
