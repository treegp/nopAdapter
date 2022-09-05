using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class SpecificationAttributeOptionRepository : GenericRepo<SpecificationAttributeOption> , ISpecificationAttributeOptionRepository
    {
        string conStr;
        public SpecificationAttributeOptionRepository(string connection) : base(connection) { conStr = connection; }

        public List<SpecificationAttributeOption> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SpecificationAttributeOption where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<SpecificationAttributeOption> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SpecificationAttributeOption where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<SpecificationAttributeOption> GetByColorSquaresRgb(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SpecificationAttributeOption where [ColorSquaresRgb] = @param1";
            return ExecutingReader(command, param);
        }

        public List<SpecificationAttributeOption> GetBySpecificationAttributeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SpecificationAttributeOption where [SpecificationAttributeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<SpecificationAttributeOption> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from SpecificationAttributeOption where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
