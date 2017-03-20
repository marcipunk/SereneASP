
namespace SereneASP.Cobrademo.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Cobrademo.AccountSheetCore")]
    [BasedOnRow(typeof(Entities.AccountSheetCoreRow))]
    public class AccountSheetCoreForm
    {
        public Int32 TaxYearId { get; set; }
        public Int32 LayerId { get; set; }
        public Int32 AccountId { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public Int32 TabletypeId { get; set; }
        public Int32 FileId { get; set; }
        public Int32 FileAvatarId { get; set; }
        public String FileGeneratedSign { get; set; }
        public String FileUserSign { get; set; }
        public Int32 OrdinalNumber { get; set; }
        public Int32 SrcAvatarId { get; set; }
        public Int32 LedgerItemId { get; set; }
        public Int32 ItemTypeId { get; set; }
        public Int32 SrcFinanceLinkId { get; set; }
        public Int32 EventTypeId { get; set; }
        public Int32 PartnerId { get; set; }
        public Int32 ReferenceNumber { get; set; }
        public String VoucherNum { get; set; }
        public String LedgerCurrencyId { get; set; }
        public Decimal LedgerRate { get; set; }
        public String LedgerName { get; set; }
        public String LedgerItemCurrencyId { get; set; }
        public Decimal LedgerItemRate { get; set; }
        public String LedgerItemName { get; set; }
        public Int32 Side { get; set; }
        public Decimal OriginalAmount { get; set; }
        public Decimal Amount { get; set; }
        public Decimal OriginalDebitAmount { get; set; }
        public Decimal OriginalCreditAmount { get; set; }
        public Decimal DebitAmount { get; set; }
        public Decimal CreditAmount { get; set; }
        public String AccountCode { get; set; }
        public String ContraAccounts { get; set; }
        public Boolean IsFinalized { get; set; }
        public Boolean IsActive { get; set; }
        public Boolean AccountInTaxYear { get; set; }
        public Boolean AccountInLayer { get; set; }
        public Boolean BookingDateInTaxYear { get; set; }
        public Boolean IsCurrent { get; set; }
    }
}