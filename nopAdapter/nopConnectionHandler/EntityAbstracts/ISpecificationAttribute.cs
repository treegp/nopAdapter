using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ISpecificationAttributeRepository : IGenericRepo<SpecificationAttribute>
    {
        List<SpecificationAttribute> GetById(int value);

        List<SpecificationAttribute> GetByName(string value);

        List<SpecificationAttribute> GetBySpecificationAttributeGroupId(Nullable<int> value);

        List<SpecificationAttribute> GetByDisplayOrder(int value);

    }
}
