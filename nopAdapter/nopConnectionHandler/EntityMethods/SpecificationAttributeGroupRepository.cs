using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class SpecificationAttributeGroupRepository : GenericRepo<SpecificationAttributeGroup> , ISpecificationAttributeGroupRepository
    {
        string conStr;
        public SpecificationAttributeGroupRepository(string connection) : base(connection) { conStr = connection; }

        public List<SpecificationAttributeGroup> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SpecificationAttributeGroup where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<SpecificationAttributeGroup> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SpecificationAttributeGroup where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<SpecificationAttributeGroup> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SpecificationAttributeGroup where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
