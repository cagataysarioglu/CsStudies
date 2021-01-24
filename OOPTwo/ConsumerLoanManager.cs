using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTwo
{
    class ConsumerLoanManager : ILoanManager
    {
        public void Calculate()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı yansıtıldı.");
        }
    }
}
