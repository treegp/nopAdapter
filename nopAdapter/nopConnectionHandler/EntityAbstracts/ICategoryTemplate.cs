using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICategoryTemplateRepository : IGenericRepo<CategoryTemplate>
    {
        List<CategoryTemplate> GetById(int value);

        List<CategoryTemplate> GetByName(string value);

        List<CategoryTemplate> GetByViewPath(string value);

        List<CategoryTemplate> GetByDisplayOrder(int value);

    }
}
