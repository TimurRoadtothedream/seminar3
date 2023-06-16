Console.WriteLine("Введите номер четверти: ");
int a = int.Parse(Console.ReadLine());
if (a < 1 || a > 4)
{
    Console.WriteLine("Недопустимое значение");
    Environment.Exit(0);
}
switch (a)
{
case 1:
    Console.WriteLine("Диапазон x > 0 и y > 0");
    break;
case 2:
    Console.WriteLine ("Диапазон x < 0 и y > 0");
    break;
case 3:
    Console.WriteLine ("Диапазон x < 0 и y < 0");
    break;
case 4:
    Console.WriteLine ("Диапазон x > 0 и y < 0");
    break;
}
