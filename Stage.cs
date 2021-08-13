using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    interface Stage
    {
        Player player { get; set; }


        void ClickStop();
        void ClickPlay();
        void ClickPause();
    }
}
