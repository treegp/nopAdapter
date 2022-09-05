using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class PictureBinary
    {
        [GenericRepoModel.Column(true,true, true)]
        public int Id { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public int PictureId { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public byte[] BinaryData { get; set; }

    }
}
