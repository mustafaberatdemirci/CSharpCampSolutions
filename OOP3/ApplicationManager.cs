using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager 
    {
        
        public void MakeApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            
            creditManager.Calculate();
            foreach (ILoggerService loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void ProvideCreditPreliminaryInformation(List<ICreditManager> credits)
        {
            foreach (ICreditManager credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
