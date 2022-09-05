using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IRecurringPaymentRepository : IGenericRepo<RecurringPayment>
    {
        List<RecurringPayment> GetById(int value);

        List<RecurringPayment> GetByInitialOrderId(int value);

        List<RecurringPayment> GetByCycleLength(int value);

        List<RecurringPayment> GetByCyclePeriodId(int value);

        List<RecurringPayment> GetByTotalCycles(int value);

        List<RecurringPayment> GetByStartDateUtc(DateTime value);

        List<RecurringPayment> GetByIsActive(bool value);

        List<RecurringPayment> GetByLastPaymentFailed(bool value);

        List<RecurringPayment> GetByDeleted(bool value);

        List<RecurringPayment> GetByCreatedOnUtc(DateTime value);

    }
}
