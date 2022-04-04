using System;
using Lain_Bootleg_DUX.GameContent;

namespace Lain_Bootleg_DUX
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var scene = new LainInterfaceScene())
                scene.Run();
        }
    }
}
