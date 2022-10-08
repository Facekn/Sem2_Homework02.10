Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");

if(num > 9999 && num <= 99999) 

{
    int a = num / 10000;
    int b = num % 10;
    int c = num / 1000;
    c = c % 10;
    int d = num / 10;
    d = d % 10;

    if (a == b && c == d)
    {
        Console.WriteLine("Данное число " +num+ " является палиндромом");
    }
    else
    {
        Console.WriteLine("Данное число " +num+ " не является палиндромом");
    }

}
else 
{
Console.WriteLine("Число не подходит. Попробуйте еще раз!");
}

