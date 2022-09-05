using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProduct_ProductTag_MappingRepository : IGenericRepo<Product_ProductTag_Mapping>
    {
        List<Product_ProductTag_Mapping> GetByProduct_Id(int value);

        List<Product_ProductTag_Mapping> GetByProductTag_Id(int value);

    }
}
