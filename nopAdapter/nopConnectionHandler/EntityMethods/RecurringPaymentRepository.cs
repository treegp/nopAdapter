using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class RecurringPaymentRepository : GenericRepo<RecurringPayment> , IRecurringPaymentRepository
    {
        string conStr;
        public RecurringPaymentRepository(string connection) : base(connection) { conStr = connection; }

        public List<RecurringPayment> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RecurringPayment where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RecurringPayment> GetByInitialOrderId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RecurringPayment where [InitialOrderId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RecurringPayment> GetByCycleLength(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RecurringPayment where [CycleLength] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RecurringPayment> GetByCyclePeriodId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RecurringPayment where [CyclePeriodId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RecurringPayment> GetByTotalCycles(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RecurringPayment where [TotalCycles] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RecurringPayment> GetByStartDateUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RecurringPayment where [StartDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RecurringPayment> GetByIsActive(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RecurringPayment where [IsActive] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RecurringPayment> GetByLastPaymentFailed(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RecurringPayment where [LastPaymentFailed] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RecurringPayment> GetByDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RecurringPayment where [Deleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RecurringPayment> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RecurringPayment where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
