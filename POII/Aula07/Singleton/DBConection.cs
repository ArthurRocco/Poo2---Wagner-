using System;

public class DBConnection
{
    private static DBConnection _instance;

    private DBConnection()
    {
        Console.WriteLine("Nova conexão de banco criada");
    }

    public static DBConnection Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }
    }

    public void ExecuteCommand(string sql)
    {
        Console.WriteLine($"Executando o comando: {sql}");
    }
}

public class Program
{
    public static void Main()
    {
        DBConnection c1 = DBConnection.Instance;
        c1.ExecuteCommand("SELECT * FROM xpto");

        DBConnection c2 = DBConnection.Instance;
        c2.ExecuteCommand("UPDATE xpto SET name = 'Jose' WHERE id = 1");
    }
}
