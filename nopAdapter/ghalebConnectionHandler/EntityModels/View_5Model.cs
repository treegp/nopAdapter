using System;
namespace nopAdapter.EntityModels
{
    [GenericRepoModel.Table("dbo")]
    public class View_5
    {
        [GenericRepoModel.Column(true,false,false)]
        public int GhalebID { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public byte GhalebType { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string MalelkiatGhaleb { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string GhalebName { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public byte[] Picture_Ghaleb { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public byte[] picture_gheteh { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Length { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Width { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Heigth { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public byte Enhesari { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string GhalebCode { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string CartoonNumber { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string LayehCount { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string GhetehCount { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public byte CartoonType { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string PimCount { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Weigth { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public byte TaeediehMoshtari { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public byte Site { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Ghotr { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string GhalebCodKhareji { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Tozihat { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Tarz_Dast { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Dast { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string GhatePalet { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string WeigthIn { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string GhotrIn { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Count_Tasbit { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Creater_Ghaleb { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string GhotrTasbit { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string HeigthTasbit { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<byte> tolid_Anboh { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string tarikh { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public string Expr1 { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public byte Expr2 { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string GhotrPim { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string HeigthPim { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Farsi_CartoonType { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string FarsiTaeedieh { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string FarsiSite { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Farsi_tolid_Anboh { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<double> Length1 { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<double> Width1 { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<double> Heigth1 { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<double> Ghotr1 { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public Nullable<double> Weigth1 { get; set; }

        [GenericRepoModel.Column(true,false,false)]
        public byte Expr3 { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Farsi_Enhesari { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Farsi_GhlebType { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Expr4 { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string Farsi_pimType { get; set; }

        [GenericRepoModel.Column(false, false,false)]
        public string weight_rahgah { get; set; }

    }
}
