using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class DiscountRequirementRepository : GenericRepo<DiscountRequirement> , IDiscountRequirementRepository
    {
        string conStr;
        public DiscountRequirementRepository(string connection) : base(connection) { conStr = connection; }

        public List<DiscountRequirement> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from DiscountRequirement where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<DiscountRequirement> GetByDiscountId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from DiscountRequirement where [DiscountId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<DiscountRequirement> GetByParentId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from DiscountRequirement where [ParentId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<DiscountRequirement> GetByDiscountRequirementRuleSystemName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from DiscountRequirement where [DiscountRequirementRuleSystemName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<DiscountRequirement> GetByInteractionTypeId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from DiscountRequirement where [InteractionTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<DiscountRequirement> GetByIsGroup(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from DiscountRequirement where [IsGroup] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
