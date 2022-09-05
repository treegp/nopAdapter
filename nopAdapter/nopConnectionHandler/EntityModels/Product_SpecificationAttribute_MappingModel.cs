using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class Product_SpecificationAttribute_Mapping
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string CustomValue { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int ProductId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int SpecificationAttributeOptionId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int AttributeTypeId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool AllowFiltering { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool ShowOnProductPage { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

    }
}
