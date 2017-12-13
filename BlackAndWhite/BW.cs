// Nichts spezielles. Alles hier ist da s einfachste vom einfachen. Keine Dynamik oder NNs.

using System.Drawing; // Du musst bei NuGet System.Drawing.Primitives runterladen

namespace BW
{
    static class ImageProcessing
    {
        public static Bitmap BW(Bitmap bmp)
        {
            Bitmap copy = bmp;
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color pixelColor = copy.GetPixel(x,y);
                    int averageColor = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color monochrome = Color.FromArgb(averageColor,averageColor,averageColor);
                    copy.SetPixel(x,y,monochrome); //Wir setzen die den Pixel mit der Farbe monochrome
                }
            }
        }
    }
}