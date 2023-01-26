// Задача “со звездочкой”: 
// Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.
//   3 ->            5 ->
//    *               *
//   ***             ***
//  *****           *****
//                 *******
//                *********

int Input(string text)
{
    Console.Write($"{text}: ");
    int treeHeight = int.Parse(Console.ReadLine()!);
    return treeHeight;
}

void Tree(int count)
{
    string[] j = new string[2 * count];
    for(int i = 0; i < 2 * count; i++)
    {
        j[i] = " ";
    }
    j[count] = "*";
    for(int i = 0; i < count; i++)
    {
        j[count - i] = "*";
        j[count + i] = "*";
        Console.WriteLine(String.Join("", j));
    }
}

void main ()
{
    Console.Clear();
    int number = Input("Введите высоту вашей ёлочки");
    Tree(number);
}

main();