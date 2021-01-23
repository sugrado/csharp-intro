using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personelCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();
            

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
            
            ApplicationManager applicationManager = new ApplicationManager();

            //applicationManager.MakeAnApplication(personelCreditManager, fileLoggerService);
            applicationManager.MakeAnApplication(new ArtisanLoanManager(), loggers);

            //applicationManager.MakeAnApplication(personelCreditManager, databaseLoggerService);
            //applicationManager.MakeAnApplication(mortgageLoanManager);
            //applicationManager.MakeAnApplication(transportCreditManager);

            List<ICreditManager> credits = new List<ICreditManager>() { personelCreditManager, transportCreditManager };
           // applicationManager.CreditPreNotification(credits);
        }
    }
}
