namespace TransportCard;

using System;

public class TransportCard
{
    private int balance = 0;
    public delegate void TransportCardEventHandler(string message);

    public event TransportCardEventHandler TransportCardEvent;

    public void Replenish(int amount)
    {
        balance += amount;
        TransportCardEvent?.Invoke($"Card replenished with {amount} rubles. Current balance: {balance}");
    }

    public bool Payment()
    {
        if (balance >= 30)
        {
            balance -= 30;
            TransportCardEvent?.Invoke($"Payment of 30 rubles successful. Current balance: {balance}");
            return true;
        }
        else
        {
            TransportCardEvent?.Invoke("Not enough funds on the card");
            return false;
        }
    }

    public void AddPredicate(Func<int, bool> predicate)
    {
        if (predicate != null)
        {
            TransportCardEvent += message =>
            {
                if (predicate(balance))
                {
                    Console.WriteLine(message);
                }
            };
        }
    }

    public void AddCashbackFunc(Func<int, int> cashbackFunc)
    {
        if (cashbackFunc != null)
        {
            TransportCardEvent += message =>
            {
                int cashback = cashbackFunc(balance);
                if (cashback > 0)
                {
                    Console.WriteLine($"Cashback of {cashback} rubles. {message}");
                }
                else
                {
                    Console.WriteLine(message);
                }
            };
        }
    }

    public void AddPaymentHistory(Action<string> paymentHistoryFunc)
    {
        if (paymentHistoryFunc != null)
        {
            TransportCardEvent += message =>
            {
                paymentHistoryFunc($"{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")} - {message}");
            };
        }
    }
}
