using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TOK_IOT : Form
    {
        public TOK_IOT()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this.axVLCPlugin21.playlist.add(@"http://bitdash-a.akamaihd.net/content/sintel/hls/video/250kbit.m3u8");
            this.axVLCPlugin21.playlist.add(@"rtsp://47.106.209.211:8554/tok.mp4");
            this.axVLCPlugin21.playlist.play();
        }
    }
}
