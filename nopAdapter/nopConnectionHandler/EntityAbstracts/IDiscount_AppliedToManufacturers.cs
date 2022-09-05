using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IDiscount_AppliedToManufacturersRepository : IGenericRepo<Discount_AppliedToManufacturers>
    {
        List<Discount_AppliedToManufacturers> GetByDiscount_Id(int value);

        List<Discount_AppliedToManufacturers> GetByManufacturer_Id(int value);

    }
}
