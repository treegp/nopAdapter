using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class RecurringPaymentHistoryRepository : GenericRepo<RecurringPaymentHistory> , IRecurringPaymentHistoryRepository
    {
        string conStr;
        public RecurringPaymentHistoryRepository(string connection) : base(connection) { conStr = connection; }

        public List<RecurringPaymentHistory> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RecurringPaymentHistory where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RecurringPaymentHistory> GetByRecurringPaymentId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RecurringPaymentHistory where [RecurringPaymentId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RecurringPaymentHistory> GetByOrderId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RecurringPaymentHistory where [OrderId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<RecurringPaymentHistory> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from RecurringPaymentHistory where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
