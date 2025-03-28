    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Shopping.MyUserContorl
    {
        public partial class AddButton : UserControl
        {
            public AddButton()
            {
                InitializeComponent();
            }

            static string path = @"D:\上位机正式课\MyShopping\Shopping\加.png";
            Image image = Image.FromFile(path);

            static bool isMouseOver = false;

        protected override void OnPaint(PaintEventArgs pevent)
            {
                base.OnPaint(pevent);
            
                Graphics g = pevent.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias; // 抗锯齿
                g.CompositingQuality = CompositingQuality.HighQuality; // 组合图像质量
                g.InterpolationMode = InterpolationMode.HighQualityBicubic; // 插值模式（影响缩放质量）
                g.PixelOffsetMode = PixelOffsetMode.HighQuality; // 像素偏移模式，提升抗锯齿效果

                RectangleF rectSrc = new RectangleF(0, 0, image.Width, image.Height);
                Rectangle rectDest = new Rectangle(0, 0, this.Width, this.Height);

                // 颜色矩阵：鼠标悬停时变淡
                float opacity = isMouseOver ? 0.8f : 1.0f;  // 透明度（鼠标悬停时降低）
                float brightness = isMouseOver ? 1.3f : 1.0f;  // 亮度增加，使其更淡

                float[][] colorMatrixElements = {
                    new float[] {brightness, 0, 0, 0, 0},  // Red
                    new float[] {0, brightness, 0, 0, 0},  // Green
                    new float[] {0, 0, brightness, 0, 0},  // Blue
                    new float[] {0, 0, 0, opacity, 0},  // Alpha（透明度）
                    new float[] {0.2f, 0.2f, 0.2f, 0, 1}  // 增加亮度
                };

                ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                ImageAttributes imgAttributes = new ImageAttributes();
                imgAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                // 绘制调整后的图片
                g.DrawImage(image, rectDest, rectSrc.X, rectSrc.Y, rectSrc.Width, rectSrc.Height, GraphicsUnit.Pixel, imgAttributes);
            }

            private void MyButton_MouseEnter(object sender, EventArgs e)
            {
                isMouseOver = true;
                this.Invalidate(); // 重新绘制控件
            }

            private void MyButton_MouseLeave(object sender, EventArgs e)
            {
                isMouseOver = false;
                this.Invalidate(); // 重新绘制控件
            }
        }
    }
