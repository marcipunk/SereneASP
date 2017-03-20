
namespace SereneASP.Cobrademo.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Cobrademo.Account")]
    [BasedOnRow(typeof(Entities.AccountRow))]
    public class AccountColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public Int32 AvatarId { get; set; }
        public byte[] Timestamp { get; set; }
        public Int32 TreasuryAccountId { get; set; }
        public Int32 TaxYearId { get; set; }
        public Int32 AncestorAccountId { get; set; }
        public Int32 ParentAccountId { get; set; }
        [EditLink]
        public String Code { get; set; }
        public Boolean Placeholder { get; set; }
        public Boolean TaxRelated { get; set; }
        public Boolean Hidden { get; set; }
        public Int32 TypeId { get; set; }
        public Int32 TransactionAccountId { get; set; }
        public Boolean IsCollectorExpected { get; set; }
        public Int32 ParallelAccountId { get; set; }
        public Int32 LayerId { get; set; }
        public Boolean IsPartnerExpected { get; set; }
    }
}