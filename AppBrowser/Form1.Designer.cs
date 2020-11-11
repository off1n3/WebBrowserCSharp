namespace AppBrowser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbMaximize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.cmbBookM = new System.Windows.Forms.ComboBox();
            this.pboxEnter = new System.Windows.Forms.PictureBox();
            this.pbGray = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookMark = new System.Windows.Forms.PictureBox();
            this.tableURL = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnReload = new System.Windows.Forms.PictureBox();
            this.btnForward = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBookMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableURL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbMinimize);
            this.panel1.Controls.Add(this.pbMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 37);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimize.Image = global::AppBrowser.Properties.Resources.Ellipse_5_2x;
            this.pbMinimize.Location = new System.Drawing.Point(1550, 12);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(16, 16);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 0;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pbMaximize
            // 
            this.pbMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximize.Image = global::AppBrowser.Properties.Resources.Ellipse_4_2x;
            this.pbMaximize.Location = new System.Drawing.Point(1528, 12);
            this.pbMaximize.Name = "pbMaximize";
            this.pbMaximize.Size = new System.Drawing.Size(16, 16);
            this.pbMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaximize.TabIndex = 0;
            this.pbMaximize.TabStop = false;
            this.pbMaximize.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::AppBrowser.Properties.Resources.Ellipse_3_2x;
            this.btnClose.Location = new System.Drawing.Point(1572, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.txtURL);
            this.panel2.Controls.Add(this.cmbBookM);
            this.panel2.Controls.Add(this.pboxEnter);
            this.panel2.Controls.Add(this.pbGray);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnBookMark);
            this.panel2.Controls.Add(this.tableURL);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.btnForward);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 100);
            this.panel2.TabIndex = 1;
            // 
            // txtURL
            // 
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.ForeColor = System.Drawing.Color.Gray;
            this.txtURL.Location = new System.Drawing.Point(338, 43);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(716, 19);
            this.txtURL.TabIndex = 4;
            this.txtURL.Enter += new System.EventHandler(this.txtURL_Enter);
            this.txtURL.Leave += new System.EventHandler(this.txtURL_Leave);
            // 
            // cmbBookM
            // 
            this.cmbBookM.FormattingEnabled = true;
            this.cmbBookM.Location = new System.Drawing.Point(1317, 68);
            this.cmbBookM.Name = "cmbBookM";
            this.cmbBookM.Size = new System.Drawing.Size(192, 21);
            this.cmbBookM.TabIndex = 2;
            this.cmbBookM.SelectedIndexChanged += new System.EventHandler(this.cmbBookM_SelectedIndexChanged);
            // 
            // pboxEnter
            // 
            this.pboxEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.pboxEnter.Image = global::AppBrowser.Properties.Resources.Path_6;
            this.pboxEnter.Location = new System.Drawing.Point(1072, 27);
            this.pboxEnter.Name = "pboxEnter";
            this.pboxEnter.Size = new System.Drawing.Size(45, 50);
            this.pboxEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxEnter.TabIndex = 3;
            this.pboxEnter.TabStop = false;
            this.pboxEnter.Click += new System.EventHandler(this.NavigateBtn);
            // 
            // pbGray
            // 
            this.pbGray.BackColor = System.Drawing.Color.Transparent;
            this.pbGray.Image = global::AppBrowser.Properties.Resources.Rectangle_4;
            this.pbGray.Location = new System.Drawing.Point(1072, 27);
            this.pbGray.Name = "pbGray";
            this.pbGray.Size = new System.Drawing.Size(47, 50);
            this.pbGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGray.TabIndex = 3;
            this.pbGray.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1387, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Favoritos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBookMark
            // 
            this.btnBookMark.Image = global::AppBrowser.Properties.Resources.Rectangle_3_2x;
            this.btnBookMark.Location = new System.Drawing.Point(1317, 23);
            this.btnBookMark.Name = "btnBookMark";
            this.btnBookMark.Size = new System.Drawing.Size(192, 39);
            this.btnBookMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBookMark.TabIndex = 1;
            this.btnBookMark.TabStop = false;
            this.btnBookMark.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // tableURL
            // 
            this.tableURL.Image = global::AppBrowser.Properties.Resources.Url;
            this.tableURL.Location = new System.Drawing.Point(285, 27);
            this.tableURL.Name = "tableURL";
            this.tableURL.Size = new System.Drawing.Size(818, 50);
            this.tableURL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tableURL.TabIndex = 0;
            this.tableURL.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Image = global::AppBrowser.Properties.Resources.Component_4_;
            this.btnStop.Location = new System.Drawing.Point(179, 27);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 50);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStop.TabIndex = 0;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // btnReload
            // 
            this.btnReload.Image = global::AppBrowser.Properties.Resources.kisspng_computer_icons_refresh_free_download_clip_art_one_button_reload_5b282ade2291f2_8680520715293590701416_2x;
            this.btnReload.Location = new System.Drawing.Point(179, 27);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(100, 50);
            this.btnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReload.TabIndex = 0;
            this.btnReload.TabStop = false;
            this.btnReload.Click += new System.EventHandler(this.reload_Click);
            // 
            // btnForward
            // 
            this.btnForward.Image = global::AppBrowser.Properties.Resources.Group_5_2x;
            this.btnForward.Location = new System.Drawing.Point(112, 27);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(52, 50);
            this.btnForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnForward.TabIndex = 0;
            this.btnForward.TabStop = false;
            this.btnForward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::AppBrowser.Properties.Resources.Group_4_2x;
            this.btnBack.Location = new System.Drawing.Point(53, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(53, 50);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.Back_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 138);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1600, 690);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 834);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(252, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1600, 869);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBookMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableURL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbMaximize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnReload;
        private System.Windows.Forms.PictureBox btnForward;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox tableURL;
        private System.Windows.Forms.PictureBox btnBookMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboxEnter;
        private System.Windows.Forms.PictureBox pbGray;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox cmbBookM;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

