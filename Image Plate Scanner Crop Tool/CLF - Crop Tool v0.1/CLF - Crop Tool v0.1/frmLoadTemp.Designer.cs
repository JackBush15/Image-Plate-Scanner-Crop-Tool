namespace CLF___Crop_Tool
{
    partial class frmLoadTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadTemp));
            this.picLoadTemp = new System.Windows.Forms.PictureBox();
            this.labelLoadTemp = new System.Windows.Forms.Label();
            this.labelTempName = new System.Windows.Forms.Label();
            this.btnDelTemp = new System.Windows.Forms.Button();
            this.btnLoadTemp = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.labelImgSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // picLoadTemp
            // 
            this.picLoadTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLoadTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picLoadTemp.Location = new System.Drawing.Point(12, 50);
            this.picLoadTemp.Name = "picLoadTemp";
            this.picLoadTemp.Size = new System.Drawing.Size(534, 534);
            this.picLoadTemp.TabIndex = 14;
            this.picLoadTemp.TabStop = false;
            // 
            // labelLoadTemp
            // 
            this.labelLoadTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLoadTemp.AutoSize = true;
            this.labelLoadTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadTemp.Location = new System.Drawing.Point(184, 9);
            this.labelLoadTemp.Name = "labelLoadTemp";
            this.labelLoadTemp.Size = new System.Drawing.Size(194, 31);
            this.labelLoadTemp.TabIndex = 13;
            this.labelLoadTemp.Text = "Load Template";
            // 
            // labelTempName
            // 
            this.labelTempName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTempName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTempName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempName.Location = new System.Drawing.Point(140, 591);
            this.labelTempName.Name = "labelTempName";
            this.labelTempName.Size = new System.Drawing.Size(278, 21);
            this.labelTempName.TabIndex = 22;
            this.labelTempName.Text = "Template:";
            this.labelTempName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelTemp
            // 
            this.btnDelTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelTemp.Location = new System.Drawing.Point(424, 590);
            this.btnDelTemp.Name = "btnDelTemp";
            this.btnDelTemp.Size = new System.Drawing.Size(93, 23);
            this.btnDelTemp.TabIndex = 21;
            this.btnDelTemp.Text = "Delete Template";
            this.btnDelTemp.UseVisualStyleBackColor = true;
            this.btnDelTemp.Click += new System.EventHandler(this.btnDelTemp_Click);
            // 
            // btnLoadTemp
            // 
            this.btnLoadTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadTemp.Location = new System.Drawing.Point(41, 590);
            this.btnLoadTemp.Name = "btnLoadTemp";
            this.btnLoadTemp.Size = new System.Drawing.Size(93, 23);
            this.btnLoadTemp.TabIndex = 20;
            this.btnLoadTemp.Text = "Load Template";
            this.btnLoadTemp.UseVisualStyleBackColor = true;
            this.btnLoadTemp.Click += new System.EventHandler(this.btnLoadTemp_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(12, 590);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(23, 23);
            this.btnPrev.TabIndex = 24;
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
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // labelImgSize
            // 
            this.labelImgSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelImgSize.BackColor = System.Drawing.SystemColors.Control;
            this.labelImgSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelImgSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImgSize.ForeColor = System.Drawing.Color.Black;
            this.labelImgSize.Location = new System.Drawing.Point(468, 566);
            this.labelImgSize.Name = "labelImgSize";
            this.labelImgSize.Size = new System.Drawing.Size(78, 18);
            this.labelImgSize.TabIndex = 25;
            this.labelImgSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLoadTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 625);
            this.Controls.Add(this.labelImgSize);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.labelTempName);
            this.Controls.Add(this.btnDelTemp);
            this.Controls.Add(this.btnLoadTemp);
            this.Controls.Add(this.picLoadTemp);
            this.Controls.Add(this.labelLoadTemp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(421, 367);
            this.Name = "frmLoadTemp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crop Tool - Load Template";
            this.Activated += new System.EventHandler(this.frmLoadTemp_Resize);
            this.Resize += new System.EventHandler(this.frmLoadTemp_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picLoadTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picLoadTemp;
        private System.Windows.Forms.Label labelLoadTemp;
        private System.Windows.Forms.Label labelTempName;
        private System.Windows.Forms.Button btnDelTemp;
        private System.Windows.Forms.Button btnLoadTemp;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labelImgSize;
    }
}