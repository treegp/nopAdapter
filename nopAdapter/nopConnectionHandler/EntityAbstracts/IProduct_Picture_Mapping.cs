using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProduct_Picture_MappingRepository : IGenericRepo<Product_Picture_Mapping>
    {
        List<Product_Picture_Mapping> GetById(int value);

        List<Product_Picture_Mapping> GetByPictureId(int value);

        List<Product_Picture_Mapping> GetByProductId(int value);

        List<Product_Picture_Mapping> GetByDisplayOrder(int value);

    }
}
