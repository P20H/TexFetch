
namespace TexFetch
{
    partial class CtrTextGenerator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.txtRepeatCount = new System.Windows.Forms.TextBox();
            this.lblRepeatCount = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblTextPattern = new System.Windows.Forms.Label();
            this.lblMacro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblMacro);
            this.splitContainer1.Panel1.Controls.Add(this.lblTextPattern);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenerate);
            this.splitContainer1.Panel1.Controls.Add(this.lblRepeatCount);
            this.splitContainer1.Panel1.Controls.Add(this.txtRepeatCount);
            this.splitContainer1.Panel1.Controls.Add(this.txtPattern);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtResult);
            this.splitContainer1.Size = new System.Drawing.Size(981, 484);
            this.splitContainer1.SplitterDistance = 371;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(606, 484);
            this.txtResult.TabIndex = 0;
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(11, 32);
            this.txtPattern.Multiline = true;
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(357, 255);
            this.txtPattern.TabIndex = 0;
            // 
            // txtRepeatCount
            // 
            this.txtRepeatCount.Location = new System.Drawing.Point(89, 293);
            this.txtRepeatCount.Name = "txtRepeatCount";
            this.txtRepeatCount.Size = new System.Drawing.Size(75, 20);
            this.txtRepeatCount.TabIndex = 1;
            this.txtRepeatCount.Text = "1";
            // 
            // lblRepeatCount
            // 
            this.lblRepeatCount.AutoSize = true;
            this.lblRepeatCount.Location = new System.Drawing.Point(8, 296);
            this.lblRepeatCount.Name = "lblRepeatCount";
            this.lblRepeatCount.Size = new System.Drawing.Size(75, 13);
            this.lblRepeatCount.TabIndex = 2;
            this.lblRepeatCount.Text = "Repeat count:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(293, 458);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblTextPattern
            // 
            this.lblTextPattern.AutoSize = true;
            this.lblTextPattern.Location = new System.Drawing.Point(11, 13);
            this.lblTextPattern.Name = "lblTextPattern";
            this.lblTextPattern.Size = new System.Drawing.Size(64, 13);
            this.lblTextPattern.TabIndex = 4;
            this.lblTextPattern.Text = "Text pattern";
            // 
            // lblMacro
            // 
            this.lblMacro.AutoSize = true;
            this.lblMacro.Location = new System.Drawing.Point(190, 13);
            this.lblMacro.Name = "lblMacro";
            this.lblMacro.Size = new System.Drawing.Size(165, 13);
            this.lblMacro.TabIndex = 5;
            this.lblMacro.Text = "Macro: COUNT(int Start, int Step)";
            // 
            // CtrTextGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "CtrTextGenerator";
            this.Size = new System.Drawing.Size(981, 484);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblRepeatCount;
        private System.Windows.Forms.TextBox txtRepeatCount;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Label lblTextPattern;
        private System.Windows.Forms.Label lblMacro;
    }
}
