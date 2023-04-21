using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseBank_Modul_17
{
    public class CalculatorBank : ICalculatorAllView
    {
        AccountBank bank;

        public CalculatorBank(AccountBank _bank) { bank = _bank; }
        public void Calculate()
        {
            if (bank.Name == "Газпромбанк" && bank.BalanceOverdraft < 10000000000000)
            {
                bank.BalanceOverdraft += 20000000; 
            }
        }
    }
}
