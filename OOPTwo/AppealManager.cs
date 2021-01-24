using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTwo
{
    class AppealManager
    {
        public void Appeal(ILoanManager loanManager, ILoggerService loggerService)
        {
            loanManager.Print();
            loggerService.Log();
        }

        public void LoanPreAdvice(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Print();
            }
        }
    }
}
