namespace CLF___Crop_Tool
{
    partial class frmCropImg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCropImg));
            this.labelImageCrops = new System.Windows.Forms.Label();
            this.picCrop = new System.Windows.Forms.PictureBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSaveCrop = new System.Windows.Forms.Button();
            this.btnDeleteCrop = new System.Windows.Forms.Button();
            this.labelCropNum = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picCrop)).BeginInit();
            this.SuspendLayout();
            // 
            // labelImageCrops
            // 
            this.labelImageCrops.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelImageCrops.AutoSize = true;
            this.labelImageCrops.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImageCrops.Location = new System.Drawing.Point(204, 9);
            this.labelImageCrops.Name = "labelImageCrops";
            this.labelImageCrops.Size = new System.Drawing.Size(169, 31);
            this.labelImageCrops.TabIndex = 7;
            this.labelImageCrops.Text = "Image Crops";
            // 
            // picCrop
            // 
            this.picCrop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCrop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCrop.Location = new System.Drawing.Point(12, 50);
            this.picCrop.Name = "picCrop";
            this.picCrop.Size = new System.Drawing.Size(534, 534);
            this.picCrop.TabIndex = 8;
            this.picCrop.TabStop = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(12, 590);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(23, 23);
            this.btnPrev.TabIndex = 12;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(523, 590);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 23);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSaveCrop
            // 
            this.btnSaveCrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCrop.Location = new System.Drawing.Point(424, 590);
            this.btnSaveCrop.Name = "btnSaveCrop";
            this.btnSaveCrop.Size = new System.Drawing.Size(93, 23);
            this.btnSaveCrop.TabIndex = 10;
            this.btnSaveCrop.Text = "Save Crop";
            this.btnSaveCrop.UseVisualStyleBackColor = true;
            this.btnSaveCrop.Click += new System.EventHandler(this.btnSaveCrop_Click);
            // 
            // btnDeleteCrop
            // 
            this.btnDeleteCrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteCrop.Location = new System.Drawing.Point(41, 590);
            this.btnDeleteCrop.Name = "btnDeleteCrop";
            this.btnDeleteCrop.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteCrop.TabIndex = 9;
            this.btnDeleteCrop.Text = "Delete Crop";
            this.btnDeleteCrop.UseVisualStyleBackColor = true;
            this.btnDeleteCrop.Click += new System.EventHandler(this.btnDeleteCrop_Click);
            // 
            // labelCropNum
            // 
            this.labelCropNum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCropNum.AutoSize = true;
            this.labelCropNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCropNum.Location = new System.Drawing.Point(216, 594);
            this.labelCropNum.Name = "labelCropNum";
            this.labelCropNum.Size = new System.Drawing.Size(121, 16);
            this.labelCropNum.TabIndex = 13;
            this.labelCropNum.Text = "Crop Number : 0 / 0";
            // 
            // frmCropImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 625);
            this.Controls.Add(this.labelCropNum);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSaveCrop);
            this.Controls.Add(this.btnDeleteCrop);
            this.Controls.Add(this.picCrop);
            this.Controls.Add(this.labelImageCrops);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(425, 379);
            this.Name = "frmCropImg";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crop Tool - Crop";
            ((System.ComponentModel.ISupportInitialize)(this.picCrop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImageCrops;
        private System.Windows.Forms.PictureBox picCrop;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSaveCrop;
        private System.Windows.Forms.Button btnDeleteCrop;
        private System.Windows.Forms.Label labelCropNum;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}