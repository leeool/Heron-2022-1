double area, semiperimetro;
double l1, l2, l3;

Console.Write("Entre com o lado 1: ");
l1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Entre com o lado 2: ");
l2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Entre com o lado 3: ");
l3 = Convert.ToDouble(Console.ReadLine()!);

semiperimetro = (l1 + l2 + l3) / 2;
area = Math.Sqrt(semiperimetro * (semiperimetro - l1) * (semiperimetro - l2) * (semiperimetro - l3));

Console.WriteLine($"\nSemiperimetro: {semiperimetro:N2}");
Console.WriteLine($"Area: {area:N2}");