
namespace SereneASP.Cobrademo.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("CobraDemo"), TableName("[dbo].[TaxYear]"), DisplayName("Tax Year"), InstanceName("Tax Year"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("CobraDemo.TaxYear")]
    public sealed class TaxYearRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Timestamp"), Column("timestamp"), Insertable(false), Updatable(false), NotNull]
        public byte[] Timestamp
        {
            get { return Fields.Timestamp[this]; }
            set { Fields.Timestamp[this] = value; }
        }

        [DisplayName("Parent Tax Year"), ForeignKey("[dbo].[TaxYear]", "Id"), LeftJoin("jParentTaxYear"), TextualField("ParentTaxYearId")]
        public Int32? ParentTaxYearId
        {
            get { return Fields.ParentTaxYearId[this]; }
            set { Fields.ParentTaxYearId[this] = value; }
        }

        [DisplayName("Currency"), Size(3), NotNull, ForeignKey("[dbo].[Currency]", "Id"), LeftJoin("jCurrency"), TextualField("CurrencyName")]
        public String CurrencyId
        {
            get { return Fields.CurrencyId[this]; }
            set { Fields.CurrencyId[this] = value; }
        }

        [DisplayName("Tax Currency"), Size(3), NotNull, ForeignKey("[dbo].[Currency]", "Id"), LeftJoin("jTaxCurrency"), TextualField("TaxCurrencyName")]
        public String TaxCurrencyId
        {
            get { return Fields.TaxCurrencyId[this]; }
            set { Fields.TaxCurrencyId[this] = value; }
        }

        [DisplayName("Name"), Size(50), NotNull, QuickSearch, TextualField("TaxYearName")]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Year Num"), NotNull]
        public Int32? YearNum
        {
            get { return Fields.YearNum[this]; }
            set { Fields.YearNum[this] = value; }
        }

        [DisplayName("Start Date"), NotNull]
        public DateTime? StartDate
        {
            get { return Fields.StartDate[this]; }
            set { Fields.StartDate[this] = value; }
        }

        [DisplayName("End Date"), NotNull]
        public DateTime? EndDate
        {
            get { return Fields.EndDate[this]; }
            set { Fields.EndDate[this] = value; }
        }

        [DisplayName("Voucher Format"), NotNull]
        public Int32? VoucherFormat
        {
            get { return Fields.VoucherFormat[this]; }
            set { Fields.VoucherFormat[this] = value; }
        }

        [DisplayName("Voucher Digits"), NotNull]
        public Int32? VoucherDigits
        {
            get { return Fields.VoucherDigits[this]; }
            set { Fields.VoucherDigits[this] = value; }
        }

        [DisplayName("Voucher Sep First"), Size(5)]
        public String VoucherSepFirst
        {
            get { return Fields.VoucherSepFirst[this]; }
            set { Fields.VoucherSepFirst[this] = value; }
        }

        [DisplayName("Voucher Sep Last"), Size(5)]
        public String VoucherSepLast
        {
            get { return Fields.VoucherSepLast[this]; }
            set { Fields.VoucherSepLast[this] = value; }
        }

        [DisplayName("Reference Num Format"), NotNull]
        public Int32? ReferenceNumFormat
        {
            get { return Fields.ReferenceNumFormat[this]; }
            set { Fields.ReferenceNumFormat[this] = value; }
        }

        [DisplayName("Reference Num Digits"), NotNull]
        public Int32? ReferenceNumDigits
        {
            get { return Fields.ReferenceNumDigits[this]; }
            set { Fields.ReferenceNumDigits[this] = value; }
        }

        [DisplayName("Reference Num Sep First"), Size(5)]
        public String ReferenceNumSepFirst
        {
            get { return Fields.ReferenceNumSepFirst[this]; }
            set { Fields.ReferenceNumSepFirst[this] = value; }
        }

        [DisplayName("Reference Num Sep Last"), Size(5)]
        public String ReferenceNumSepLast
        {
            get { return Fields.ReferenceNumSepLast[this]; }
            set { Fields.ReferenceNumSepLast[this] = value; }
        }

        [DisplayName("Is Closed"), NotNull]
        public Boolean? IsClosed
        {
            get { return Fields.IsClosed[this]; }
            set { Fields.IsClosed[this] = value; }
        }

        [DisplayName("Currency Evaluation Mode"), NotNull]
        public Int32? CurrencyEvaluationMode
        {
            get { return Fields.CurrencyEvaluationMode[this]; }
            set { Fields.CurrencyEvaluationMode[this] = value; }
        }

        [DisplayName("Currency Exchange Type"), NotNull]
        public Int32? CurrencyExchangeType
        {
            get { return Fields.CurrencyExchangeType[this]; }
            set { Fields.CurrencyExchangeType[this] = value; }
        }

        [DisplayName("Sales Exchance Type"), NotNull]
        public Int32? SalesExchanceType
        {
            get { return Fields.SalesExchanceType[this]; }
            set { Fields.SalesExchanceType[this] = value; }
        }

        [DisplayName("Booking Exchange Type"), NotNull]
        public Int32? BookingExchangeType
        {
            get { return Fields.BookingExchangeType[this]; }
            set { Fields.BookingExchangeType[this] = value; }
        }

        [DisplayName("Stock Evaluation Mode"), NotNull]
        public Int32? StockEvaluationMode
        {
            get { return Fields.StockEvaluationMode[this]; }
            set { Fields.StockEvaluationMode[this] = value; }
        }

        [DisplayName("Finance Lock Date")]
        public DateTime? FinanceLockDate
        {
            get { return Fields.FinanceLockDate[this]; }
            set { Fields.FinanceLockDate[this] = value; }
        }

        [DisplayName("Parallel Booking"), NotNull]
        public Boolean? ParallelBooking
        {
            get { return Fields.ParallelBooking[this]; }
            set { Fields.ParallelBooking[this] = value; }
        }

        [DisplayName("Ledger Rounding"), NotNull]
        public Boolean? LedgerRounding
        {
            get { return Fields.LedgerRounding[this]; }
            set { Fields.LedgerRounding[this] = value; }
        }

        [DisplayName("Secondary Account Allowed"), NotNull]
        public Boolean? SecondaryAccountAllowed
        {
            get { return Fields.SecondaryAccountAllowed[this]; }
            set { Fields.SecondaryAccountAllowed[this] = value; }
        }

        [DisplayName("Bank Transaction Booking"), NotNull]
        public Boolean? BankTransactionBooking
        {
            get { return Fields.BankTransactionBooking[this]; }
            set { Fields.BankTransactionBooking[this] = value; }
        }

        [DisplayName("Cash Accounting"), NotNull]
        public Boolean? CashAccounting
        {
            get { return Fields.CashAccounting[this]; }
            set { Fields.CashAccounting[this] = value; }
        }

        [DisplayName("Ledger Item Collector To Secondary Account"), NotNull]
        public Boolean? LedgerItemCollectorToSecondaryAccount
        {
            get { return Fields.LedgerItemCollectorToSecondaryAccount[this]; }
            set { Fields.LedgerItemCollectorToSecondaryAccount[this] = value; }
        }

        [DisplayName("Ledger Rounding Threshold Amount"), Size(19), Scale(4), NotNull]
        public Decimal? LedgerRoundingThresholdAmount
        {
            get { return Fields.LedgerRoundingThresholdAmount[this]; }
            set { Fields.LedgerRoundingThresholdAmount[this] = value; }
        }

        [DisplayName("Apply Finence Lock To Stock"), NotNull]
        public Boolean? ApplyFinenceLockToStock
        {
            get { return Fields.ApplyFinenceLockToStock[this]; }
            set { Fields.ApplyFinenceLockToStock[this] = value; }
        }

        [DisplayName("Cash Accounting Vat Carry Over"), Column("CashAccountingVATCarryOver"), NotNull]
        public Boolean? CashAccountingVatCarryOver
        {
            get { return Fields.CashAccountingVatCarryOver[this]; }
            set { Fields.CashAccountingVatCarryOver[this] = value; }
        }

        [DisplayName("Vat Off Period Transfer"), Column("VATOffPeriodTransfer"), NotNull]
        public Boolean? VatOffPeriodTransfer
        {
            get { return Fields.VatOffPeriodTransfer[this]; }
            set { Fields.VatOffPeriodTransfer[this] = value; }
        }

        [DisplayName("Vat Rate Difference Transfer"), Column("VATRateDifferenceTransfer"), NotNull]
        public Boolean? VatRateDifferenceTransfer
        {
            get { return Fields.VatRateDifferenceTransfer[this]; }
            set { Fields.VatRateDifferenceTransfer[this] = value; }
        }

        [DisplayName("Voucher Short Year Number"), NotNull]
        public Boolean? VoucherShortYearNumber
        {
            get { return Fields.VoucherShortYearNumber[this]; }
            set { Fields.VoucherShortYearNumber[this] = value; }
        }

        [DisplayName("Reference Short Year Number"), NotNull]
        public Boolean? ReferenceShortYearNumber
        {
            get { return Fields.ReferenceShortYearNumber[this]; }
            set { Fields.ReferenceShortYearNumber[this] = value; }
        }

        [DisplayName("Parent Tax Year Timestamp"), Expression("jParentTaxYear.[timestamp]")]
        public byte[] ParentTaxYearTimestamp
        {
            get { return Fields.ParentTaxYearTimestamp[this]; }
            set { Fields.ParentTaxYearTimestamp[this] = value; }
        }

        [DisplayName("Parent Tax Year Parent Tax Year Id"), Expression("jParentTaxYear.[ParentTaxYearId]")]
        public Int32? ParentTaxYearParentTaxYearId
        {
            get { return Fields.ParentTaxYearParentTaxYearId[this]; }
            set { Fields.ParentTaxYearParentTaxYearId[this] = value; }
        }

        [DisplayName("Parent Tax Year Currency Id"), Expression("jParentTaxYear.[CurrencyId]")]
        public String ParentTaxYearCurrencyId
        {
            get { return Fields.ParentTaxYearCurrencyId[this]; }
            set { Fields.ParentTaxYearCurrencyId[this] = value; }
        }

        [DisplayName("Parent Tax Year Tax Currency Id"), Expression("jParentTaxYear.[TaxCurrencyId]")]
        public String ParentTaxYearTaxCurrencyId
        {
            get { return Fields.ParentTaxYearTaxCurrencyId[this]; }
            set { Fields.ParentTaxYearTaxCurrencyId[this] = value; }
        }

        [DisplayName("Parent Tax Year Name"), Expression("jParentTaxYear.[Name]")]
        public String ParentTaxYearName
        {
            get { return Fields.ParentTaxYearName[this]; }
            set { Fields.ParentTaxYearName[this] = value; }
        }

        [DisplayName("Parent Tax Year Year Num"), Expression("jParentTaxYear.[YearNum]")]
        public Int32? ParentTaxYearYearNum
        {
            get { return Fields.ParentTaxYearYearNum[this]; }
            set { Fields.ParentTaxYearYearNum[this] = value; }
        }

        [DisplayName("Parent Tax Year Start Date"), Expression("jParentTaxYear.[StartDate]")]
        public DateTime? ParentTaxYearStartDate
        {
            get { return Fields.ParentTaxYearStartDate[this]; }
            set { Fields.ParentTaxYearStartDate[this] = value; }
        }

        [DisplayName("Parent Tax Year End Date"), Expression("jParentTaxYear.[EndDate]")]
        public DateTime? ParentTaxYearEndDate
        {
            get { return Fields.ParentTaxYearEndDate[this]; }
            set { Fields.ParentTaxYearEndDate[this] = value; }
        }

        [DisplayName("Parent Tax Year Voucher Format"), Expression("jParentTaxYear.[VoucherFormat]")]
        public Int32? ParentTaxYearVoucherFormat
        {
            get { return Fields.ParentTaxYearVoucherFormat[this]; }
            set { Fields.ParentTaxYearVoucherFormat[this] = value; }
        }

        [DisplayName("Parent Tax Year Voucher Digits"), Expression("jParentTaxYear.[VoucherDigits]")]
        public Int32? ParentTaxYearVoucherDigits
        {
            get { return Fields.ParentTaxYearVoucherDigits[this]; }
            set { Fields.ParentTaxYearVoucherDigits[this] = value; }
        }

        [DisplayName("Parent Tax Year Voucher Sep First"), Expression("jParentTaxYear.[VoucherSepFirst]")]
        public String ParentTaxYearVoucherSepFirst
        {
            get { return Fields.ParentTaxYearVoucherSepFirst[this]; }
            set { Fields.ParentTaxYearVoucherSepFirst[this] = value; }
        }

        [DisplayName("Parent Tax Year Voucher Sep Last"), Expression("jParentTaxYear.[VoucherSepLast]")]
        public String ParentTaxYearVoucherSepLast
        {
            get { return Fields.ParentTaxYearVoucherSepLast[this]; }
            set { Fields.ParentTaxYearVoucherSepLast[this] = value; }
        }

        [DisplayName("Parent Tax Year Reference Num Format"), Expression("jParentTaxYear.[ReferenceNumFormat]")]
        public Int32? ParentTaxYearReferenceNumFormat
        {
            get { return Fields.ParentTaxYearReferenceNumFormat[this]; }
            set { Fields.ParentTaxYearReferenceNumFormat[this] = value; }
        }

        [DisplayName("Parent Tax Year Reference Num Digits"), Expression("jParentTaxYear.[ReferenceNumDigits]")]
        public Int32? ParentTaxYearReferenceNumDigits
        {
            get { return Fields.ParentTaxYearReferenceNumDigits[this]; }
            set { Fields.ParentTaxYearReferenceNumDigits[this] = value; }
        }

        [DisplayName("Parent Tax Year Reference Num Sep First"), Expression("jParentTaxYear.[ReferenceNumSepFirst]")]
        public String ParentTaxYearReferenceNumSepFirst
        {
            get { return Fields.ParentTaxYearReferenceNumSepFirst[this]; }
            set { Fields.ParentTaxYearReferenceNumSepFirst[this] = value; }
        }

        [DisplayName("Parent Tax Year Reference Num Sep Last"), Expression("jParentTaxYear.[ReferenceNumSepLast]")]
        public String ParentTaxYearReferenceNumSepLast
        {
            get { return Fields.ParentTaxYearReferenceNumSepLast[this]; }
            set { Fields.ParentTaxYearReferenceNumSepLast[this] = value; }
        }

        [DisplayName("Parent Tax Year Is Closed"), Expression("jParentTaxYear.[IsClosed]")]
        public Boolean? ParentTaxYearIsClosed
        {
            get { return Fields.ParentTaxYearIsClosed[this]; }
            set { Fields.ParentTaxYearIsClosed[this] = value; }
        }

        [DisplayName("Parent Tax Year Currency Evaluation Mode"), Expression("jParentTaxYear.[CurrencyEvaluationMode]")]
        public Int32? ParentTaxYearCurrencyEvaluationMode
        {
            get { return Fields.ParentTaxYearCurrencyEvaluationMode[this]; }
            set { Fields.ParentTaxYearCurrencyEvaluationMode[this] = value; }
        }

        [DisplayName("Parent Tax Year Currency Exchange Type"), Expression("jParentTaxYear.[CurrencyExchangeType]")]
        public Int32? ParentTaxYearCurrencyExchangeType
        {
            get { return Fields.ParentTaxYearCurrencyExchangeType[this]; }
            set { Fields.ParentTaxYearCurrencyExchangeType[this] = value; }
        }

        [DisplayName("Parent Tax Year Sales Exchance Type"), Expression("jParentTaxYear.[SalesExchanceType]")]
        public Int32? ParentTaxYearSalesExchanceType
        {
            get { return Fields.ParentTaxYearSalesExchanceType[this]; }
            set { Fields.ParentTaxYearSalesExchanceType[this] = value; }
        }

        [DisplayName("Parent Tax Year Booking Exchange Type"), Expression("jParentTaxYear.[BookingExchangeType]")]
        public Int32? ParentTaxYearBookingExchangeType
        {
            get { return Fields.ParentTaxYearBookingExchangeType[this]; }
            set { Fields.ParentTaxYearBookingExchangeType[this] = value; }
        }

        [DisplayName("Parent Tax Year Stock Evaluation Mode"), Expression("jParentTaxYear.[StockEvaluationMode]")]
        public Int32? ParentTaxYearStockEvaluationMode
        {
            get { return Fields.ParentTaxYearStockEvaluationMode[this]; }
            set { Fields.ParentTaxYearStockEvaluationMode[this] = value; }
        }

        [DisplayName("Parent Tax Year Finance Lock Date"), Expression("jParentTaxYear.[FinanceLockDate]")]
        public DateTime? ParentTaxYearFinanceLockDate
        {
            get { return Fields.ParentTaxYearFinanceLockDate[this]; }
            set { Fields.ParentTaxYearFinanceLockDate[this] = value; }
        }

        [DisplayName("Parent Tax Year Parallel Booking"), Expression("jParentTaxYear.[ParallelBooking]")]
        public Boolean? ParentTaxYearParallelBooking
        {
            get { return Fields.ParentTaxYearParallelBooking[this]; }
            set { Fields.ParentTaxYearParallelBooking[this] = value; }
        }

        [DisplayName("Parent Tax Year Ledger Rounding"), Expression("jParentTaxYear.[LedgerRounding]")]
        public Boolean? ParentTaxYearLedgerRounding
        {
            get { return Fields.ParentTaxYearLedgerRounding[this]; }
            set { Fields.ParentTaxYearLedgerRounding[this] = value; }
        }

        [DisplayName("Parent Tax Year Secondary Account Allowed"), Expression("jParentTaxYear.[SecondaryAccountAllowed]")]
        public Boolean? ParentTaxYearSecondaryAccountAllowed
        {
            get { return Fields.ParentTaxYearSecondaryAccountAllowed[this]; }
            set { Fields.ParentTaxYearSecondaryAccountAllowed[this] = value; }
        }

        [DisplayName("Parent Tax Year Bank Transaction Booking"), Expression("jParentTaxYear.[BankTransactionBooking]")]
        public Boolean? ParentTaxYearBankTransactionBooking
        {
            get { return Fields.ParentTaxYearBankTransactionBooking[this]; }
            set { Fields.ParentTaxYearBankTransactionBooking[this] = value; }
        }

        [DisplayName("Parent Tax Year Cash Accounting"), Expression("jParentTaxYear.[CashAccounting]")]
        public Boolean? ParentTaxYearCashAccounting
        {
            get { return Fields.ParentTaxYearCashAccounting[this]; }
            set { Fields.ParentTaxYearCashAccounting[this] = value; }
        }

        [DisplayName("Parent Tax Year Ledger Item Collector To Secondary Account"), Expression("jParentTaxYear.[LedgerItemCollectorToSecondaryAccount]")]
        public Boolean? ParentTaxYearLedgerItemCollectorToSecondaryAccount
        {
            get { return Fields.ParentTaxYearLedgerItemCollectorToSecondaryAccount[this]; }
            set { Fields.ParentTaxYearLedgerItemCollectorToSecondaryAccount[this] = value; }
        }

        [DisplayName("Parent Tax Year Ledger Rounding Threshold Amount"), Expression("jParentTaxYear.[LedgerRoundingThresholdAmount]")]
        public Decimal? ParentTaxYearLedgerRoundingThresholdAmount
        {
            get { return Fields.ParentTaxYearLedgerRoundingThresholdAmount[this]; }
            set { Fields.ParentTaxYearLedgerRoundingThresholdAmount[this] = value; }
        }

        [DisplayName("Parent Tax Year Apply Finence Lock To Stock"), Expression("jParentTaxYear.[ApplyFinenceLockToStock]")]
        public Boolean? ParentTaxYearApplyFinenceLockToStock
        {
            get { return Fields.ParentTaxYearApplyFinenceLockToStock[this]; }
            set { Fields.ParentTaxYearApplyFinenceLockToStock[this] = value; }
        }

        [DisplayName("Parent Tax Year Cash Accounting Vat Carry Over"), Expression("jParentTaxYear.[CashAccountingVATCarryOver]")]
        public Boolean? ParentTaxYearCashAccountingVatCarryOver
        {
            get { return Fields.ParentTaxYearCashAccountingVatCarryOver[this]; }
            set { Fields.ParentTaxYearCashAccountingVatCarryOver[this] = value; }
        }

        [DisplayName("Parent Tax Year Vat Off Period Transfer"), Expression("jParentTaxYear.[VATOffPeriodTransfer]")]
        public Boolean? ParentTaxYearVatOffPeriodTransfer
        {
            get { return Fields.ParentTaxYearVatOffPeriodTransfer[this]; }
            set { Fields.ParentTaxYearVatOffPeriodTransfer[this] = value; }
        }

        [DisplayName("Parent Tax Year Vat Rate Difference Transfer"), Expression("jParentTaxYear.[VATRateDifferenceTransfer]")]
        public Boolean? ParentTaxYearVatRateDifferenceTransfer
        {
            get { return Fields.ParentTaxYearVatRateDifferenceTransfer[this]; }
            set { Fields.ParentTaxYearVatRateDifferenceTransfer[this] = value; }
        }

        [DisplayName("Parent Tax Year Voucher Short Year Number"), Expression("jParentTaxYear.[VoucherShortYearNumber]")]
        public Boolean? ParentTaxYearVoucherShortYearNumber
        {
            get { return Fields.ParentTaxYearVoucherShortYearNumber[this]; }
            set { Fields.ParentTaxYearVoucherShortYearNumber[this] = value; }
        }

        [DisplayName("Parent Tax Year Reference Short Year Number"), Expression("jParentTaxYear.[ReferenceShortYearNumber]")]
        public Boolean? ParentTaxYearReferenceShortYearNumber
        {
            get { return Fields.ParentTaxYearReferenceShortYearNumber[this]; }
            set { Fields.ParentTaxYearReferenceShortYearNumber[this] = value; }
        }

        [DisplayName("Currency Name"), Expression("jCurrency.[Name]")]
        public String CurrencyName
        {
            get { return Fields.CurrencyName[this]; }
            set { Fields.CurrencyName[this] = value; }
        }

        [DisplayName("Currency Is Active"), Expression("jCurrency.[IsActive]")]
        public Boolean? CurrencyIsActive
        {
            get { return Fields.CurrencyIsActive[this]; }
            set { Fields.CurrencyIsActive[this] = value; }
        }

        [DisplayName("Currency End Date"), Expression("jCurrency.[EndDate]")]
        public DateTime? CurrencyEndDate
        {
            get { return Fields.CurrencyEndDate[this]; }
            set { Fields.CurrencyEndDate[this] = value; }
        }

        [DisplayName("Currency Min Amount"), Expression("jCurrency.[MinAmount]")]
        public Decimal? CurrencyMinAmount
        {
            get { return Fields.CurrencyMinAmount[this]; }
            set { Fields.CurrencyMinAmount[this] = value; }
        }

        [DisplayName("Currency Timestamp"), Expression("jCurrency.[timestamp]")]
        public byte[] CurrencyTimestamp
        {
            get { return Fields.CurrencyTimestamp[this]; }
            set { Fields.CurrencyTimestamp[this] = value; }
        }

        [DisplayName("Currency Avatar Id"), Expression("jCurrency.[AvatarId]")]
        public Int32? CurrencyAvatarId
        {
            get { return Fields.CurrencyAvatarId[this]; }
            set { Fields.CurrencyAvatarId[this] = value; }
        }

        [DisplayName("Tax Currency Name"), Expression("jTaxCurrency.[Name]")]
        public String TaxCurrencyName
        {
            get { return Fields.TaxCurrencyName[this]; }
            set { Fields.TaxCurrencyName[this] = value; }
        }

        [DisplayName("Tax Currency Is Active"), Expression("jTaxCurrency.[IsActive]")]
        public Boolean? TaxCurrencyIsActive
        {
            get { return Fields.TaxCurrencyIsActive[this]; }
            set { Fields.TaxCurrencyIsActive[this] = value; }
        }

        [DisplayName("Tax Currency End Date"), Expression("jTaxCurrency.[EndDate]")]
        public DateTime? TaxCurrencyEndDate
        {
            get { return Fields.TaxCurrencyEndDate[this]; }
            set { Fields.TaxCurrencyEndDate[this] = value; }
        }

        [DisplayName("Tax Currency Min Amount"), Expression("jTaxCurrency.[MinAmount]")]
        public Decimal? TaxCurrencyMinAmount
        {
            get { return Fields.TaxCurrencyMinAmount[this]; }
            set { Fields.TaxCurrencyMinAmount[this] = value; }
        }

        [DisplayName("Tax Currency Timestamp"), Expression("jTaxCurrency.[timestamp]")]
        public byte[] TaxCurrencyTimestamp
        {
            get { return Fields.TaxCurrencyTimestamp[this]; }
            set { Fields.TaxCurrencyTimestamp[this] = value; }
        }

        [DisplayName("Tax Currency Avatar Id"), Expression("jTaxCurrency.[AvatarId]")]
        public Int32? TaxCurrencyAvatarId
        {
            get { return Fields.TaxCurrencyAvatarId[this]; }
            set { Fields.TaxCurrencyAvatarId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TaxYearRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public ByteArrayField Timestamp;
            public Int32Field ParentTaxYearId;
            public StringField CurrencyId;
            public StringField TaxCurrencyId;
            public StringField Name;
            public Int32Field YearNum;
            public DateTimeField StartDate;
            public DateTimeField EndDate;
            public Int32Field VoucherFormat;
            public Int32Field VoucherDigits;
            public StringField VoucherSepFirst;
            public StringField VoucherSepLast;
            public Int32Field ReferenceNumFormat;
            public Int32Field ReferenceNumDigits;
            public StringField ReferenceNumSepFirst;
            public StringField ReferenceNumSepLast;
            public BooleanField IsClosed;
            public Int32Field CurrencyEvaluationMode;
            public Int32Field CurrencyExchangeType;
            public Int32Field SalesExchanceType;
            public Int32Field BookingExchangeType;
            public Int32Field StockEvaluationMode;
            public DateTimeField FinanceLockDate;
            public BooleanField ParallelBooking;
            public BooleanField LedgerRounding;
            public BooleanField SecondaryAccountAllowed;
            public BooleanField BankTransactionBooking;
            public BooleanField CashAccounting;
            public BooleanField LedgerItemCollectorToSecondaryAccount;
            public DecimalField LedgerRoundingThresholdAmount;
            public BooleanField ApplyFinenceLockToStock;
            public BooleanField CashAccountingVatCarryOver;
            public BooleanField VatOffPeriodTransfer;
            public BooleanField VatRateDifferenceTransfer;
            public BooleanField VoucherShortYearNumber;
            public BooleanField ReferenceShortYearNumber;

            public ByteArrayField ParentTaxYearTimestamp;
            public Int32Field ParentTaxYearParentTaxYearId;
            public StringField ParentTaxYearCurrencyId;
            public StringField ParentTaxYearTaxCurrencyId;
            public StringField ParentTaxYearName;
            public Int32Field ParentTaxYearYearNum;
            public DateTimeField ParentTaxYearStartDate;
            public DateTimeField ParentTaxYearEndDate;
            public Int32Field ParentTaxYearVoucherFormat;
            public Int32Field ParentTaxYearVoucherDigits;
            public StringField ParentTaxYearVoucherSepFirst;
            public StringField ParentTaxYearVoucherSepLast;
            public Int32Field ParentTaxYearReferenceNumFormat;
            public Int32Field ParentTaxYearReferenceNumDigits;
            public StringField ParentTaxYearReferenceNumSepFirst;
            public StringField ParentTaxYearReferenceNumSepLast;
            public BooleanField ParentTaxYearIsClosed;
            public Int32Field ParentTaxYearCurrencyEvaluationMode;
            public Int32Field ParentTaxYearCurrencyExchangeType;
            public Int32Field ParentTaxYearSalesExchanceType;
            public Int32Field ParentTaxYearBookingExchangeType;
            public Int32Field ParentTaxYearStockEvaluationMode;
            public DateTimeField ParentTaxYearFinanceLockDate;
            public BooleanField ParentTaxYearParallelBooking;
            public BooleanField ParentTaxYearLedgerRounding;
            public BooleanField ParentTaxYearSecondaryAccountAllowed;
            public BooleanField ParentTaxYearBankTransactionBooking;
            public BooleanField ParentTaxYearCashAccounting;
            public BooleanField ParentTaxYearLedgerItemCollectorToSecondaryAccount;
            public DecimalField ParentTaxYearLedgerRoundingThresholdAmount;
            public BooleanField ParentTaxYearApplyFinenceLockToStock;
            public BooleanField ParentTaxYearCashAccountingVatCarryOver;
            public BooleanField ParentTaxYearVatOffPeriodTransfer;
            public BooleanField ParentTaxYearVatRateDifferenceTransfer;
            public BooleanField ParentTaxYearVoucherShortYearNumber;
            public BooleanField ParentTaxYearReferenceShortYearNumber;

            public StringField CurrencyName;
            public BooleanField CurrencyIsActive;
            public DateTimeField CurrencyEndDate;
            public DecimalField CurrencyMinAmount;
            public ByteArrayField CurrencyTimestamp;
            public Int32Field CurrencyAvatarId;

            public StringField TaxCurrencyName;
            public BooleanField TaxCurrencyIsActive;
            public DateTimeField TaxCurrencyEndDate;
            public DecimalField TaxCurrencyMinAmount;
            public ByteArrayField TaxCurrencyTimestamp;
            public Int32Field TaxCurrencyAvatarId;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Cobrademo.TaxYear";
            }
        }
    }
}
