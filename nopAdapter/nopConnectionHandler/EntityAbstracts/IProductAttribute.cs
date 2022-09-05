using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProductAttributeRepository : IGenericRepo<ProductAttribute>
    {
        List<ProductAttribute> GetById(int value);

        List<ProductAttribute> GetByName(string value);

        List<ProductAttribute> GetByDescription(string value);

    }
}
