// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.WriteLine("Enter the M number:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the N number:");
int N = Convert.ToInt32(Console.ReadLine());
int sumElements = 0;


string PrintNumbers(int start, int end)
{
    if (end == start) return start.ToString();
    return (start + "," + PrintNumbers(start + 1, end));
}


void SumNumbers(int start, int end, int sumElements)
{
    if (start > end)
    {
        Console.WriteLine($"The sum of natural elements in the range from M to N = {sumElements}");
        return;
    }
    sumElements = sumElements + (start++);
    SumNumbers(start, end, sumElements);
}
if (M < N)
{
    Console.WriteLine();
    Console.WriteLine($"Natural numbers in the range from M to N = {PrintNumbers(M, N)}");
    Console.WriteLine();
    SumNumbers(M, N, sumElements);
}
else
{
    Console.WriteLine("Error. M > N.");
}