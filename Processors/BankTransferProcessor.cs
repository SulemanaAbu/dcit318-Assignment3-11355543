using System;
using FinanceManagementSystem.Interfaces;
using FinanceManagementSystem.Models;

namespace FinanceManagementSystem.Processors
{
    public class BankTransferProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine("[Bank Transfer] Processed " + transaction.Amount.ToString("C") + " for " + transaction.Category);
        }
    }
}