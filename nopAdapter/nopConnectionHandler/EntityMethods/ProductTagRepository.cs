using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ProductTagRepository : GenericRepo<ProductTag> , IProductTagRepository
    {
        string conStr;
        public ProductTagRepository(string connection) : base(connection) { conStr = connection; }

        public List<ProductTag> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductTag where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductTag> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductTag where [Name] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
