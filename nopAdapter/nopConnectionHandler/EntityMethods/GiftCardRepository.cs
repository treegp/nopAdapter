using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class GiftCardRepository : GenericRepo<GiftCard> , IGiftCardRepository
    {
        string conStr;
        public GiftCardRepository(string connection) : base(connection) { conStr = connection; }

        public List<GiftCard> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCard where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCard> GetByPurchasedWithOrderItemId(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCard where [PurchasedWithOrderItemId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCard> GetByGiftCardTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCard where [GiftCardTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCard> GetByAmount(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCard where [Amount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCard> GetByIsGiftCardActivated(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCard where [IsGiftCardActivated] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCard> GetByGiftCardCouponCode(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCard where [GiftCardCouponCode] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCard> GetByRecipientName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCard where [RecipientName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCard> GetByRecipientEmail(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCard where [RecipientEmail] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCard> GetBySenderName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCard where [SenderName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCard> GetBySenderEmail(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCard where [SenderEmail] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCard> GetByMessage(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCard where [Message] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCard> GetByIsRecipientNotified(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCard where [IsRecipientNotified] = @param1";
            return ExecutingReader(command, param);
        }

        public List<GiftCard> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from GiftCard where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
