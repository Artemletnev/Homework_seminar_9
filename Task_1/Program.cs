//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


Console.WriteLine("Enter the N number:");
int N =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the M number:");
int M =Convert.ToInt32(Console.ReadLine());

string  PrintNumbers(int start, int end)
{
    if (end == start) return start.ToString();
    return (start + "," + PrintNumbers(start + 1, end));  
}
Console.WriteLine(PrintNumbers(M, N));


