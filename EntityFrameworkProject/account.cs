//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class account
    {
        public int ID { get; set; }
        public string accountNum { get; set; }
        public string branchName { get; set; }
        public string city { get; set; }

        public account(int iD, string accountNum, string branchName, string city)
        {
            ID = iD;
            this.accountNum = accountNum;
            this.branchName = branchName;
            this.city = city;
        }

        public account()
        { }
        public override string ToString()
        {
            return "" + ID + " " + accountNum + " " + branchName + " " + city + "";
        }
    }
}
