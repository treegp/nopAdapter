using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProduct_Manufacturer_MappingRepository : IGenericRepo<Product_Manufacturer_Mapping>
    {
        List<Product_Manufacturer_Mapping> GetById(int value);

        List<Product_Manufacturer_Mapping> GetByManufacturerId(int value);

        List<Product_Manufacturer_Mapping> GetByProductId(int value);

        List<Product_Manufacturer_Mapping> GetByIsFeaturedProduct(bool value);

        List<Product_Manufacturer_Mapping> GetByDisplayOrder(int value);

    }
}
