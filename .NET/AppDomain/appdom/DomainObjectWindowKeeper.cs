using System;

namespace appdom
{
    public class DomainObjectWindowKeeper : MarshalByRefObject
    {
        public void Do()
        {
            MainWindow w = new MainWindow();
            w.Show();
        }
    }
}
