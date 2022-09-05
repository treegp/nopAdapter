using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface ICategoriesRepository : IGenericRepo<Categories>
    {
        List<Categories> GetById(int value);

        List<Categories> GetByTitle(string value);

        List<Categories> GetByParentCategoryId(Nullable<int> value);

    }
}
