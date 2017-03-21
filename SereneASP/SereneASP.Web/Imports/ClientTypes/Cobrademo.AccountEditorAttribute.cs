using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SereneASP.Cobrademo
{
    public partial class AccountEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SereneASP.Cobrademo.AccountEditor";

        public AccountEditorAttribute()
            : base(Key)
        {
        }
    }
}

