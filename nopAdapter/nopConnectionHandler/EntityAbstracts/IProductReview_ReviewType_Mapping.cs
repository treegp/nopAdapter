using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProductReview_ReviewType_MappingRepository : IGenericRepo<ProductReview_ReviewType_Mapping>
    {
        List<ProductReview_ReviewType_Mapping> GetById(int value);

        List<ProductReview_ReviewType_Mapping> GetByProductReviewId(int value);

        List<ProductReview_ReviewType_Mapping> GetByReviewTypeId(int value);

        List<ProductReview_ReviewType_Mapping> GetByRating(int value);

    }
}
