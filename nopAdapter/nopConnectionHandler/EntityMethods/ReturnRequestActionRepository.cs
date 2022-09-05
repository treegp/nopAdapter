using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ReturnRequestActionRepository : GenericRepo<ReturnRequestAction> , IReturnRequestActionRepository
    {
        string conStr;
        public ReturnRequestActionRepository(string connection) : base(connection) { conStr = connection; }

        public List<ReturnRequestAction> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequestAction where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequestAction> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequestAction where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReturnRequestAction> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReturnRequestAction where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
