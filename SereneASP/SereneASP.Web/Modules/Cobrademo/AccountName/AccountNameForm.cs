
namespace SereneASP.Cobrademo.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Cobrademo.AccountName")]
    [BasedOnRow(typeof(Entities.AccountNameRow))]
    public class AccountNameForm
    {
        public String LanguageId { get; set; }
        public String Value { get; set; }
        public String Note { get; set; }
    }
}