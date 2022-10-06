using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Account
    {
        private int balance;
        private readonly String pin;
        private int status;

        public Account()
        {
            this.balance = 10000;
            this.pin = "123456";
            this.status = 1;
            ;
        }

        public void SetBalance(int balance)
        {
            this.balance = balance;
        }

        public int GetBalance()
        {
            return this.balance;
        }

        public String GetPin()
        {
            return this.pin;
        }

        public void SetStatus(int status)
        {
            this.status = status;
        }

        public int GetStatus()
        {
            return this.status;
        }
    }
}
