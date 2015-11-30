using System;
using Microsoft.VisualBasic.ApplicationServices;

namespace SingletonApplication
{
    public class SingletonApplicationWrapper : WindowsFormsApplicationBase
    {
        public SingletonApplicationWrapper()
        {
            IsSingleInstance = true;
        }


    }
}
