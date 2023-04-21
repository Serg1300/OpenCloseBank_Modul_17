using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseBank_Modul_17
{
    public class CalculatorAccount:ICalculatorAllView
    {
        public Account account;
        public CalculatorAccount(Account _account) { account = _account;  }
        // Метод для расчета процентной ставки
        public void Calculate()
        {
            if (account.Type == "Обычный")
            {
                // расчет процентной ставки обычного аккаунта по правилам банка
                account.Interest = account.Balance * 0.4;

                if (account.Balance < 1000)
                    account.Interest -= account.Balance * 0.2;

                if (account.Balance < 50000)
                    account.Interest -= account.Balance * 0.4;
            }
            else if (account.Type == "Зарплатный")
            {
                // расчет процентной ставк зарплатного аккаунта по правилам банка
                account.Interest = account.Balance * 0.5;
            }
        }
    }
}
