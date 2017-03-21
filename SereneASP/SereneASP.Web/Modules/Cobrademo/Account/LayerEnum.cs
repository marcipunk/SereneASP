using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Serenity.ComponentModel;
using System.ComponentModel;

namespace SereneASP.Modules.Cobrademo.Account
{

    [EnumKey("Account.LayerId")]
    public enum LayerEnum
    {
        [Description("Elsődleges")]
        Elsodleges = 1,
        [Description("Párhuzamos")]
        Parhuzamos = 2
    }
}
