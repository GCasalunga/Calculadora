public class Aritmetica
{
    public static void Adicao()
    {
        double e, f, resultado2;

        Console.WriteLine("---Soma A+B---\n");
        Console.WriteLine("Digite os valores.");
        Console.Write("E = ");
        e = Convert.ToDouble(Console.ReadLine());
        Console.Write("F = ");
        f = Convert.ToDouble(Console.ReadLine());

        resultado2 = e + f;

        Console.WriteLine($"{e} Somado {f} é {resultado2}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        return;
    }

    public static void Subtracao()
    {
        double g, h, resultado3;

        Console.WriteLine("--Subtração A/B--\n");
        Console.WriteLine("Digite os Valores.");

        Console.Write("A = ");
        g = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        h = Convert.ToDouble(Console.ReadLine());

        resultado3 = g - h;

        Console.WriteLine($"{g} Subtraido por {h} é {resultado3}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        return;
    }
    public static void Multiplicação()
    {
        double a, b, resultado;

        Console.WriteLine("--- Multiplicação AxB ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = a * b;

        Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
    }
    public static void Divisão()
    {
        double c, d, resultado1;

        Console.WriteLine("--Divisão A/B--\n");
        Console.WriteLine("Digite os Valores.");

        Console.Write("A = ");
        c = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        d = Convert.ToDouble(Console.ReadLine());

        resultado1 = c / d;

        Console.WriteLine($"{c} Dividido por {d} é {resultado1}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
    }
    public static void Exponenciação()
    {
        double numeroA, numeroB, potencia;

        Console.WriteLine("--- Exponenciação A^B---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("(a):");
        numeroA = Convert.ToDouble(Console.ReadLine());

        Console.Write("(b):");
        numeroB = Convert.ToDouble(Console.ReadLine());

        potencia = Math.Pow(numeroA, numeroB);

        Console.WriteLine($"{numeroA} elevado a {numeroB} é: {potencia}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
    }
    public static void Radiciação()

    {
        double o, p, resultado;

        Console.WriteLine("--- Calcular radiciacao ---\n");
        Console.WriteLine("---radiciado o#p ---\n");

        Console.WriteLine("digite os valores:");

        o = Convert.ToDouble(Console.ReadLine());
        p = Convert.ToDouble(Console.ReadLine());

        resultado = Math.Pow(o, 1 / p);

        Console.WriteLine($"{o} radiciado {p} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
    }
    public static void Bhaskara()
    {
        double a, b, c, delta, x1, x2;

        Console.WriteLine("-- Equação do segundo grau --");

        Console.Write("(a): ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("(b): ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("(c): ");
        c = Convert.ToDouble(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("Não é uma equação de segundo grau!");
            Console.ReadKey();
        }
        else
        {
            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine($"Como delta = {delta:N2}, a equação não possui raízes reais!");
                Console.ReadKey();
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"x1 = {x1:N2} e x2 = {x2:N2}");
            }
        }
    }
}