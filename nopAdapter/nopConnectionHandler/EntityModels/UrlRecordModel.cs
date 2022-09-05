using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class UrlRecord
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string EntityName { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Slug { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int EntityId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public bool IsActive { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int LanguageId { get; set; }

    }
}
