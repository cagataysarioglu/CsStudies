using System;
using System.Collections.Generic;

namespace OOPTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager consumerLoanManager = new ConsumerLoanManager();
            ILoanManager vehicleLoanManager = new VehicleLoanManager();
            ILoanManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService dbLoggerService = new FileLoggerService();
            ILoggerService fLoggerService = new DatabaseLoggerService();

            AppealManager appealManager = new AppealManager();
            appealManager.Appeal(consumerLoanManager, new DatabaseLoggerService()); // İçeride yenileyip de verebiliriz.

            List<ILoanManager> loans = new List<ILoanManager>() { vehicleLoanManager, consumerLoanManager };
            //appealManager.LoanPreAdvice(loans);
        }
    }
}
