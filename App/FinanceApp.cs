using System;
using System.Collections.Generic;
using FinanceManagementSystem.Models;
using FinanceManagementSystem.Accounts;
using FinanceManagementSystem.Processors;

namespace FinanceManagementSystem.App
{
    public class FinanceApp
    {
        private List<Transaction> _transactions = new List<Transaction>();

        public void Run()
        {
            SavingsAccount account = new SavingsAccount("ACC123", 1000m);

            Transaction t1 = new Transaction(1, DateTime.Now, 100m, "Groceries");
            Transaction t2 = new Transaction(2, DateTime.Now, 200m, "Utilities");
            Transaction t3 = new Transaction(3, DateTime.Now, 50m, "Entertainment");

            MobileMoneyProcessor mobileMoneyProcessor = new MobileMoneyProcessor();
            BankTransferProcessor bankTransferProcessor = new BankTransferProcessor();
            CryptoWalletProcessor cryptoWalletProcessor = new CryptoWalletProcessor();

            mobileMoneyProcessor.Process(t1);
            account.ApplyTransaction(t1);
            _transactions.Add(t1);

            bankTransferProcessor.Process(t2);
            account.ApplyTransaction(t2);
            _transactions.Add(t2);

            cryptoWalletProcessor.Process(t3);
            account.ApplyTransaction(t3);
            _transactions.Add(t3);
        }
    }
}