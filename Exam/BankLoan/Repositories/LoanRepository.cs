﻿using BankLoan.Models.Contracts;
using BankLoan.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace BankLoan.Repositories
{
    public class LoanRepository : IRepository<ILoan>
    {
        private readonly List<ILoan> loans;
        public LoanRepository()
        {
            loans = new List<ILoan>();
        }
        public IReadOnlyCollection<ILoan> Models => loans.AsReadOnly();

        public void AddModel(ILoan model)
        {
            loans.Add(model);
        }

        public ILoan FirstModel(string name) => loans.FirstOrDefault(x => x.GetType().Name == name);

        public bool RemoveModel(ILoan model) => loans.Remove(model);
    }
}
