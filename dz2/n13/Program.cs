Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if  (num < 100) Console.WriteLine($"Третьей цифры в числе {num} нет");
while (num > 1000) 
{
num = num / 10;
 }
int num2 = num % 10;
Console.WriteLine($"Третья цифра в числе -> {num2}"); 
