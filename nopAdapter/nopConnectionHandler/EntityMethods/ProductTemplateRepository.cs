using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ProductTemplateRepository : GenericRepo<ProductTemplate> , IProductTemplateRepository
    {
        string conStr;
        public ProductTemplateRepository(string connection) : base(connection) { conStr = connection; }

        public List<ProductTemplate> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductTemplate where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductTemplate> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductTemplate where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductTemplate> GetByViewPath(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductTemplate where [ViewPath] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductTemplate> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductTemplate where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<ProductTemplate> GetByIgnoredProductTypes(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from ProductTemplate where [IgnoredProductTypes] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
