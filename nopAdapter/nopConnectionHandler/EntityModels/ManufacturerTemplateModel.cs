using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class ManufacturerTemplate
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Name { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string ViewPath { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int DisplayOrder { get; set; }

    }
}
