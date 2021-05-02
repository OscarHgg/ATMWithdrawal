using System;
using System.Collections.Generic;

namespace ATMWithdrawal
{
    public class WithdrawalATM
    {
        public WithdrawalATM(List<int> bills)
        {
            Bills = bills;
        }

        List<int> Bills { get; set; }


        public int Withdraw(int amount)
        {
            int amountRemaining = amount;
            List<int> billsTobeRemoved = new List<int>();


            for (int i = 0; i < Bills.Count; i++)
            {
                int bill = Bills[i];

                if (amountRemaining >= bill)
                {
                    amountRemaining -= bill;
                    billsTobeRemoved.Add(bill);
                }

            }
            if (amountRemaining == 0)
            {
                foreach (var bill in billsTobeRemoved)
                {
                    Bills.Remove(bill);
                }
                return amount;
            }

            return -1;
        }
    }
}
