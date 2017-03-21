using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SereneASP.Cobrademo
{
    public partial class AccountSheetCoreEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SereneASP.Cobrademo.AccountSheetCoreEditor";

        public AccountSheetCoreEditorAttribute()
            : base(Key)
        {
        }
    }
}

