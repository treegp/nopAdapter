using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProductTemplateRepository : IGenericRepo<ProductTemplate>
    {
        List<ProductTemplate> GetById(int value);

        List<ProductTemplate> GetByName(string value);

        List<ProductTemplate> GetByViewPath(string value);

        List<ProductTemplate> GetByDisplayOrder(int value);

        List<ProductTemplate> GetByIgnoredProductTypes(string value);

    }
}
