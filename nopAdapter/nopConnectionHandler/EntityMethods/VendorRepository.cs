using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class VendorRepository : GenericRepo<Vendor> , IVendorRepository
    {
        string conStr;
        public VendorRepository(string connection) : base(connection) { conStr = connection; }

        public List<Vendor> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByEmail(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [Email] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByMetaKeywords(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [MetaKeywords] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByMetaTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [MetaTitle] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByPageSizeOptions(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [PageSizeOptions] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByPictureId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [PictureId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByAddressId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [AddressId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByAdminComment(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [AdminComment] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByActive(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [Active] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [Deleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByMetaDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [MetaDescription] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByPageSize(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [PageSize] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByAllowCustomersToSelectPageSize(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [AllowCustomersToSelectPageSize] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByPriceRangeFiltering(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [PriceRangeFiltering] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByPriceFrom(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [PriceFrom] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByPriceTo(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [PriceTo] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Vendor> GetByManuallyPriceRange(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Vendor where [ManuallyPriceRange] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
