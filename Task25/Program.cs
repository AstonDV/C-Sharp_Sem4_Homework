// Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNum(string text)
{
    Console.Write($"{text}: ");
    int tempNum = int.Parse(Console.ReadLine()!);
    return tempNum;
}

int Exponentiation(int number, int degree)
{
    int tempExpo = 1;
    for (int i = 0; i < degree; i++)
    {
        tempExpo *= number;
    
    }
    return tempExpo;
}

void main()
{
    Console.Clear();
    int a = InputNum("Введите число A");
    int b = InputNum("Введите число B");
    Console.Write($"Результат возведения числа {a} в натуральную степень {b} равен {Exponentiation(a, b)}");
}

main();