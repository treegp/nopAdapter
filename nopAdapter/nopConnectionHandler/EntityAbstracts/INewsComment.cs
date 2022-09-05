using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface INewsCommentRepository : IGenericRepo<NewsComment>
    {
        List<NewsComment> GetById(int value);

        List<NewsComment> GetByCustomerId(int value);

        List<NewsComment> GetByNewsItemId(int value);

        List<NewsComment> GetByStoreId(int value);

        List<NewsComment> GetByCommentTitle(string value);

        List<NewsComment> GetByCommentText(string value);

        List<NewsComment> GetByIsApproved(bool value);

        List<NewsComment> GetByCreatedOnUtc(DateTime value);

    }
}
