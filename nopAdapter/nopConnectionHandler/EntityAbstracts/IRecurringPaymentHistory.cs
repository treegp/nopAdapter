using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IRecurringPaymentHistoryRepository : IGenericRepo<RecurringPaymentHistory>
    {
        List<RecurringPaymentHistory> GetById(int value);

        List<RecurringPaymentHistory> GetByRecurringPaymentId(int value);

        List<RecurringPaymentHistory> GetByOrderId(int value);

        List<RecurringPaymentHistory> GetByCreatedOnUtc(DateTime value);

    }
}
