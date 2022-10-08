void Main(string[] args)
{
    int n = 595;
    int d = GetSecondDigit(n);
    Console.WriteLine(d);
    //Console.ReadKey();
}

    int GetSecondDigit(int k)
{
    k /= 10;
    int d = k % 10;
    return d;
}
Main(args);
