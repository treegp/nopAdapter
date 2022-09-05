using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ProductAttributeRepository : GenericRepo<ProductAttribute> , IProductAttributeRepository
    {
        string conStr;
        public ProductAttributeRepository(string connection) : base(connection) { conStr = connection; }

        public List<ProductAttribute> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttribute where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttribute> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttribute where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductAttribute> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductAttribute where [Description] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
