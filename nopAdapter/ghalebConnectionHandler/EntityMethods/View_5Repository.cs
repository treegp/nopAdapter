using nopAdapter.EntityAbstracts;
using nopAdapter.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace nopAdapter.EntityMethods
{
    public class View_5Repository : GenericRepo<View_5> , IView_5Repository
    {
        string conStr;
        public View_5Repository(string connection) : base(connection) { conStr = connection; }

        public List<View_5> GetByGhalebID(int value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [GhalebID] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByGhalebType(byte value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [GhalebType] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByMalelkiatGhaleb(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [MalelkiatGhaleb] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByGhalebName(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [GhalebName] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByPicture_Ghaleb(byte[] value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Picture_Ghaleb] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetBypicture_gheteh(byte[] value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [picture_gheteh] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByLength(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Length] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByWidth(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Width] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByHeigth(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Heigth] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByEnhesari(byte value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Enhesari] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByGhalebCode(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [GhalebCode] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByCartoonNumber(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [CartoonNumber] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByLayehCount(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [LayehCount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByGhetehCount(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [GhetehCount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByCartoonType(byte value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [CartoonType] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByPimCount(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [PimCount] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByWeigth(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Weigth] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByTaeediehMoshtari(byte value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [TaeediehMoshtari] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetBySite(byte value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Site] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByGhotr(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Ghotr] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByGhalebCodKhareji(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [GhalebCodKhareji] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByTozihat(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Tozihat] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByTarz_Dast(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Tarz_Dast] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByDast(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Dast] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByGhatePalet(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [GhatePalet] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByWeigthIn(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [WeigthIn] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByGhotrIn(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [GhotrIn] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByCount_Tasbit(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Count_Tasbit] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByCreater_Ghaleb(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Creater_Ghaleb] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByGhotrTasbit(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [GhotrTasbit] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByHeigthTasbit(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [HeigthTasbit] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetBytolid_Anboh(Nullable<byte> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [tolid_Anboh] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetBytarikh(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [tarikh] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByExpr1(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Expr1] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByExpr2(byte value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Expr2] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByGhotrPim(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [GhotrPim] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByHeigthPim(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [HeigthPim] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByFarsi_CartoonType(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Farsi_CartoonType] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByFarsiTaeedieh(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [FarsiTaeedieh] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByFarsiSite(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [FarsiSite] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByFarsi_tolid_Anboh(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Farsi_tolid_Anboh] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByLength1(Nullable<double> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Length1] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByWidth1(Nullable<double> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Width1] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByHeigth1(Nullable<double> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Heigth1] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByGhotr1(Nullable<double> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Ghotr1] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByWeigth1(Nullable<double> value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Weigth1] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByExpr3(byte value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Expr3] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByFarsi_Enhesari(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Farsi_Enhesari] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByFarsi_GhlebType(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Farsi_GhlebType] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByExpr4(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Expr4] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByFarsi_pimType(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [Farsi_pimType] = @param1";
            return ExecutingReader(command, param);
        }

        public List<View_5> GetByweight_rahgah(string value)
        {
            SqlParameter param = new SqlParameter("param1", value);
            string command = "select * from View_5 where [weight_rahgah] = @param1";
            return ExecutingReader(command, param);
        }
    }
}
