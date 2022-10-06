Console.Clear();
Console.WriteLine("Введите порядковый номер дня недели");
int n = Convert.ToInt32(Console.ReadLine());
if (n>0 && n<6)
{
    Console.WriteLine("Будний");
}
else if (n>5 && n<8)
{
    Console.WriteLine("Выходной");
}
else 
{
    Console.WriteLine("Нет такого дня недели");
}