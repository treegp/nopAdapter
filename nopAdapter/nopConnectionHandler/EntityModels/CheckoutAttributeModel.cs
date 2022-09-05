using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class CheckoutAttribute
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string TextPrompt { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsRequired { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool ShippableProductRequired { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsTaxExempt { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int TaxCategoryId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int AttributeControlTypeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool LimitedToStores { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> ValidationMinLength { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> ValidationMaxLength { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ValidationFileAllowedExtensions { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<int> ValidationFileMaximumSize { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string DefaultValue { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string ConditionAttributeXml { get; set; }

    }
}
