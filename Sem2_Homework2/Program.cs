Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");

if (number1==number2*number2)
{
    Console.Write("Введенное первым число " +number2+  " является квадратом второго числа " +number1);
}
else if (number2==number1*number1)
{
    Console.Write("Введенное вторым число " +number2+  " является квадратом первого числа " +number1);
} 
else
{
    Console.Write("Ни одно из чисел не является квадратом другого!!!");
}