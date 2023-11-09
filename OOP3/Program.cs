namespace OOP3
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();

            ICreditManager vehicleCreditManager = new VehicleCreditManager();

            ICreditManager housingCreditManager = new HousingCreditManager();

            ICreditManager tradesmanCreditManager = new TradesmanCreditManager();
            
            ILoggerService databaseLoggerService = new DatabaseLoggerSevice();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            ApplicationManager applicationManager = new ApplicationManager();

            List<ILoggerService> loggerServices = new List<ILoggerService>()
            {databaseLoggerService,smsLoggerService };
            applicationManager.MakeApplication(tradesmanCreditManager, loggerServices);

            List<ICreditManager> credits = new List<ICreditManager>()
            {vehicleCreditManager,personalFinanceCreditManager};

            //applicationManager.ProvideCreditPreliminaryInformation(credits);

        }
    }
}