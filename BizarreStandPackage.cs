using System;
using System.Runtime.InteropServices;
using System.Threading;
using Task = System.Threading.Tasks.Task;
using Microsoft.VisualStudio.Shell;
using BizarreStand.ToolWindow;

namespace BizarreStand
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [Guid(BizarreStandPackage.PackageGuidString)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [ProvideToolWindow(typeof(StandWindow))]
    public sealed class BizarreStandPackage : AsyncPackage
    {
        public const string PackageGuidString = "05f88461-9c17-4581-9870-7685655767a1";

        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await this.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
            await ShowStandWindowCommand.InitializeAsync(this);
        }
    }
}
