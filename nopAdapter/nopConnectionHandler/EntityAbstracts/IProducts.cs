using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProductsRepository : IGenericRepo<Products>
    {
        List<Products> GetById(int value);

        List<Products> GetByTitle(string value);

        List<Products> GetByCategoryId(int value);

        List<Products> GetByPrice(decimal value);

    }
}
