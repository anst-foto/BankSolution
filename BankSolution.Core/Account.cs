using BankSolution.Logger;

namespace BankSolution.Core;

public class Account
{
    private ILogger? _logger;
    public Guid Id { get; init; }
    public Person Person { get; init; }
    public double Balance { get; private set; }

    public Account(Person person, double balance = 0, ILogger? logger = null)
    {
        Id = Guid.NewGuid();
        Person = person;
        Balance = balance;
        _logger = logger;
    }

    public void Deposit(double money)
    {
        if (money < 0)
        {
            if (_logger is not null)
            {
                _logger.LogError($"Попытка пополнения счёта на {money}");
            }
            return;
        }
        
        Balance += money;
        _logger?.LogInfo($"Пополнение счёта на {money}");
    }

    public void Withdraw(double money)
    {
        if (money < 0 || money > Balance)
        {
            _logger?.LogError($"Попытка снятия со счёта {money}");
            return;
        }

        Balance -= money;
        _logger?.LogInfo($"Снятие со счёта {money}");
    }

    public void AddLogger(ILogger logger)
    {
        _logger = logger;
    }
}