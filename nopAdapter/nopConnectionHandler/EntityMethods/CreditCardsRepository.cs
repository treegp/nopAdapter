using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CreditCardsRepository : GenericRepo<CreditCards> , ICreditCardsRepository
    {
        string conStr;
        public CreditCardsRepository(string connection) : base(connection) { conStr = connection; }

        public List<CreditCards> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CreditCards where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CreditCards> GetByCardNumber(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CreditCards where [CardNumber] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CreditCards> GetByExpireDate(DateTimeOffset value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CreditCards where [ExpireDate] = @param1";
            return ExecutingReader(command, param);
        }

        public List<CreditCards> GetByCustomerId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from CreditCards where [CustomerId] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
