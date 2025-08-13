using System;
using FinanceManagementSystem.Interfaces;
using FinanceManagementSystem.Models;

namespace FinanceManagementSystem.Processors
{
    public class CryptoWalletProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine("[Crypto Wallet] Processed " + transaction.Amount.ToString("C") + " for " + transaction.Category);
        }
    }
}