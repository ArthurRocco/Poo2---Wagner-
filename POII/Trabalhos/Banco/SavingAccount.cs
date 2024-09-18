using System;

public class SavingsAccount : Account
{
    public float Rate { get; set; }
    private int withdrawalsThisMonth = 0;
    private const int FreeWithdrawals = 3;
    private const float FeeAfterFreeWithdrawals = 1.0f;

    public override void DebitAmount(float amount)
    {
        if (Balance >= amount)
        {
            if (withdrawalsThisMonth >= FreeWithdrawals)
            {
                Balance -= FeeAfterFreeWithdrawals;
                Console.WriteLine("Taxa de R$1,00 cobrada por saque.");
            }
            Balance -= amount;
            withdrawalsThisMonth++;
        }
        else
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }
    }

    public override void CreditAmount(float amount)
    {
        Balance += amount;
    }

    public override void Render()
    {
        Balance += Balance * Rate;
        Console.WriteLine($"Saldo rendido em {Rate * 100}%: {Balance}");
    }

    public override void Transfer(Account toAccount, float amount)
    {
        if (toAccount is CurrentAccount && Balance >= amount)
        {
            DebitAmount(amount);
            toAccount.CreditAmount(amount);
        }
        else
        {
            throw new InvalidOperationException("Só é possível transferir para contas correntes do mesmo cliente.");
        }
    }

    public override void FazerPix(string chavePix, float amount)
    {
        throw new InvalidOperationException("Conta Poupança não pode fazer Pix.");
    }
}
