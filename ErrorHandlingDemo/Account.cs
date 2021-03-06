﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingDemo
{
    class Account
    {
        private string _name;
        private int _accountNumber;
        private double _accountBalance;
        private List<double> _transactions;

        public string Name { get => _name; set => _name = value; }
        public int AccountNumber { get => _accountNumber; }
        public double AccountBalance { get => _accountBalance; }

        // note that I don't use a property for my transactions - I control access to those with my methods

        public Account(string name)
        {
            this._name = name;
            Random random = new Random();
            this._accountNumber = random.Next(100000000);
            this._accountBalance = 0;
            this._transactions = new List<double>();

        }

        public void DepositFunds(double deposit)
        {
            _transactions.Add(deposit);
            _accountBalance += deposit;
        }

        public double GetAccountBalance()
        {
            return _accountBalance;
        }

        public double FindTransaction(int position)
        {
            // EXAMPLE 2
            // return _transactions[position]; 

            // EXAMPLE 3
            double foundTransaction = 0;
            try
            {
                Console.WriteLine("Accessing account!");
                foundTransaction =  _transactions[position];
            }
            catch (Exception)
            {
                throw new ArgumentException("Transaction doesn't exist!");
              
            }
            finally
            {
                Console.WriteLine("Logged out of account. Thank you!");

            }

            return foundTransaction;
        }


    }
}
