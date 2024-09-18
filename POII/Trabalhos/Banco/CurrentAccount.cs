using System;

public class CurrentAccount : Account
{
    public float Limit { get; set; }

    public override void DebitAmount(float amount)
    {
        if (Balance + Limit >= amount)
        {
            Balance -= amount;
        }
        else
        {
            throw new InvalidOperationException("Limite excedido.");
        }
    }

    public override void CreditAmount(float amount)
    {
        Balance += amount;
    }

    public override void Transfer(Account toAccount, float amount)
    {
        if (Balance >= amount)
        {
            DebitAmount(amount);
            toAccount.CreditAmount(amount);
        }
        else
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }
    }

    public override void Render()
    {
        throw new InvalidOperationException("Conta Corrente não rende.");
    }

    public override void FazerPix(string chavePix, float amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Pix realizado com sucesso. Valor: {amount}");
        }
        else
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }
    }
}
