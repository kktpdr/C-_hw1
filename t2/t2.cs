int input_int(string msg)
{
    Console.Write(msg);
    int a = int.Parse(Console.ReadLine());
    return a;
}
int a = input_int ("Put three-digit number(xxx): ");
if (a > 99 && a < 1000)
{
    int f = a % 100;
    int res = f / 10;
    Console.WriteLine($"The second number of {a} is {res}");
}
else
{
    Console.WriteLine($"The number isn't three-digit.");
}
