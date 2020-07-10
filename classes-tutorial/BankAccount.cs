using System;
using System.Collections.Generic;
namespace classes_tutorial
{
  public class BankAccount
  {
    private static int accountNumberSeed = 1234567890;

    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance {
      get {
        decimal balance = 0;
        foreach (Transaction transaction in allTransactions) {
          balance += transaction.Amount;
        }
        return balance;
      }
    }
    public List<Transaction> allTransactions = new List<Transaction>();
    public string GetAccountHistory() {
      var report = new System.Text.StringBuilder();

      decimal balance = 0;
      report.AppendLine("Date\t\t\tAmount\tBalance\tNotes");
      foreach (var trans in allTransactions) {
        balance += trans.Amount;
        report.AppendLine($"{trans.Date}\t{trans.Amount}\t{balance}\t{trans.Notes}");
      }
      return report.ToString();
    }
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
      if (amount <= 0) {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
      }
      var deposit = new Transaction(amount, date, note);
      allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
      if (amount <= 0)
      {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
      }
      if (Balance - amount < 0)
      {
        throw new InvalidOperationException("Insufficient funds for this withdrawal.");
      }
      var withdrawal = new Transaction(-amount, date, note);
      allTransactions.Add(withdrawal);
    }
    public BankAccount(string name, decimal balance)
    {
      this.Owner = name;
      this.Number = accountNumberSeed.ToString();
      accountNumberSeed++;
      MakeDeposit(balance, DateTime.Now, "Initial Balance");
    }
  }

}
