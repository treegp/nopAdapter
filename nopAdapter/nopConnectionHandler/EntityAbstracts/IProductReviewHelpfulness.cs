using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProductReviewHelpfulnessRepository : IGenericRepo<ProductReviewHelpfulness>
    {
        List<ProductReviewHelpfulness> GetById(int value);

        List<ProductReviewHelpfulness> GetByProductReviewId(int value);

        List<ProductReviewHelpfulness> GetByWasHelpful(bool value);

        List<ProductReviewHelpfulness> GetByCustomerId(int value);

    }
}
