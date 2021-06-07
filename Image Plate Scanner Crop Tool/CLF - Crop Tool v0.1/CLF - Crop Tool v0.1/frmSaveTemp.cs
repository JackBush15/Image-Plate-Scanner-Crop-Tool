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
    public partial class frmSaveTemp : Form
    {
        // ================================================= Setup: =================================================

        //Create file paths and directory info
        private static string tempFilePath = Application.StartupPath + @"\Store\Templates\";
        private DirectoryInfo diTemp = new DirectoryInfo(tempFilePath);

        //Declare Crop Pen
        Pen tempPen = new Pen(Color.Black);
        Pen imgPen = new Pen(Color.Red);
        Graphics g;

        //New rectangle list
        List<Rectangle> listRect = new List<Rectangle>();

        //create resize variables
        double R0, R1, M;
        int xd, yd;
        Size imgSize = new Size();
        Size imgPicSize = new Size();
        Size picSize = new Size();

        // ----------------------------------------------------------------------------------------------------------

        // ---------------------------------------------- Load Form: ------------------------------------------------

        //Load Form
        public frmSaveTemp(List<Rectangle> listRect0, Size imgSize0)
        {
            InitializeComponent();

            //Collect rectangle list from frmLoadImg
            listRect = listRect0;
            imgSize = imgSize0;            
        }

        //Resize Form
        private void frmSaveTemp_Resize(object sender, EventArgs e)
        {
            picSaveTemp.Refresh();
            g = picSaveTemp.CreateGraphics();

            picSize = picSaveTemp.Size;
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

        //Display template
        private void displayTemplate(object sender, EventArgs e)
        {
            tempPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            picSaveTemp.Refresh();

            Rectangle imgRect = new Rectangle(xd, yd, Convert.ToInt32(M * imgSize.Width - 5), Convert.ToInt32(M * imgSize.Height - 5));
            g.DrawRectangle(imgPen, imgRect);

            foreach (Rectangle rec0 in listRect)
            {
                Rectangle rec1 = new Rectangle();
                rec1.X = Convert.ToInt32(M * rec0.X + xd);
                rec1.Y = Convert.ToInt32(M * rec0.Y + yd);
                rec1.Width = Convert.ToInt32(M * rec0.Width);
                rec1.Height = Convert.ToInt32(M * rec0.Height);
                g.DrawRectangle(tempPen, rec1);
            }
        }

        // ----------------------------------------------------------------------------------------------------------

        // ------------------------------------------- Save Template As: --------------------------------------------

        //Test Charecters are appropriate
        private void textSaveAs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[\\:*?<>|/\u0022]"))//Filters for all windows illegal charecters (the " charecter is writen in unicode as this was the only way i could get it to work)
            {
                e.Handled = true;
            }
        }

        //Test if Template can be saved
        private void btnSaveTemp_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textSaveAs.Text))
            {
                MessageBox.Show("Input Name For Template", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // is a name input?
            }
            else if (textSaveAs.Text == "uuddlrlrbas")
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\CLF - Crop Tool EE.wav");
                player.Play();
                MessageBox.Show("Here We Go!", "Itsa Me! Mario!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textSaveAs.Text == "CON" | textSaveAs.Text == "PRN" | textSaveAs.Text == "AUX" | textSaveAs.Text == "NUL" | textSaveAs.Text == "COM1" | textSaveAs.Text == "COM2"
                | textSaveAs.Text == "COM3" | textSaveAs.Text == "COM4" | textSaveAs.Text == "COM5" | textSaveAs.Text == "COM6" | textSaveAs.Text == "COM7" | textSaveAs.Text == "COM8"
                | textSaveAs.Text == "COM9" | textSaveAs.Text == "LPT1" | textSaveAs.Text == "LPT2" | textSaveAs.Text == "LPT3" | textSaveAs.Text == "LPT4" | textSaveAs.Text == "LPT5"
                | textSaveAs.Text == "LPT6" | textSaveAs.Text == "LPT7" | textSaveAs.Text == "LPT8" | textSaveAs.Text == "LPT9") //Filter for wondows reserved file names
            {
                MessageBox.Show("Template Name Is Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (File.Exists(tempFilePath + textSaveAs.Text))
            {
                DialogResult result = MessageBox.Show("Template Already Exists With That Name.\r\nWould You Like To Replace It?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // does the name already exist?

                if (result == DialogResult.Yes)
                {
                    savingTemplates(null, null);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want To Save This Template As: " + textSaveAs.Text + "?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); // does the name already exist?

                if (result == DialogResult.Yes)
                {
                    savingTemplates(null, null);
                }
            }
        }

        //Save template
        private void savingTemplates(object sender, EventArgs e)
        {
            using (FileStream fs = File.Create(tempFilePath + textSaveAs.Text))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                //define size of image it was drawn on
                writer.WriteLine(imgSize.Width + "," + imgSize.Height);

                //define template
                foreach (Rectangle rec in listRect)
                {
                    writer.WriteLine(rec.X + "," + rec.Y + "," + rec.Width + "," + rec.Height);
                }
            }

            textSaveAs.Text = ("");
            this.Close();
        }

        // ----------------------------------------------------------------------------------------------------------

        // ==========================================================================================================
    }
}