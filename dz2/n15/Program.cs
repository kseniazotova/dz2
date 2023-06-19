 //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 6 -> да
Console.WriteLine("Введите число дня недели");
int num = int.Parse(Console.ReadLine());
if ((num == 7) || (num == 6)) Console.WriteLine("Выходной"); 
else if ((num < 1) || (num > 7 )) Console.WriteLine("Такого дня недели нет");
else if ((num > 0) || (num < 6 )) Console.WriteLine("Будний день");