using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoRecycle.UI
{
    public partial class Form主窗口 : Form
    {
        public Form主窗口()
        {
            InitializeComponent();
        }

        private void Form主窗口_KeyDown(object sender, KeyEventArgs e)
        {
            //按下Esc键，退出程序
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit(); // 或者使用 this.Close();
            }
        }

        private void TabControl上_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 获取当前选中的标签页索引
            int selectedIndex = tabControl上.SelectedIndex;

            // 根据索引判断是否切换到了 "广告" 标签页
            if (selectedIndex == 0) //  "广告" 标签页的索引为 0
            {
                // 在 "广告" 标签页上播放视频
                PlayVideo();
            }
            else
            {

            }
        }
        private void PlayVideo()
        {
            axWindowsMediaPlayer1.URL = "D:\\work\\source\\EcoRecycle\\EcoRecycle\\bin\\Debug\\AdVideos\\绿水青山.mp4"; // 指定视频文件的路径
            axWindowsMediaPlayer1.Ctlcontrols.play(); // 开始播放
        }
    }
}
