using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAutomation.Pages
{
    public class InstallationPage : BasePage
    {
        private static InstallationPage installationPage;

        public static InstallationPage Instance  => installationPage ?? (installationPage = new InstallationPage());
    }
}
