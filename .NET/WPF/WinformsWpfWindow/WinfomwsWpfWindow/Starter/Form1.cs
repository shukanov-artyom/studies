using System;
using System.Windows.Forms;
using WpfClassLibrary;

namespace Starter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Separator().Do(new NakedLoverViewModel());
        }
    }
}
