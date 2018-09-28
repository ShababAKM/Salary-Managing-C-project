namespace SalaryManager
{
    partial class FirstPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            this.mlDay = new MetroFramework.Controls.MetroLabel();
            this.mlTime = new MetroFramework.Controls.MetroLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mlSecond = new MetroFramework.Controls.MetroLabel();
            this.mTDlabel = new MetroFramework.Controls.MetroLabel();
            this.mlDate = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlDay
            // 
            this.mlDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mlDay.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlDay.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlDay.ForeColor = System.Drawing.Color.SpringGreen;
            this.mlDay.Location = new System.Drawing.Point(337, 178);
            this.mlDay.Name = "mlDay";
            this.mlDay.Size = new System.Drawing.Size(208, 25);
            this.mlDay.TabIndex = 3;
            this.mlDay.Text = "dddd";
            this.mlDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlDay.UseCustomBackColor = true;
            this.mlDay.UseCustomForeColor = true;
            // 
            // mlTime
            // 
            this.mlTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mlTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlTime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlTime.ForeColor = System.Drawing.Color.SpringGreen;
            this.mlTime.Location = new System.Drawing.Point(337, 76);
            this.mlTime.Name = "mlTime";
            this.mlTime.Size = new System.Drawing.Size(173, 33);
            this.mlTime.TabIndex = 4;
            this.mlTime.Text = "00 : 00";
            this.mlTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlTime.UseCustomBackColor = true;
            this.mlTime.UseCustomForeColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(174, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(619, 254);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "Sign In";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mlSecond
            // 
            this.mlSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mlSecond.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mlSecond.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlSecond.ForeColor = System.Drawing.Color.SpringGreen;
            this.mlSecond.Location = new System.Drawing.Point(518, 88);
            this.mlSecond.Name = "mlSecond";
            this.mlSecond.Size = new System.Drawing.Size(27, 21);
            this.mlSecond.TabIndex = 7;
            this.mlSecond.Text = "00";
            this.mlSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlSecond.UseCustomBackColor = true;
            this.mlSecond.UseCustomForeColor = true;
            // 
            // mTDlabel
            // 
            this.mTDlabel.BackColor = System.Drawing.Color.Gray;
            this.mTDlabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mTDlabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mTDlabel.Location = new System.Drawing.Point(296, 0);
            this.mTDlabel.Name = "mTDlabel";
            this.mTDlabel.Size = new System.Drawing.Size(288, 57);
            this.mTDlabel.TabIndex = 14;
            this.mTDlabel.Text = "Running Time And Date";
            this.mTDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTDlabel.UseCustomBackColor = true;
            // 
            // mlDate
            // 
            this.mlDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mlDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlDate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlDate.ForeColor = System.Drawing.Color.SpringGreen;
            this.mlDate.Location = new System.Drawing.Point(337, 129);
            this.mlDate.Name = "mlDate";
            this.mlDate.Size = new System.Drawing.Size(208, 32);
            this.mlDate.TabIndex = 15;
            this.mlDate.Text = "dd : mm : yyyy";
            this.mlDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlDate.UseCustomBackColor = true;
            this.mlDate.UseCustomForeColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Gray;
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 236);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(959, 258);
            this.metroPanel1.TabIndex = 16;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Gray;
            this.metroPanel2.Controls.Add(this.mlDate);
            this.metroPanel2.Controls.Add(this.mlSecond);
            this.metroPanel2.Controls.Add(this.mTDlabel);
            this.metroPanel2.Controls.Add(this.mlDay);
            this.metroPanel2.Controls.Add(this.mlTime);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(959, 237);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroPanel2.TabIndex = 17;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseCustomForeColor = true;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FirstPage";
            this.Size = new System.Drawing.Size(959, 494);
            this.UseCustomBackColor = true;
            this.UseCustomForeColor = true;
            this.Load += new System.EventHandler(this.FirstPage_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlDay;
        private MetroFramework.Controls.MetroLabel mlTime;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel mlSecond;
        private MetroFramework.Controls.MetroLabel mTDlabel;
        private MetroFramework.Controls.MetroLabel mlDate;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
    }
}
