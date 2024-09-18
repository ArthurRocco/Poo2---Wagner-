using System;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Sua forma geométrica é 2D ou 3D?");
            Console.WriteLine("1. 2D");
            Console.WriteLine("2. 3D");
            Console.WriteLine("0. Sair");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Menu2D();
                    break;
                case "2":
                    Menu3D();
                    break;
                case "0":
                    return; // Encerra o programa
                default:
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                    break;
            }
        }
    }

    private static void Menu2D()
    {
        Console.WriteLine("Escolha a forma geométrica 2D que deseja calcular:");
        Console.WriteLine("1. Círculo");
        Console.WriteLine("2. Retângulo");
        Console.WriteLine("3. Triângulo");
        Console.WriteLine("0. Voltar");

        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                CalcularCirculo();
                break;
            case "2":
                CalcularRetangulo();
                break;
            case "3":
                CalcularTriangulo();
                break;
            case "0":
                return; // Volta ao menu principal
            default:
                Console.WriteLine("Escolha inválida. Tente novamente.");
                break;
        }
    }

    private static void Menu3D()
    {
        Console.WriteLine("Escolha a forma geométrica 3D que deseja calcular:");
        Console.WriteLine("1. Cubo");
        Console.WriteLine("2. Esfera");
        Console.WriteLine("3. Cilindro");
        Console.WriteLine("4. Cone");
        Console.WriteLine("0. Voltar");

        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                CalcularCubo();
                break;
            case "2":
                CalcularEsfera();
                break;
            case "3":
                CalcularCilindro();
                break;
            case "4":
                CalcularCone();
                break;
            case "0":
                return; // Volta ao menu principal
            default:
                Console.WriteLine("Escolha inválida. Tente novamente.");
                break;
        }
    }

    private static void CalcularCirculo()
    {
        Console.Write("Digite o raio do círculo: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        FiguraGeometrica circulo = new Circulo(raio);

        Console.WriteLine("Perímetro do círculo: " + circulo.CalcularPerimetro());
        Console.WriteLine("Área do círculo: " + circulo.CalcularArea());

        try
        {
            Console.WriteLine("Volume do círculo: " + circulo.CalcularVolume());
        }
        catch (NotImplementedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void CalcularRetangulo()
    {
        Console.Write("Digite a largura do retângulo: ");
        double largura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura do retângulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        FiguraGeometrica retangulo = new Retangulo(largura, altura);

        Console.WriteLine("Perímetro do retângulo: " + retangulo.CalcularPerimetro());
        Console.WriteLine("Área do retângulo: " + retangulo.CalcularArea());
    }

    private static void CalcularTriangulo()
    {
        Console.Write("Digite o comprimento do lado 1 do triângulo: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o comprimento do lado 2 do triângulo: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o comprimento do lado 3 do triângulo: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a base do triângulo: ");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura do triângulo: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        FiguraGeometrica triangulo = new Triangulo(lado1, lado2, lado3, baseTriangulo, altura);

        Console.WriteLine("Perímetro do triângulo: " + triangulo.CalcularPerimetro());
        Console.WriteLine("Área do triângulo: " + triangulo.CalcularArea());
        Console.WriteLine("Volume do triângulo: " + triangulo.CalcularVolume());
    }

    private static void CalcularCubo()
    {
        Console.Write("Digite o comprimento da aresta do cubo: ");
        double lado = Convert.ToDouble(Console.ReadLine());

        FiguraGeometrica cubo = new Cubo(lado);

        Console.WriteLine("Perímetro do cubo: " + cubo.CalcularPerimetro());
        Console.WriteLine("Área do cubo: " + cubo.CalcularArea());
        Console.WriteLine("Volume do cubo: " + cubo.CalcularVolume());
    }

    private static void CalcularEsfera()
    {
        Console.Write("Digite o raio da esfera: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        FiguraGeometrica esfera = new Esfera(raio);

        Console.WriteLine("Área da esfera: " + esfera.CalcularArea());
        Console.WriteLine("Volume da esfera: " + esfera.CalcularVolume());
    }

    private static void CalcularCilindro()
    {
        Console.Write("Digite o raio da base do cilindro: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura do cilindro: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        FiguraGeometrica cilindro = new Cilindro(raio, altura);

        Console.WriteLine("Perímetro da base do cilindro: " + cilindro.CalcularPerimetro());
        Console.WriteLine("Área superficial do cilindro: " + cilindro.CalcularArea());
        Console.WriteLine("Volume do cilindro: " + cilindro.CalcularVolume());
    }

    private static void CalcularCone()
    {
        Console.Write("Digite o raio da base do cone: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura do cone: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        FiguraGeometrica cone = new Cone(raio, altura);

        Console.WriteLine("Perímetro da base do cone: " + cone.CalcularPerimetro());
        Console.WriteLine("Área superficial do cone: " + cone.CalcularArea());
        Console.WriteLine("Volume do cone: " + cone.CalcularVolume());
    }
}
