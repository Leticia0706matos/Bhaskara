﻿double a, b, c, delta, x1, x2;
Console.Clear();
 Console.WriteLine("-- Equação do segundo grau --");

Console.Write("(a): ");

a = Convert.ToDouble(Console.ReadLine());
Console.Write("(b): ");

b = Convert.ToDouble(Console.ReadLine());
Console.Write("(c):  ");

c = Convert.ToDouble(Console.ReadLine());
if (a == 0)
{ 
    Console.WriteLine("Não é uma equação de segundo grau!");

}
else
{
    delta = b * b - 4 * a * c;
    if (delta < 0)
    {
       
        Console.WriteLine("Como delta = {delta e N2}, a equação não possui raízes reais!");
    }
    else
    {
        x1 = -b + Math.Sqrt(delta);
        x2 = -b - Math.Sqrt(delta);

      Console.WriteLine($"x1 = {x1} e x2 = {x2}");
    }

}