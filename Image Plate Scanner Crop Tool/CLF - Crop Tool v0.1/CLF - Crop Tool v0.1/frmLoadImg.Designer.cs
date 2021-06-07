namespace CLF___Crop_Tool
{
    partial class frmLoadImg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadImg));
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCrop = new System.Windows.Forms.Button();
            this.btnSaveTemp = new System.Windows.Forms.Button();
            this.btnLoadTemp = new System.Windows.Forms.Button();
            this.labelCropTool = new System.Windows.Forms.Label();
            this.barContrast = new System.Windows.Forms.HScrollBar();
            this.barBrightness = new System.Windows.Forms.HScrollBar();
            this.labelContrast = new System.Windows.Forms.Label();
            this.groupBC = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMin = new System.Windows.Forms.Label();
            this.barMin = new System.Windows.Forms.HScrollBar();
            this.barMax = new System.Windows.Forms.HScrollBar();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.picInput = new System.Windows.Forms.PictureBox();
            this.groupBC.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadImg.Location = new System.Drawing.Point(3, 3);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(90, 21);
            this.btnLoadImg.TabIndex = 0;
            this.btnLoadImg.Text = "Load Image";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            this.btnLoadImg.Click += new System.EventHandler(this.btnLoadImg_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(3, 467);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCrop
            // 
            this.btnCrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrop.Location = new System.Drawing.Point(3, 31);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(90, 21);
            this.btnCrop.TabIndex = 2;
            this.btnCrop.Text = "Crop";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // btnSaveTemp
            // 
            this.btnSaveTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTemp.Location = new System.Drawing.Point(3, 87);
            this.btnSaveTemp.Name = "btnSaveTemp";
            this.btnSaveTemp.Size = new System.Drawing.Size(90, 22);
            this.btnSaveTemp.TabIndex = 3;
            this.btnSaveTemp.Text = "Save Template";
            this.btnSaveTemp.UseVisualStyleBackColor = true;
            this.btnSaveTemp.Click += new System.EventHandler(this.btnSaveTemp_Click);
            // 
            // btnLoadTemp
            // 
            this.btnLoadTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTemp.Location = new System.Drawing.Point(3, 115);
            this.btnLoadTemp.Name = "btnLoadTemp";
            this.btnLoadTemp.Size = new System.Drawing.Size(90, 21);
            this.btnLoadTemp.TabIndex = 4;
            this.btnLoadTemp.Text = "Load Template";
            this.btnLoadTemp.UseVisualStyleBackColor = true;
            this.btnLoadTemp.Click += new System.EventHandler(this.btnLoadTemp_Click);
            // 
            // labelCropTool
            // 
            this.labelCropTool.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCropTool.AutoSize = true;
            this.labelCropTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCropTool.Location = new System.Drawing.Point(240, 15);
            this.labelCropTool.Name = "labelCropTool";
            this.labelCropTool.Size = new System.Drawing.Size(133, 31);
            this.labelCropTool.TabIndex = 6;
            this.labelCropTool.Text = "Crop Tool";
            // 
            // barContrast
            // 
            this.barContrast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.barContrast.Location = new System.Drawing.Point(107, 26);
            this.barContrast.Minimum = -98;
            this.barContrast.Name = "barContrast";
            this.barContrast.Size = new System.Drawing.Size(184, 17);
            this.barContrast.TabIndex = 1;
            this.barContrast.Value = 1;
            this.barContrast.Scroll += new System.Windows.Forms.ScrollEventHandler(this.barBrightnessContrast_Scroll);
            // 
            // barBrightness
            // 
            this.barBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.barBrightness.Location = new System.Drawing.Point(107, 3);
            this.barBrightness.Minimum = -98;
            this.barBrightness.Name = "barBrightness";
            this.barBrightness.Size = new System.Drawing.Size(184, 17);
            this.barBrightness.TabIndex = 3;
            this.barBrightness.Value = 1;
            this.barBrightness.Scroll += new System.Windows.Forms.ScrollEventHandler(this.barBrightnessContrast_Scroll);
            // 
            // labelContrast
            // 
            this.labelContrast.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelContrast.AutoSize = true;
            this.labelContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrast.Location = new System.Drawing.Point(3, 27);
            this.labelContrast.Name = "labelContrast";
            this.labelContrast.Size = new System.Drawing.Size(60, 16);
            this.labelContrast.TabIndex = 8;
            this.labelContrast.Text = "Contrast:";
            // 
            // groupBC
            // 
            this.groupBC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBC.Controls.Add(this.tableLayoutPanel1);
            this.groupBC.Location = new System.Drawing.Point(12, 552);
            this.groupBC.MaximumSize = new System.Drawing.Size(0, 72);
            this.groupBC.MinimumSize = new System.Drawing.Size(585, 72);
            this.groupBC.Name = "groupBC";
            this.groupBC.Size = new System.Drawing.Size(585, 72);
            this.groupBC.TabIndex = 7;
            this.groupBC.TabStop = false;
            this.groupBC.Text = "Adjust Brightness/Contrast";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelMin, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.barMin, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.barMax, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelContrast, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelMax, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.barBrightness, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.barContrast, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelBrightness, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(583, 47);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // labelMin
            // 
            this.labelMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(294, 27);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(64, 16);
            this.labelMin.TabIndex = 15;
            this.labelMin.Text = "Minimum:";
            // 
            // barMin
            // 
            this.barMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.barMin.Location = new System.Drawing.Point(398, 26);
            this.barMin.Minimum = -98;
            this.barMin.Name = "barMin";
            this.barMin.Size = new System.Drawing.Size(185, 17);
            this.barMin.TabIndex = 13;
            this.barMin.Value = -98;
            this.barMin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.barMin_Scroll);
            // 
            // barMax
            // 
            this.barMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.barMax.Location = new System.Drawing.Point(398, 3);
            this.barMax.Minimum = -98;
            this.barMax.Name = "barMax";
            this.barMax.Size = new System.Drawing.Size(185, 17);
            this.barMax.TabIndex = 12;
            this.barMax.Value = 100;
            this.barMax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.barMax_Scroll);
            // 
            // labelMax
            // 
            this.labelMax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(294, 3);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(68, 16);
            this.labelMax.TabIndex = 14;
            this.labelMax.Text = "Maximum:";
            // 
            // labelBrightness
            // 
            this.labelBrightness.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrightness.Location = new System.Drawing.Point(3, 3);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(74, 16);
            this.labelBrightness.TabIndex = 10;
            this.labelBrightness.Text = "Brightness:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnLoadImg, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCrop, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSaveTemp, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnReset, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnLoadTemp, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(505, 56);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(96, 493);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // picInput
            // 
            this.picInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picInput.Location = new System.Drawing.Point(12, 60);
            this.picInput.Name = "picInput";
            this.picInput.Size = new System.Drawing.Size(487, 487);
            this.picInput.TabIndex = 5;
            this.picInput.TabStop = false;
            this.picInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picInput_MouseClick);
            // 
            // frmLoadImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 636);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.picInput);
            this.Controls.Add(this.labelCropTool);
            this.Controls.Add(this.groupBC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(624, 373);
            this.Name = "frmLoadImg";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crop Tool";
            this.Load += new System.EventHandler(this.frmLoadImg_Load);
            this.Resize += new System.EventHandler(this.frmLoadImg_Resize);
            this.groupBC.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImg;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.Button btnSaveTemp;
        private System.Windows.Forms.Button btnLoadTemp;
        private System.Windows.Forms.Label labelCropTool;
        private System.Windows.Forms.HScrollBar barContrast;
        private System.Windows.Forms.HScrollBar barBrightness;
        private System.Windows.Forms.Label labelContrast;
        private System.Windows.Forms.GroupBox groupBC;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.HScrollBar barMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.HScrollBar barMax;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox picInput;
    }
}

