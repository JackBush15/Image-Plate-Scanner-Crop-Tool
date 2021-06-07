using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace CLF___Crop_Tool
{
    public partial class frmCropImg : Form
    {
        // ================================================= Setup: =================================================

        //Create file paths and directory info
        private static string imgFilePath = Application.StartupPath + @"\Store\Images\";
        private DirectoryInfo diImg = new DirectoryInfo(imgFilePath);

        //Counter Variables
        int imgNum;
        string imgName;

        // ----------------------------------------------------------------------------------------------------------

        // ---------------------------------------------- Load Form: ------------------------------------------------

        //Load Form
        public frmCropImg()
        {
            InitializeComponent();

            //Disable scroll buttons unill multiple crops taken
            btnNext.Enabled = false;
            btnPrev.Enabled = false;

            updateFrm();
        }

        // ----------------------------------------------------------------------------------------------------------

        // ---------------------------------------------- Load Crop: ------------------------------------------------

        //Load New Crop
        public void updateFrm()
        {
            imgNum = diImg.GetFiles().Count();//counts number of images
            picCrop.SizeMode = PictureBoxSizeMode.Zoom;

            openCrop(null, null);

            //enable crop cycle if multiple crops
            if (diImg.GetFiles().Count() >= 2)
            {
                btnNext.Enabled = true;
                btnPrev.Enabled = true;
            }
        }

        //Open Image
        private void openCrop (object sender, EventArgs e)
        {
            labelCropNum.Text = ("Crop Number: " + imgNum + " / " + diImg.GetFiles().Count());//display total number of crops

            imgName = diImg.EnumerateFiles().Select(f => f.Name).ElementAt(imgNum-1);

            var fs = File.OpenRead(imgFilePath + imgName); //Filestream solves erro when deleting
            picCrop.Image = Image.FromStream(fs);//Load Image from temp file
            fs.Close();
        }

        // ----------------------------------------------------------------------------------------------------------

        // ----------------------------------------- Cycle Through Crops: -------------------------------------------

        //Next Crop
        private void btnNext_Click(object sender, EventArgs e)
        {
            //Spillover            
            if (imgNum == diImg.GetFiles().Count())
            {
                imgNum = 1;
            }
            else
            {
                imgNum++;
            }

            openCrop(null, null);
        }

        //Previous Crop
        private void btnPrev_Click(object sender, EventArgs e)
        {
            //Spillover            
            if (imgNum == 1)
            {
                imgNum = diImg.GetFiles().Count();
            }
            else
            {
                imgNum--;
            }

            openCrop(null, null);
        }

        // ----------------------------------------------------------------------------------------------------------

        // --------------------------------------------- Delete Crops: -----------------------------------------------

        //Delete Crops
        private void btnDeleteCrop_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Delete This Image?\r\nThis Action Cannot Be Undone.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//alert message

            if (result == DialogResult.Yes)
            {
                File.Delete(imgFilePath + imgName);//Delete selected crop

                if (diImg.GetFiles().Count() == 0) //If the last crop deleted close form
                {
                    MessageBox.Show("All Images Deleted", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);//alert message
                    this.Close(); //close form
                }
                else 
                {
                    if (diImg.GetFiles().Count() == 1) //If only one crop remains turn off scroll buttons
                    {
                        btnNext.Enabled = false;
                        btnPrev.Enabled = false;
                    }

                    btnPrev_Click(null, null); //View previous crop
                }
            }
        }

        // ----------------------------------------------------------------------------------------------------------

        // ---------------------------------------------- Save Crops: -----------------------------------------------

        //Save Crops
        private void btnSaveCrop_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();//Open save dialog
            f.Filter = "TIFF(*.TIFF)|*.tiff|TIF(*.TIF)|*.tif";//filter for .tiff files

            if (f.ShowDialog() == DialogResult.OK)//If load was sucessful
            {
                Image Output = picCrop.Image; //save image in picCrop
                Output.Save(f.FileName);
            }
        }

        // ----------------------------------------------------------------------------------------------------------

        // ==========================================================================================================
    }
}