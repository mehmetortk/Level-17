using System;
using System.Collections.Generic;

namespace Level_17
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditBaseManager credit1 = new ResidenceCreditManager();
            ICreditBaseManager credit2 = new VehicleCreditManager();
            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.Application(credit2);
            ILog log1 = new Database();
            ILog log2 = new System();
            ILog log3 = new Message();
            List<ICreditBaseManager> creditBaseManagers = new List<ICreditBaseManager>(){ credit1};
            List<ILog> Logss = new List<ILog>(){log3,log1,log2};
            applicationManager.CreditPreInformation(creditBaseManagers,Logss );

        }


    }
}
