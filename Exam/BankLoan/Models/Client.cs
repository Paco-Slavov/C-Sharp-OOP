using BankLoan.Models.Contracts;
using BankLoan.Utilities.Messages;
using System;
using System.Collections.Generic;

namespace BankLoan.Models
{
    public abstract class Client : IClient
    {
        private string name;
        private string id;
        private int interest;
        private double income;
        private double income1;

        public Client(string name, string id, double income)
        {
            Name = name;
            Id = id;
            Income = income;
            Interest = interest;
        }

        public Client(string name, string id, double income, double income1) : this(name, id, income)
        {
            this.income1 = income1;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.ClientNameNullOrWhitespace));
                }
                name = value;
            }
        }

        public string Id
        {
            get => id;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.ClientIdNullOrWhitespace));
                }
                id = value;
            }
        }

        public int Interest
        {
            get => interest;
            protected set => Interest = value;
        }

        public double Income
        {
            get => income;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.ClientIncomeBelowZero));
                }
            }
        }

        public abstract void IncreaseInterest();
    }
}
