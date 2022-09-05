using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ISpecificationAttributeOptionRepository : IGenericRepo<SpecificationAttributeOption>
    {
        List<SpecificationAttributeOption> GetById(int value);

        List<SpecificationAttributeOption> GetByName(string value);

        List<SpecificationAttributeOption> GetByColorSquaresRgb(string value);

        List<SpecificationAttributeOption> GetBySpecificationAttributeId(int value);

        List<SpecificationAttributeOption> GetByDisplayOrder(int value);

    }
}
