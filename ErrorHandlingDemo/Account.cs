using System;
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

        public string Name { get => _name; set => _name = value; }
        public int AccountNumber { get => _accountNumber; }

        public Account(string name)
        {
            this._name = name;
            Random random = new Random();
            this._accountNumber = random.Next(100000000);

        }



    }
}
