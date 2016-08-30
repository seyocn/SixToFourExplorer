namespace SixToFourExplorer_build
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInputWebAddr = new System.Windows.Forms.Label();
            this.comboBoxWebAddr = new System.Windows.Forms.ComboBox();
            this.buttonVisit = new System.Windows.Forms.Button();
            this.buttonIPv4home = new System.Windows.Forms.Button();
            this.buttonIPv6home = new System.Windows.Forms.Button();
            this.labelWebAddrNotice = new System.Windows.Forms.Label();
            this.buttonIPv6TVneu = new System.Windows.Forms.Button();
            this.buttonNEU = new System.Windows.Forms.Button();
            this.buttonBYR = new System.Windows.Forms.Button();
            this.buttonIPv6TVbyr = new System.Windows.Forms.Button();
            this.labelVer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInputWebAddr
            // 
            this.labelInputWebAddr.AutoSize = true;
            this.labelInputWebAddr.Location = new System.Drawing.Point(29, 20);
            this.labelInputWebAddr.Name = "labelInputWebAddr";
            this.labelInputWebAddr.Size = new System.Drawing.Size(65, 12);
            this.labelInputWebAddr.TabIndex = 0;
            this.labelInputWebAddr.Text = "输入网址：";
            // 
            // comboBoxWebAddr
            // 
            this.comboBoxWebAddr.FormattingEnabled = true;
            this.comboBoxWebAddr.Location = new System.Drawing.Point(100, 17);
            this.comboBoxWebAddr.Name = "comboBoxWebAddr";
            this.comboBoxWebAddr.Size = new System.Drawing.Size(608, 20);
            this.comboBoxWebAddr.TabIndex = 1;
            // 
            // buttonVisit
            // 
            this.buttonVisit.Location = new System.Drawing.Point(714, 15);
            this.buttonVisit.Name = "buttonVisit";
            this.buttonVisit.Size = new System.Drawing.Size(75, 23);
            this.buttonVisit.TabIndex = 2;
            this.buttonVisit.Text = "访问";
            this.buttonVisit.UseVisualStyleBackColor = true;
            this.buttonVisit.Click += new System.EventHandler(this.buttonVisit_Click);
            // 
            // buttonIPv4home
            // 
            this.buttonIPv4home.Location = new System.Drawing.Point(31, 76);
            this.buttonIPv4home.Name = "buttonIPv4home";
            this.buttonIPv4home.Size = new System.Drawing.Size(377, 85);
            this.buttonIPv4home.TabIndex = 3;
            this.buttonIPv4home.Text = "IPv4网址快速导航";
            this.buttonIPv4home.UseVisualStyleBackColor = true;
            this.buttonIPv4home.Click += new System.EventHandler(this.buttonIPv4home_Click);
            // 
            // buttonIPv6home
            // 
            this.buttonIPv6home.Location = new System.Drawing.Point(412, 76);
            this.buttonIPv6home.Name = "buttonIPv6home";
            this.buttonIPv6home.Size = new System.Drawing.Size(377, 85);
            this.buttonIPv6home.TabIndex = 4;
            this.buttonIPv6home.Text = "IPv6资源列表";
            this.buttonIPv6home.UseVisualStyleBackColor = true;
            this.buttonIPv6home.Click += new System.EventHandler(this.buttonIPv6home_Click);
            // 
            // labelWebAddrNotice
            // 
            this.labelWebAddrNotice.AutoSize = true;
            this.labelWebAddrNotice.Location = new System.Drawing.Point(44, 41);
            this.labelWebAddrNotice.Name = "labelWebAddrNotice";
            this.labelWebAddrNotice.Size = new System.Drawing.Size(719, 12);
            this.labelWebAddrNotice.TabIndex = 5;
            this.labelWebAddrNotice.Text = "(暂时不支持https/SSL协议，浏览视频网站时可能无法播放视频)(IPv4地址请输入首页，暂不支持直接访问子页面，但是支持二级域名)";
            // 
            // buttonIPv6TVneu
            // 
            this.buttonIPv6TVneu.Location = new System.Drawing.Point(31, 167);
            this.buttonIPv6TVneu.Name = "buttonIPv6TVneu";
            this.buttonIPv6TVneu.Size = new System.Drawing.Size(187, 85);
            this.buttonIPv6TVneu.TabIndex = 6;
            this.buttonIPv6TVneu.Text = "高清电视直播(东北大学源)";
            this.buttonIPv6TVneu.UseVisualStyleBackColor = true;
            this.buttonIPv6TVneu.Click += new System.EventHandler(this.buttonIPv6TVneu_Click);
            // 
            // buttonNEU
            // 
            this.buttonNEU.Location = new System.Drawing.Point(412, 167);
            this.buttonNEU.Name = "buttonNEU";
            this.buttonNEU.Size = new System.Drawing.Size(187, 85);
            this.buttonNEU.TabIndex = 7;
            this.buttonNEU.Text = "六维空间";
            this.buttonNEU.UseVisualStyleBackColor = true;
            this.buttonNEU.Click += new System.EventHandler(this.buttonNEU_Click);
            // 
            // buttonBYR
            // 
            this.buttonBYR.Location = new System.Drawing.Point(602, 167);
            this.buttonBYR.Name = "buttonBYR";
            this.buttonBYR.Size = new System.Drawing.Size(187, 84);
            this.buttonBYR.TabIndex = 8;
            this.buttonBYR.Text = "北邮人";
            this.buttonBYR.UseVisualStyleBackColor = true;
            this.buttonBYR.Click += new System.EventHandler(this.buttonBYR_Click);
            // 
            // buttonIPv6TVbyr
            // 
            this.buttonIPv6TVbyr.Location = new System.Drawing.Point(219, 167);
            this.buttonIPv6TVbyr.Name = "buttonIPv6TVbyr";
            this.buttonIPv6TVbyr.Size = new System.Drawing.Size(187, 84);
            this.buttonIPv6TVbyr.TabIndex = 9;
            this.buttonIPv6TVbyr.Text = "高清电视直播(北邮源)";
            this.buttonIPv6TVbyr.UseVisualStyleBackColor = true;
            this.buttonIPv6TVbyr.Click += new System.EventHandler(this.buttonIPv6TVbyr_Click);
            // 
            // labelVer
            // 
            this.labelVer.AutoSize = true;
            this.labelVer.Location = new System.Drawing.Point(31, 269);
            this.labelVer.Name = "labelVer";
            this.labelVer.Size = new System.Drawing.Size(59, 12);
            this.labelVer.TabIndex = 10;
            this.labelVer.Text = "Version: ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 293);
            this.Controls.Add(this.labelVer);
            this.Controls.Add(this.buttonIPv6TVbyr);
            this.Controls.Add(this.buttonBYR);
            this.Controls.Add(this.buttonNEU);
            this.Controls.Add(this.buttonIPv6TVneu);
            this.Controls.Add(this.labelWebAddrNotice);
            this.Controls.Add(this.buttonIPv6home);
            this.Controls.Add(this.buttonIPv4home);
            this.Controls.Add(this.buttonVisit);
            this.Controls.Add(this.comboBoxWebAddr);
            this.Controls.Add(this.labelInputWebAddr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "6to4浏览器";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputWebAddr;
        private System.Windows.Forms.ComboBox comboBoxWebAddr;
        private System.Windows.Forms.Button buttonVisit;
        private System.Windows.Forms.Button buttonIPv4home;
        private System.Windows.Forms.Button buttonIPv6home;
        private System.Windows.Forms.Label labelWebAddrNotice;
        private System.Windows.Forms.Button buttonIPv6TVneu;
        private System.Windows.Forms.Button buttonNEU;
        private System.Windows.Forms.Button buttonBYR;
        private System.Windows.Forms.Button buttonIPv6TVbyr;
        private System.Windows.Forms.Label labelVer;
    }
}

