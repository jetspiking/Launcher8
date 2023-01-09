using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Launcher8.Core
{

    public static class Discoverer
    {
        private const String ExplorerProcess = "explorer.exe";
        private const String ShellPath = @"shell:appsFolder\";
        private const String AppsGuid = "{1e87508d-89c2-42f0-8a7e-645a0f50ca58}";

        public static List<Application> GetInstalledApplications()
        {
            List<Application> applications = new List<Application>();

            Guid appsFolderGuid = new Guid(AppsGuid);
            ShellObject appsFolderShellObject = (ShellObject)KnownFolderHelper.FromKnownFolderId(appsFolderGuid);
            foreach (ShellObject applicationShellObject in (IKnownFolder)appsFolderShellObject)
            {
                applications.Add(new Application(
                    applicationShellObject.Name,
                    applicationShellObject.ParsingName,
                    applicationShellObject.Thumbnail.SmallBitmapSource));
            }

            return applications;
        }

        public static void LaunchExplorerShell()
        {
            System.Diagnostics.Process.Start(ExplorerProcess, ShellPath);
        }

        public static void LaunchApplication(Application application)
        {
            System.Diagnostics.Process.Start(ExplorerProcess, ShellPath + application.ParsingName);
        }
        
    }
}
