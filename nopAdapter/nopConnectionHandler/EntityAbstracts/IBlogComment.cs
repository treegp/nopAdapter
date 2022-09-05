using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IBlogCommentRepository : IGenericRepo<BlogComment>
    {
        List<BlogComment> GetById(int value);

        List<BlogComment> GetByStoreId(int value);

        List<BlogComment> GetByCustomerId(int value);

        List<BlogComment> GetByBlogPostId(int value);

        List<BlogComment> GetByCommentText(string value);

        List<BlogComment> GetByIsApproved(bool value);

        List<BlogComment> GetByCreatedOnUtc(DateTime value);

    }
}
