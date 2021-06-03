using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexFetch
{
    public class MarkdownGenerator
    {
        public enum GenerationMode
        {
            Default,
            GlossarQA
        }

        private List<ScreenCaptureItem> itemsToGenerate;

        private GenerationMode genMode;

        public MarkdownGenerator(List<ScreenCaptureItem> i, GenerationMode m = GenerationMode.Default)
        {
            this.itemsToGenerate = i;
            this.genMode = m;
        }



        public string Generate()
        {
            if(genMode == GenerationMode.Default)
            {
                return this.generateDefault();
            } else if (genMode == GenerationMode.GlossarQA)
            {
                return this.generateGlossarQA();
            }

            return string.Empty;
        }

        public string RemoveNewLine(string str)
        {
            return str.Replace("\n", "").Replace("\r", "").Trim();
        }

        private string generateGlossarQA()
        {
            // MD syntax for dotCards

            List<string> sb = new List<string>();

            bool isQuestion = true;
            foreach (ScreenCaptureItem item in this.itemsToGenerate)
            {
                if(isQuestion)
                {
                    sb.Add("### Begriff");
                    sb.Add(Environment.NewLine);
                    sb.Add(this.lineToMarkdown(item, item.GenrationType));
                    sb.Add(Environment.NewLine);
                    sb.Add("---");
                    sb.Add(Environment.NewLine);
                } else
                {
                    sb.Add(this.lineToMarkdown(item, item.GenrationType));
                }
                isQuestion = !isQuestion;
            }

            string res = string.Empty;
            foreach (string str in sb)
            {
                res += str + Environment.NewLine;
            }

            return res;
        }

        private string generateDefault()
        {
            List<string> sb = new List<string>();
            try
            {
                foreach (ScreenCaptureItem item in this.itemsToGenerate)
                {
                    if (item.GenrationType != MkGenrationType.Image && item.Text == string.Empty)
                    {
                        continue;
                    }

                    sb.Add(this.lineToMarkdown(item, item.GenrationType));

                    sb.Add(@"");
                    sb.Add(@"");

                }

                string res = string.Empty;
                foreach (string str in sb)
                {
                    res += str + Environment.NewLine;
                }

                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return string.Empty;
        }

        private string lineToMarkdown(ScreenCaptureItem item, MkGenrationType genType)
        {
            List<string> sb = new List<string>();

            switch (genType)
            {
                case MkGenrationType.Text:
                    sb.Add(item.Text);
                    break;

                case MkGenrationType.OneHash:
                    sb.Add(@"#" + @" " + this.RemoveNewLine(item.Text));
                    break;

                case MkGenrationType.TwoHash:
                    sb.Add(@"##" + @" " + this.RemoveNewLine(item.Text));
                    break;

                case MkGenrationType.ThreeHash:
                    sb.Add(@"###" + @" " + this.RemoveNewLine(item.Text));
                    break;

                case MkGenrationType.FourHash:
                    sb.Add(@"####" + @" " + this.RemoveNewLine(item.Text));
                    break;

                case MkGenrationType.FiveHash:
                    sb.Add(@"#####" + @" " + this.RemoveNewLine(item.Text));
                    break;

                case MkGenrationType.Summary:
                    sb.Add(@">**Zusammenfassung**");
                    sb.Add(@">");
                    StringReader reader = new StringReader(item.Text);
                    string line = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        sb.Add(@">" + line);
                    }
                    break;

                case MkGenrationType.SummaryPart:
                    StringReader readerPart = new StringReader(item.Text);
                    string linePart = string.Empty;
                    while ((linePart = readerPart.ReadLine()) != null)
                    {
                        sb.Add(@">" + linePart);
                    }
                    break;

                case MkGenrationType.Image:
                    sb.Add(@"![" + item.ImageName + @"](" + @"./Content/" + item.ImageName + @".png)");
                    break;

                case MkGenrationType.Bold:
                    sb.Add(@"**" + this.RemoveNewLine(item.Text) + @"**");
                    break;

                case MkGenrationType.List:
                    sb.Add(@"+ " + this.RemoveNewLine(item.Text));
                    break;

            }

            string res = string.Empty;
            foreach (string str in sb)
            {
                res += str + Environment.NewLine;
            }
            return res;
        }
    }
}
