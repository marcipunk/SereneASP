
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

        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 AccountId { get; set; }
        [EditLink]
        public String AccountCode { get; set; }
        public String LanguageId { get; set; }
        [EditLink]
        public String Value { get; set; }
        public String Note { get; set; }
    }
}