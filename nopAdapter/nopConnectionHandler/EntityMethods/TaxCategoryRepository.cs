using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class TaxCategoryRepository : GenericRepo<TaxCategory> , ITaxCategoryRepository
    {
        string conStr;
        public TaxCategoryRepository(string connection) : base(connection) { conStr = connection; }

        public List<TaxCategory> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TaxCategory where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TaxCategory> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TaxCategory where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<TaxCategory> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from TaxCategory where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
