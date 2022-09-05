using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ReturnRequestReasonRepository : GenericRepo<ReturnRequestReason> , IReturnRequestReasonRepository
    {
        string conStr;
        public ReturnRequestReasonRepository(string connection) : base(connection) { conStr = connection; }

        public List<ReturnRequestReason> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequestReason where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequestReason> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequestReason where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequestReason> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequestReason where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
