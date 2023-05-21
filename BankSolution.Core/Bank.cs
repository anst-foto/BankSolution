using BankSolution.Logger;

namespace BankSolution.Core;

public class Bank
{
    private ILogger? _logger;
    public List<Account> Accounts { get; init; }

    public Bank()
    {
        Accounts = new List<Account>();
        _logger = null;
    }

    public void CreateAccount(Person person, double money = 0, ILogger? logger = null)
    {
        Accounts.Add(new Account(person, money, logger));
        _logger?.LogInfo($"Аккаунт создан - {person}");
    }

    public IEnumerable<Account> FindAllByName(string name)
    {
        /*var list = new List<Account>();
        foreach (var account in Accounts)
        {
            if (account.Person.FirstName == name || account.Person.LastName == name)
            {
                list.Add(account);
            }
        }

        return list;*/
        foreach (var account in Accounts)
        {
            if (account.Person.FirstName == name || account.Person.LastName == name)
            {
                yield return account;
            }
        }
    }

    public Account FindById(Guid id)
    {
        foreach (var account in Accounts)
        {
            if (account.Id == id)
            {
                return account;
            }
        }
        
        _logger?.LogError($"Счёт {id:B} не найден");
        throw new InvalidDataException($"Счёт {id:B} не найден");
    }
    
    public void AddLogger(ILogger logger)
    {
        _logger = logger;
    }
}