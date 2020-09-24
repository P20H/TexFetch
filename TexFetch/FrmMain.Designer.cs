namespace TexFetch
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCapture = new System.Windows.Forms.Button();
            this.lstCapture = new System.Windows.Forms.ListBox();
            this.ctxCaptureList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateScreenshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TabControl();
            this.tbTextFromImage = new System.Windows.Forms.TabPage();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDetect = new System.Windows.Forms.Button();
            this.btnDetectAllText = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbMkGen = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtImageSaveLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picPreviewMk = new System.Windows.Forms.PictureBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lblNine = new System.Windows.Forms.Label();
            this.lblEight = new System.Windows.Forms.Label();
            this.lblSeven = new System.Windows.Forms.Label();
            this.lblSix = new System.Windows.Forms.Label();
            this.lblFive = new System.Windows.Forms.Label();
            this.lblFour = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblOne = new System.Windows.Forms.Label();
            this.lblZero = new System.Windows.Forms.Label();
            this.rdbBold = new System.Windows.Forms.RadioButton();
            this.rdbZSBlock = new System.Windows.Forms.RadioButton();
            this.rdbText = new System.Windows.Forms.RadioButton();
            this.btnExportImgs = new System.Windows.Forms.Button();
            this.rdbSummary = new System.Windows.Forms.RadioButton();
            this.lblImgName = new System.Windows.Forms.Label();
            this.txtImgName = new System.Windows.Forms.TextBox();
            this.rdbImage = new System.Windows.Forms.RadioButton();
            this.rdbFiveHash = new System.Windows.Forms.RadioButton();
            this.rdbFourHash = new System.Windows.Forms.RadioButton();
            this.rdbThreeHash = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rdbTwoHash = new System.Windows.Forms.RadioButton();
            this.rdbOneHash = new System.Windows.Forms.RadioButton();
            this.txtMkText = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.rdbList = new System.Windows.Forms.RadioButton();
            this.lblList = new System.Windows.Forms.Label();
            this.tbSpeech = new System.Windows.Forms.TabPage();
            this.lblTODO = new System.Windows.Forms.Label();
            this.ctxCaptureList.SuspendLayout();
            this.tbText.SuspendLayout();
            this.tbTextFromImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.tbMkGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewMk)).BeginInit();
            this.grpOptions.SuspendLayout();
            this.tbSpeech.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(12, 12);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(372, 49);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // lstCapture
            // 
            this.lstCapture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCapture.ContextMenuStrip = this.ctxCaptureList;
            this.lstCapture.FormattingEnabled = true;
            this.lstCapture.Location = new System.Drawing.Point(12, 67);
            this.lstCapture.Name = "lstCapture";
            this.lstCapture.Size = new System.Drawing.Size(372, 706);
            this.lstCapture.TabIndex = 1;
            this.lstCapture.SelectedIndexChanged += new System.EventHandler(this.lstCapture_SelectedIndexChanged);
            this.lstCapture.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstCapture_KeyPress);
            // 
            // ctxCaptureList
            // 
            this.ctxCaptureList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeItemToolStripMenuItem,
            this.updateScreenshotToolStripMenuItem});
            this.ctxCaptureList.Name = "ctxCaptureList";
            this.ctxCaptureList.Size = new System.Drawing.Size(174, 48);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.removeItemToolStripMenuItem_Click);
            // 
            // updateScreenshotToolStripMenuItem
            // 
            this.updateScreenshotToolStripMenuItem.Name = "updateScreenshotToolStripMenuItem";
            this.updateScreenshotToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.updateScreenshotToolStripMenuItem.Text = "Update Screenshot";
            this.updateScreenshotToolStripMenuItem.Click += new System.EventHandler(this.updateScreenshotToolStripMenuItem_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(12, 797);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(58, 22);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(76, 797);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 22);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Controls.Add(this.tbTextFromImage);
            this.tbText.Controls.Add(this.tbMkGen);
            this.tbText.Controls.Add(this.tbSpeech);
            this.tbText.Location = new System.Drawing.Point(390, 12);
            this.tbText.Name = "tbText";
            this.tbText.SelectedIndex = 0;
            this.tbText.Size = new System.Drawing.Size(1206, 772);
            this.tbText.TabIndex = 12;
            // 
            // tbTextFromImage
            // 
            this.tbTextFromImage.Controls.Add(this.btnCopy);
            this.tbTextFromImage.Controls.Add(this.btnDetect);
            this.tbTextFromImage.Controls.Add(this.btnDetectAllText);
            this.tbTextFromImage.Controls.Add(this.txtText);
            this.tbTextFromImage.Controls.Add(this.picPreview);
            this.tbTextFromImage.Controls.Add(this.btnSave);
            this.tbTextFromImage.Location = new System.Drawing.Point(4, 22);
            this.tbTextFromImage.Name = "tbTextFromImage";
            this.tbTextFromImage.Padding = new System.Windows.Forms.Padding(3);
            this.tbTextFromImage.Size = new System.Drawing.Size(1198, 746);
            this.tbTextFromImage.TabIndex = 0;
            this.tbTextFromImage.Text = "Text from Image";
            this.tbTextFromImage.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(1132, 717);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(58, 22);
            this.btnCopy.TabIndex = 13;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDetect
            // 
            this.btnDetect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetect.Location = new System.Drawing.Point(6, 718);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(99, 22);
            this.btnDetect.TabIndex = 12;
            this.btnDetect.Text = "Detect";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // btnDetectAllText
            // 
            this.btnDetectAllText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetectAllText.Location = new System.Drawing.Point(111, 718);
            this.btnDetectAllText.Name = "btnDetectAllText";
            this.btnDetectAllText.Size = new System.Drawing.Size(99, 22);
            this.btnDetectAllText.TabIndex = 11;
            this.btnDetectAllText.Text = "Detect all";
            this.btnDetectAllText.UseVisualStyleBackColor = true;
            this.btnDetectAllText.Click += new System.EventHandler(this.btnDetectAllText_Click);
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Location = new System.Drawing.Point(6, 525);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(1184, 187);
            this.txtText.TabIndex = 10;
            // 
            // picPreview
            // 
            this.picPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPreview.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picPreview.Location = new System.Drawing.Point(6, 6);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(1184, 485);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPreview.TabIndex = 9;
            this.picPreview.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1132, 497);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 22);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tbMkGen
            // 
            this.tbMkGen.Controls.Add(this.splitContainer1);
            this.tbMkGen.Location = new System.Drawing.Point(4, 22);
            this.tbMkGen.Name = "tbMkGen";
            this.tbMkGen.Padding = new System.Windows.Forms.Padding(3);
            this.tbMkGen.Size = new System.Drawing.Size(1198, 746);
            this.tbMkGen.TabIndex = 2;
            this.tbMkGen.Text = "Markdown";
            this.tbMkGen.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowse);
            this.splitContainer1.Panel1.Controls.Add(this.txtImageSaveLoc);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.picPreviewMk);
            this.splitContainer1.Panel1.Controls.Add(this.grpOptions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtMkText);
            this.splitContainer1.Size = new System.Drawing.Size(1192, 740);
            this.splitContainer1.SplitterDistance = 552;
            this.splitContainer1.TabIndex = 46;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(518, 209);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 20);
            this.btnBrowse.TabIndex = 49;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtImageSaveLoc
            // 
            this.txtImageSaveLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImageSaveLoc.Location = new System.Drawing.Point(119, 209);
            this.txtImageSaveLoc.Name = "txtImageSaveLoc";
            this.txtImageSaveLoc.Size = new System.Drawing.Size(393, 20);
            this.txtImageSaveLoc.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Image save location:";
            // 
            // picPreviewMk
            // 
            this.picPreviewMk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPreviewMk.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picPreviewMk.Location = new System.Drawing.Point(3, 3);
            this.picPreviewMk.Name = "picPreviewMk";
            this.picPreviewMk.Size = new System.Drawing.Size(545, 193);
            this.picPreviewMk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPreviewMk.TabIndex = 46;
            this.picPreviewMk.TabStop = false;
            // 
            // grpOptions
            // 
            this.grpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptions.Controls.Add(this.lblList);
            this.grpOptions.Controls.Add(this.rdbList);
            this.grpOptions.Controls.Add(this.lblNine);
            this.grpOptions.Controls.Add(this.lblEight);
            this.grpOptions.Controls.Add(this.lblSeven);
            this.grpOptions.Controls.Add(this.lblSix);
            this.grpOptions.Controls.Add(this.lblFive);
            this.grpOptions.Controls.Add(this.lblFour);
            this.grpOptions.Controls.Add(this.lblThree);
            this.grpOptions.Controls.Add(this.lblTwo);
            this.grpOptions.Controls.Add(this.lblOne);
            this.grpOptions.Controls.Add(this.lblZero);
            this.grpOptions.Controls.Add(this.rdbBold);
            this.grpOptions.Controls.Add(this.rdbZSBlock);
            this.grpOptions.Controls.Add(this.rdbText);
            this.grpOptions.Controls.Add(this.btnExportImgs);
            this.grpOptions.Controls.Add(this.rdbSummary);
            this.grpOptions.Controls.Add(this.lblImgName);
            this.grpOptions.Controls.Add(this.txtImgName);
            this.grpOptions.Controls.Add(this.rdbImage);
            this.grpOptions.Controls.Add(this.rdbFiveHash);
            this.grpOptions.Controls.Add(this.rdbFourHash);
            this.grpOptions.Controls.Add(this.rdbThreeHash);
            this.grpOptions.Controls.Add(this.btnGenerate);
            this.grpOptions.Controls.Add(this.rdbTwoHash);
            this.grpOptions.Controls.Add(this.rdbOneHash);
            this.grpOptions.Location = new System.Drawing.Point(4, 235);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(545, 322);
            this.grpOptions.TabIndex = 45;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // lblNine
            // 
            this.lblNine.AutoSize = true;
            this.lblNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNine.Location = new System.Drawing.Point(15, 236);
            this.lblNine.Name = "lblNine";
            this.lblNine.Size = new System.Drawing.Size(14, 13);
            this.lblNine.TabIndex = 36;
            this.lblNine.Text = "9";
            // 
            // lblEight
            // 
            this.lblEight.AutoSize = true;
            this.lblEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEight.Location = new System.Drawing.Point(15, 213);
            this.lblEight.Name = "lblEight";
            this.lblEight.Size = new System.Drawing.Size(14, 13);
            this.lblEight.TabIndex = 35;
            this.lblEight.Text = "8";
            // 
            // lblSeven
            // 
            this.lblSeven.AutoSize = true;
            this.lblSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeven.Location = new System.Drawing.Point(15, 190);
            this.lblSeven.Name = "lblSeven";
            this.lblSeven.Size = new System.Drawing.Size(14, 13);
            this.lblSeven.TabIndex = 34;
            this.lblSeven.Text = "7";
            // 
            // lblSix
            // 
            this.lblSix.AutoSize = true;
            this.lblSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSix.Location = new System.Drawing.Point(15, 168);
            this.lblSix.Name = "lblSix";
            this.lblSix.Size = new System.Drawing.Size(14, 13);
            this.lblSix.TabIndex = 33;
            this.lblSix.Text = "6";
            // 
            // lblFive
            // 
            this.lblFive.AutoSize = true;
            this.lblFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFive.Location = new System.Drawing.Point(15, 146);
            this.lblFive.Name = "lblFive";
            this.lblFive.Size = new System.Drawing.Size(14, 13);
            this.lblFive.TabIndex = 32;
            this.lblFive.Text = "5";
            // 
            // lblFour
            // 
            this.lblFour.AutoSize = true;
            this.lblFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFour.Location = new System.Drawing.Point(15, 123);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(14, 13);
            this.lblFour.TabIndex = 31;
            this.lblFour.Text = "4";
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThree.Location = new System.Drawing.Point(15, 100);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(14, 13);
            this.lblThree.TabIndex = 30;
            this.lblThree.Text = "3";
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwo.Location = new System.Drawing.Point(15, 79);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(14, 13);
            this.lblTwo.TabIndex = 29;
            this.lblTwo.Text = "2";
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOne.Location = new System.Drawing.Point(15, 56);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(14, 13);
            this.lblOne.TabIndex = 28;
            this.lblOne.Text = "1";
            // 
            // lblZero
            // 
            this.lblZero.AutoSize = true;
            this.lblZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZero.Location = new System.Drawing.Point(15, 31);
            this.lblZero.Name = "lblZero";
            this.lblZero.Size = new System.Drawing.Size(14, 13);
            this.lblZero.TabIndex = 27;
            this.lblZero.Text = "0";
            // 
            // rdbBold
            // 
            this.rdbBold.AutoSize = true;
            this.rdbBold.Location = new System.Drawing.Point(45, 234);
            this.rdbBold.Name = "rdbBold";
            this.rdbBold.Size = new System.Drawing.Size(62, 17);
            this.rdbBold.TabIndex = 26;
            this.rdbBold.TabStop = true;
            this.rdbBold.Text = "**Bold**";
            this.rdbBold.UseVisualStyleBackColor = true;
            this.rdbBold.CheckedChanged += new System.EventHandler(this.rdbBold_CheckedChanged);
            // 
            // rdbZSBlock
            // 
            this.rdbZSBlock.AutoSize = true;
            this.rdbZSBlock.Location = new System.Drawing.Point(45, 211);
            this.rdbZSBlock.Name = "rdbZSBlock";
            this.rdbZSBlock.Size = new System.Drawing.Size(69, 17);
            this.rdbZSBlock.TabIndex = 25;
            this.rdbZSBlock.TabStop = true;
            this.rdbZSBlock.Text = "ZS Block";
            this.rdbZSBlock.UseVisualStyleBackColor = true;
            this.rdbZSBlock.CheckedChanged += new System.EventHandler(this.rdbZSBlock_CheckedChanged);
            // 
            // rdbText
            // 
            this.rdbText.AutoSize = true;
            this.rdbText.Location = new System.Drawing.Point(45, 29);
            this.rdbText.Name = "rdbText";
            this.rdbText.Size = new System.Drawing.Size(46, 17);
            this.rdbText.TabIndex = 24;
            this.rdbText.TabStop = true;
            this.rdbText.Text = "Text";
            this.rdbText.UseVisualStyleBackColor = true;
            this.rdbText.CheckedChanged += new System.EventHandler(this.rdbText_CheckedChanged);
            // 
            // btnExportImgs
            // 
            this.btnExportImgs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportImgs.Location = new System.Drawing.Point(435, 294);
            this.btnExportImgs.Name = "btnExportImgs";
            this.btnExportImgs.Size = new System.Drawing.Size(95, 22);
            this.btnExportImgs.TabIndex = 23;
            this.btnExportImgs.Text = "Export Images";
            this.btnExportImgs.UseVisualStyleBackColor = true;
            this.btnExportImgs.Click += new System.EventHandler(this.btnExportImgs_Click);
            // 
            // rdbSummary
            // 
            this.rdbSummary.AutoSize = true;
            this.rdbSummary.Location = new System.Drawing.Point(45, 188);
            this.rdbSummary.Name = "rdbSummary";
            this.rdbSummary.Size = new System.Drawing.Size(114, 17);
            this.rdbSummary.TabIndex = 22;
            this.rdbSummary.TabStop = true;
            this.rdbSummary.Text = "Zusammenfassung";
            this.rdbSummary.UseVisualStyleBackColor = true;
            this.rdbSummary.CheckedChanged += new System.EventHandler(this.rdbSummary_CheckedChanged);
            // 
            // lblImgName
            // 
            this.lblImgName.AutoSize = true;
            this.lblImgName.Location = new System.Drawing.Point(169, 167);
            this.lblImgName.Name = "lblImgName";
            this.lblImgName.Size = new System.Drawing.Size(68, 13);
            this.lblImgName.TabIndex = 21;
            this.lblImgName.Text = "Image name:";
            // 
            // txtImgName
            // 
            this.txtImgName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImgName.Location = new System.Drawing.Point(243, 164);
            this.txtImgName.Name = "txtImgName";
            this.txtImgName.Size = new System.Drawing.Size(287, 20);
            this.txtImgName.TabIndex = 20;
            this.txtImgName.TextChanged += new System.EventHandler(this.txtImgName_TextChanged);
            // 
            // rdbImage
            // 
            this.rdbImage.AutoSize = true;
            this.rdbImage.Location = new System.Drawing.Point(45, 165);
            this.rdbImage.Name = "rdbImage";
            this.rdbImage.Size = new System.Drawing.Size(54, 17);
            this.rdbImage.TabIndex = 19;
            this.rdbImage.TabStop = true;
            this.rdbImage.Text = "Image";
            this.rdbImage.UseVisualStyleBackColor = true;
            this.rdbImage.CheckedChanged += new System.EventHandler(this.rdbImage_CheckedChanged);
            // 
            // rdbFiveHash
            // 
            this.rdbFiveHash.AutoSize = true;
            this.rdbFiveHash.Location = new System.Drawing.Point(45, 144);
            this.rdbFiveHash.Name = "rdbFiveHash";
            this.rdbFiveHash.Size = new System.Drawing.Size(60, 17);
            this.rdbFiveHash.TabIndex = 18;
            this.rdbFiveHash.TabStop = true;
            this.rdbFiveHash.Text = "#####";
            this.rdbFiveHash.UseVisualStyleBackColor = true;
            this.rdbFiveHash.CheckedChanged += new System.EventHandler(this.rdbFiveHash_CheckedChanged);
            // 
            // rdbFourHash
            // 
            this.rdbFourHash.AutoSize = true;
            this.rdbFourHash.Location = new System.Drawing.Point(45, 121);
            this.rdbFourHash.Name = "rdbFourHash";
            this.rdbFourHash.Size = new System.Drawing.Size(53, 17);
            this.rdbFourHash.TabIndex = 17;
            this.rdbFourHash.TabStop = true;
            this.rdbFourHash.Text = "####";
            this.rdbFourHash.UseVisualStyleBackColor = true;
            this.rdbFourHash.CheckedChanged += new System.EventHandler(this.rdbFourHash_CheckedChanged);
            // 
            // rdbThreeHash
            // 
            this.rdbThreeHash.AutoSize = true;
            this.rdbThreeHash.Location = new System.Drawing.Point(45, 98);
            this.rdbThreeHash.Name = "rdbThreeHash";
            this.rdbThreeHash.Size = new System.Drawing.Size(46, 17);
            this.rdbThreeHash.TabIndex = 16;
            this.rdbThreeHash.TabStop = true;
            this.rdbThreeHash.Text = "###";
            this.rdbThreeHash.UseVisualStyleBackColor = true;
            this.rdbThreeHash.CheckedChanged += new System.EventHandler(this.rdbThreeHash_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(352, 294);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(77, 22);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // rdbTwoHash
            // 
            this.rdbTwoHash.AutoSize = true;
            this.rdbTwoHash.Location = new System.Drawing.Point(45, 75);
            this.rdbTwoHash.Name = "rdbTwoHash";
            this.rdbTwoHash.Size = new System.Drawing.Size(39, 17);
            this.rdbTwoHash.TabIndex = 15;
            this.rdbTwoHash.TabStop = true;
            this.rdbTwoHash.Text = "##";
            this.rdbTwoHash.UseVisualStyleBackColor = true;
            this.rdbTwoHash.CheckedChanged += new System.EventHandler(this.rdbTwoHash_CheckedChanged);
            // 
            // rdbOneHash
            // 
            this.rdbOneHash.AutoSize = true;
            this.rdbOneHash.Location = new System.Drawing.Point(45, 52);
            this.rdbOneHash.Name = "rdbOneHash";
            this.rdbOneHash.Size = new System.Drawing.Size(32, 17);
            this.rdbOneHash.TabIndex = 14;
            this.rdbOneHash.TabStop = true;
            this.rdbOneHash.Text = "#";
            this.rdbOneHash.UseVisualStyleBackColor = true;
            this.rdbOneHash.CheckedChanged += new System.EventHandler(this.rdbOneHash_CheckedChanged);
            // 
            // txtMkText
            // 
            this.txtMkText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMkText.Location = new System.Drawing.Point(0, 0);
            this.txtMkText.Multiline = true;
            this.txtMkText.Name = "txtMkText";
            this.txtMkText.Size = new System.Drawing.Size(636, 740);
            this.txtMkText.TabIndex = 40;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 839);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // rdbList
            // 
            this.rdbList.AutoSize = true;
            this.rdbList.Location = new System.Drawing.Point(45, 257);
            this.rdbList.Name = "rdbList";
            this.rdbList.Size = new System.Drawing.Size(72, 17);
            this.rdbList.TabIndex = 37;
            this.rdbList.TabStop = true;
            this.rdbList.Text = "+ List item";
            this.rdbList.UseVisualStyleBackColor = true;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(15, 259);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(14, 13);
            this.lblList.TabIndex = 38;
            this.lblList.Text = "+";
            // 
            // tbSpeech
            // 
            this.tbSpeech.Controls.Add(this.lblTODO);
            this.tbSpeech.Location = new System.Drawing.Point(4, 22);
            this.tbSpeech.Name = "tbSpeech";
            this.tbSpeech.Padding = new System.Windows.Forms.Padding(3);
            this.tbSpeech.Size = new System.Drawing.Size(1198, 746);
            this.tbSpeech.TabIndex = 3;
            this.tbSpeech.Text = "Speech";
            this.tbSpeech.UseVisualStyleBackColor = true;
            // 
            // lblTODO
            // 
            this.lblTODO.AutoSize = true;
            this.lblTODO.Location = new System.Drawing.Point(41, 33);
            this.lblTODO.Name = "lblTODO";
            this.lblTODO.Size = new System.Drawing.Size(38, 13);
            this.lblTODO.TabIndex = 0;
            this.lblTODO.Text = "TODO";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 839);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstCapture);
            this.Controls.Add(this.btnCapture);
            this.Name = "FrmMain";
            this.Text = "TexFetch";
            this.ctxCaptureList.ResumeLayout(false);
            this.tbText.ResumeLayout(false);
            this.tbTextFromImage.ResumeLayout(false);
            this.tbTextFromImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.tbMkGen.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreviewMk)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.tbSpeech.ResumeLayout(false);
            this.tbSpeech.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.ListBox lstCapture;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabControl tbText;
        private System.Windows.Forms.TabPage tbTextFromImage;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Button btnDetectAllText;
        private System.Windows.Forms.ContextMenuStrip ctxCaptureList;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateScreenshotToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage tbMkGen;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtImageSaveLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPreviewMk;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.RadioButton rdbZSBlock;
        private System.Windows.Forms.RadioButton rdbText;
        private System.Windows.Forms.Button btnExportImgs;
        private System.Windows.Forms.RadioButton rdbSummary;
        private System.Windows.Forms.Label lblImgName;
        private System.Windows.Forms.TextBox txtImgName;
        private System.Windows.Forms.RadioButton rdbImage;
        private System.Windows.Forms.RadioButton rdbFiveHash;
        private System.Windows.Forms.RadioButton rdbFourHash;
        private System.Windows.Forms.RadioButton rdbThreeHash;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton rdbTwoHash;
        private System.Windows.Forms.RadioButton rdbOneHash;
        private System.Windows.Forms.TextBox txtMkText;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.RadioButton rdbBold;
        private System.Windows.Forms.Label lblNine;
        private System.Windows.Forms.Label lblEight;
        private System.Windows.Forms.Label lblSeven;
        private System.Windows.Forms.Label lblSix;
        private System.Windows.Forms.Label lblFive;
        private System.Windows.Forms.Label lblFour;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblZero;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.RadioButton rdbList;
        private System.Windows.Forms.TabPage tbSpeech;
        private System.Windows.Forms.Label lblTODO;
    }
}