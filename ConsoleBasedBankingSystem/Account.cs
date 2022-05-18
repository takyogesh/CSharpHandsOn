using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedBankingSystem
{
    public abstract class Account
    {
        public abstract void AccountDetails(String Name, int AcctNum,long PhNum, int Bal);
        public abstract int DepositAmt(int Amt);
        public abstract int WithdrawAmt(int Amt);
        public abstract String DisplayAccountDetails();
        public abstract void AtmRequest(Boolean request);
        public virtual Array TotalCustomerList()
        {
            //this methos store the list of custoner
            return null;
        }
    }

    public class CurrentAccount : Account
    {
        //inherite the account class
        string AccounttHolderName;
        long MobileNum;
        private int AccountNum;
        private int Balance;
        public ATM AtmObj;

        public override void AccountDetails(string Name, int AcctNum, long PhNum, int Bal)
        {
            AccounttHolderName= Name;
            AccountNum= AcctNum;
            Balance = Bal;
            MobileNum= PhNum;
        }

        public override int DepositAmt(int Amt)
        {
                Balance += Amt;
                return Balance;
        }
        public override int WithdrawAmt(int Amt)
        {
            if (Amt > 2000)   // if the amount is greater than 2000 then only withdraw
            {
                Balance -= Amt;
                return Balance;
            }
            else
            {
                Console.WriteLine("Amount to be withdraw not allowed");
                return Balance;
            }
        }
        public override void AtmRequest(Boolean request)
        {
            // when customer had request a atm card then this method call by manager by passing true
           //then only atm object creater
            if (request)
            {
                AtmObj = new ATM();
                //call setpassword method
               
            }
        }
        public override Array TotalCustomerList()
        {
            //return total current account customer list.
            //also fetch details of single customer.
            return null;
        }

        public override string DisplayAccountDetails()
        {
            return "Account Holder Name : " + AccounttHolderName + "Account Number : " + AccountNum +
                "Account Balance : " + Balance + "Mobile Number : " + MobileNum + "";
        }
    }

    public class SavingAccount: Account
    {
        String AccounttHolderName;
        private int AccountNum;
        long MobileNum;
        private int Balance;
        public ATM atm = null;

        public override void AccountDetails(string Name, int AcctNum, long PhNum, int Bal)
        {
            AccounttHolderName = Name;
            AccountNum = AcctNum;
            Balance = Bal;
            MobileNum = PhNum;
        }

        public override int DepositAmt(int Amt)
        {
            Balance += Amt;
            return Balance;
        }
        public override int WithdrawAmt(int Amt)
        {
            if (Amt > 500)
            {
                Balance -= Amt;
                return Balance;
            }
            else
            {
                Console.WriteLine("Amount to be withdraw not allowed");
                return Balance;
            }
        }
        public override void AtmRequest(Boolean request)
        {
            if (request)
            {
                atm = new ATM();
            }
        }
        public override Array TotalCustomerList()
        {
            //return total saving account customer list.
            //also fetch details of single customer.
            return null;
        }
        public override string DisplayAccountDetails()
        {
            return "Account Holder Name : " + AccounttHolderName + "Account Number : " + AccountNum +
                "Account Balance : " + Balance + "Mobile Number : " + MobileNum + "";
        }

       
    }
}
