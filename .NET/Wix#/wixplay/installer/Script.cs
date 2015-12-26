using System;
using WixSharp;

namespace installer
{
    class Script
    {
        static void Main(string[] args)
        {
            Project project =
            new Project("MyWixProd",
                new Dir(new Id("INSTALL_DIR"), @"%ProgramFiles%\SharpTest",
                    new File(new Id("wixplay.exe"), @"..\wixplay\bin\debug\wixplay.exe")),
                new Dir(@"%AppData%\Microsoft\Windows\Start Menu\Programs\Startup",
                    new ExeFileShortcut(new Id("autorunShortcut"), "Build Monitor", "[INSTALL_DIR]wixplay.exe", String.Empty)))
            {
                Actions = new WixSharp.Action[]
                {
                    new InstalledFileAction("wixplay.exe", "", Return.check, When.After, Step.InstallFinalize, Condition.NOT_Installed),
                },
                GUID = new Guid("6f330b47-2577-43ad-9095-1861ba2588dd"),
                UI = WUI.WixUI_ProgressOnly
            };

            Compiler.BuildMsi(project);
        }
    }
}
