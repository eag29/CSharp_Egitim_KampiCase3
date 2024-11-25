namespace EF_Project
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.btnGuide = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuide
            // 
            this.btnGuide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuide.BackgroundImage")));
            this.btnGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuide.Location = new System.Drawing.Point(37, 47);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(70, 70);
            this.btnGuide.TabIndex = 3;
            this.btnGuide.UseVisualStyleBackColor = true;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocation.BackgroundImage")));
            this.btnLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocation.Location = new System.Drawing.Point(141, 47);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(70, 70);
            this.btnLocation.TabIndex = 4;
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnChart
            // 
            this.btnChart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChart.BackgroundImage")));
            this.btnChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChart.Location = new System.Drawing.Point(245, 47);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(70, 70);
            this.btnChart.TabIndex = 5;
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(358, 167);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.btnGuide);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnChart;
    }
}