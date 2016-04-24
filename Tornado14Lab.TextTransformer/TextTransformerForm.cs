using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tornado14Lab.TextTransformer.Controls;

namespace Tornado14Lab.TextTransformer
{
    public partial class TextTransformerForm : Form
    {
        public TextTransformerForm()
        {
            InitializeComponent();
        }

        private void toolStripButtonProcess_Click(object sender, EventArgs e)
        {
            FilterHelper filterHelper = new FilterHelper();
            StringBuilder text = new StringBuilder();
            for (int count = 0; count < 500000; count++)
            {
                text.AppendLine(string.Format("-{0}-", count));
            }
            string resultText = text.ToString();
            foreach (BaseFilter filter in scenarioSelector1.panelActiveFilter.Controls)
            {
                List<object> filterParameters = filter.Values;
                FilterContext filterContext = new FilterContext()
                {
                    Parameters = filterParameters,
                    Text = resultText
                };
                FilterResult filterResult = filterHelper.filterList[filter.Key].Invoke(filterContext);
                resultText = filterResult.Text;
            }
            textBox2.Text = resultText;
        }
    }
}
