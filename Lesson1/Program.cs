int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (x == y)
{
    Console.WriteLine("teng");
}
else if (x > y)
{
    Console.WriteLine(x);
}
else if(x == 2)
{
    Console.WriteLine("2 ga teng");
}
else
{
    Console.WriteLine(y);
}

Console.Write("a: ");
string input = Console.ReadLine();

int a = Convert.ToInt32(input);

Console.Write("b: ");
input = Console.ReadLine();
int b = Convert.ToInt32(input);

int sum = a + b;

Console.WriteLine("sum: " + sum);

