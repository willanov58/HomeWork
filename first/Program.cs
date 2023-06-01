Console.WriteLine("Введите a= ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b=");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine("Max is " + a);
    Console.WriteLine("Min is " + b);
}
else if (b>a)
{
Console.WriteLine("Max is " + b);
Console.WriteLine("Min is " + a);
}
else 
{
    Console.WriteLine("Number are equal");
}

