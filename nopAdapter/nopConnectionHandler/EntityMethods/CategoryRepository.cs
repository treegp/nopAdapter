using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class CategoryRepository : GenericRepo<Category> , ICategoryRepository
    {
        string conStr;
        public CategoryRepository(string connection) : base(connection) { conStr = connection; }

        public List<Category> GetById(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [Id] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [Name] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByMetaKeywords(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [MetaKeywords] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByMetaTitle(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [MetaTitle] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByPageSizeOptions(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [PageSizeOptions] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [Description] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByCategoryTemplateId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [CategoryTemplateId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByMetaDescription(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [MetaDescription] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByParentCategoryId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [ParentCategoryId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByPictureId(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [PictureId] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByPageSize(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [PageSize] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByAllowCustomersToSelectPageSize(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [AllowCustomersToSelectPageSize] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByShowOnHomepage(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [ShowOnHomepage] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByIncludeInTopMenu(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [IncludeInTopMenu] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetBySubjectToAcl(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [SubjectToAcl] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByLimitedToStores(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [LimitedToStores] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByPublished(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [Published] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByDeleted(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [Deleted] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByDisplayOrder(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [DisplayOrder] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByCreatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [CreatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByUpdatedOnUtc(DateTime value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [UpdatedOnUtc] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByPriceRangeFiltering(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [PriceRangeFiltering] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByPriceFrom(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [PriceFrom] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByPriceTo(decimal value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [PriceTo] = @param1";
            return ExecutingReader(command, param);
        }

        public List<Category> GetByManuallyPriceRange(bool value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from Category where [ManuallyPriceRange] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
