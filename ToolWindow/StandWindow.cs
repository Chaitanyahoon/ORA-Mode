using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace BizarreStand.ToolWindow
{
    [Guid("87645371-3444-4866-9912-785366441221")]
    public class StandWindow : ToolWindowPane
    {
        public StandWindow() : base(null)
        {
            this.Caption = "ORA Mode – Ambience";
            this.Content = new StandWindowControl();
        }
    }
}
