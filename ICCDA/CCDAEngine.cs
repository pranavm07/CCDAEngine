using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICCDA
{
    public static class CCDAEngine
    {
         static CCDAEngine()
        {
            Startup.Register();
        }
    }
}
