
namespace SereneASP.Cobrademo.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Cobrademo.AccountName")]
    [BasedOnRow(typeof(Entities.AccountNameRow))]
    public class AccountNameColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 AccountId { get; set; }
        [EditLink]
        public String LanguageId { get; set; }
        public String Value { get; set; }
        public String Note { get; set; }
    }
}