// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void Main()
{
    Console.WriteLine(isPalindrom(14212));
    Console.WriteLine(isPalindrom(12821));
    Console.WriteLine(isPalindrom(23432));
}

Boolean isPalindrom(Int16 number)
{
    char[] n1 = number.ToString().ToCharArray();
    char[] n2 = number.ToString().ToCharArray();
    Array.Reverse(n1);

    String s1 = new String(n1);
    Console.WriteLine(n1);
    String s2 = new String(n2);
    Console.WriteLine(n2);

    return (s1 == s2);
}
Main();
