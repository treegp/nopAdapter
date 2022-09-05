using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IGiftCardRepository : IGenericRepo<GiftCard>
    {
        List<GiftCard> GetById(int value);

        List<GiftCard> GetByPurchasedWithOrderItemId(Nullable<int> value);

        List<GiftCard> GetByGiftCardTypeId(int value);

        List<GiftCard> GetByAmount(decimal value);

        List<GiftCard> GetByIsGiftCardActivated(bool value);

        List<GiftCard> GetByGiftCardCouponCode(string value);

        List<GiftCard> GetByRecipientName(string value);

        List<GiftCard> GetByRecipientEmail(string value);

        List<GiftCard> GetBySenderName(string value);

        List<GiftCard> GetBySenderEmail(string value);

        List<GiftCard> GetByMessage(string value);

        List<GiftCard> GetByIsRecipientNotified(bool value);

        List<GiftCard> GetByCreatedOnUtc(DateTime value);

    }
}
