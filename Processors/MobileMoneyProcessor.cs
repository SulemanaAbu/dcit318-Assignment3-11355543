using System;
using FinanceManagementSystem.Interfaces;
using FinanceManagementSystem.Models;

namespace FinanceManagementSystem.Processors
{
    public class MobileMoneyProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine("[Mobile Money] Processed " + transaction.Amount.ToString("C") + " for " + transaction.Category);
        }
    }
}