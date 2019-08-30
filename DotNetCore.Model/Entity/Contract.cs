using System;

namespace DotNetCore.Model
{
    public abstract class Contract
    {
        public int ContractId { get; set; }
        public DateTime StartDate { get; set; }
        public int Months { get; set; }
        public decimal Charge { get; set; }
    }

   
}
