using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ReviewTypeRepository : GenericRepo<ReviewType> , IReviewTypeRepository
    {
        string conStr;
        public ReviewTypeRepository(string connection) : base(connection) { conStr = connection; }

        public List<ReviewType> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReviewType where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReviewType> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReviewType where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReviewType> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReviewType where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReviewType> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReviewType where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReviewType> GetByVisibleToAllCustomers(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReviewType where [VisibleToAllCustomers] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ReviewType> GetByIsRequired(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ReviewType where [IsRequired] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
