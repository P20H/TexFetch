using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace TexFetch
{
    public partial class FrmMain : Form
    {
        #region Private vars

        private TesseractEngine engine;

        #endregion

        #region Construktor

        public FrmMain()
        {
            InitializeComponent();

            this.engine = new TesseractEngine("./tessdata", "deu", EngineMode.Default);
            this.txtImageSaveLoc.Text = Properties.Settings.Default.ImageSavePath;

            this.grpOptions.Visible = false;
        }

        #endregion

        #region Private Methods

        private void updateMarkdownOptions(ScreenCaptureItem sci)
        {

            this.rdbText.Checked      = sci.GenrationType == MkGenrationType.Text;
            this.rdbOneHash.Checked   = sci.GenrationType == MkGenrationType.OneHash;
            this.rdbTwoHash.Checked   = sci.GenrationType == MkGenrationType.TwoHash;
            this.rdbThreeHash.Checked = sci.GenrationType == MkGenrationType.ThreeHash;
            this.rdbFourHash.Checked  = sci.GenrationType == MkGenrationType.FourHash;
            this.rdbFiveHash.Checked  = sci.GenrationType == MkGenrationType.FiveHash;
            this.rdbImage.Checked     = sci.GenrationType == MkGenrationType.Image;
            this.rdbSummary.Checked   = sci.GenrationType == MkGenrationType.Summary;
            this.rdbZSBlock.Checked   = sci.GenrationType == MkGenrationType.SummaryPart;
            this.rdbBold.Checked      = sci.GenrationType == MkGenrationType.Bold;
            this.rdbList.Checked      = sci.GenrationType == MkGenrationType.List;

            this.txtImgName.Text = sci.ImageName;

        }

        private void setMarkdownOptions()
        {

            ScreenCaptureItem itm = (ScreenCaptureItem)this.lstCapture.SelectedItems[0];

            if (this.rdbText.Checked)
            {
                itm.GenrationType = MkGenrationType.Text;
            }
            else if (this.rdbOneHash.Checked)
            {
                itm.GenrationType = MkGenrationType.OneHash;
            }
            else if (this.rdbTwoHash.Checked)
            {
                itm.GenrationType = MkGenrationType.TwoHash;
            }
            else if (this.rdbThreeHash.Checked)
            {
                itm.GenrationType = MkGenrationType.ThreeHash;
            }
            else if (this.rdbFourHash.Checked)
            {
                itm.GenrationType = MkGenrationType.FourHash;
            }
            else if (this.rdbFiveHash.Checked)
            {
                itm.GenrationType = MkGenrationType.FiveHash;
            }
            else if (this.rdbSummary.Checked)
            {
                itm.GenrationType = MkGenrationType.Summary;
            }
            else if (this.rdbZSBlock.Checked)
            {
                itm.GenrationType = MkGenrationType.SummaryPart;
            }
            else if (this.rdbImage.Checked)
            {
                itm.GenrationType = MkGenrationType.Image;
            }
            else if (this.rdbBold.Checked)
            {
                itm.GenrationType = MkGenrationType.Bold;
            }
            else if (this.rdbList.Checked)
            {
                itm.GenrationType = MkGenrationType.List;
            }


            this.txtImgName.Enabled = this.rdbImage.Checked;
            this.lstCapture.Items[this.lstCapture.SelectedIndices[0]] = itm;


            this.updateMarkdownOptions(itm);
        }

        private string detectText(Bitmap image)
        {
            Page pg = this.engine.Process(image, PageSegMode.Auto);
            string text = pg.GetText();

            pg.Dispose();

            return text;
        }

        #endregion

        #region Events

        private void btnCapture_Click(object sender, EventArgs e)
        {
            Overlay ovr = new Overlay();
            Bitmap gr = ovr.Init();
            string text = string.Empty;

            ScreenCaptureItem item = new ScreenCaptureItem(DateTime.Now.ToString(), gr, string.Empty);
            item.ImageName = "img_" + this.lstCapture.Items.Count.ToString();
            this.lstCapture.Items.Add(item);

            this.lstCapture.SelectedIndex = this.lstCapture.Items.Count - 1;
        }

        private void lstCapture_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.grpOptions.Visible = this.lstCapture.Items.Count > 0;

            if (this.lstCapture.SelectedItems.Count > 0)
            {
                ScreenCaptureItem sci = (ScreenCaptureItem)this.lstCapture.SelectedItems[0];

                this.picPreview.Image = sci.Image;
                this.picPreviewMk.Image = sci.Image;
                this.txtText.Text = sci.Text;

                this.updateMarkdownOptions(sci);
            }
            else
            {
                this.picPreview.Image = null;
                this.picPreviewMk.Image = null;
                this.txtText.Text = string.Empty;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.lstCapture.SelectedItems.Count > 0)
            {
                this.lstCapture.Items.RemoveAt(this.lstCapture.SelectedIndex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.lstCapture.SelectedItems.Count > 0)
            {
                ScreenCaptureItem lb = (ScreenCaptureItem)this.lstCapture.SelectedItems[0];

                // https://ourcodeworld.com/articles/read/890/how-to-solve-csharp-exception-current-thread-must-be-set-to-single-thread-apartment-sta-mode-before-ole-calls-can-be-made-ensure-that-your-main-function-has-stathreadattribute-marked-on-it#:~:text=ThreadStateException%3A%20'Current%20thread%20must%20be,'

                Thread t = new Thread((ThreadStart)(() =>
                {
                    using (SaveFileDialog dlg = new SaveFileDialog())
                    {

                        dlg.DefaultExt = "png";
                        dlg.Filter = "png (*.png)|*.png";

                        DialogResult res = dlg.ShowDialog();
                        if (res == DialogResult.OK)
                        {
                            lb.Image.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }

                }));

                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                t.Join();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string clipText = this.txtText.Text;
            Thread t = new Thread((ThreadStart)(() =>
            {
                System.Windows.Forms.Clipboard.SetText(clipText);
            }
            ));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(this.lstCapture.SelectedItems.Count <= 0)
            {
                return;
            }
            this.lstCapture.Items.Clear();
        }

        private void rdbOneHash_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lstCapture.SelectedItems.Count <= 0)
            {
                return;
            }
            this.setMarkdownOptions();
        }

        private void rdbTwoHash_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lstCapture.SelectedItems.Count <= 0)
            {
                return;
            }
            this.setMarkdownOptions();
        }

        private void rdbThreeHash_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lstCapture.SelectedItems.Count <= 0)
            {
                return;
            }
            this.setMarkdownOptions();
        }

        private void rdbFourHash_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lstCapture.SelectedItems.Count <= 0)
            {
                return;
            }
            this.setMarkdownOptions();
        }

        private void rdbFiveHash_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lstCapture.SelectedItems.Count <= 0)
            {
                return;
            }
            this.setMarkdownOptions();
        }

        private void rdbImage_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lstCapture.SelectedItems.Count <= 0)
            {
                return;
            }
            this.setMarkdownOptions();
        }

        private void rdbSummary_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lstCapture.SelectedItems.Count <= 0)
            {
                return;
            }
            this.setMarkdownOptions();
        }

        private void rdbText_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lstCapture.SelectedItems.Count <= 0)
            {
                return;
            }
            this.setMarkdownOptions();
        }

        private void rdbZSBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lstCapture.SelectedItems.Count <= 0)
            {
                return;
            }
            this.setMarkdownOptions();
        }

        private void rdbBold_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lstCapture.SelectedItems.Count <= 0)
            {
                return;
            }
            this.setMarkdownOptions();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                List<ScreenCaptureItem> itm = new List<ScreenCaptureItem>();

                for (int i = 0; i < this.lstCapture.Items.Count; i++)
                {
                    ScreenCaptureItem sci = (ScreenCaptureItem)this.lstCapture.Items[i];
                    if (!sci.TextGenerated && sci.GenrationType != MkGenrationType.Image)
                    {
                        sci.Text = this.detectText(sci.Image);
                        sci.TextGenerated = true;
                    }
                    itm.Add(sci);
                }

                MarkdownGenerator generator = new MarkdownGenerator(itm);

                this.txtMkText.Text = generator.Generate();

                File.WriteAllText("./Preview.md", this.txtMkText.Text);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnExportImgs_Click(object sender, EventArgs e)
        {
            foreach (var itm in this.lstCapture.Items)
            {
                ScreenCaptureItem sci = (ScreenCaptureItem)itm;
                if (sci.GenrationType == MkGenrationType.Image)
                {
                    string path = Path.Combine(this.txtImageSaveLoc.Text, sci.ImageName + ".png");
                    if(sci.Image != null)
                    {
                        sci.Image.Save(path);
                    }
                    
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            Thread t = new Thread((ThreadStart)(() =>
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    DialogResult res = fbd.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        path = fbd.SelectedPath;
                    }
                }
            }
            ));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

            this.txtImageSaveLoc.Text = path;

            Properties.Settings.Default.ImageSavePath = path;
            Properties.Settings.Default.Save();


        }

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lstCapture.SelectedItems.Count <= 0)
            {
                return;
            }
            this.lstCapture.Items.RemoveAt(this.lstCapture.SelectedIndex);

        }

        private void updateScreenshotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lstCapture.SelectedItems.Count <= 0)
            {
                return;
            }

            ScreenCaptureItem sci = (ScreenCaptureItem)this.lstCapture.SelectedItems[0];

            Overlay ovr = new Overlay();
            Bitmap gr = ovr.Init();

            sci.Image = gr;

            this.lstCapture.Items[this.lstCapture.SelectedIndices[0]] = sci;
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            // Detect text on selected item
            if (this.lstCapture.SelectedItems.Count <= 0)
            {
                return;
            }

            for (int i = 0; i < this.lstCapture.SelectedItems.Count; i++)
            {
                ScreenCaptureItem itm = (ScreenCaptureItem)this.lstCapture.SelectedItems[i];
                itm.Text = this.detectText(itm.Image);
                itm.TextGenerated = true;
                this.lstCapture.Items[this.lstCapture.SelectedIndices[i]] = itm;
            }
        }

        private void btnDetectAllText_Click(object sender, EventArgs e)
        {
            // Detect text on selected item
            if (this.lstCapture.Items.Count <= 0)
            {
                return;
            }

            for (int i = 0; i < this.lstCapture.Items.Count; i++)
            {
                ScreenCaptureItem itm = (ScreenCaptureItem)this.lstCapture.Items[i];
                itm.Text = this.detectText(itm.Image);
                itm.TextGenerated = true;
                this.lstCapture.Items[i] = itm;
            }
        }

        private void lstCapture_KeyPress(object sender, KeyPressEventArgs e)
        {

            ScreenCaptureItem itm = (ScreenCaptureItem)this.lstCapture.SelectedItem;
            if(itm == null)
            {
                return;
            }

            switch(e.KeyChar)
            {
                case '0':
                    itm.GenrationType = MkGenrationType.Text;
                    break;
                case '1':
                    itm.GenrationType = MkGenrationType.OneHash;
                    break;
                case '2':
                    itm.GenrationType = MkGenrationType.TwoHash;
                    break;
                case '3':
                    itm.GenrationType = MkGenrationType.ThreeHash;
                    break;
                case '4':
                    itm.GenrationType = MkGenrationType.FourHash;
                    break;
                case '5':
                    itm.GenrationType = MkGenrationType.FiveHash;
                    break;
                case '6':
                    itm.GenrationType = MkGenrationType.Image;
                    break;
                case '7':
                    itm.GenrationType = MkGenrationType.Summary;
                    break;
                case '8':
                    itm.GenrationType = MkGenrationType.SummaryPart;
                    break;
                case '9':
                    itm.GenrationType = MkGenrationType.Bold;
                    break;
                case '*':
                    itm.GenrationType = MkGenrationType.Bold;
                    break;
                case '+':
                    itm.GenrationType = MkGenrationType.List;
                    break;
            }
            
            this.updateMarkdownOptions(itm);

            e.Handled = true;
        }


        private void txtImgName_TextChanged(object sender, EventArgs e)
        {
            ScreenCaptureItem itm = (ScreenCaptureItem)this.lstCapture.SelectedItem;
            if(itm == null)
            {
                return;
            }

            if(itm.GenrationType == MkGenrationType.Image)
            {
                itm.ImageName = this.txtImgName.Text.Trim().Replace(' ', '_');
                this.lstCapture.Items[this.lstCapture.SelectedIndex] = itm;
            }
            
        }

        #endregion

    }
}
