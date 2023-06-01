Console.WriteLine("Введите a= ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b=");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите c=");
int c = Convert.ToInt32(Console.ReadLine());
if (a>b && a>c)
{
    Console.WriteLine("Max is a = " + a);
}
else if (b>a && b>c)
{
Console.WriteLine("Max is b = " + b);
}
else 
{
    Console.WriteLine("Max is c = " + c);
}
