using System;
using System.Collections.Generic;

public class Program
{
    private static List<Station> stations = new List<Station>();
    private static List<Monitor> monitors = new List<Monitor>();

    static void Main(string[] args)
    {
        int option;

        do
        {
            Console.WriteLine("\n--- Menu de Operações ---");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Criar Nova Estação");
            Console.WriteLine("2 - Atualizar Estação");
            Console.WriteLine("3 - Remover Estação");
            Console.WriteLine("4 - Criar Monitor");
            Console.WriteLine("5 - Editar Monitor");
            Console.Write("Escolha uma opção: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                case 1:
                    CriarNovaEstacao();
                    break;
                case 2:
                    AtualizarEstacao();
                    break;
                case 3:
                    RemoverEstacao();
                    break;
                case 4:
                    CriarMonitor();
                    break;
                case 5:
                    EditarMonitor();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (option != 0);
    }

    private static void CriarNovaEstacao()
    {
        Console.Write("Digite a UF da nova estação: ");
        string uf = Console.ReadLine();
        stations.Add(new Station(uf));
        Console.WriteLine("Nova estação criada.");
    }

    private static void AtualizarEstacao()
    {
        Console.WriteLine("Estações disponíveis:");
        for (int i = 0; i < stations.Count; i++)
        {
            Console.WriteLine($"{i} - UF: {stations[i].UF}");
        }

        Console.Write("Escolha o índice da estação para atualizar: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < stations.Count)
        {
            Console.Write("Digite a nova temperatura: ");
            float temp = float.Parse(Console.ReadLine());
            stations[index].SetTemperature(temp);
            Console.WriteLine("Temperatura atualizada.");
        }
        else
        {
            Console.WriteLine("Estação inválida!");
        }
    }

    private static void RemoverEstacao()
    {
        Console.WriteLine("Estações disponíveis:");
        for (int i = 0; i < stations.Count; i++)
        {
            Console.WriteLine($"{i} - UF: {stations[i].UF}");
        }

        Console.Write("Escolha o índice da estação para remover: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < stations.Count)
        {
            stations.RemoveAt(index);
            Console.WriteLine("Estação removida.");
        }
        else
        {
            Console.WriteLine("Estação inválida!");
        }
    }

    private static void CriarMonitor()
    {
        Console.Write("Digite o nome do novo monitor: ");
        string name = Console.ReadLine();
        monitors.Add(new Monitor(name));
        Console.WriteLine("Monitor criado.");
    }

    private static void EditarMonitor()
    {
        Console.WriteLine("Monitores disponíveis:");
        for (int i = 0; i < monitors.Count; i++)
        {
            Console.WriteLine($"{i} - {monitors[i].Name}");
        }

        Console.Write("Escolha o índice do monitor para editar: ");
        int monitorIndex = int.Parse(Console.ReadLine());

        if (monitorIndex >= 0 && monitorIndex < monitors.Count)
        {
            Console.WriteLine("Estações disponíveis:");
            for (int i = 0; i < stations.Count; i++)
            {
                Console.WriteLine($"{i} - UF: {stations[i].UF}");
            }

            Console.Write("Escolha o índice da estação para adicionar ou remover do monitor: ");
            int stationIndex = int.Parse(Console.ReadLine());

            if (stationIndex >= 0 && stationIndex < stations.Count)
            {
                Station station = stations[stationIndex];
                Monitor monitor = monitors[monitorIndex];

                Console.Write("Deseja (1) Adicionar ou (2) Remover o monitor da estação? ");
                int action = int.Parse(Console.ReadLine());

                if (action == 1)
                {
                    station.AddObserver(monitor);
                    Console.WriteLine("Monitor adicionado à estação.");
                }
                else if (action == 2)
                {
                    station.RemoveObserver(monitor);
                    Console.WriteLine("Monitor removido da estação.");
                }
                else
                {
                    Console.WriteLine("Ação inválida!");
                }
            }
            else
            {
                Console.WriteLine("Estação inválida!");
            }
        }
        else
        {
            Console.WriteLine("Monitor inválido!");
        }
    }
}
