using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IQueuedEmailRepository : IGenericRepo<QueuedEmail>
    {
        List<QueuedEmail> GetById(int value);

        List<QueuedEmail> GetByFrom(string value);

        List<QueuedEmail> GetByFromName(string value);

        List<QueuedEmail> GetByTo(string value);

        List<QueuedEmail> GetByToName(string value);

        List<QueuedEmail> GetByReplyTo(string value);

        List<QueuedEmail> GetByReplyToName(string value);

        List<QueuedEmail> GetByCC(string value);

        List<QueuedEmail> GetByBcc(string value);

        List<QueuedEmail> GetBySubject(string value);

        List<QueuedEmail> GetByEmailAccountId(int value);

        List<QueuedEmail> GetByPriorityId(int value);

        List<QueuedEmail> GetByBody(string value);

        List<QueuedEmail> GetByAttachmentFilePath(string value);

        List<QueuedEmail> GetByAttachmentFileName(string value);

        List<QueuedEmail> GetByAttachedDownloadId(int value);

        List<QueuedEmail> GetByCreatedOnUtc(DateTime value);

        List<QueuedEmail> GetByDontSendBeforeDateUtc(Nullable<DateTime> value);

        List<QueuedEmail> GetBySentTries(int value);

        List<QueuedEmail> GetBySentOnUtc(Nullable<DateTime> value);

    }
}
