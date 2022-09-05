using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProductTagRepository : IGenericRepo<ProductTag>
    {
        List<ProductTag> GetById(int value);

        List<ProductTag> GetByName(string value);

    }
}
