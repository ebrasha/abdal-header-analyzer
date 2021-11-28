namespace Abdal_Security_Group_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.target_url_tb = new Telerik.WinControls.UI.RadTextBox();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.radLabelElement2 = new Telerik.WinControls.UI.RadLabelElement();
            this.radLabelElement3 = new Telerik.WinControls.UI.RadLabelElement();
            this.radLabelElement4 = new Telerik.WinControls.UI.RadLabelElement();
            this.result_lb = new System.Windows.Forms.RichTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.backgroundWorker_reponser = new System.ComponentModel.BackgroundWorker();
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.waitingBarIndicatorElement2 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            this.waitingBarIndicatorElement1 = new Telerik.WinControls.UI.WaitingBarIndicatorElement();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.target_url_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // target_url_tb
            // 
            this.target_url_tb.Location = new System.Drawing.Point(12, 45);
            this.target_url_tb.Name = "target_url_tb";
            this.target_url_tb.NullText = "example : hackers.zone";
            this.target_url_tb.Size = new System.Drawing.Size(274, 24);
            this.target_url_tb.TabIndex = 2;
            this.target_url_tb.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 21);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(54, 18);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Target url";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(310, 45);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(87, 24);
            this.radButton1.TabIndex = 4;
            this.radButton1.Text = "Get Header";
            this.radButton1.ThemeName = "VisualStudio2012Dark";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1,
            this.radLabelElement2,
            this.radLabelElement3,
            this.radLabelElement4});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 491);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(884, 26);
            this.radStatusStrip1.TabIndex = 81;
            this.radStatusStrip1.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radStatusStrip1.GetChildAt(0).GetChildAt(0))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radStatusStrip1.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(93)))), ((int)(((byte)(116)))));
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.ForeColor = System.Drawing.Color.White;
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusStrip1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "Programmer : Ebrahim Shafiei (EbraSha)  |  +98 09022223301";
            this.radLabelElement1.TextWrap = true;
            this.radLabelElement1.UseCompatibleTextRendering = false;
            // 
            // radLabelElement2
            // 
            this.radLabelElement2.ForeColor = System.Drawing.Color.White;
            this.radLabelElement2.Name = "radLabelElement2";
            this.radStatusStrip1.SetSpring(this.radLabelElement2, false);
            this.radLabelElement2.Text = "|  Prof.Shafiei@Gmail.com";
            this.radLabelElement2.TextWrap = true;
            this.radLabelElement2.UseCompatibleTextRendering = false;
            // 
            // radLabelElement3
            // 
            this.radLabelElement3.Name = "radLabelElement3";
            this.radStatusStrip1.SetSpring(this.radLabelElement3, false);
            this.radLabelElement3.Text = "";
            this.radLabelElement3.TextWrap = true;
            this.radLabelElement3.UseCompatibleTextRendering = false;
            // 
            // radLabelElement4
            // 
            this.radLabelElement4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radLabelElement4.Name = "radLabelElement4";
            this.radStatusStrip1.SetSpring(this.radLabelElement4, false);
            this.radLabelElement4.Text = "| Powered By Abdal Security Agency ";
            this.radLabelElement4.TextWrap = true;
            this.radLabelElement4.UseCompatibleTextRendering = false;
            // 
            // result_lb
            // 
            this.result_lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.result_lb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_lb.ForeColor = System.Drawing.Color.LightGray;
            this.result_lb.Location = new System.Drawing.Point(12, 99);
            this.result_lb.Name = "result_lb";
            this.result_lb.Size = new System.Drawing.Size(519, 368);
            this.result_lb.TabIndex = 7;
            this.result_lb.Text = "";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 75);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(93, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Response Header";
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // backgroundWorker_reponser
            // 
            this.backgroundWorker_reponser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_reponser_DoWork);
            this.backgroundWorker_reponser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_reponser_RunWorkerCompleted);
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.Location = new System.Drawing.Point(571, 367);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.Size = new System.Drawing.Size(256, 24);
            this.radWaitingBar1.TabIndex = 85;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.ThemeName = "VisualStudio2012Dark";
            this.radWaitingBar1.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.radWaitingBar1.WaitingBarElement.SeparatorElement.Dash = true;
            this.radWaitingBar1.WaitingIndicators.Add(this.waitingBarIndicatorElement2);
            this.radWaitingBar1.WaitingIndicators.Add(this.waitingBarIndicatorElement1);
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash;
            ((Telerik.WinControls.UI.WaitingBarContentElement)(this.radWaitingBar1.GetChildAt(0).GetChildAt(0))).WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash;
            ((Telerik.WinControls.UI.WaitingBarSeparatorElement)(this.radWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Dash = true;
            // 
            // waitingBarIndicatorElement2
            // 
            this.waitingBarIndicatorElement2.Name = "waitingBarIndicatorElement2";
            this.waitingBarIndicatorElement2.StretchHorizontally = false;
            // 
            // waitingBarIndicatorElement1
            // 
            this.waitingBarIndicatorElement1.Name = "waitingBarIndicatorElement1";
            this.waitingBarIndicatorElement1.StretchHorizontally = false;
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(403, 45);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(72, 24);
            this.radButton2.TabIndex = 5;
            this.radButton2.Text = "Cancel";
            this.radButton2.ThemeName = "VisualStudio2012Dark";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Abdal_Header_Analyzer.Properties.Resources.Trash_Empty;
            this.pictureBox5.Location = new System.Drawing.Point(479, 45);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 86;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Abdal_Header_Analyzer.Properties.Resources.logo;
            this.pictureBox4.Location = new System.Drawing.Point(571, 84);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(256, 256);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 84;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Abdal_Header_Analyzer.Properties.Resources.gitlab_icon_rgb;
            this.pictureBox3.Location = new System.Drawing.Point(770, 451);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 83;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Abdal_Header_Analyzer.Properties.Resources.github;
            this.pictureBox2.Location = new System.Drawing.Point(808, 451);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Abdal_Header_Analyzer.Properties.Resources.coin_5_32;
            this.pictureBox1.Location = new System.Drawing.Point(846, 451);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(884, 517);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radWaitingBar1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.result_lb);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.target_url_tb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Abdal Header Analyzer";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.target_url_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox target_url_tb;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement2;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement3;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RichTextBox result_lb;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.ComponentModel.BackgroundWorker backgroundWorker_reponser;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement2;
        private Telerik.WinControls.UI.WaitingBarIndicatorElement waitingBarIndicatorElement1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

