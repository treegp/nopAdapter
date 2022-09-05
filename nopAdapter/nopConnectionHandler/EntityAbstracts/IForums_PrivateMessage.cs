using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IForums_PrivateMessageRepository : IGenericRepo<Forums_PrivateMessage>
    {
        List<Forums_PrivateMessage> GetById(int value);

        List<Forums_PrivateMessage> GetBySubject(string value);

        List<Forums_PrivateMessage> GetByText(string value);

        List<Forums_PrivateMessage> GetByFromCustomerId(int value);

        List<Forums_PrivateMessage> GetByToCustomerId(int value);

        List<Forums_PrivateMessage> GetByStoreId(int value);

        List<Forums_PrivateMessage> GetByIsRead(bool value);

        List<Forums_PrivateMessage> GetByIsDeletedByAuthor(bool value);

        List<Forums_PrivateMessage> GetByIsDeletedByRecipient(bool value);

        List<Forums_PrivateMessage> GetByCreatedOnUtc(DateTime value);

    }
}
