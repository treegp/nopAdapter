using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ProductAvailabilityRangeRepository : GenericRepo<ProductAvailabilityRange> , IProductAvailabilityRangeRepository
    {
        string conStr;
        public ProductAvailabilityRangeRepository(string connection) : base(connection) { conStr = connection; }

        public List<ProductAvailabilityRange> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAvailabilityRange where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAvailabilityRange> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAvailabilityRange where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAvailabilityRange> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAvailabilityRange where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
