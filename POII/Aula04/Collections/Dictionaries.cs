using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        // Criando e inicializando o dicionário
        Dictionary<string, int> idades = new Dictionary<string, int>
        {
            {"Carlos", 30},
            {"Joao", 22},
            {"Clara", 18},
            {"Wagner", 0}
        };

        // Adicionando mais itens ao dicionário
        idades.Add("Alice", 25);
        idades.Add("Jhon", 28);

        // Exibindo a idade de Clara
        Console.WriteLine("Clara tem " + idades["Clara"] + " anos.");

        // Verificando se o dicionário contém a chave "Bob"
        if (idades.ContainsKey("Bob"))
        {
            Console.WriteLine("Eu sei a idade do Bob.");
        }
        else
        {
            Console.WriteLine("Eu não sei a idade do Bob.");
        }

        // Atualizando a idade de Clara
        idades["Clara"] = 19;

        // Exibindo a nova idade de Clara
        Console.WriteLine("Clara tem " + idades["Clara"] + " anos.");

        // Removendo Clara do dicionário
        idades.Remove("Clara");

        // Verificando se o dicionário contém a chave "Clara" após remoção
        if (idades.ContainsKey("Clara"))
        {
            Console.WriteLine("Eu ainda sei a idade da Clara.");
        }
        else
        {
            Console.WriteLine("Eu não sei a idade da Clara.");
        }

        // Iterando sobre o dicionário e exibindo chaves e valores
        foreach (KeyValuePair<string, int> pair in idades)
        {
            Console.WriteLine(pair.Key + " possui " + pair.Value + " anos.");
        }

        // Iterando sobre as chaves do dicionário e exibindo chaves e valores
        foreach (string chave in idades.Keys)
        {
            Console.WriteLine(chave + " possui " + idades[chave] + " anos.");
        }

        // Exibindo o número de pessoas no dicionário
        Console.WriteLine("Sabemos a idade de " + idades.Count + " pessoas.");

        // Limpando o dicionário
        idades.Clear();
        Console.WriteLine("Sabemos a idade de " + idades.Count + " pessoas.");
    }
}
