using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediBaseManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ICrediBaseManager transportCrediManager = new TransportCrediManager();
            ICrediBaseManager residinceCrediManager = new ResidinceCrediManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ICrediBaseManager esnafCrediManager = new EsnafKredisiManager();
            ILoggerService SMSLoggerService = new SMSLoggerService();



            ConsultManager consultManager = new ConsultManager();
            consultManager.Consult(esnafCrediManager, SMSLoggerService);

            List<ICrediBaseManager> credits = new List<ICrediBaseManager>() { transportCrediManager  };
            //consultManager.GivePreİnfo(credits);
        }
    }
}