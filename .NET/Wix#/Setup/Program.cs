using System;
using WixSharp;

namespace Setup
{
    public static class Program
    {
        static public void Main(string[] args)
        {
            Dir directory = new Dir("AppDirectory");
            directory.Files.Add(new File("readme.txt"));
            /*directory.Files.Add(new File(@"..\wixsh\bin\debug\wixsh.exe"));
            directory.Files.Add(new File(@"..\wixsh\bin\debug\wixsh.exe.config"));*/
            var project = new Project("Wix# Test");
            project.Dirs.Add(directory);
            /*project.Actions.Add(new InstalledFileAction("wixsh.exe", 
                String.Empty, 
                Return.check, 
                When.After,
                Step.InstallFinalize, 
                Condition.Installed));*/
            project.Actions.Add(new ManagedAction("MyAction"));
            project.UI = WUI.WixUI_ProgressOnly;
            Compiler.BuildMsi(project);
        }
    }
}