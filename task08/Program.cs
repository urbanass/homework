//Console.WriteLine("start");
void Metod1(int number)
{
int num = 1;
while (num <= number)
    {
        if (num % 2 ==0)
        {
         Console.WriteLine(num);
        }
        num++;
    }
}
int number = int.Parse(Console.ReadLine());
Metod1(number);