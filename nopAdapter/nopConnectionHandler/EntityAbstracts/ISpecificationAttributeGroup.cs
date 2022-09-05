using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ISpecificationAttributeGroupRepository : IGenericRepo<SpecificationAttributeGroup>
    {
        List<SpecificationAttributeGroup> GetById(int value);

        List<SpecificationAttributeGroup> GetByName(string value);

        List<SpecificationAttributeGroup> GetByDisplayOrder(int value);

    }
}
