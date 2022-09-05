using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IProductReviewRepository : IGenericRepo<ProductReview>
    {
        List<ProductReview> GetById(int value);

        List<ProductReview> GetByCustomerId(int value);

        List<ProductReview> GetByProductId(int value);

        List<ProductReview> GetByStoreId(int value);

        List<ProductReview> GetByIsApproved(bool value);

        List<ProductReview> GetByTitle(string value);

        List<ProductReview> GetByReviewText(string value);

        List<ProductReview> GetByReplyText(string value);

        List<ProductReview> GetByCustomerNotifiedOfReply(bool value);

        List<ProductReview> GetByRating(int value);

        List<ProductReview> GetByHelpfulYesTotal(int value);

        List<ProductReview> GetByHelpfulNoTotal(int value);

        List<ProductReview> GetByCreatedOnUtc(DateTime value);

    }
}
