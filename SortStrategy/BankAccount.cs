using System;

namespace SortStrategy
{
    public class BankAccount : IComparable<BankAccount>
    {
        public string AccountNo {get;set;}
        public decimal Balance {get;set;}
        public int CompareTo(BankAccount other)
        {
            if(this.Balance == other.Balance) return 0;
            if(this.Balance < other.Balance) return -1;
            return 1;
        }

        public override string ToString() => $"Account No: {AccountNo}, Balance: {Balance}";

    }



}
