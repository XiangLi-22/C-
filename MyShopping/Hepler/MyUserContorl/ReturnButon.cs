using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Shopping.MyUserContorl
{
    public partial class ReturnButon : UserControl
    {
        public ReturnButon()
        {
            InitializeComponent();
        }

        //static string path = Path.Combine(Environment.CurrentDirectory, @"..\..\image\返回.png");
        static string path = @"D:\上位机正式课\MyShopping1\MyShopping\Shopping\image\返回.png";
        Image image = Image.FromFile(path);
        static bool isMouseOver = false;
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

            // 仅调整透明度
            float opacity = isMouseOver ? 0.6f : 1.0f;  // 透明度（鼠标悬停时降低）

            float[][] colorMatrixElements = {
                new float[] {1, 0, 0, 0, 0},  // Red
                new float[] {0, 1, 0, 0, 0},  // Green
                new float[] {0, 0, 1, 0, 0},  // Blue
                new float[] {0, 0, 0, opacity, 0},  // Alpha（透明度）
                new float[] {0, 0, 0, 0, 1}   // 保持不变
            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imgAttributes = new ImageAttributes();
            imgAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            // 绘制调整后的图片
            g.DrawImage(image, rectDest, rectSrc.X, rectSrc.Y, rectSrc.Width, rectSrc.Height, GraphicsUnit.Pixel, imgAttributes);
        }

        private void ReturnButon_MouseEnter(object sender, System.EventArgs e)
        {
            isMouseOver = true;
            this.Invalidate(); // 重新绘制控件
        }

        private void ReturnButon_MouseLeave(object sender, System.EventArgs e)
        {
            isMouseOver = false;
            this.Invalidate(); // 重新绘制控件
        }
    }
}
