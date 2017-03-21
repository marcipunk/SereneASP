using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SereneASP.Cobrademo
{
    public partial class AccountNameEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SereneASP.Cobrademo.AccountNameEditor";

        public AccountNameEditorAttribute()
            : base(Key)
        {
        }
    }
}

