using System;
using Microsoft.Deployment.WindowsInstaller;

namespace Setup
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult MyAction(Session session)
        {
            System.Diagnostics.Process.Start("Notepad.exe", session["INSTALLDIR"] + @"\readme.txt");
            return ActionResult.Success;
        }
    }
}
