using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class SpecificationAttributeRepository : GenericRepo<SpecificationAttribute> , ISpecificationAttributeRepository
    {
        string conStr;
        public SpecificationAttributeRepository(string connection) : base(connection) { conStr = connection; }

        public List<SpecificationAttribute> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SpecificationAttribute where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<SpecificationAttribute> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SpecificationAttribute where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<SpecificationAttribute> GetBySpecificationAttributeGroupId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SpecificationAttribute where [SpecificationAttributeGroupId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<SpecificationAttribute> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SpecificationAttribute where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
