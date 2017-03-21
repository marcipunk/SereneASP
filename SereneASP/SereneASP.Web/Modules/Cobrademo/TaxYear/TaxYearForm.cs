
namespace SereneASP.Cobrademo.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Cobrademo.TaxYear")]
    [BasedOnRow(typeof(Entities.TaxYearRow))]
    public class TaxYearForm
    {
        public byte[] Timestamp { get; set; }
        public Int32 ParentTaxYearId { get; set; }
        public String CurrencyId { get; set; }
        public String TaxCurrencyId { get; set; }
        public String Name { get; set; }
        public Int32 YearNum { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Int32 VoucherFormat { get; set; }
        public Int32 VoucherDigits { get; set; }
        public String VoucherSepFirst { get; set; }
        public String VoucherSepLast { get; set; }
        public Int32 ReferenceNumFormat { get; set; }
        public Int32 ReferenceNumDigits { get; set; }
        public String ReferenceNumSepFirst { get; set; }
        public String ReferenceNumSepLast { get; set; }
        public Boolean IsClosed { get; set; }
        public Int32 CurrencyEvaluationMode { get; set; }
        public Int32 CurrencyExchangeType { get; set; }
        public Int32 SalesExchanceType { get; set; }
        public Int32 BookingExchangeType { get; set; }
        public Int32 StockEvaluationMode { get; set; }
        public DateTime FinanceLockDate { get; set; }
        public Boolean ParallelBooking { get; set; }
        public Boolean LedgerRounding { get; set; }
        public Boolean SecondaryAccountAllowed { get; set; }
        public Boolean BankTransactionBooking { get; set; }
        public Boolean CashAccounting { get; set; }
        public Boolean LedgerItemCollectorToSecondaryAccount { get; set; }
        public Decimal LedgerRoundingThresholdAmount { get; set; }
        public Boolean ApplyFinenceLockToStock { get; set; }
        public Boolean CashAccountingVatCarryOver { get; set; }
        public Boolean VatOffPeriodTransfer { get; set; }
        public Boolean VatRateDifferenceTransfer { get; set; }
        public Boolean VoucherShortYearNumber { get; set; }
        public Boolean ReferenceShortYearNumber { get; set; }
    }
}