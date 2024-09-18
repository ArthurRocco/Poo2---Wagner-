using System;

public abstract class Account
{
    public int AccNumber { get; set; }
    public float Balance { get; set; }
    public DateTime OpeningDate { get; set; }

    public abstract void DebitAmount(float amount);
    public abstract void CreditAmount(float amount);
    public abstract void Render();
    public abstract void Transfer(Account toAccount, float amount);
    public abstract void FazerPix(string chavePix, float amount);

    public float GetBalance()
    {
        return Balance;
    }
}
