using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexFetch
{
    public partial class CtrTextGenerator : UserControl
    {
        public CtrTextGenerator()
        {
            InitializeComponent();
        }

        private string replaceMacro(string pattern, int repeadIdx)
        {

            string text = string.Empty;
            var matches = System.Text.RegularExpressions.Regex.Matches(pattern, "COUNT(", System.Text.RegularExpressions.RegexOptions.None);

            foreach(var match in matches)
            {
                
            }

            return string.Empty;
        }

        private void generateText()
        {
            this.txtResult.Text = string.Empty;

            string pattern = this.txtPattern.Text;

            int repeatCount = Convert.ToInt32(this.txtRepeatCount.Text);
            for (int i = 0; i < repeatCount; i++)
            {
                this.txtResult.Text += this.replaceMacro(pattern, i);
            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }
    }
}
