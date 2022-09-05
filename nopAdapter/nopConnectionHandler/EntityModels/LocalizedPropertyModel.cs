using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class LocalizedProperty
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string LocaleKeyGroup { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string LocaleKey { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string LocaleValue { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int LanguageId { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int EntityId { get; set; }

    }
}
