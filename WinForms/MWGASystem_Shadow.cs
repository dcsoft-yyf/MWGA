#if ! MWGA
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DCSoft
{
    /// <summary>
    /// MWGASystem兼容性代码，在真正的WinForms中无效
    /// </summary>
    public static class MWGASystem
    {
        public static void SetControlOwnerDraw(object obj) { }
    }
}
#endif