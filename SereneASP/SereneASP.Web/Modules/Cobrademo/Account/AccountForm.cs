
namespace SereneASP.Cobrademo.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Cobrademo.Account")]
    [BasedOnRow(typeof(Entities.AccountRow))]
    public class AccountForm
    {
        //public Int32 AvatarId { get; set; }
        //public byte[] Timestamp { get; set; }
        public String Code { get; set; }
        public Int32 TaxYearId { get; set; }
        public Int32 TreasuryAccountId { get; set; }

        public Int32 AncestorAccountId { get; set; }
        public Int32 ParentAccountId { get; set; }

        public Boolean Placeholder { get; set; }
        public Boolean TaxRelated { get; set; }
        public Boolean Hidden { get; set; }
        //public Int32 TypeId { get; set; }
        public Int32 TransactionAccountId { get; set; }
        public Boolean IsCollectorExpected { get; set; }
        public Int32 ParallelAccountId { get; set; }
        public Modules.Cobrademo.Account.LayerEnum LayerId { get; set; }
        public Boolean IsPartnerExpected { get; set; }
    }
}