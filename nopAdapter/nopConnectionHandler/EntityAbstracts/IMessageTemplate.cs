using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IMessageTemplateRepository : IGenericRepo<MessageTemplate>
    {
        List<MessageTemplate> GetById(int value);

        List<MessageTemplate> GetByName(string value);

        List<MessageTemplate> GetByBccEmailAddresses(string value);

        List<MessageTemplate> GetBySubject(string value);

        List<MessageTemplate> GetByEmailAccountId(int value);

        List<MessageTemplate> GetByBody(string value);

        List<MessageTemplate> GetByIsActive(bool value);

        List<MessageTemplate> GetByDelayBeforeSend(Nullable<int> value);

        List<MessageTemplate> GetByDelayPeriodId(int value);

        List<MessageTemplate> GetByAttachedDownloadId(int value);

        List<MessageTemplate> GetByLimitedToStores(bool value);

    }
}
