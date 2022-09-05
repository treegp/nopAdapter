using System;
using System.Collections.Generic;
using nopAdapter.EntityMethods;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using nopAdapter.EntityModels;

namespace nopAdapterMain
{
    

    public partial class DataManagement : Form
    {
        public List<nopAdapter.EntityModels.View_5> DbGhaleb;
        public List<nopAdapter.EntityModels.Picture> DbPicture;
        private nopAdapter.EntityMethods.View_5Repository viewRepo = new View_5Repository("Data Source=192.168.0.2;Initial Catalog=Ghaleb;Integrated Security=False;User ID=it2;Password=123456");
        private nopAdapter.EntityMethods.PictureRepository pictRepo = new PictureRepository("Data Source=192.168.0.31;Initial Catalog=nop;Integrated Security=False;User ID=sa;Password=Sen@tor123124421321");
        private nopAdapter.EntityMethods.PictureBinaryRepository binaRepo = new PictureBinaryRepository("Data Source=192.168.0.31;Initial Catalog=nop;Integrated Security=False;User ID=sa;Password=Sen@tor123124421321");

        public DataManagement()
        {
            InitializeComponent();
            Text = "nop data adapter";

            
        }

        private void RunButton_Click(object sender, System.EventArgs e)
        {

            LogTextBox.Text = "";


            foreach (View_5 Ghaleb in DbGhaleb)
            {
                if (!DbPicture.Where(p => p.AltAttribute == Ghaleb.GhalebID.ToString()).Any())
                {
                    nopAdapter.EntityModels.Picture pic_p = new nopAdapter.EntityModels.Picture();
                    pic_p.MimeType = "image/jpeg";
                    pic_p.SeoFilename = "P-" + Ghaleb.GhalebCode + "-" + Ghaleb.GhalebID.ToString();
                    pic_p.AltAttribute = Ghaleb.GhalebID.ToString();
                    pic_p.TitleAttribute = "قطعه" + Ghaleb.GhalebCode + " " + Ghaleb.GhalebName;
                    pic_p.IsNew = false;
                    

                    var insertedPic_p = pictRepo.Insert(pic_p);

                    nopAdapter.EntityModels.PictureBinary picBinary_p = new PictureBinary();
                    picBinary_p.PictureId = insertedPic_p.Id;
                    picBinary_p.BinaryData = Ghaleb.picture_gheteh;

                    binaRepo.Insert(picBinary_p);
                    LogTextBox.Text += pic_p.TitleAttribute + Environment.NewLine;


                    nopAdapter.EntityModels.Picture pic_q = new nopAdapter.EntityModels.Picture();
                    pic_q.MimeType = "image/jpeg";
                    pic_q.SeoFilename = "q-" + Ghaleb.GhalebCode + "-" + Ghaleb.GhalebID.ToString();
                    pic_q.AltAttribute = Ghaleb.GhalebID.ToString();
                    pic_q.TitleAttribute = "قالب" + Ghaleb.GhalebCode + " " + Ghaleb.GhalebName;
                    pic_q.IsNew = false;

                    var insertedPic_q = pictRepo.Insert(pic_q);

                    nopAdapter.EntityModels.PictureBinary picBinary_q = new PictureBinary();
                    picBinary_q.PictureId = insertedPic_q.Id;
                    picBinary_q.BinaryData = Ghaleb.picture_gheteh;

                    binaRepo.Insert(picBinary_q);
                    LogTextBox.Text += pic_q.TitleAttribute + Environment.NewLine;



                }


            }


        }

        private void CatchButton_Click(object sender, System.EventArgs e)
        {
            DbGhaleb = viewRepo.GetAll();
            DbPicture = pictRepo.GetAll();

            MessageBox.Show("اطلاعات دریافت شد");
        }
    }












}
