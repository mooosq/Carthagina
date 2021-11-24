using System;
using System.Collections.Generic;
using Carthagina.Core.Models;

namespace Carthagina.Core.Reports.Interfaces
{
    public interface IReportGenerator
    {
        AverageForTransactionsInGivenDate GetDailyTransactionsReport(Date date);
        CustomerTransactions GetCustomerTransactions(int customerId);
        DailyProductsReport GetDailyProductReport(int productId, Date date);
    }
}