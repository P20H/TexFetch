﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace TexFetch
{
    class TexFetch
    {

        public static Bitmap Snip(int x, int y, int w, int h)
        {
            Bitmap final_image;
            //string dir = "";

            Image screenshot = takeScreenshot();

            Rectangle rect = new Rectangle(
                Utils.GetScaleFactor() * Screen.left * -1 + x, 
                Utils.GetScaleFactor() * Screen.top  * -1 + y, 
                w, 
                h);
            Bitmap originalImage = new Bitmap(screenshot, screenshot.Width, screenshot.Height);

            if(w <= 0 || h <= 0)
            {
                return new Bitmap(10, 10);
            }

            final_image = new Bitmap(w, h);

            Graphics g = Graphics.FromImage(final_image);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.DrawImage(originalImage, 0, 0, rect, GraphicsUnit.Pixel);

            return final_image;

            //save();
        }

        private static Image takeScreenshot()
        {
            Bitmap printscreen = new Bitmap(Utils.GetScaleFactor() * Screen.width, Utils.GetScaleFactor() * Screen.height);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(
                Utils.GetScaleFactor() * Screen.left,
                Utils.GetScaleFactor() * Screen.top, 
                0, 0, printscreen.Size);

            Image scr;
            using (MemoryStream s = new MemoryStream())
            {
                printscreen.Save(s, ImageFormat.Bmp);
                scr = Image.FromStream(s);
            }

            return scr;
        }

        private void save()
        {
            //var path = getPath();
            //final_image.Save(path, ImageFormat.Png);
            //System.Diagnostics.Process.Start("explorer.exe", @dir);
        }

        private string getPath()
        {

            //string[] args = Environment.GetCommandLineArgs();
            //if (args.Length == 2) dir = args[1];
            //if (dir.Length == 0 || !Directory.Exists(dir)) dir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\Screenshots\\";
            //Directory.CreateDirectory(dir);
            //
            //var name = DateTime.Now.ToString().Replace(".", "-").Replace(" ", "_").Replace(":", "-").Replace("/", "-").Replace("\\", "-");
            //var path = dir + "\\" + name + ".png";
            //int i = 2;
            //while (File.Exists(path))
            //{
            //    path = dir + "\\" + name + "_" + i + ".png";
            //    i++;
            //}
            //return path;

            return string.Empty;
        }

    }
}
