using System;

namespace FinanceManagementSystem.Models
{
    public class Transaction
    {
        public int Id { get; }
        public DateTime Date { get; }
        public decimal Amount { get; }
        public string Category { get; }

        public Transaction(int id, DateTime date, decimal amount, string category)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Category = category;
        }
    }
}