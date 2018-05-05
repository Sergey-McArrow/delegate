using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{

    public class Account
    {
        public delegate void AccountStateHandler(string message);

        AccountStateHandler stateHandler;

        private int sum;
        public Account(int sum)
        {
            this.sum = sum;
        }
        public int CurrentSum => sum;

        public void RegisterHandler(AccountStateHandler handler)
        {
            this.stateHandler = handler;
        }
        public void Put(int sum)
        {
            this.sum += sum;
            this.stateHandler.Invoke($"{sum} was aded on you account");
        }
        public void WithDraw(int sum)
        {
            if (sum <= this.sum)
            {
                this.sum -= sum;
                this.stateHandler.Invoke($"{sum} was withdrawed");
            }
            else
                stateHandler.Invoke("You have don't enough money");
        }

    }
}
