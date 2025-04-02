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
    public partial class NextPageButton : UserControl
    {
        //static string page = Path.Combine(Environment.CurrentDirectory, @"..\..\image\next.png");
        static string page = @"D:\上位机正式课\MyShopping1\MyShopping\Shopping\image\next.png";
        Image image = Image.FromFile(page);

        public NextPageButton()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;


            RectangleF rectSrc = new RectangleF(0, 0, image.Width, image.Height);
            Rectangle rectDest = new Rectangle(0, 0, this.Width, this.Height);
            g.DrawImage(image, rectDest, rectSrc.X, rectSrc.Y, rectSrc.Width, rectSrc.Height, GraphicsUnit.Pixel);
        }

    }
}
