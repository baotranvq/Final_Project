using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop.Components
{
    
    public partial class Widget : UserControl
    {
        private string lblTitle;
        private object imgImage;
        private object lblCost;

        public event EventHandler OnSelect = null;
        public Widget()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e); 
        }
        //public string Title { get => lblTitle.Text; set => lblTitle.Text = value; }
        //public string Cost { get => lblTitle.Text; set => lblCost.Text = value; }
        //public Image Icon { get => imgImage.Image; set => imgImage.Image = value; }


    }
}
 