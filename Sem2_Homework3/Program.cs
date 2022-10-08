Console.Write("Введите номер четверти для плоскости: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number==1)
{
    Console.WriteLine("Диапазон возможных координат xy: x>0, y>0");
} 

else if (number==2)
{
    Console.WriteLine("Диапазон возможных координат xy: x<0, y>0");
} 

else if (number==3)
{
    Console.WriteLine("Диапазон возможных координат xy: x<0, y<0");
} 

else if (number==4)
{
    Console.WriteLine("Диапазон возможных координат xy: x>0, y<0");
} 

 
else 
{
    Console.WriteLine("Не является четвертью. Попробуйте еще раз!");
}