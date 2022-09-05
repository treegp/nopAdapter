using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IReviewTypeRepository : IGenericRepo<ReviewType>
    {
        List<ReviewType> GetById(int value);

        List<ReviewType> GetByName(string value);

        List<ReviewType> GetByDescription(string value);

        List<ReviewType> GetByDisplayOrder(int value);

        List<ReviewType> GetByVisibleToAllCustomers(bool value);

        List<ReviewType> GetByIsRequired(bool value);

    }
}
