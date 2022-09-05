using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class ManufacturerRepository : GenericRepo<Manufacturer> , IManufacturerRepository
    {
        string conStr;
        public ManufacturerRepository(string connection) : base(connection) { conStr = connection; }

        public List<Manufacturer> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByMetaKeywords(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [MetaKeywords] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByMetaTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [MetaTitle] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByPageSizeOptions(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [PageSizeOptions] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByManufacturerTemplateId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [ManufacturerTemplateId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByMetaDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [MetaDescription] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByPictureId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [PictureId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByPageSize(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [PageSize] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByAllowCustomersToSelectPageSize(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [AllowCustomersToSelectPageSize] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetBySubjectToAcl(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [SubjectToAcl] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByLimitedToStores(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [LimitedToStores] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByPublished(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [Published] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [Deleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByUpdatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [UpdatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByPriceRangeFiltering(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [PriceRangeFiltering] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByPriceFrom(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [PriceFrom] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByPriceTo(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [PriceTo] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Manufacturer> GetByManuallyPriceRange(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Manufacturer where [ManuallyPriceRange] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
