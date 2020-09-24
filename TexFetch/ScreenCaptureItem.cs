using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexFetch
{

    public enum MkGenrationType
    {
        Text,

        OneHash,

        TwoHash,

        ThreeHash,

        FourHash,

        FiveHash,

        Summary,

        SummaryPart,

        Image,

        Bold,

        List
    }

    public class ScreenCaptureItem
    {
        public ScreenCaptureItem(string name, Bitmap image, string text)
        {
            this.Name = name;
            this.Text = text;
            this.Image = image;

            this.ImageName = string.Empty;
            this.GenrationType = MkGenrationType.Text;
        }

        public string Name { get; set; }

        public bool TextGenerated { get; set; }

        public string Text { get; set; }

        public Bitmap Image { get; set; }

        public string ImageName { get; set; }

        public MkGenrationType GenrationType { get; set; }

        public override string ToString()
        {
            return this.Name + " - ( " + this.GenrationType.ToString() + " ) ";
        }
    }
}
