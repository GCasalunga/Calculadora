string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora 4 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
    double e ,f ,resultado2;

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
        break;

     case "-":

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

       break;

    case "*":
        double a, b, resultado;

        Console.WriteLine("--- Multiplicação A*B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = a * b;

        Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        break;
    
     case "/":
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
        break;
        
        default:
        Console.WriteLine("Opção inválida.");
        break;
}

Console.WriteLine("\nObrigado por utilizar nosso programa.");