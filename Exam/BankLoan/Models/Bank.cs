using BankLoan.Models.Contracts;
using BankLoan.Repositories;
using BankLoan.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankLoan.Models
{
    public abstract class Bank : IBank
    {
        private string name;
        private int capacity;
        private LoanRepository loans;
        private readonly List<IClient> clients;

        public Bank(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            loans = new LoanRepository();
            clients = new List<IClient>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.BankNameNullOrWhiteSpace));
                }
                name = value;
            }
        }

        public int Capacity
        {
            get => capacity;
            private set => capacity = value;
        }
        public IReadOnlyCollection<ILoan> Loans => loans.Models;

        public IReadOnlyCollection<IClient> Clients => clients.AsReadOnly();

        public void AddClient(IClient Client)
        {
            if (Capacity > clients.Count)
            {
                clients.Add(Client);
            }
            else
            {
                throw new ArgumentException(string.Format("Not enough capacity for this client."));
            }
        }

        public void AddLoan(ILoan loan)
        {
            loans.AddModel((Models.Loan)loan);
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}, Type: {GetType().Name}");
            string clientsList = "none";
            if (clients.Any())
            {
                Queue<string> names = new();
                foreach (var client in clients)
                {
                    names.Enqueue(client.Name);
                }
                clientsList = string.Join(", ", names);
            }
            sb.AppendLine($"Clients: {clientsList}");
            sb.AppendLine($"Loans: {Loans.Count}, Sum of Rates: {(int)SumRates()}");
            return sb.ToString().TrimEnd();
        }

        public void RemoveClient(IClient Client)
        {
            clients.Remove(Client);
        }

        public double SumRates()
        {
            double result = 0;
            foreach (var loan in Loans)
            {
                result += loan.InterestRate;
            }
            return Math.Round(result, 2);
        }
    }
}
