string opcaoDesejada;

do
{
    Console.Clear();

    Console.WriteLine("--- Calculadora 4 operações ---\n");

    Console.WriteLine("[+] Soma");
    Console.WriteLine("[-] Subtração");
    Console.WriteLine("[*] Multiplicação");
    Console.WriteLine("[/] Divisão");
    Console.WriteLine("[E ou e] Exponenciação");
    Console.WriteLine("[.] Radiciação");
    Console.WriteLine("[b ou B] Bhaskara");

    Console.WriteLine("\n[0] Sair");

    Console.Write("\nSelecione a operação desejada: ");

    opcaoDesejada = Console.ReadLine()!;

    switch (opcaoDesejada)
    {
        case "+":
            Aritmetica.Adicao();
            break;

        case "-":
            Aritmetica.Subtracao();

            break;

        case "*":
            Aritmetica.Multiplicação();

            break;

        case "/":
            Aritmetica.Divisão();
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;

        case "E" or "e":

            Aritmetica.Exponenciação();
            break;

        case "R" or "r":
            Aritmetica.Radiciação();

            break;

        case "B" or "b":
            Aritmetica.Bhaskara();

            break;

        case "0":
            break;
    }

    Console.ResetColor();

} while (opcaoDesejada != "0");

Console.WriteLine("\nObrigado por utilizar nosso programa.");