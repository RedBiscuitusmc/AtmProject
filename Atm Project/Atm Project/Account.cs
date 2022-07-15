using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        public static decimal CheckingBalance { get; set; }
        private decimal SavingsBalance;
        public int AccountID { get; set; }
        public static int _pin { get; set; }
        public string getfirstName { get; set; }
        public string getlastName { get; set; }

        public decimal GetCheckingBalance()
        {
            return CheckingBalance;
        }
        public decimal GetSavingsBalance()
        {
            return SavingsBalance;
        }
        public decimal CheckingDeposite(decimal despoite)
        {
            return CheckingBalance += despoite++;
        }
        public decimal SavingDeposite(decimal despoite)
        {
            return SavingsBalance += despoite;
        }
        public decimal CheckingWithDraw(decimal despoite)
        {
            return CheckingBalance -= despoite;
        }
        public decimal SavingWithDraw(decimal despoite)
        {
            return SavingsBalance -= despoite;
        }
        public decimal readme()
        {
            return CheckingBalance;
        }
    }
}
