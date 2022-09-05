using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IDiscountRequirementRepository : IGenericRepo<DiscountRequirement>
    {
        List<DiscountRequirement> GetById(int value);

        List<DiscountRequirement> GetByDiscountId(int value);

        List<DiscountRequirement> GetByParentId(Nullable<int> value);

        List<DiscountRequirement> GetByDiscountRequirementRuleSystemName(string value);

        List<DiscountRequirement> GetByInteractionTypeId(Nullable<int> value);

        List<DiscountRequirement> GetByIsGroup(bool value);

    }
}
