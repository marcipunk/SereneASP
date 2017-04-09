
namespace SereneASP.Cobrademo.Entities
{
    using SereneASP.Modules.Cobrademo.Account;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("CobraDemo"), TableName("[dbo].[Account]"), DisplayName("Account"), InstanceName("Account"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class AccountRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), NotNull, Identity, ForeignKey("[dbo].[AccountName]", "AccountId"), LeftJoin ("jAccountName")]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Avatar"), Column("AvatarID"), ForeignKey("[dbo].[Avatar]", "Id"), LeftJoin("jAvatar")]
        public Int32? AvatarId
        {
            get { return Fields.AvatarId[this]; }
            set { Fields.AvatarId[this] = value; }
        }

        [DisplayName("Timestamp"), Column("timestamp"), Insertable(false), Updatable(false), NotNull]
        public byte[] Timestamp
        {
            get { return Fields.Timestamp[this]; }
            set { Fields.Timestamp[this] = value; }
        }

        [DisplayName("Account Name"), Expression("jAccountName.[Value]")]
        [LookupEditor(typeof(AccountNameRow))]
        public String AccountName
        {
            get { return Fields.AccountName[this]; }
            set { Fields.AccountName[this] = value; }
        }

        [DisplayName("Language Id"), Expression("jAccountName.[LanguageId]")]
        
        public String LanguageId
        {
            get { return Fields.LanguageId[this]; }
            set { Fields.LanguageId[this] = value; }
        }


        [DisplayName("Treasury Account"), ForeignKey("[dbo].[TreasuryAccount]", "Id"), LeftJoin("jTreasuryAccount"), TextualField("TreasuryAccountNumber")]
        public Int32? TreasuryAccountId
        {
            get { return Fields.TreasuryAccountId[this]; }
            set { Fields.TreasuryAccountId[this] = value; }
        }

        [DisplayName("Tax Year"), NotNull, ForeignKey("[dbo].[TaxYear]", "Id"), LeftJoin("jTaxYear")/*, TextualField("TaxYearName")*/]
        [LookupEditor(typeof(TaxYearRow))]
        public Int32? TaxYearId
        {
            get { return Fields.TaxYearId[this]; }
            set { Fields.TaxYearId[this] = value; }
        }

        [DisplayName("Ancestor Account"), ForeignKey("[dbo].[Account]", "Id"), LeftJoin("jAncestorAccount"), TextualField("AncestorAccountCode")]
        public Int32? AncestorAccountId
        {
            get { return Fields.AncestorAccountId[this]; }
            set { Fields.AncestorAccountId[this] = value; }
        }

        [DisplayName("Parent Account"), ForeignKey("[dbo].[Account]", "Id"), LeftJoin("jParentAccount"), TextualField("ParentAccountCode")]
        public Int32? ParentAccountId
        {
            get { return Fields.ParentAccountId[this]; }
            set { Fields.ParentAccountId[this] = value; }
        }

        [DisplayName("Code"), Size(15), NotNull, QuickSearch]
        public String Code
        {
            get { return Fields.Code[this]; }
            set { Fields.Code[this] = value; }
        }

        [DisplayName("Placeholder"), NotNull]
        public Boolean? Placeholder
        {
            get { return Fields.Placeholder[this]; }
            set { Fields.Placeholder[this] = value; }
        }

        [DisplayName("Tax Related"), NotNull]
        public Boolean? TaxRelated
        {
            get { return Fields.TaxRelated[this]; }
            set { Fields.TaxRelated[this] = value; }
        }

        [DisplayName("Hidden"), NotNull]
        public Boolean? Hidden
        {
            get { return Fields.Hidden[this]; }
            set { Fields.Hidden[this] = value; }
        }

        [DisplayName("Type Id"), NotNull, DefaultValue(0)]
        public Int32? TypeId
        {
            get { return Fields.TypeId[this]; }
            set { Fields.TypeId[this] = value; }
        }

        [DisplayName("Transaction Account"), ForeignKey("[dbo].[Account]", "Id"), LeftJoin("jTransactionAccount"), TextualField("TransactionAccountCode")]
        public Int32? TransactionAccountId
        {
            get { return Fields.TransactionAccountId[this]; }
            set { Fields.TransactionAccountId[this] = value; }
        }

        [DisplayName("Is Collector Expected"), NotNull]
        public Boolean? IsCollectorExpected
        {
            get { return Fields.IsCollectorExpected[this]; }
            set { Fields.IsCollectorExpected[this] = value; }
        }

        [DisplayName("Parallel Account"), ForeignKey("[dbo].[Account]", "Id"), LeftJoin("jParallelAccount"), TextualField("ParallelAccountCode")]
        public Int32? ParallelAccountId
        {
            get { return Fields.ParallelAccountId[this]; }
            set { Fields.ParallelAccountId[this] = value; }
        }

        [DisplayName("Layer Id"), NotNull, DefaultValue(1)]
        public LayerEnum? LayerId
        {
            get { return (LayerEnum?)Fields.LayerId[this]; }
            set { Fields.LayerId[this] = (Int32?)value; }
        }

        [DisplayName("Is Partner Expected"), NotNull]
        public Boolean? IsPartnerExpected
        {
            get { return Fields.IsPartnerExpected[this]; }
            set { Fields.IsPartnerExpected[this] = value; }
        }

        [DisplayName("Avatar Table Type Id"), Expression("jAvatar.[TableTypeId]")]
        public Int32? AvatarTableTypeId
        {
            get { return Fields.AvatarTableTypeId[this]; }
            set { Fields.AvatarTableTypeId[this] = value; }
        }

        [DisplayName("Avatar Global Id"), Expression("jAvatar.[GlobalId]")]
        public Guid? AvatarGlobalId
        {
            get { return Fields.AvatarGlobalId[this]; }
            set { Fields.AvatarGlobalId[this] = value; }
        }

        [DisplayName("Treasury Account Number"), Expression("jTreasuryAccount.[Number]")]
        public String TreasuryAccountNumber
        {
            get { return Fields.TreasuryAccountNumber[this]; }
            set { Fields.TreasuryAccountNumber[this] = value; }
        }

        [DisplayName("Treasury Account Name"), Expression("jTreasuryAccount.[Name]")]
        public String TreasuryAccountName
        {
            get { return Fields.TreasuryAccountName[this]; }
            set { Fields.TreasuryAccountName[this] = value; }
        }

        [DisplayName("Treasury Account Tax Code"), Expression("jTreasuryAccount.[TaxCode]")]
        public String TreasuryAccountTaxCode
        {
            get { return Fields.TreasuryAccountTaxCode[this]; }
            set { Fields.TreasuryAccountTaxCode[this] = value; }
        }

        [DisplayName("Treasury Account Valid From"), Expression("jTreasuryAccount.[ValidFrom]")]
        public DateTime? TreasuryAccountValidFrom
        {
            get { return Fields.TreasuryAccountValidFrom[this]; }
            set { Fields.TreasuryAccountValidFrom[this] = value; }
        }

        [DisplayName("Treasury Account Valid Until"), Expression("jTreasuryAccount.[ValidUntil]")]
        public DateTime? TreasuryAccountValidUntil
        {
            get { return Fields.TreasuryAccountValidUntil[this]; }
            set { Fields.TreasuryAccountValidUntil[this] = value; }
        }

        //[DisplayName("Tax Year Timestamp"), Expression("jTaxYear.[timestamp]")]
        //public byte[] TaxYearTimestamp
        //{
        //    get { return Fields.TaxYearTimestamp[this]; }
        //    set { Fields.TaxYearTimestamp[this] = value; }
        //}

        //[DisplayName("Tax Year Parent Tax Year Id"), Expression("jTaxYear.[ParentTaxYearId]")]
        //public Int32? TaxYearParentTaxYearId
        //{
        //    get { return Fields.TaxYearParentTaxYearId[this]; }
        //    set { Fields.TaxYearParentTaxYearId[this] = value; }
        //}

        //[DisplayName("Tax Year Currency Id"), Expression("jTaxYear.[CurrencyId]")]
        //public String TaxYearCurrencyId
        //{
        //    get { return Fields.TaxYearCurrencyId[this]; }
        //    set { Fields.TaxYearCurrencyId[this] = value; }
        //}

        //[DisplayName("Tax Year Tax Currency Id"), Expression("jTaxYear.[TaxCurrencyId]")]
        //public String TaxYearTaxCurrencyId
        //{
        //    get { return Fields.TaxYearTaxCurrencyId[this]; }
        //    set { Fields.TaxYearTaxCurrencyId[this] = value; }
        //}

        [DisplayName("Tax Year Name"), Expression("jTaxYear.[Name]")]
        public String TaxYearName
        {
            get { return Fields.TaxYearName[this]; }
            set { Fields.TaxYearName[this] = value; }
        }

        [DisplayName("Tax Year Year Num"), Expression("jTaxYear.[YearNum]")]
        public Int32? TaxYearYearNum
        {
            get { return Fields.TaxYearYearNum[this]; }
            set { Fields.TaxYearYearNum[this] = value; }
        }

        //[DisplayName("Tax Year Start Date"), Expression("jTaxYear.[StartDate]")]
        //public DateTime? TaxYearStartDate
        //{
        //    get { return Fields.TaxYearStartDate[this]; }
        //    set { Fields.TaxYearStartDate[this] = value; }
        //}

        //[DisplayName("Tax Year End Date"), Expression("jTaxYear.[EndDate]")]
        //public DateTime? TaxYearEndDate
        //{
        //    get { return Fields.TaxYearEndDate[this]; }
        //    set { Fields.TaxYearEndDate[this] = value; }
        //}

        //[DisplayName("Tax Year Voucher Format"), Expression("jTaxYear.[VoucherFormat]")]
        //public Int32? TaxYearVoucherFormat
        //{
        //    get { return Fields.TaxYearVoucherFormat[this]; }
        //    set { Fields.TaxYearVoucherFormat[this] = value; }
        //}

        //[DisplayName("Tax Year Voucher Digits"), Expression("jTaxYear.[VoucherDigits]")]
        //public Int32? TaxYearVoucherDigits
        //{
        //    get { return Fields.TaxYearVoucherDigits[this]; }
        //    set { Fields.TaxYearVoucherDigits[this] = value; }
        //}

        //[DisplayName("Tax Year Voucher Sep First"), Expression("jTaxYear.[VoucherSepFirst]")]
        //public String TaxYearVoucherSepFirst
        //{
        //    get { return Fields.TaxYearVoucherSepFirst[this]; }
        //    set { Fields.TaxYearVoucherSepFirst[this] = value; }
        //}

        //[DisplayName("Tax Year Voucher Sep Last"), Expression("jTaxYear.[VoucherSepLast]")]
        //public String TaxYearVoucherSepLast
        //{
        //    get { return Fields.TaxYearVoucherSepLast[this]; }
        //    set { Fields.TaxYearVoucherSepLast[this] = value; }
        //}

        //[DisplayName("Tax Year Reference Num Format"), Expression("jTaxYear.[ReferenceNumFormat]")]
        //public Int32? TaxYearReferenceNumFormat
        //{
        //    get { return Fields.TaxYearReferenceNumFormat[this]; }
        //    set { Fields.TaxYearReferenceNumFormat[this] = value; }
        //}

        //[DisplayName("Tax Year Reference Num Digits"), Expression("jTaxYear.[ReferenceNumDigits]")]
        //public Int32? TaxYearReferenceNumDigits
        //{
        //    get { return Fields.TaxYearReferenceNumDigits[this]; }
        //    set { Fields.TaxYearReferenceNumDigits[this] = value; }
        //}

        //[DisplayName("Tax Year Reference Num Sep First"), Expression("jTaxYear.[ReferenceNumSepFirst]")]
        //public String TaxYearReferenceNumSepFirst
        //{
        //    get { return Fields.TaxYearReferenceNumSepFirst[this]; }
        //    set { Fields.TaxYearReferenceNumSepFirst[this] = value; }
        //}

        //[DisplayName("Tax Year Reference Num Sep Last"), Expression("jTaxYear.[ReferenceNumSepLast]")]
        //public String TaxYearReferenceNumSepLast
        //{
        //    get { return Fields.TaxYearReferenceNumSepLast[this]; }
        //    set { Fields.TaxYearReferenceNumSepLast[this] = value; }
        //}

        //[DisplayName("Tax Year Is Closed"), Expression("jTaxYear.[IsClosed]")]
        //public Boolean? TaxYearIsClosed
        //{
        //    get { return Fields.TaxYearIsClosed[this]; }
        //    set { Fields.TaxYearIsClosed[this] = value; }
        //}

        //[DisplayName("Tax Year Currency Evaluation Mode"), Expression("jTaxYear.[CurrencyEvaluationMode]")]
        //public Int32? TaxYearCurrencyEvaluationMode
        //{
        //    get { return Fields.TaxYearCurrencyEvaluationMode[this]; }
        //    set { Fields.TaxYearCurrencyEvaluationMode[this] = value; }
        //}

        //[DisplayName("Tax Year Currency Exchange Type"), Expression("jTaxYear.[CurrencyExchangeType]")]
        //public Int32? TaxYearCurrencyExchangeType
        //{
        //    get { return Fields.TaxYearCurrencyExchangeType[this]; }
        //    set { Fields.TaxYearCurrencyExchangeType[this] = value; }
        //}

        //[DisplayName("Tax Year Sales Exchance Type"), Expression("jTaxYear.[SalesExchanceType]")]
        //public Int32? TaxYearSalesExchanceType
        //{
        //    get { return Fields.TaxYearSalesExchanceType[this]; }
        //    set { Fields.TaxYearSalesExchanceType[this] = value; }
        //}

        //[DisplayName("Tax Year Booking Exchange Type"), Expression("jTaxYear.[BookingExchangeType]")]
        //public Int32? TaxYearBookingExchangeType
        //{
        //    get { return Fields.TaxYearBookingExchangeType[this]; }
        //    set { Fields.TaxYearBookingExchangeType[this] = value; }
        //}

        //[DisplayName("Tax Year Stock Evaluation Mode"), Expression("jTaxYear.[StockEvaluationMode]")]
        //public Int32? TaxYearStockEvaluationMode
        //{
        //    get { return Fields.TaxYearStockEvaluationMode[this]; }
        //    set { Fields.TaxYearStockEvaluationMode[this] = value; }
        //}

        //[DisplayName("Tax Year Finance Lock Date"), Expression("jTaxYear.[FinanceLockDate]")]
        //public DateTime? TaxYearFinanceLockDate
        //{
        //    get { return Fields.TaxYearFinanceLockDate[this]; }
        //    set { Fields.TaxYearFinanceLockDate[this] = value; }
        //}

        //[DisplayName("Tax Year Parallel Booking"), Expression("jTaxYear.[ParallelBooking]")]
        //public Boolean? TaxYearParallelBooking
        //{
        //    get { return Fields.TaxYearParallelBooking[this]; }
        //    set { Fields.TaxYearParallelBooking[this] = value; }
        //}

        //[DisplayName("Tax Year Ledger Rounding"), Expression("jTaxYear.[LedgerRounding]")]
        //public Boolean? TaxYearLedgerRounding
        //{
        //    get { return Fields.TaxYearLedgerRounding[this]; }
        //    set { Fields.TaxYearLedgerRounding[this] = value; }
        //}

        //[DisplayName("Tax Year Secondary Account Allowed"), Expression("jTaxYear.[SecondaryAccountAllowed]")]
        //public Boolean? TaxYearSecondaryAccountAllowed
        //{
        //    get { return Fields.TaxYearSecondaryAccountAllowed[this]; }
        //    set { Fields.TaxYearSecondaryAccountAllowed[this] = value; }
        //}

        //[DisplayName("Tax Year Bank Transaction Booking"), Expression("jTaxYear.[BankTransactionBooking]")]
        //public Boolean? TaxYearBankTransactionBooking
        //{
        //    get { return Fields.TaxYearBankTransactionBooking[this]; }
        //    set { Fields.TaxYearBankTransactionBooking[this] = value; }
        //}

        //[DisplayName("Tax Year Cash Accounting"), Expression("jTaxYear.[CashAccounting]")]
        //public Boolean? TaxYearCashAccounting
        //{
        //    get { return Fields.TaxYearCashAccounting[this]; }
        //    set { Fields.TaxYearCashAccounting[this] = value; }
        //}

        //[DisplayName("Tax Year Ledger Item Collector To Secondary Account"), Expression("jTaxYear.[LedgerItemCollectorToSecondaryAccount]")]
        //public Boolean? TaxYearLedgerItemCollectorToSecondaryAccount
        //{
        //    get { return Fields.TaxYearLedgerItemCollectorToSecondaryAccount[this]; }
        //    set { Fields.TaxYearLedgerItemCollectorToSecondaryAccount[this] = value; }
        //}

        //[DisplayName("Tax Year Ledger Rounding Threshold Amount"), Expression("jTaxYear.[LedgerRoundingThresholdAmount]")]
        //public Decimal? TaxYearLedgerRoundingThresholdAmount
        //{
        //    get { return Fields.TaxYearLedgerRoundingThresholdAmount[this]; }
        //    set { Fields.TaxYearLedgerRoundingThresholdAmount[this] = value; }
        //}

        //[DisplayName("Tax Year Apply Finence Lock To Stock"), Expression("jTaxYear.[ApplyFinenceLockToStock]")]
        //public Boolean? TaxYearApplyFinenceLockToStock
        //{
        //    get { return Fields.TaxYearApplyFinenceLockToStock[this]; }
        //    set { Fields.TaxYearApplyFinenceLockToStock[this] = value; }
        //}

        //[DisplayName("Tax Year Cash Accounting Vat Carry Over"), Expression("jTaxYear.[CashAccountingVATCarryOver]")]
        //public Boolean? TaxYearCashAccountingVatCarryOver
        //{
        //    get { return Fields.TaxYearCashAccountingVatCarryOver[this]; }
        //    set { Fields.TaxYearCashAccountingVatCarryOver[this] = value; }
        //}

        //[DisplayName("Tax Year Vat Off Period Transfer"), Expression("jTaxYear.[VATOffPeriodTransfer]")]
        //public Boolean? TaxYearVatOffPeriodTransfer
        //{
        //    get { return Fields.TaxYearVatOffPeriodTransfer[this]; }
        //    set { Fields.TaxYearVatOffPeriodTransfer[this] = value; }
        //}

        //[DisplayName("Tax Year Vat Rate Difference Transfer"), Expression("jTaxYear.[VATRateDifferenceTransfer]")]
        //public Boolean? TaxYearVatRateDifferenceTransfer
        //{
        //    get { return Fields.TaxYearVatRateDifferenceTransfer[this]; }
        //    set { Fields.TaxYearVatRateDifferenceTransfer[this] = value; }
        //}

        //[DisplayName("Tax Year Voucher Short Year Number"), Expression("jTaxYear.[VoucherShortYearNumber]")]
        //public Boolean? TaxYearVoucherShortYearNumber
        //{
        //    get { return Fields.TaxYearVoucherShortYearNumber[this]; }
        //    set { Fields.TaxYearVoucherShortYearNumber[this] = value; }
        //}

        //[DisplayName("Tax Year Reference Short Year Number"), Expression("jTaxYear.[ReferenceShortYearNumber]")]
        //public Boolean? TaxYearReferenceShortYearNumber
        //{
        //    get { return Fields.TaxYearReferenceShortYearNumber[this]; }
        //    set { Fields.TaxYearReferenceShortYearNumber[this] = value; }
        //}

        //[DisplayName("Ancestor Account Avatar Id"), Expression("jAncestorAccount.[AvatarID]")]
        //public Int32? AncestorAccountAvatarId
        //{
        //    get { return Fields.AncestorAccountAvatarId[this]; }
        //    set { Fields.AncestorAccountAvatarId[this] = value; }
        //}

        //[DisplayName("Ancestor Account Timestamp"), Expression("jAncestorAccount.[timestamp]")]
        //public byte[] AncestorAccountTimestamp
        //{
        //    get { return Fields.AncestorAccountTimestamp[this]; }
        //    set { Fields.AncestorAccountTimestamp[this] = value; }
        //}

        //[DisplayName("Ancestor Account Treasury Account Id"), Expression("jAncestorAccount.[TreasuryAccountId]")]
        //public Int32? AncestorAccountTreasuryAccountId
        //{
        //    get { return Fields.AncestorAccountTreasuryAccountId[this]; }
        //    set { Fields.AncestorAccountTreasuryAccountId[this] = value; }
        //}

        //[DisplayName("Ancestor Account Tax Year Id"), Expression("jAncestorAccount.[TaxYearId]")]
        //public Int32? AncestorAccountTaxYearId
        //{
        //    get { return Fields.AncestorAccountTaxYearId[this]; }
        //    set { Fields.AncestorAccountTaxYearId[this] = value; }
        //}

        //[DisplayName("Ancestor Account Ancestor Account Id"), Expression("jAncestorAccount.[AncestorAccountId]")]
        //public Int32? AncestorAccountAncestorAccountId
        //{
        //    get { return Fields.AncestorAccountAncestorAccountId[this]; }
        //    set { Fields.AncestorAccountAncestorAccountId[this] = value; }
        //}

        //[DisplayName("Ancestor Account Parent Account Id"), Expression("jAncestorAccount.[ParentAccountId]")]
        //public Int32? AncestorAccountParentAccountId
        //{
        //    get { return Fields.AncestorAccountParentAccountId[this]; }
        //    set { Fields.AncestorAccountParentAccountId[this] = value; }
        //}

        [DisplayName("Ancestor Account Code"), Expression("jAncestorAccount.[Code]")]
        public String AncestorAccountCode
        {
            get { return Fields.AncestorAccountCode[this]; }
            set { Fields.AncestorAccountCode[this] = value; }
        }

        [DisplayName("Ancestor Account Placeholder"), Expression("jAncestorAccount.[Placeholder]")]
        public Boolean? AncestorAccountPlaceholder
        {
            get { return Fields.AncestorAccountPlaceholder[this]; }
            set { Fields.AncestorAccountPlaceholder[this] = value; }
        }

        [DisplayName("Ancestor Account Tax Related"), Expression("jAncestorAccount.[TaxRelated]")]
        public Boolean? AncestorAccountTaxRelated
        {
            get { return Fields.AncestorAccountTaxRelated[this]; }
            set { Fields.AncestorAccountTaxRelated[this] = value; }
        }

        [DisplayName("Ancestor Account Hidden"), Expression("jAncestorAccount.[Hidden]")]
        public Boolean? AncestorAccountHidden
        {
            get { return Fields.AncestorAccountHidden[this]; }
            set { Fields.AncestorAccountHidden[this] = value; }
        }

        [DisplayName("Ancestor Account Type Id"), Expression("jAncestorAccount.[TypeId]")]
        public Int32? AncestorAccountTypeId
        {
            get { return Fields.AncestorAccountTypeId[this]; }
            set { Fields.AncestorAccountTypeId[this] = value; }
        }

        [DisplayName("Ancestor Account Transaction Account Id"), Expression("jAncestorAccount.[TransactionAccountId]")]
        public Int32? AncestorAccountTransactionAccountId
        {
            get { return Fields.AncestorAccountTransactionAccountId[this]; }
            set { Fields.AncestorAccountTransactionAccountId[this] = value; }
        }

        [DisplayName("Ancestor Account Is Collector Expected"), Expression("jAncestorAccount.[IsCollectorExpected]")]
        public Boolean? AncestorAccountIsCollectorExpected
        {
            get { return Fields.AncestorAccountIsCollectorExpected[this]; }
            set { Fields.AncestorAccountIsCollectorExpected[this] = value; }
        }

        [DisplayName("Ancestor Account Parallel Account Id"), Expression("jAncestorAccount.[ParallelAccountId]")]
        public Int32? AncestorAccountParallelAccountId
        {
            get { return Fields.AncestorAccountParallelAccountId[this]; }
            set { Fields.AncestorAccountParallelAccountId[this] = value; }
        }

        [DisplayName("Ancestor Account Layer Id"), Expression("jAncestorAccount.[LayerId]")]
        public Int32? AncestorAccountLayerId
        {
            get { return Fields.AncestorAccountLayerId[this]; }
            set { Fields.AncestorAccountLayerId[this] = value; }
        }

        [DisplayName("Ancestor Account Is Partner Expected"), Expression("jAncestorAccount.[IsPartnerExpected]")]
        public Boolean? AncestorAccountIsPartnerExpected
        {
            get { return Fields.AncestorAccountIsPartnerExpected[this]; }
            set { Fields.AncestorAccountIsPartnerExpected[this] = value; }
        }

        //[DisplayName("Parent Account Avatar Id"), Expression("jParentAccount.[AvatarID]")]
        //public Int32? ParentAccountAvatarId
        //{
        //    get { return Fields.ParentAccountAvatarId[this]; }
        //    set { Fields.ParentAccountAvatarId[this] = value; }
        //}

        //[DisplayName("Parent Account Timestamp"), Expression("jParentAccount.[timestamp]")]
        //public byte[] ParentAccountTimestamp
        //{
        //    get { return Fields.ParentAccountTimestamp[this]; }
        //    set { Fields.ParentAccountTimestamp[this] = value; }
        //}

        //[DisplayName("Parent Account Treasury Account Id"), Expression("jParentAccount.[TreasuryAccountId]")]
        //public Int32? ParentAccountTreasuryAccountId
        //{
        //    get { return Fields.ParentAccountTreasuryAccountId[this]; }
        //    set { Fields.ParentAccountTreasuryAccountId[this] = value; }
        //}

        //[DisplayName("Parent Account Tax Year Id"), Expression("jParentAccount.[TaxYearId]")]
        //public Int32? ParentAccountTaxYearId
        //{
        //    get { return Fields.ParentAccountTaxYearId[this]; }
        //    set { Fields.ParentAccountTaxYearId[this] = value; }
        //}

        //[DisplayName("Parent Account Ancestor Account Id"), Expression("jParentAccount.[AncestorAccountId]")]
        //public Int32? ParentAccountAncestorAccountId
        //{
        //    get { return Fields.ParentAccountAncestorAccountId[this]; }
        //    set { Fields.ParentAccountAncestorAccountId[this] = value; }
        //}

        //[DisplayName("Parent Account Parent Account Id"), Expression("jParentAccount.[ParentAccountId]")]
        //public Int32? ParentAccountParentAccountId
        //{
        //    get { return Fields.ParentAccountParentAccountId[this]; }
        //    set { Fields.ParentAccountParentAccountId[this] = value; }
        //}

        [DisplayName("Parent Account Code"), Expression("jParentAccount.[Code]")]
        public String ParentAccountCode
        {
            get { return Fields.ParentAccountCode[this]; }
            set { Fields.ParentAccountCode[this] = value; }
        }

        //[DisplayName("Parent Account Placeholder"), Expression("jParentAccount.[Placeholder]")]
        //public Boolean? ParentAccountPlaceholder
        //{
        //    get { return Fields.ParentAccountPlaceholder[this]; }
        //    set { Fields.ParentAccountPlaceholder[this] = value; }
        //}

        //[DisplayName("Parent Account Tax Related"), Expression("jParentAccount.[TaxRelated]")]
        //public Boolean? ParentAccountTaxRelated
        //{
        //    get { return Fields.ParentAccountTaxRelated[this]; }
        //    set { Fields.ParentAccountTaxRelated[this] = value; }
        //}

        //[DisplayName("Parent Account Hidden"), Expression("jParentAccount.[Hidden]")]
        //public Boolean? ParentAccountHidden
        //{
        //    get { return Fields.ParentAccountHidden[this]; }
        //    set { Fields.ParentAccountHidden[this] = value; }
        //}

        //[DisplayName("Parent Account Type Id"), Expression("jParentAccount.[TypeId]")]
        //public Int32? ParentAccountTypeId
        //{
        //    get { return Fields.ParentAccountTypeId[this]; }
        //    set { Fields.ParentAccountTypeId[this] = value; }
        //}

        //[DisplayName("Parent Account Transaction Account Id"), Expression("jParentAccount.[TransactionAccountId]")]
        //public Int32? ParentAccountTransactionAccountId
        //{
        //    get { return Fields.ParentAccountTransactionAccountId[this]; }
        //    set { Fields.ParentAccountTransactionAccountId[this] = value; }
        //}

        //[DisplayName("Parent Account Is Collector Expected"), Expression("jParentAccount.[IsCollectorExpected]")]
        //public Boolean? ParentAccountIsCollectorExpected
        //{
        //    get { return Fields.ParentAccountIsCollectorExpected[this]; }
        //    set { Fields.ParentAccountIsCollectorExpected[this] = value; }
        //}

        //[DisplayName("Parent Account Parallel Account Id"), Expression("jParentAccount.[ParallelAccountId]")]
        //public Int32? ParentAccountParallelAccountId
        //{
        //    get { return Fields.ParentAccountParallelAccountId[this]; }
        //    set { Fields.ParentAccountParallelAccountId[this] = value; }
        //}

        //[DisplayName("Parent Account Layer Id"), Expression("jParentAccount.[LayerId]")]
        //public Int32? ParentAccountLayerId
        //{
        //    get { return Fields.ParentAccountLayerId[this]; }
        //    set { Fields.ParentAccountLayerId[this] = value; }
        //}

        //[DisplayName("Parent Account Is Partner Expected"), Expression("jParentAccount.[IsPartnerExpected]")]
        //public Boolean? ParentAccountIsPartnerExpected
        //{
        //    get { return Fields.ParentAccountIsPartnerExpected[this]; }
        //    set { Fields.ParentAccountIsPartnerExpected[this] = value; }
        //}

        //[DisplayName("Transaction Account Avatar Id"), Expression("jTransactionAccount.[AvatarID]")]
        //public Int32? TransactionAccountAvatarId
        //{
        //    get { return Fields.TransactionAccountAvatarId[this]; }
        //    set { Fields.TransactionAccountAvatarId[this] = value; }
        //}

        //[DisplayName("Transaction Account Timestamp"), Expression("jTransactionAccount.[timestamp]")]
        //public byte[] TransactionAccountTimestamp
        //{
        //    get { return Fields.TransactionAccountTimestamp[this]; }
        //    set { Fields.TransactionAccountTimestamp[this] = value; }
        //}

        //[DisplayName("Transaction Account Treasury Account Id"), Expression("jTransactionAccount.[TreasuryAccountId]")]
        //public Int32? TransactionAccountTreasuryAccountId
        //{
        //    get { return Fields.TransactionAccountTreasuryAccountId[this]; }
        //    set { Fields.TransactionAccountTreasuryAccountId[this] = value; }
        //}

        //[DisplayName("Transaction Account Tax Year Id"), Expression("jTransactionAccount.[TaxYearId]")]
        //public Int32? TransactionAccountTaxYearId
        //{
        //    get { return Fields.TransactionAccountTaxYearId[this]; }
        //    set { Fields.TransactionAccountTaxYearId[this] = value; }
        //}

        //[DisplayName("Transaction Account Ancestor Account Id"), Expression("jTransactionAccount.[AncestorAccountId]")]
        //public Int32? TransactionAccountAncestorAccountId
        //{
        //    get { return Fields.TransactionAccountAncestorAccountId[this]; }
        //    set { Fields.TransactionAccountAncestorAccountId[this] = value; }
        //}

        //[DisplayName("Transaction Account Parent Account Id"), Expression("jTransactionAccount.[ParentAccountId]")]
        //public Int32? TransactionAccountParentAccountId
        //{
        //    get { return Fields.TransactionAccountParentAccountId[this]; }
        //    set { Fields.TransactionAccountParentAccountId[this] = value; }
        //}

        [DisplayName("Transaction Account Code"), Expression("jTransactionAccount.[Code]")]
        public String TransactionAccountCode
        {
            get { return Fields.TransactionAccountCode[this]; }
            set { Fields.TransactionAccountCode[this] = value; }
        }

        //[DisplayName("Transaction Account Placeholder"), Expression("jTransactionAccount.[Placeholder]")]
        //public Boolean? TransactionAccountPlaceholder
        //{
        //    get { return Fields.TransactionAccountPlaceholder[this]; }
        //    set { Fields.TransactionAccountPlaceholder[this] = value; }
        //}

        //[DisplayName("Transaction Account Tax Related"), Expression("jTransactionAccount.[TaxRelated]")]
        //public Boolean? TransactionAccountTaxRelated
        //{
        //    get { return Fields.TransactionAccountTaxRelated[this]; }
        //    set { Fields.TransactionAccountTaxRelated[this] = value; }
        //}

        //[DisplayName("Transaction Account Hidden"), Expression("jTransactionAccount.[Hidden]")]
        //public Boolean? TransactionAccountHidden
        //{
        //    get { return Fields.TransactionAccountHidden[this]; }
        //    set { Fields.TransactionAccountHidden[this] = value; }
        //}

        //[DisplayName("Transaction Account Type Id"), Expression("jTransactionAccount.[TypeId]")]
        //public Int32? TransactionAccountTypeId
        //{
        //    get { return Fields.TransactionAccountTypeId[this]; }
        //    set { Fields.TransactionAccountTypeId[this] = value; }
        //}

        //[DisplayName("Transaction Account Transaction Account Id"), Expression("jTransactionAccount.[TransactionAccountId]")]
        //public Int32? TransactionAccountTransactionAccountId
        //{
        //    get { return Fields.TransactionAccountTransactionAccountId[this]; }
        //    set { Fields.TransactionAccountTransactionAccountId[this] = value; }
        //}

        //[DisplayName("Transaction Account Is Collector Expected"), Expression("jTransactionAccount.[IsCollectorExpected]")]
        //public Boolean? TransactionAccountIsCollectorExpected
        //{
        //    get { return Fields.TransactionAccountIsCollectorExpected[this]; }
        //    set { Fields.TransactionAccountIsCollectorExpected[this] = value; }
        //}

        //[DisplayName("Transaction Account Parallel Account Id"), Expression("jTransactionAccount.[ParallelAccountId]")]
        //public Int32? TransactionAccountParallelAccountId
        //{
        //    get { return Fields.TransactionAccountParallelAccountId[this]; }
        //    set { Fields.TransactionAccountParallelAccountId[this] = value; }
        //}

        //[DisplayName("Transaction Account Layer Id"), Expression("jTransactionAccount.[LayerId]")]
        //public Int32? TransactionAccountLayerId
        //{
        //    get { return Fields.TransactionAccountLayerId[this]; }
        //    set { Fields.TransactionAccountLayerId[this] = value; }
        //}

        //[DisplayName("Transaction Account Is Partner Expected"), Expression("jTransactionAccount.[IsPartnerExpected]")]
        //public Boolean? TransactionAccountIsPartnerExpected
        //{
        //    get { return Fields.TransactionAccountIsPartnerExpected[this]; }
        //    set { Fields.TransactionAccountIsPartnerExpected[this] = value; }
        //}

        //[DisplayName("Parallel Account Avatar Id"), Expression("jParallelAccount.[AvatarID]")]
        //public Int32? ParallelAccountAvatarId
        //{
        //    get { return Fields.ParallelAccountAvatarId[this]; }
        //    set { Fields.ParallelAccountAvatarId[this] = value; }
        //}

        //[DisplayName("Parallel Account Timestamp"), Expression("jParallelAccount.[timestamp]")]
        //public byte[] ParallelAccountTimestamp
        //{
        //    get { return Fields.ParallelAccountTimestamp[this]; }
        //    set { Fields.ParallelAccountTimestamp[this] = value; }
        //}

        //[DisplayName("Parallel Account Treasury Account Id"), Expression("jParallelAccount.[TreasuryAccountId]")]
        //public Int32? ParallelAccountTreasuryAccountId
        //{
        //    get { return Fields.ParallelAccountTreasuryAccountId[this]; }
        //    set { Fields.ParallelAccountTreasuryAccountId[this] = value; }
        //}

        //[DisplayName("Parallel Account Tax Year Id"), Expression("jParallelAccount.[TaxYearId]")]
        //public Int32? ParallelAccountTaxYearId
        //{
        //    get { return Fields.ParallelAccountTaxYearId[this]; }
        //    set { Fields.ParallelAccountTaxYearId[this] = value; }
        //}

        //[DisplayName("Parallel Account Ancestor Account Id"), Expression("jParallelAccount.[AncestorAccountId]")]
        //public Int32? ParallelAccountAncestorAccountId
        //{
        //    get { return Fields.ParallelAccountAncestorAccountId[this]; }
        //    set { Fields.ParallelAccountAncestorAccountId[this] = value; }
        //}

        //[DisplayName("Parallel Account Parent Account Id"), Expression("jParallelAccount.[ParentAccountId]")]
        //public Int32? ParallelAccountParentAccountId
        //{
        //    get { return Fields.ParallelAccountParentAccountId[this]; }
        //    set { Fields.ParallelAccountParentAccountId[this] = value; }
        //}

        [DisplayName("Parallel Account Code"), Expression("jParallelAccount.[Code]")]
        public String ParallelAccountCode
        {
            get { return Fields.ParallelAccountCode[this]; }
            set { Fields.ParallelAccountCode[this] = value; }
        }

        //[DisplayName("Parallel Account Placeholder"), Expression("jParallelAccount.[Placeholder]")]
        //public Boolean? ParallelAccountPlaceholder
        //{
        //    get { return Fields.ParallelAccountPlaceholder[this]; }
        //    set { Fields.ParallelAccountPlaceholder[this] = value; }
        //}

        //[DisplayName("Parallel Account Tax Related"), Expression("jParallelAccount.[TaxRelated]")]
        //public Boolean? ParallelAccountTaxRelated
        //{
        //    get { return Fields.ParallelAccountTaxRelated[this]; }
        //    set { Fields.ParallelAccountTaxRelated[this] = value; }
        //}

        //[DisplayName("Parallel Account Hidden"), Expression("jParallelAccount.[Hidden]")]
        //public Boolean? ParallelAccountHidden
        //{
        //    get { return Fields.ParallelAccountHidden[this]; }
        //    set { Fields.ParallelAccountHidden[this] = value; }
        //}

        //[DisplayName("Parallel Account Type Id"), Expression("jParallelAccount.[TypeId]")]
        //public Int32? ParallelAccountTypeId
        //{
        //    get { return Fields.ParallelAccountTypeId[this]; }
        //    set { Fields.ParallelAccountTypeId[this] = value; }
        //}

        //[DisplayName("Parallel Account Transaction Account Id"), Expression("jParallelAccount.[TransactionAccountId]")]
        //public Int32? ParallelAccountTransactionAccountId
        //{
        //    get { return Fields.ParallelAccountTransactionAccountId[this]; }
        //    set { Fields.ParallelAccountTransactionAccountId[this] = value; }
        //}

        //[DisplayName("Parallel Account Is Collector Expected"), Expression("jParallelAccount.[IsCollectorExpected]")]
        //public Boolean? ParallelAccountIsCollectorExpected
        //{
        //    get { return Fields.ParallelAccountIsCollectorExpected[this]; }
        //    set { Fields.ParallelAccountIsCollectorExpected[this] = value; }
        //}

        //[DisplayName("Parallel Account Parallel Account Id"), Expression("jParallelAccount.[ParallelAccountId]")]
        //public Int32? ParallelAccountParallelAccountId
        //{
        //    get { return Fields.ParallelAccountParallelAccountId[this]; }
        //    set { Fields.ParallelAccountParallelAccountId[this] = value; }
        //}

        //[DisplayName("Parallel Account Layer Id"), Expression("jParallelAccount.[LayerId]")]
        //public Int32? ParallelAccountLayerId
        //{
        //    get { return Fields.ParallelAccountLayerId[this]; }
        //    set { Fields.ParallelAccountLayerId[this] = value; }
        //}

        //[DisplayName("Parallel Account Is Partner Expected"), Expression("jParallelAccount.[IsPartnerExpected]")]
        //public Boolean? ParallelAccountIsPartnerExpected
        //{
        //    get { return Fields.ParallelAccountIsPartnerExpected[this]; }
        //    set { Fields.ParallelAccountIsPartnerExpected[this] = value; }
        //}

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Code; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AccountRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field AvatarId;
            public ByteArrayField Timestamp;
            public StringField AccountName;
            public StringField LanguageId;
            public Int32Field TreasuryAccountId;
            public Int32Field TaxYearId;
            public Int32Field AncestorAccountId;
            public Int32Field ParentAccountId;
            public StringField Code;
            public BooleanField Placeholder;
            public BooleanField TaxRelated;
            public BooleanField Hidden;
            public Int32Field TypeId;
            public Int32Field TransactionAccountId;
            public BooleanField IsCollectorExpected;
            public Int32Field ParallelAccountId;
            public Int32Field LayerId;
            public BooleanField IsPartnerExpected;

            public Int32Field AvatarTableTypeId;
            public GuidField AvatarGlobalId;

            public StringField TreasuryAccountNumber;
            public StringField TreasuryAccountName;
            public StringField TreasuryAccountTaxCode;
            public DateTimeField TreasuryAccountValidFrom;
            public DateTimeField TreasuryAccountValidUntil;

            //public ByteArrayField TaxYearTimestamp;
            //public Int32Field TaxYearParentTaxYearId;
            //public StringField TaxYearCurrencyId;
            //public StringField TaxYearTaxCurrencyId;
            public StringField TaxYearName;
            public Int32Field TaxYearYearNum;
            //public DateTimeField TaxYearStartDate;
            //public DateTimeField TaxYearEndDate;
            //public Int32Field TaxYearVoucherFormat;
            //public Int32Field TaxYearVoucherDigits;
            //public StringField TaxYearVoucherSepFirst;
            //public StringField TaxYearVoucherSepLast;
            //public Int32Field TaxYearReferenceNumFormat;
            //public Int32Field TaxYearReferenceNumDigits;
            //public StringField TaxYearReferenceNumSepFirst;
            //public StringField TaxYearReferenceNumSepLast;
            //public BooleanField TaxYearIsClosed;
            //public Int32Field TaxYearCurrencyEvaluationMode;
            //public Int32Field TaxYearCurrencyExchangeType;
            //public Int32Field TaxYearSalesExchanceType;
            //public Int32Field TaxYearBookingExchangeType;
            //public Int32Field TaxYearStockEvaluationMode;
            //public DateTimeField TaxYearFinanceLockDate;
            //public BooleanField TaxYearParallelBooking;
            //public BooleanField TaxYearLedgerRounding;
            //public BooleanField TaxYearSecondaryAccountAllowed;
            //public BooleanField TaxYearBankTransactionBooking;
            //public BooleanField TaxYearCashAccounting;
            //public BooleanField TaxYearLedgerItemCollectorToSecondaryAccount;
            //public DecimalField TaxYearLedgerRoundingThresholdAmount;
            //public BooleanField TaxYearApplyFinenceLockToStock;
            //public BooleanField TaxYearCashAccountingVatCarryOver;
            //public BooleanField TaxYearVatOffPeriodTransfer;
            //public BooleanField TaxYearVatRateDifferenceTransfer;
            //public BooleanField TaxYearVoucherShortYearNumber;
            //public BooleanField TaxYearReferenceShortYearNumber;

            //public Int32Field AncestorAccountAvatarId;
            //public ByteArrayField AncestorAccountTimestamp;
            //public Int32Field AncestorAccountTreasuryAccountId;
            //public Int32Field AncestorAccountTaxYearId;
            //public Int32Field AncestorAccountAncestorAccountId;
            //public Int32Field AncestorAccountParentAccountId;
            public StringField AncestorAccountCode;
            public BooleanField AncestorAccountPlaceholder;
            public BooleanField AncestorAccountTaxRelated;
            public BooleanField AncestorAccountHidden;
            public Int32Field AncestorAccountTypeId;
            public Int32Field AncestorAccountTransactionAccountId;
            public BooleanField AncestorAccountIsCollectorExpected;
            public Int32Field AncestorAccountParallelAccountId;
            public Int32Field AncestorAccountLayerId;
            public BooleanField AncestorAccountIsPartnerExpected;

            //public Int32Field ParentAccountAvatarId;
            //public ByteArrayField ParentAccountTimestamp;
            //public Int32Field ParentAccountTreasuryAccountId;
            //public Int32Field ParentAccountTaxYearId;
            //public Int32Field ParentAccountAncestorAccountId;
            //public Int32Field ParentAccountParentAccountId;
            public StringField ParentAccountCode;
            //public BooleanField ParentAccountPlaceholder;
            //public BooleanField ParentAccountTaxRelated;
            //public BooleanField ParentAccountHidden;
            //public Int32Field ParentAccountTypeId;
            //public Int32Field ParentAccountTransactionAccountId;
            //public BooleanField ParentAccountIsCollectorExpected;
            //public Int32Field ParentAccountParallelAccountId;
            //public Int32Field ParentAccountLayerId;
            //public BooleanField ParentAccountIsPartnerExpected;

            //public Int32Field TransactionAccountAvatarId;
            //public ByteArrayField TransactionAccountTimestamp;
            //public Int32Field TransactionAccountTreasuryAccountId;
            //public Int32Field TransactionAccountTaxYearId;
            //public Int32Field TransactionAccountAncestorAccountId;
            //public Int32Field TransactionAccountParentAccountId;
            public StringField TransactionAccountCode;
            //public BooleanField TransactionAccountPlaceholder;
            //public BooleanField TransactionAccountTaxRelated;
            //public BooleanField TransactionAccountHidden;
            //public Int32Field TransactionAccountTypeId;
            //public Int32Field TransactionAccountTransactionAccountId;
            //public BooleanField TransactionAccountIsCollectorExpected;
            //public Int32Field TransactionAccountParallelAccountId;
            //public Int32Field TransactionAccountLayerId;
            //public BooleanField TransactionAccountIsPartnerExpected;

            //public Int32Field ParallelAccountAvatarId;
            //public ByteArrayField ParallelAccountTimestamp;
            //public Int32Field ParallelAccountTreasuryAccountId;
            //public Int32Field ParallelAccountTaxYearId;
            //public Int32Field ParallelAccountAncestorAccountId;
            //public Int32Field ParallelAccountParentAccountId;
            public StringField ParallelAccountCode;
            //public BooleanField ParallelAccountPlaceholder;
            //public BooleanField ParallelAccountTaxRelated;
            //public BooleanField ParallelAccountHidden;
            //public Int32Field ParallelAccountTypeId;
            //public Int32Field ParallelAccountTransactionAccountId;
            //public BooleanField ParallelAccountIsCollectorExpected;
            //public Int32Field ParallelAccountParallelAccountId;
            //public Int32Field ParallelAccountLayerId;
            //public BooleanField ParallelAccountIsPartnerExpected;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Cobrademo.Account";
            }
        }
    }
}
