// программа, которая принимает на вход принимает число N, а на выходе показывает все четные числа от 1 до N

Console.Clear();
Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine()!);
int n2 = 2;
while (n2 <= n)
{
    Console.WriteLine($"{n2}");
    n2 = n2 + 2;
}
