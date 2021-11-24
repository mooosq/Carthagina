using System;
using Carthagina.Core;
using Carthagina.Core.Models;
using Carthagina.Core.Reports;

namespace Carthagina
{
    class Program
    {
        static void Main(string[] args)
        {
            Startup.StartupProcess();

            var reportGenerator = new ReportGenerator();

            var customerTransactions = reportGenerator.GetDailyTransactionsReport(new Date()
            {
                Day = 12,
                Month = 1,
                Year = 2021
            });

            Console.ReadKey();
        }
    }
}