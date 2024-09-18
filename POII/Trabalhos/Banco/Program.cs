using System;

class Program
{
    static void Main(string[] args)
    {
        Account currentAccount = null;
        Account savingsAccount = null;
        Account salaryAccount = null;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("----- Bem-vindo ao Sistema de Contas -----");
            Console.WriteLine("1. Criar Conta Corrente");
            Console.WriteLine("2. Criar Conta Poupança");
            Console.WriteLine("3. Criar Conta Salário");
            Console.WriteLine("4. Realizar operações");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    currentAccount = CreateAccount(new CurrentAccountFactory(), "Corrente");
                    break;
                case "2":
                    savingsAccount = CreateAccount(new SavingsAccountFactory(), "Poupança");
                    break;
                case "3":
                    salaryAccount = CreateAccount(new SalaryAccountFactory(), "Salário");
                    break;
                case "4":
                    PerformOperations(currentAccount, savingsAccount, salaryAccount);
                    break;
                case "5":
                    Console.WriteLine("Obrigado por usar o sistema.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }

    static Account CreateAccount(AccountFactory factory, string accountType)
    {
        Account account = factory.CreateAccount();
        Console.Write($"Digite o número da Conta {accountType}: ");
        account.AccNumber = int.Parse(Console.ReadLine());
        Console.Write("Digite o saldo inicial: ");
        account.CreditAmount(float.Parse(Console.ReadLine()));
        Console.WriteLine($"Conta {accountType} criada com sucesso.");
        return account;
    }

    static void PerformOperations(Account currentAccount, Account savingsAccount, Account salaryAccount)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("----- Menu de Operações -----");
            Console.WriteLine("1. Operações Conta Corrente");
            Console.WriteLine("2. Operações Conta Poupança");
            Console.WriteLine("3. Operações Conta Salário");
            Console.WriteLine("4. Voltar");
            Console.Write("Escolha uma conta para realizar operações: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    if (currentAccount != null) HandleAccountOperations(currentAccount);
                    else Console.WriteLine("Conta Corrente não criada.");
                    break;
                case "2":
                    if (savingsAccount != null) HandleAccountOperations(savingsAccount);
                    else Console.WriteLine("Conta Poupança não criada.");
                    break;
                case "3":
                    if (salaryAccount != null) HandleAccountOperations(salaryAccount);
                    else Console.WriteLine("Conta Salário não criada.");
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void HandleAccountOperations(Account account)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"----- Operações para Conta {account.AccNumber} -----");
            Console.WriteLine("1. Sacar");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Transferir");
            if (account is CurrentAccount || account is SalaryAccount)
            {
                Console.WriteLine("4. Fazer Pix");
            }
            if (account is SavingsAccount)
            {
                Console.WriteLine("5. Render Saldo");
            }
            Console.WriteLine("6. Ver Saldo");
            Console.WriteLine("7. Voltar");
            Console.Write("Escolha uma operação: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    PerformDebit(account);
                    break;
                case "2":
                    PerformCredit(account);
                    break;
                case "3":
                    PerformTransfer(account);
                    break;
                case "4":
                    if (account is CurrentAccount || account is SalaryAccount)
                        PerformPix(account);
                    else
                        Console.WriteLine("Opção inválida.");
                    break;
                case "5":
                    if (account is SavingsAccount)
                        account.Render();
                    else
                        Console.WriteLine("Opção inválida.");
                    break;
                case "6":
                    Console.WriteLine($"Saldo atual: {account.GetBalance()}");
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void PerformDebit(Account account)
    {
        Console.Write("Digite o valor para saque: ");
        float amount = float.Parse(Console.ReadLine());
        try
        {
            account.DebitAmount(amount);
            Console.WriteLine("Saque realizado com sucesso.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void PerformCredit(Account account)
    {
        Console.Write("Digite o valor para depósito: ");
        float amount = float.Parse(Console.ReadLine());
        account.CreditAmount(amount);
        Console.WriteLine("Depósito realizado com sucesso.");
    }

    static void PerformTransfer(Account account)
    {
        Console.Write("Digite o valor para transferência: ");
        float amount = float.Parse(Console.ReadLine());
        Console.Write("Digite o número da conta destino: ");
        int toAccountNumber = int.Parse(Console.ReadLine());
        Account toAccount = new CurrentAccount();
        try
        {
            account.Transfer(toAccount, amount);
            Console.WriteLine("Transferência realizada com sucesso.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void PerformPix(Account account)
    {
        Console.Write("Digite a chave Pix: ");
        string chavePix = Console.ReadLine();
        Console.Write("Digite o valor do Pix: ");
        float amount = float.Parse(Console.ReadLine());
        try
        {
            account.FazerPix(chavePix, amount);
            Console.WriteLine("Pix realizado com sucesso.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
