using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_17
{
    class ApplicationManager
    {
        public void Application(ICreditBaseManager baseManager, ILog logger)
        {
            baseManager.Calculate();
            logger.Log();
        }

      
        public void CreditPreInformation(List<ICreditBaseManager> credits, List<ILog> logs)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
                
            }
            foreach (var log in logs)
            {
                log.Log();
            }
        }
        
    }
}
