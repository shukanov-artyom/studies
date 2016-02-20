using System;
using System;
using System.Windows.Forms;

namespace mapsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchClick(object sender, EventArgs e)
        {
            string city = textBoxCity.Text;
            string query = String.Format("http://maps.google.com/maps?q={0}", city);
            webBrowser1.Navigate(query);
        }
    }
}
