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
    public partial class frmLoadTemp : Form
    {
        // ================================================= Setup: =================================================

        //Create file paths and directory info
        private static string tempFilePath = Application.StartupPath + @"\Store\Templates\";
        private DirectoryInfo diTemp = new DirectoryInfo(tempFilePath);

        //Declare Crop Pen
        Pen tempPen = new Pen(Color.White);
        Graphics g;

        Bitmap bmpTemp;

        //New rectangle list
        public List<Rectangle> listRect = new List<Rectangle>();

        int tempNum = 0;
        string tempName;

        //create resize variables
        double R0, R1, M;
        int xd, yd;
        public Size tempImgSize = new Size(); //public to pass to frmLoadImg
        Size imgSize = new Size();
        Size imgPicSize = new Size();
        Size picSize = new Size();

        //bool test if load button pressed
        public bool bLoad = false; //public to pass to frmLoadImg

        //separate out CSV components
        string[] lines;
        string[] fields;


        // ----------------------------------------------------------------------------------------------------------

        // ---------------------------------------------- Load Form: ------------------------------------------------

        //Load Form
        public frmLoadTemp(Bitmap bmpIn)
        {
            InitializeComponent();

            //Colect Image Size from frmLoadImg
            bmpTemp = bmpIn;

            picLoadTemp.SizeMode = PictureBoxSizeMode.Zoom; //Fit image to picturebox
            picLoadTemp.Image = (Image)bmpTemp;

            tempNum = diTemp.GetFiles().Count() - 1;

            //enable crop cycle if multiple crops
            if (diTemp.GetFiles().Count() >= 2)
            {
                btnNext.Enabled = true;
                btnPrev.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
            }
        }

        //Resize form
        private void frmLoadTemp_Resize(object sender, EventArgs e)
        {
            picLoadTemp.Refresh();
            g = picLoadTemp.CreateGraphics();

            takeCVS(null, null);

            imgSize = bmpTemp.Size;
            picSize = picLoadTemp.Size;            
            R0 = (double)imgSize.Width / (double)imgSize.Height;
            R1 = (double)picSize.Width / (double)picSize.Height;

            if (R0 >= R1)
            {
                M = (double)picSize.Width / (double)imgSize.Width;
                imgPicSize.Width = picSize.Width;
                imgPicSize.Height = Convert.ToInt32(M * (double)imgSize.Height);
                yd = Convert.ToInt32(0.5d * (picSize.Height - imgPicSize.Height));
                xd = 0;
            }
            else if (R0 < R1)
            {
                M = (double)picSize.Height / (double)imgSize.Height;
                imgPicSize.Width = Convert.ToInt32(M * (double)imgSize.Width);
                imgPicSize.Height = picSize.Height;
                xd = Convert.ToInt32(0.5d * (picSize.Width - imgPicSize.Width));
                yd = 0;
            }

            displayTemplate(null, null);
        }

        //Take measurments from CVS
        private void takeCVS(object sender, EventArgs e)
        {
            //First template name         
            tempName = diTemp.EnumerateFiles().Select(f => f.Name).ElementAt(tempNum);

            //separate out CSV components
            lines = File.ReadAllLines(tempFilePath + tempName);
            fields = lines[0].Split(',');
            listRect.Clear();

            //define image size template was drawn on
            tempImgSize.Width = int.Parse(fields[0]);
            tempImgSize.Height = int.Parse(fields[1]);

            labelImgSize.Text = tempImgSize.Width + " x " + tempImgSize.Height;

            Rectangle rect = new Rectangle();

            //cycle through list
            for (int i = 1; i < lines.Length; i++)
            {
                fields = lines[i].Split(',');

                rect.X = int.Parse(fields[0]);
                rect.Y = int.Parse(fields[1]);
                rect.Width = int.Parse(fields[2]);
                rect.Height = int.Parse(fields[3]);

                listRect.Add(rect); // add all rectangles from template 1 to list
            }
        }

        //Display template
        private void displayTemplate(object sender, EventArgs e)
        {
            tempPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            //Refresh picturebox
            this.picLoadTemp.Invalidate();            
            picLoadTemp.Refresh();

            foreach (Rectangle rec0 in listRect)
            {
                Rectangle rec1 = new Rectangle();
                rec1.X = Convert.ToInt32(M * rec0.X + xd);
                rec1.Y = Convert.ToInt32(M * rec0.Y + yd);
                rec1.Width = Convert.ToInt32(M * rec0.Width);
                rec1.Height = Convert.ToInt32(M * rec0.Height);
                g.DrawRectangle(tempPen, rec1);
            }

            //display template name
            labelTempName.Text = ("Template: " + tempName);
        }

        // ----------------------------------------------------------------------------------------------------------

        // --------------------------------------- Cycle Through Templates: -----------------------------------------

        //Next Template
        private void btnNext_Click(object sender, EventArgs e)
        {
            //Spillover            
            if (tempNum == diTemp.GetFiles().Count() - 1)
            {
                tempNum = 0;
            }
            else
            {
                tempNum++;
            }

            frmLoadTemp_Resize(null, null);
        }

        //Previous Template
        private void btnPrev_Click(object sender, EventArgs e)
        {
            //Spillover            
            if (tempNum == 0)
            {
                tempNum = diTemp.GetFiles().Count() - 1;
            }
            else
            {
                tempNum--;
            }

            frmLoadTemp_Resize(null, null);
        }

        // ----------------------------------------------------------------------------------------------------------

        // ------------------------------------------- Delete Template: ---------------------------------------------

        //Delete Template
        private void btnDelTemp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Delete The Template: " + tempName + "?\r\nThis Action Cannot Be Undone.", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //delete current template
                File.Delete(tempFilePath + tempName);

                //show preious template
                if (diTemp.GetFiles().Count() == 0)
                {
                    MessageBox.Show("All Templates Deleted", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);//alert message
                    this.Close();
                }
                else
                {
                    if (diTemp.GetFiles().Count() == 1) //If only one crop remains turn off scroll buttons
                    {
                        btnNext.Enabled = false;
                        btnPrev.Enabled = false;
                    }
                    btnPrev_Click(null, null);
                }
            }
        }

        // ----------------------------------------------------------------------------------------------------------

        // -------------------------------------------- Load Template: ----------------------------------------------

        //Load Template into frmLoadImg
        private void btnLoadTemp_Click(object sender, EventArgs e)
        {
            //declare form is to be loaded
            bLoad = true;

            this.Close();
        }

        // ----------------------------------------------------------------------------------------------------------

        // ==========================================================================================================
    }
}