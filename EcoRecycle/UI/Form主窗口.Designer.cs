namespace EcoRecycle.UI
{
    partial class Form主窗口
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
            this.splitContainer主页面 = new System.Windows.Forms.SplitContainer();
            this.tabControl上 = new System.Windows.Forms.TabControl();
            this.tabPage广告 = new System.Windows.Forms.TabPage();
            this.tabPage摄像 = new System.Windows.Forms.TabPage();
            this.splitContainer摄像 = new System.Windows.Forms.SplitContainer();
            this.tabControl下 = new System.Windows.Forms.TabControl();
            this.tabPage登录 = new System.Windows.Forms.TabPage();
            this.splitContainer登录 = new System.Windows.Forms.SplitContainer();
            this.tabPage用户 = new System.Windows.Forms.TabPage();
            this.button扫码登录 = new System.Windows.Forms.Button();
            this.button手机号登录 = new System.Windows.Forms.Button();
            this.button人脸识别 = new System.Windows.Forms.Button();
            this.buttonIC卡登录 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer主页面)).BeginInit();
            this.splitContainer主页面.Panel1.SuspendLayout();
            this.splitContainer主页面.Panel2.SuspendLayout();
            this.splitContainer主页面.SuspendLayout();
            this.tabControl上.SuspendLayout();
            this.tabPage摄像.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer摄像)).BeginInit();
            this.splitContainer摄像.SuspendLayout();
            this.tabControl下.SuspendLayout();
            this.tabPage登录.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer登录)).BeginInit();
            this.splitContainer登录.Panel2.SuspendLayout();
            this.splitContainer登录.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer主页面
            // 
            this.splitContainer主页面.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer主页面.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer主页面.IsSplitterFixed = true;
            this.splitContainer主页面.Location = new System.Drawing.Point(0, 0);
            this.splitContainer主页面.Name = "splitContainer主页面";
            this.splitContainer主页面.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer主页面.Panel1
            // 
            this.splitContainer主页面.Panel1.Controls.Add(this.tabControl上);
            // 
            // splitContainer主页面.Panel2
            // 
            this.splitContainer主页面.Panel2.Controls.Add(this.tabControl下);
            this.splitContainer主页面.Size = new System.Drawing.Size(1280, 720);
            this.splitContainer主页面.SplitterDistance = 360;
            this.splitContainer主页面.TabIndex = 0;
            // 
            // tabControl上
            // 
            this.tabControl上.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl上.Controls.Add(this.tabPage广告);
            this.tabControl上.Controls.Add(this.tabPage摄像);
            this.tabControl上.Location = new System.Drawing.Point(3, 5);
            this.tabControl上.Multiline = true;
            this.tabControl上.Name = "tabControl上";
            this.tabControl上.SelectedIndex = 0;
            this.tabControl上.Size = new System.Drawing.Size(1274, 357);
            this.tabControl上.TabIndex = 0;
            this.tabControl上.SelectedIndexChanged += new System.EventHandler(this.TabControl上_SelectedIndexChanged);
            // 
            // tabPage广告
            // 
            this.tabPage广告.Location = new System.Drawing.Point(22, 4);
            this.tabPage广告.Name = "tabPage广告";
            this.tabPage广告.Size = new System.Drawing.Size(1248, 349);
            this.tabPage广告.TabIndex = 0;
            this.tabPage广告.Text = "广告";
            this.tabPage广告.UseVisualStyleBackColor = true;
            // 
            // tabPage摄像
            // 
            this.tabPage摄像.Controls.Add(this.splitContainer摄像);
            this.tabPage摄像.Location = new System.Drawing.Point(22, 4);
            this.tabPage摄像.Name = "tabPage摄像";
            this.tabPage摄像.Size = new System.Drawing.Size(1248, 349);
            this.tabPage摄像.TabIndex = 0;
            this.tabPage摄像.Text = "摄像";
            this.tabPage摄像.UseVisualStyleBackColor = true;
            // 
            // splitContainer摄像
            // 
            this.splitContainer摄像.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer摄像.Location = new System.Drawing.Point(0, 0);
            this.splitContainer摄像.Name = "splitContainer摄像";
            this.splitContainer摄像.Size = new System.Drawing.Size(1248, 349);
            this.splitContainer摄像.SplitterDistance = 609;
            this.splitContainer摄像.TabIndex = 0;
            // 
            // tabControl下
            // 
            this.tabControl下.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl下.Controls.Add(this.tabPage登录);
            this.tabControl下.Controls.Add(this.tabPage用户);
            this.tabControl下.Location = new System.Drawing.Point(3, -4);
            this.tabControl下.Multiline = true;
            this.tabControl下.Name = "tabControl下";
            this.tabControl下.SelectedIndex = 0;
            this.tabControl下.Size = new System.Drawing.Size(1274, 357);
            this.tabControl下.TabIndex = 0;
            // 
            // tabPage登录
            // 
            this.tabPage登录.Controls.Add(this.splitContainer登录);
            this.tabPage登录.Location = new System.Drawing.Point(22, 4);
            this.tabPage登录.Name = "tabPage登录";
            this.tabPage登录.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage登录.Size = new System.Drawing.Size(1248, 349);
            this.tabPage登录.TabIndex = 0;
            this.tabPage登录.Text = "登录";
            this.tabPage登录.UseVisualStyleBackColor = true;
            // 
            // splitContainer登录
            // 
            this.splitContainer登录.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer登录.Location = new System.Drawing.Point(3, 3);
            this.splitContainer登录.Name = "splitContainer登录";
            this.splitContainer登录.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer登录.Panel2
            // 
            this.splitContainer登录.Panel2.Controls.Add(this.buttonIC卡登录);
            this.splitContainer登录.Panel2.Controls.Add(this.button人脸识别);
            this.splitContainer登录.Panel2.Controls.Add(this.button手机号登录);
            this.splitContainer登录.Panel2.Controls.Add(this.button扫码登录);
            this.splitContainer登录.Size = new System.Drawing.Size(1242, 343);
            this.splitContainer登录.SplitterDistance = 190;
            this.splitContainer登录.TabIndex = 0;
            // 
            // tabPage用户
            // 
            this.tabPage用户.Location = new System.Drawing.Point(22, 4);
            this.tabPage用户.Name = "tabPage用户";
            this.tabPage用户.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage用户.Size = new System.Drawing.Size(1248, 349);
            this.tabPage用户.TabIndex = 1;
            this.tabPage用户.Text = "用户";
            this.tabPage用户.UseVisualStyleBackColor = true;
            // 
            // button扫码登录
            // 
            this.button扫码登录.BackColor = System.Drawing.Color.LightBlue;
            this.button扫码登录.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button扫码登录.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button扫码登录.Font = new System.Drawing.Font("新宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button扫码登录.Location = new System.Drawing.Point(61, 26);
            this.button扫码登录.Name = "button扫码登录";
            this.button扫码登录.Size = new System.Drawing.Size(221, 105);
            this.button扫码登录.TabIndex = 0;
            this.button扫码登录.Text = "扫码登录";
            this.button扫码登录.UseVisualStyleBackColor = false;
            // 
            // button手机号登录
            // 
            this.button手机号登录.BackColor = System.Drawing.Color.LightBlue;
            this.button手机号登录.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button手机号登录.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button手机号登录.Font = new System.Drawing.Font("新宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button手机号登录.Location = new System.Drawing.Point(358, 26);
            this.button手机号登录.Name = "button手机号登录";
            this.button手机号登录.Size = new System.Drawing.Size(221, 105);
            this.button手机号登录.TabIndex = 1;
            this.button手机号登录.Text = "手机号登录";
            this.button手机号登录.UseVisualStyleBackColor = false;
            // 
            // button人脸识别
            // 
            this.button人脸识别.BackColor = System.Drawing.Color.LightBlue;
            this.button人脸识别.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button人脸识别.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button人脸识别.Font = new System.Drawing.Font("新宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button人脸识别.Location = new System.Drawing.Point(655, 26);
            this.button人脸识别.Name = "button人脸识别";
            this.button人脸识别.Size = new System.Drawing.Size(221, 105);
            this.button人脸识别.TabIndex = 2;
            this.button人脸识别.Text = "人脸识别";
            this.button人脸识别.UseVisualStyleBackColor = false;
            // 
            // buttonIC卡登录
            // 
            this.buttonIC卡登录.BackColor = System.Drawing.Color.LightBlue;
            this.buttonIC卡登录.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIC卡登录.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIC卡登录.Font = new System.Drawing.Font("新宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonIC卡登录.Location = new System.Drawing.Point(952, 26);
            this.buttonIC卡登录.Name = "buttonIC卡登录";
            this.buttonIC卡登录.Size = new System.Drawing.Size(221, 105);
            this.buttonIC卡登录.TabIndex = 3;
            this.buttonIC卡登录.Text = "IC卡登录";
            this.buttonIC卡登录.UseVisualStyleBackColor = false;
            // 
            // Form主窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer主页面);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form主窗口";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form主窗口";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form主窗口_KeyDown);
            this.splitContainer主页面.Panel1.ResumeLayout(false);
            this.splitContainer主页面.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer主页面)).EndInit();
            this.splitContainer主页面.ResumeLayout(false);
            this.tabControl上.ResumeLayout(false);
            this.tabPage摄像.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer摄像)).EndInit();
            this.splitContainer摄像.ResumeLayout(false);
            this.tabControl下.ResumeLayout(false);
            this.tabPage登录.ResumeLayout(false);
            this.splitContainer登录.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer登录)).EndInit();
            this.splitContainer登录.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer主页面;
        private System.Windows.Forms.TabControl tabControl下;
        private System.Windows.Forms.TabPage tabPage登录;
        private System.Windows.Forms.TabPage tabPage用户;
        private System.Windows.Forms.SplitContainer splitContainer登录;
        private System.Windows.Forms.TabControl tabControl上;
        private System.Windows.Forms.TabPage tabPage广告;
        private System.Windows.Forms.TabPage tabPage摄像;
        private System.Windows.Forms.SplitContainer splitContainer摄像;
        private System.Windows.Forms.Button button扫码登录;
        private System.Windows.Forms.Button buttonIC卡登录;
        private System.Windows.Forms.Button button人脸识别;
        private System.Windows.Forms.Button button手机号登录;
    }
}