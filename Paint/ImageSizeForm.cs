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
    public partial class ImageSizeForm : Form
    {
        public int Width
        {
            get
            {
                return Convert.ToInt16(textBoxWidth.Text);
            }
            set
            {
                textBoxWidth.Text = value.ToString();
            }
        }

        public int Height
        {
            get
            {
                return Convert.ToInt16(textBoxHeight.Text);
            }
            set
            {
                textBoxHeight.Text = value.ToString();
            }
        }

        public ImageSizeForm(int width, int height)
        {
            InitializeComponent();


            Width = width;
            Height = height;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
