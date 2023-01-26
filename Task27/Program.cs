// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNum(string text)
{
    Console.Write($"{text}: ");
    int tempNum = int.Parse(Console.ReadLine()!);
    return tempNum;
}

int SumNumbers (int n)
{
    int sum = 0;
    if (n < 0) n *= -1;
    for (int i = 0; n > 0; i++)
    {
        sum = n % 10 + sum;
        n /= 10;
    }
    return sum;
}

void main()
{
    Console.Clear();
    int check = InputNum("Введите ваше число");
    Console.WriteLine($"Сумма цифр в введенном числе {check} равна: {SumNumbers(check)}");
}

main();