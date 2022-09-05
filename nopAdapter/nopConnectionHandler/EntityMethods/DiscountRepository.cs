using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class DiscountRepository : GenericRepo<Discount> , IDiscountRepository
    {
        string conStr;
        public DiscountRepository(string connection) : base(connection) { conStr = connection; }

        public List<Discount> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByCouponCode(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [CouponCode] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByAdminComment(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [AdminComment] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByDiscountTypeId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [DiscountTypeId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByUsePercentage(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [UsePercentage] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByDiscountPercentage(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [DiscountPercentage] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByDiscountAmount(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [DiscountAmount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByMaximumDiscountAmount(Nullable<decimal> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [MaximumDiscountAmount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByStartDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [StartDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByEndDateUtc(Nullable<DateTime> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [EndDateUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByRequiresCouponCode(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [RequiresCouponCode] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByIsCumulative(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [IsCumulative] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByDiscountLimitationId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [DiscountLimitationId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByLimitationTimes(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [LimitationTimes] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByMaximumDiscountedQuantity(Nullable<int> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [MaximumDiscountedQuantity] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Discount> GetByAppliedToSubCategories(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Discount where [AppliedToSubCategories] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
