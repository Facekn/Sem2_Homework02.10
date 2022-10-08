Console.Write("Введите номер дня недели: ");
int daynumber = int.Parse(Console.ReadLine() ?? "0");

if (daynumber > 0 && daynumber <= 5)
{
    Console.Write("К сожалению, это не выходной день, а рабочий");
}
else if (daynumber >= 6 && daynumber <= 7)

{
   Console.Write("Это выходной день"); 
}

else Console.Write("Дня недели с таким номер не существует!!!");