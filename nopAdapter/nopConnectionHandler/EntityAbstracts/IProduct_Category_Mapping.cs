using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProduct_Category_MappingRepository : IGenericRepo<Product_Category_Mapping>
    {
        List<Product_Category_Mapping> GetById(int value);

        List<Product_Category_Mapping> GetByCategoryId(int value);

        List<Product_Category_Mapping> GetByProductId(int value);

        List<Product_Category_Mapping> GetByIsFeaturedProduct(bool value);

        List<Product_Category_Mapping> GetByDisplayOrder(int value);

    }
}
