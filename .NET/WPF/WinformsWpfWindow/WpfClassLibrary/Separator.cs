using System;
using System.Windows;

namespace WpfClassLibrary
{
    public class Separator
    {
        public void Do(object v)
        {
            NakedLover l = new NakedLover();
            l.DataContext = v;
            l.ShowDialog();
        }
    }
}
