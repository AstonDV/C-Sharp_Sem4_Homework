// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

string Input(string text)
{
    Console.Write($"{text}: ");
    string numbers = Console.ReadLine();
    return numbers;
}

string[] ArrayBuild(string BunchOfNumbers)
{
    char[] separators = new char[] {',', ' '};
    string[] array = BunchOfNumbers.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return array;
}

void main()
{
    Console.Clear();
    string inputNum = Input("Введите восемь чисел через запятую или через пробел");
    Console.Write($"[{String.Join(", ", ArrayBuild(inputNum))}]");
}

main();