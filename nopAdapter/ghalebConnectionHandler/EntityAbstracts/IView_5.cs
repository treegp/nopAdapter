using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IView_5Repository : IGenericRepo<View_5>
    {
        List<View_5> GetByGhalebID(int value);

        List<View_5> GetByGhalebType(byte value);

        List<View_5> GetByMalelkiatGhaleb(string value);

        List<View_5> GetByGhalebName(string value);

        List<View_5> GetByPicture_Ghaleb(byte[] value);

        List<View_5> GetBypicture_gheteh(byte[] value);

        List<View_5> GetByLength(string value);

        List<View_5> GetByWidth(string value);

        List<View_5> GetByHeigth(string value);

        List<View_5> GetByEnhesari(byte value);

        List<View_5> GetByGhalebCode(string value);

        List<View_5> GetByCartoonNumber(string value);

        List<View_5> GetByLayehCount(string value);

        List<View_5> GetByGhetehCount(string value);

        List<View_5> GetByCartoonType(byte value);

        List<View_5> GetByPimCount(string value);

        List<View_5> GetByWeigth(string value);

        List<View_5> GetByTaeediehMoshtari(byte value);

        List<View_5> GetBySite(byte value);

        List<View_5> GetByGhotr(string value);

        List<View_5> GetByGhalebCodKhareji(string value);

        List<View_5> GetByTozihat(string value);

        List<View_5> GetByTarz_Dast(string value);

        List<View_5> GetByDast(string value);

        List<View_5> GetByGhatePalet(string value);

        List<View_5> GetByWeigthIn(string value);

        List<View_5> GetByGhotrIn(string value);

        List<View_5> GetByCount_Tasbit(string value);

        List<View_5> GetByCreater_Ghaleb(string value);

        List<View_5> GetByGhotrTasbit(string value);

        List<View_5> GetByHeigthTasbit(string value);

        List<View_5> GetBytolid_Anboh(Nullable<byte> value);

        List<View_5> GetBytarikh(string value);

        List<View_5> GetByExpr1(string value);

        List<View_5> GetByExpr2(byte value);

        List<View_5> GetByGhotrPim(string value);

        List<View_5> GetByHeigthPim(string value);

        List<View_5> GetByFarsi_CartoonType(string value);

        List<View_5> GetByFarsiTaeedieh(string value);

        List<View_5> GetByFarsiSite(string value);

        List<View_5> GetByFarsi_tolid_Anboh(string value);

        List<View_5> GetByLength1(Nullable<double> value);

        List<View_5> GetByWidth1(Nullable<double> value);

        List<View_5> GetByHeigth1(Nullable<double> value);

        List<View_5> GetByGhotr1(Nullable<double> value);

        List<View_5> GetByWeigth1(Nullable<double> value);

        List<View_5> GetByExpr3(byte value);

        List<View_5> GetByFarsi_Enhesari(string value);

        List<View_5> GetByFarsi_GhlebType(string value);

        List<View_5> GetByExpr4(string value);

        List<View_5> GetByFarsi_pimType(string value);

        List<View_5> GetByweight_rahgah(string value);

    }
}
