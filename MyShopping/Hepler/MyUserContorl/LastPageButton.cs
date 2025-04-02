using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hepler.MyUserContorl
{
    public partial class LastPageButton : UserControl
    {
        public LastPageButton()
        {
            InitializeComponent();
        }

        //static string path = Path.Combine(Environment.CurrentDirectory, @"..\..\image\last.png");
        static string path = @"D:\上位机正式课\MyShopping1\MyShopping\Shopping\image\last.png";
        Image image = Image.FromFile(path);

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // 抗锯齿
            g.CompositingQuality = CompositingQuality.HighQuality; // 组合图像质量
            g.InterpolationMode = InterpolationMode.HighQualityBicubic; // 插值模式（影响缩放质量）
            g.PixelOffsetMode = PixelOffsetMode.HighQuality; // 像素偏移模式，提升抗锯齿效果

            RectangleF rectSrc = new RectangleF(0, 0, image.Width, image.Height);
            Rectangle rectDest = new Rectangle(0, 0, this.Width, this.Height);

            g.DrawImage(image, rectDest, rectSrc.X, rectSrc.Y, rectSrc.Width, rectSrc.Height, GraphicsUnit.Pixel);
        }
    }
}
