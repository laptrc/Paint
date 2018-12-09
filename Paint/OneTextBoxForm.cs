using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class OneTextBoxForm : Form
    {
        public int Value
        {
            get
            {
                return Convert.ToInt16(textBoxValue.Text);
            }
            set
            {
                textBoxValue.Text = value.ToString();
            }
        }

        public OneTextBoxForm(string title, string label, int value)
        {
            InitializeComponent();

            this.Text = title;
            labelValue.Text = label;
            Value = value;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
