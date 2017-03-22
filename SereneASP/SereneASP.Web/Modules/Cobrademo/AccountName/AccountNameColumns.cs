
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
        public String AccountLanguageId { get; set; }
        [EditLink]
        public String AccountCode { get; set; }
        public String LanguageId { get; set; }
        [EditLink]
        public String Value { get; set; }
        public String Note { get; set; }
    }
}