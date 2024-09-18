using System;

public class SalaryAccount : Account
{
    public override void DebitAmount(float amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
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
        throw new InvalidOperationException("Conta Salário não pode render.");
    }

    public override void FazerPix(string chavePix, float amount)
    {
        throw new InvalidOperationException("Conta Salário não pode fazer Pix.");
    }
}
