Console.Clear();
Console.WriteLine("Введите число, а явыведу трерью цифру");

string str = Console.ReadLine();
int m=str.Length;

double n = Math.Pow(10,m-3);
double n2 = Math.Pow(10,m-2);

int nI=(int)n;
int nI2=(int)n2;

double strDou = Double.Parse(str);
double result = strDou%n2;
double result2 = result/n;
double result2M = Math.Round(result2);

if (m<3)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    if (result2M>result2)
    {
        Console.WriteLine(result2M-1);

    }

    else
    {
        Console.WriteLine(result2M);

    }
}



    

