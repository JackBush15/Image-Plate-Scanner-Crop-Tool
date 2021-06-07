namespace CLF___Crop_Tool
{
    partial class frmSaveTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaveTemp));
            this.picSaveTemp = new System.Windows.Forms.PictureBox();
            this.labelSaveTemp = new System.Windows.Forms.Label();
            this.btnSaveTemp = new System.Windows.Forms.Button();
            this.textSaveAs = new System.Windows.Forms.TextBox();
            this.labelSaveAs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // picSaveTemp
            // 
            this.picSaveTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSaveTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSaveTemp.Location = new System.Drawing.Point(12, 50);
            this.picSaveTemp.Name = "picSaveTemp";
            this.picSaveTemp.Size = new System.Drawing.Size(534, 534);
            this.picSaveTemp.TabIndex = 10;
            this.picSaveTemp.TabStop = false;
            // 
            // labelSaveTemp
            // 
            this.labelSaveTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSaveTemp.AutoSize = true;
            this.labelSaveTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaveTemp.Location = new System.Drawing.Point(187, 9);
            this.labelSaveTemp.Name = "labelSaveTemp";
            this.labelSaveTemp.Size = new System.Drawing.Size(196, 31);
            this.labelSaveTemp.TabIndex = 9;
            this.labelSaveTemp.Text = "Save Template";
            // 
            // btnSaveTemp
            // 
            this.btnSaveTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTemp.Location = new System.Drawing.Point(453, 590);
            this.btnSaveTemp.Name = "btnSaveTemp";
            this.btnSaveTemp.Size = new System.Drawing.Size(93, 23);
            this.btnSaveTemp.TabIndex = 11;
            this.btnSaveTemp.Text = "Save Template";
            this.btnSaveTemp.UseVisualStyleBackColor = true;
            this.btnSaveTemp.Click += new System.EventHandler(this.btnSaveTemp_Click);
            // 
            // textSaveAs
            // 
            this.textSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSaveAs.Location = new System.Drawing.Point(76, 591);
            this.textSaveAs.Name = "textSaveAs";
            this.textSaveAs.Size = new System.Drawing.Size(371, 20);
            this.textSaveAs.TabIndex = 12;
            this.textSaveAs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSaveAs_KeyPress);
            // 
            // labelSaveAs
            // 
            this.labelSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSaveAs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaveAs.Location = new System.Drawing.Point(12, 591);
            this.labelSaveAs.Name = "labelSaveAs";
            this.labelSaveAs.Size = new System.Drawing.Size(65, 20);
            this.labelSaveAs.TabIndex = 13;
            this.labelSaveAs.Text = "Save As:";
            this.labelSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSaveTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 625);
            this.Controls.Add(this.labelSaveAs);
            this.Controls.Add(this.textSaveAs);
            this.Controls.Add(this.btnSaveTemp);
            this.Controls.Add(this.picSaveTemp);
            this.Controls.Add(this.labelSaveTemp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(423, 373);
            this.Name = "frmSaveTemp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crop Tool - Save Template";
            this.Activated += new System.EventHandler(this.frmSaveTemp_Resize);
            this.Resize += new System.EventHandler(this.frmSaveTemp_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picSaveTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSaveTemp;
        private System.Windows.Forms.Label labelSaveTemp;
        private System.Windows.Forms.Button btnSaveTemp;
        private System.Windows.Forms.TextBox textSaveAs;
        private System.Windows.Forms.Label labelSaveAs;
    }
}