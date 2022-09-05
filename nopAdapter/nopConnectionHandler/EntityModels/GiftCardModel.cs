using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class GiftCard
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> PurchasedWithOrderItemId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int GiftCardTypeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public decimal Amount { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsGiftCardActivated { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string GiftCardCouponCode { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string RecipientName { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string RecipientEmail { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string SenderName { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string SenderEmail { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Message { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsRecipientNotified { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public DateTime CreatedOnUtc { get; set; }

    }
}
