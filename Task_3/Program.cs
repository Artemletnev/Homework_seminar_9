//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.WriteLine("Enter the m number:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the n number:");
int n = Convert.ToInt32(Console.ReadLine());


int AckermannFunction(int firstnumber, int secondnumber)
{
    if (firstnumber == 0) return secondnumber + 1;
    if (firstnumber != 0 && secondnumber == 0) return AckermannFunction(firstnumber - 1, 1);
    if (firstnumber > 0 && secondnumber > 0) return AckermannFunction(firstnumber - 1, AckermannFunction(firstnumber, secondnumber - 1));
    return AckermannFunction(firstnumber, secondnumber);
}

Console.WriteLine($"Ackerman function for numbers ({m},{n}) = {AckermannFunction(m, n)}");