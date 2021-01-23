using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ConsultManager
    {
        public void Consult(ICrediBaseManager crediBaseManager , ILoggerService loggerService)
        {
            crediBaseManager.Calculate();
            loggerService.Log();
        }

        public void GivePreİnfo(List<ICrediBaseManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
