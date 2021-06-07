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

// ============================================= Specification: =============================================
// --------------------------------------------- What It Does:  ---------------------------------------------
// > This program is for a Crop Tool for scanned images of partical detection
// > User can upload an image to crop tool
// > Can select multiple reigions of the image to take crops of
// > The selected regions can be saved as a template to use on other images
// > User can load in a template from a list to use on an image
// > User can delete templates
// > Each cropped image is temporarily stored
// > User can scroll through all cropped images
// > Each image selected in a template or otherwise is stored individually
// > User can permently save the cropped images
// > When a new image is loaded in all the temporarliy stored crops are deleted
// > When making a selection on the image right clicking on the image will remove the previosly drawn region
// > Double right clicking will remove all drawn regions
// > Can enhance the contrast of the image
// > Can increase the brigtness of the image
// > Can adjust the maximum and minimum pixel values
// > Can incrementally increase any of these 4 values with arrows
// --------------------------------------------- Requirements:  ---------------------------------------------
// > Images must not be distorted when being loaded, while in the program, or when saved
// > The bit depth of the image must remain constant when being loaded and when saved
// > The resolution of the images must not be affected when being loaded, while in the program, or when saved
// > Folders used to save images or templates will be created on the devise if not already present
// > The croped images must not be affected by any contrast or brightness adjustments made to the inout image
// > The program must load and save .TIFF files
// > The program must be able to run on any devise
// > The program must be simple and intuitive to use
// > Hovering over buttons will display a description of the buttons functionality 
// > The program must display an error message when the user makes an unsuported action
// > Window is resizeable to allow small images to be seen easier
// > The program must be peer tested to minimise the number of bugs
// ==========================================================================================================

namespace CLF___Crop_Tool
{
    public partial class frmLoadImg : Form
    {
        // ================================================= Setup: =================================================

        //Create file paths and directory info
        private static string imgFilePath = Application.StartupPath + @"\Store\Images\";
        private DirectoryInfo diImg = new DirectoryInfo(imgFilePath);
        private static string tempFilePath = Application.StartupPath + @"\Store\Templates\";
        private DirectoryInfo diTemp = new DirectoryInfo(tempFilePath);

        //Creat Images and Bitmaps
        Image inputImg;
        Bitmap bmpIn, bmpOut;

        //Declare pen and graphics
        Pen crpPen;
        Graphics g;

        //Create contrast variables
        int conVal, brtVal, minVal, maxVal;
        float conDis, brtDis, minDis, maxDis;

        //Create crop variables
        int rectX, rectY, rectW, rectH;
        Point XY0, XY1;

        //create resize variables
        double R0, R1, M;
        int xd, yd;
        Size imgSize = new Size();
        Size imgPicSize = new Size();
        Size picSize = new Size();

        //Rectangle Lists
        Rectangle rect = new Rectangle();
        public List<Rectangle> listRect = new List<Rectangle>();

        //Counter variables
        int rectNum = 0, imgNum = 0;

        //Test if forms are open
        bool isOpen = false;

        //Declare other forms
        public frmCropImg frmCropImg { get; set; }

        // ----------------------------------------------------------------------------------------------------------

        // ----------------------------------------------- Load Form: -----------------------------------------------

        //Setup Initial conditions
        public frmLoadImg()
        {
            InitializeComponent();

            //Declare pen
            crpPen = new Pen(Color.White);
            crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            //Adjustment bars are disabled until image is loaded
            barContrast.Enabled = false;
            barBrightness.Enabled = false;
            barMax.Enabled = false;
            barMin.Enabled = false;
        }

        // ----------------------------------------------------------------------------------------------------------

        // ---------------------------------------------- Load Image: -----------------------------------------------

        //Load Image to picInput and set initial conditions
        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            //Open Load Dialog
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "TIFF(*.TIFF)|*.tiff|TIF(*.TIF)|*.tif"; //Filter for all forms of tiff files

            //If Image load was sucessful
            if (f.ShowDialog() == DialogResult.OK)
            {
                //Take input image and apply to bitmap
                inputImg = Image.FromFile(f.FileName);
                bmpIn = new Bitmap(inputImg);

                picInput.SizeMode = PictureBoxSizeMode.Zoom; //Fit image to picturebox
                picInput.Image = (Image)bmpIn; //Put bitmap into picInput

                //Enable adjustment bars
                barContrast.Enabled = true;
                barBrightness.Enabled = true;
                barMax.Enabled = true;
                barMin.Enabled = true;

                //Create Store folder and subfiles 
                if (Directory.Exists(imgFilePath))
                {
                    frmLoadImg_Load(null, null);
                }
                else { Directory.CreateDirectory(imgFilePath); }
                if (!Directory.Exists(tempFilePath)) { Directory.CreateDirectory(tempFilePath); }

                imgSize = picInput.Image.Size;
                picInput_Select(null, null); //Trigger picInput_Select
                btnReset_Click(null, null); //Trigger btnReset_Click
            }
        }

        //Activate Select Properties
        private void picInput_Select(object sender, EventArgs e)
        {
            picInput.MouseEnter += new EventHandler(picInput_MouseEnter);

            picInput.MouseLeave += new EventHandler(picInput_MouseLeave);

            picInput.MouseDown += new MouseEventHandler(picInput_MouseDown);

            picInput.MouseMove += new MouseEventHandler(picInput_MouseMove);

            picInput.MouseUp += new MouseEventHandler(picInput_MouseUp);

            picInput.MouseDoubleClick += new MouseEventHandler(picInput_MouseDoubleClick);
        }

        //Resize Form
        private void frmLoadImg_Resize(object sender, EventArgs e)
        {
            picInput.Refresh();
            g = picInput.CreateGraphics();

            picSize = picInput.Size;
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

            drawRectangles(null, null);
        }

        // ----------------------------------------------------------------------------------------------------------

        // --------------------------------------------- Adjust Image: ----------------------------------------------

        //Brightness and Contrast Function
        private void barBrightnessContrast_Scroll(object sender, ScrollEventArgs e)
        {
            //Take brightness and contrast values
            conVal = barContrast.Value;
            brtVal = barBrightness.Value;

            //Apply function to max and min values
            maxVal = -conVal + 102 - brtVal;
            minVal = conVal - 98 - brtVal;

            //Confine bar values within their min and max
            if (maxVal > barMax.Maximum)
            {
                maxVal = barMax.Maximum;
            }
            else if (maxVal < barMax.Minimum)
            {
                maxVal = barMax.Minimum;
            }
            if (minVal > barMin.Maximum)
            {
                minVal = barMin.Maximum;
            }
            else if (minVal < barMin.Minimum)
            {
                minVal = barMin.Minimum;
            }

            //Set max and min values
            barMax.Value = maxVal;
            barMin.Value = minVal;

            adjImage(null, null); //Trigger adjImage
        }

        //Maximum limit
        private void barMax_Scroll(object sender, ScrollEventArgs e)
        {
            //Take max and min values
            maxVal = barMax.Value;
            minVal = barMin.Value;

            //Ensure max > min
            if (maxVal < minVal)
            {
                barMin.Value = maxVal;
            }

            barMinMax(null, null); //Trigger barMinMax
        }

        //Minimum limit
        private void barMin_Scroll(object sender, ScrollEventArgs e)
        {
            //Take max and min values
            maxVal = barMax.Value;
            minVal = barMin.Value;

            //Ensure max > min
            if (maxVal < minVal)
            {
                barMax.Value = minVal;
            }

            barMinMax(null, null); //Trigger barMinMax
        }

        //Minimum and Maximum Function
        private void barMinMax(object sender, EventArgs e)
        {
            //Apply function to brightness and contrast values
            conVal = minVal / 2 + 100 - maxVal / 2;
            brtVal = -minVal / 2 + 2 - maxVal / 2;

            //Confine bar values within their min and max
            if (conVal > barContrast.Maximum)
            {
                conVal = barContrast.Maximum;
            }
            else if (conVal < barContrast.Minimum)
            {
                conVal = barContrast.Minimum;
            }
            if (brtVal > barBrightness.Maximum)
            {
                brtVal = barBrightness.Maximum;
            }
            else if (brtVal < barBrightness.Minimum)
            {
                brtVal = barBrightness.Minimum;
            }

            //Set brightness and contrast values
            barContrast.Value = conVal;
            barBrightness.Value = brtVal;

            adjImage(null, null); //Trigger adjImage
        }

        //Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (picInput.Image == null) //Error message test
            {
                MessageBox.Show("No Image Loaded To Reset", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Reset Image adjustment
                barContrast.Value = 1;
                barBrightness.Value = 1;
                barMax.Value = 100;
                barMin.Value = -98;

                //Delete rectangles
                delRect(null, null);

                //Adjust Image
                adjImage(null, null);
            }
        }

        //Adjust Image
        private void adjImage(object sender, EventArgs e)
        {
            //Take final values from bars
            conVal = barContrast.Value;
            brtVal = barBrightness.Value;
            maxVal = barMax.Value;
            minVal = barMin.Value;

            //Calculate display values for bars
            if (barContrast.Value >= 1) { conDis = barContrast.Value; }
            else { conDis = (float)Math.Round((barContrast.Value + 98f) / 99f, 2); }

            if (barBrightness.Value >= 1) { brtDis = barBrightness.Value; }
            else { brtDis = (float)Math.Round((barBrightness.Value + 98f) / 99f, 2); }

            maxDis = (float)Math.Round((barMax.Value + 98f) * 255f / 198f);
            minDis = (float)Math.Round((barMin.Value + 98f) * 255f / 198f);

            //Display bar values
            labelContrast.Text = "Contrast: " + conDis;
            labelBrightness.Text = "Brightness: " + brtDis;
            labelMax.Text = "Maximum: " + maxDis;
            labelMin.Text = "Minimum: " + minDis;

            float b = brtVal / 100f; //Brightness component
            float c = (conVal / 100f) + 1f; //Contrast component
            float t = (1 - c) / 2; //Secondary contrast component

            //Create temporary bitmap as not to edit original image            
            Bitmap bmpTemp0 = bmpIn;
            Bitmap bmpTemp1 = new Bitmap(bmpTemp0.Width, bmpTemp0.Height);
            Graphics newGraphics = Graphics.FromImage(bmpTemp1);

            //Color matrix - edits image
            float[][] FloatColorMatrix =
            {
                new float[] {c, 0, 0, 0, 0}, // red
                new float[] {0, c, 0, 0, 0}, // green
                new float[] {0, 0, c, 0, 0}, // blue
                new float[] {0, 0, 0, 1, 0}, // alpha
                new float[] {c * b + t, c * b + t, c * b + t, 0, 1}, // white
            };

            ColorMatrix newColorMatrix = new ColorMatrix(FloatColorMatrix);
            ImageAttributes attributes = new ImageAttributes();

            attributes.SetColorMatrix(newColorMatrix);

            newGraphics.DrawImage(bmpTemp0, new Rectangle(0, 0, bmpTemp0.Width, bmpTemp0.Height), 0, 0, bmpTemp0.Width, bmpTemp0.Height, GraphicsUnit.Pixel, attributes);
            attributes.Dispose();
            newGraphics.Dispose();

            //Display newly adjusted image in picInput
            picInput.Image = (Image)bmpTemp1;

            drawRectangles(null, null);
        }

        // ----------------------------------------------------------------------------------------------------------

        // ------------------------------------------- Start Selection: ---------------------------------------------

        //Cursor Cross when over picInput and normal when not
        private void picInput_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Cross;
        }
        private void picInput_MouseLeave(object sender, EventArgs e)
        {
            base.OnMouseLeave(e);
            Cursor = Cursors.Default;
        }


        //Draw Rectangles
        private void drawRectangles(object sender, EventArgs e)
        {
            picInput.Refresh();

            foreach (Rectangle rec0 in listRect)
            {
                Rectangle rec1 = new Rectangle();
                rec1.X = Convert.ToInt32(M * rec0.X + xd);
                rec1.Y = Convert.ToInt32(M * rec0.Y + yd);
                rec1.Width = Convert.ToInt32(M * rec0.Width);
                rec1.Height = Convert.ToInt32(M * rec0.Height);
                g.DrawRectangle(crpPen, rec1);
            }
        }

        //Set Starting Coords
        private void picInput_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == System.Windows.Forms.MouseButtons.Left) //Check left mouse button is used
            {
                if ((listRect.Count + diImg.GetFiles().Count()) >= 99)
                {
                    MessageBox.Show("Maximum of 99 Crops\r\nCurrent Selections And Crops Total 99", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);//error message
                }
                else
                {
                    //Set Starting Coords
                    XY0 = e.Location;
                }
            }            
        }

        //draw rectangle on picInput
        private void picInput_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left) //Check left mouse button is used
            {
                picInput.Refresh();
                g = picInput.CreateGraphics();

                XY1 = e.Location;

                if (XY1.X > picInput.Width-4) // range for x coord
                { XY1.X = picInput.Width-4; }
                else if (XY1.X < 0)
                { XY1.X = 0; }

                if (XY1.Y > picInput.Height-5) // range for y coord
                { XY1.Y = picInput.Height-5; }
                else if (XY1.Y < 0)
                { XY1.Y = 0; }

                frmLoadImg_Resize(null, null); //Trigger picInput_Resize

                //set crop dimentions
                rectW = Convert.ToInt32((double)Math.Abs(XY0.X - XY1.X) / M);
                rectH = Convert.ToInt32((double)Math.Abs(XY0.Y - XY1.Y) / M);
                rect.Size = new Size(rectW, rectH);
                //set top ancor coords
                rectX = Convert.ToInt32((double)(Math.Min(XY0.X, XY1.X) - xd) / M);
                rectY = Convert.ToInt32((double)(Math.Min(XY0.Y, XY1.Y) - yd) / M);
                rect.Location = new Point(rectX, rectY);

                //Draw previous rectangles as new one is drawn
                drawRectangles(null, null);
                //draw new rectangle
                Rectangle rec = new Rectangle();
                rec.X = Convert.ToInt32(M * rect.X + xd);
                rec.Y = Convert.ToInt32(M * rect.Y + yd);
                rec.Width = Convert.ToInt32(M * rect.Width);
                rec.Height = Convert.ToInt32(M * rect.Height);
                g.DrawRectangle(crpPen, rec);
            }
        }

        //store new rectangles
        private void picInput_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                listRect.Add(rect);
                rectNum = listRect.Count();

                drawRectangles(null, null);
            }
        }

        // ----------------------------------------------------------------------------------------------------------


        // ------------------------------------------ Delete Selections: --------------------------------------------

        //right click to remove most recent rectangle
        private void picInput_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (rectNum != 0)
                {
                    this.picInput.Invalidate();//clear all rectangles on picInput
                    listRect.RemoveAt(rectNum - 1);//remove more recent from the list
                    rectNum = listRect.Count();//recount list
                    picInput.Refresh();//refresh
                    drawRectangles(null, null);
                }
            }
        }

        //double right click to remove all rectangles
        private void picInput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                delRect(null, null);
            }
        }
        private void delRect(object sender, EventArgs e)
        {
            if (rectNum != 0)
            {
                this.picInput.Invalidate();//clear all rectangles on picInput
                listRect.Clear();//remove more recent from the list
                rectNum = listRect.Count();//recount list
            }
        }

        // ----------------------------------------------------------------------------------------------------------


        // ------------------------------------------- Crop Selections: ---------------------------------------------

        //Crop Selected Area
        public void btnCrop_Click(object sender, EventArgs e)
        {
            //Test if crop form should be opened
            if (diImg.GetFiles().Count() > 0 | rectNum != 0)
            {
                if (rectNum != 0)
                {
                    if ((listRect.Count + diImg.GetFiles().Count()) > 99)
                    {
                        MessageBox.Show("Maximum of 99 Crops", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);//error message
                    }
                    else
                    {
                        //Cycle through recctangles and take crops of each
                        foreach (Rectangle rec in listRect)
                        {
                            //Take crop of rectangle
                            bmpOut = bmpIn.Clone(rec, PixelFormat.DontCare);

                            bmpOut.Save(imgFilePath + imgNum, ImageFormat.Tiff);//Save bitmap to temporary image folder
                            imgNum++;//Increases the name of the crop                        
                        }
                    }
                }

                //Test if form is open
                FormCollection fc = Application.OpenForms;
                foreach (Form frm in fc)
                {
                    if (frm.Name == "frmCropImg")
                    {
                        isOpen = true;
                    }
                    else
                    {
                        isOpen = false;
                    }
                }

                //Open or Update
                if (isOpen == false)
                {
                    frmCropImg frmCI = new frmCropImg();
                    frmCI.Show();
                    frmCropImg = frmCI;
                }
                else
                {
                    frmCropImg.updateFrm();//Update form
                }
            }
            else if (diImg.GetFiles().Count() == 0 && rectNum == 0)
            {
                MessageBox.Show("Select region to crop", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//error message
            }
        }

        //Clear crops
        private void frmLoadImg_Load(object sender, EventArgs e)
        {
            foreach (FileInfo file in diImg.GetFiles())
            {
                file.Delete();
            }
        }

        // ----------------------------------------------------------------------------------------------------------

        // -------------------------------------------- Save Template: ----------------------------------------------

        //Save Template
        private void btnSaveTemp_Click(object sender, EventArgs e)
        {
            if (rectNum == 0)
            {
                MessageBox.Show("Make Selection To Save Template", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//error message
            }
            else
            {
                frmSaveTemp frmST = new frmSaveTemp(listRect, imgSize);
                frmST.ShowDialog();//open save template (ShowDialode prevents user interfacing with CropTool while SaveTemplate is open)
            }
        }

        // ----------------------------------------------------------------------------------------------------------

        // -------------------------------------------- Load Template: ----------------------------------------------
        
        //Load Template
        private void btnLoadTemp_Click(object sender, EventArgs e)
        {
            if (picInput.Image == null)
            {
                MessageBox.Show("Load Image To Use Template", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//error message
            }
            else if (diTemp.GetFiles().Count() == 0)
            {
                MessageBox.Show("No Templates Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
                frmLoadTemp frmLT = new frmLoadTemp(bmpIn);
                frmLT.ShowDialog();//open load template dialog

                if (frmLT.bLoad == true) // check load button was pressed
                {
                    if (rectNum != 0)
                    {
                        DialogResult result1 = MessageBox.Show("Loading A Template Will Clear All Current Selections.\r\nDo You Want To Continue?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result1 == DialogResult.No)
                        {
                            return;
                        }
                    }
                    
                    if (imgSize != frmLT.tempImgSize)
                    {
                        DialogResult result0 = MessageBox.Show("This Template Was Made On An Image With Dimentions: \r\n" + frmLT.tempImgSize.Width + " x " + frmLT.tempImgSize.Height +
                            "\r\nThe Current Image Loaded Has Dimentions: \r\n" + imgSize.Width + " x " + imgSize.Height + "\r\nThis Difference May Cause Issues. Do You Want To Continue?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result0 == DialogResult.No)
                        {
                            return;
                        }
                    }

                    listRect = frmLT.listRect;
                    this.picInput.Invalidate();//clear all rectangles on picInput
                    rectNum = listRect.Count();//recount list
                    picInput.Refresh();//refresh
                    frmLoadImg_Resize(null, null);
                }
            }
        }

        // ----------------------------------------------------------------------------------------------------------

        // ==========================================================================================================
    }
}