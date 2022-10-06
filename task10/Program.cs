Console.Clear();
Console.WriteLine("Введите трехзначное число, я выведу второе");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n%100;
int n2=n1/10;

if (n >99 && n<1000)
{
    Console.WriteLine(n2);
}

else
{
    Console.WriteLine("Введите ТРЕХЗНАЧНОЕ число! Это не трехзначное число!");
}
