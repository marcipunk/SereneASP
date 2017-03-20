
namespace SereneASP.Cobrademo.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("CobraDemo"), TableName("[dbo].[AccountSheetCore]"), DisplayName("Account Sheet Core"), InstanceName("Account Sheet Core"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class AccountSheetCoreRow : Row, INameRow
    {
        [DisplayName("Tax Year Id"), NotNull]
        public Int32? TaxYearId
        {
            get { return Fields.TaxYearId[this]; }
            set { Fields.TaxYearId[this] = value; }
        }

        [DisplayName("Layer Id"), NotNull]
        public Int32? LayerId
        {
            get { return Fields.LayerId[this]; }
            set { Fields.LayerId[this] = value; }
        }

        [DisplayName("Account Id")]
        public Int32? AccountId
        {
            get { return Fields.AccountId[this]; }
            set { Fields.AccountId[this] = value; }
        }

        [DisplayName("Booking Date")]
        public DateTime? BookingDate
        {
            get { return Fields.BookingDate[this]; }
            set { Fields.BookingDate[this] = value; }
        }

        [DisplayName("Completion Date")]
        public DateTime? CompletionDate
        {
            get { return Fields.CompletionDate[this]; }
            set { Fields.CompletionDate[this] = value; }
        }

        [DisplayName("Tabletype Id"), NotNull]
        public Int32? TabletypeId
        {
            get { return Fields.TabletypeId[this]; }
            set { Fields.TabletypeId[this] = value; }
        }

        [DisplayName("File Id")]
        public Int32? FileId
        {
            get { return Fields.FileId[this]; }
            set { Fields.FileId[this] = value; }
        }

        [DisplayName("File Avatar Id")]
        public Int32? FileAvatarId
        {
            get { return Fields.FileAvatarId[this]; }
            set { Fields.FileAvatarId[this] = value; }
        }

        [DisplayName("File Generated Sign"), Size(5), QuickSearch]
        public String FileGeneratedSign
        {
            get { return Fields.FileGeneratedSign[this]; }
            set { Fields.FileGeneratedSign[this] = value; }
        }

        [DisplayName("File User Sign"), Size(5)]
        public String FileUserSign
        {
            get { return Fields.FileUserSign[this]; }
            set { Fields.FileUserSign[this] = value; }
        }

        [DisplayName("Ordinal Number"), NotNull]
        public Int32? OrdinalNumber
        {
            get { return Fields.OrdinalNumber[this]; }
            set { Fields.OrdinalNumber[this] = value; }
        }

        [DisplayName("Src Avatar Id"), NotNull]
        public Int32? SrcAvatarId
        {
            get { return Fields.SrcAvatarId[this]; }
            set { Fields.SrcAvatarId[this] = value; }
        }

        [DisplayName("Ledger Item Id"), NotNull]
        public Int32? LedgerItemId
        {
            get { return Fields.LedgerItemId[this]; }
            set { Fields.LedgerItemId[this] = value; }
        }

        [DisplayName("Item Type Id"), NotNull]
        public Int32? ItemTypeId
        {
            get { return Fields.ItemTypeId[this]; }
            set { Fields.ItemTypeId[this] = value; }
        }

        [DisplayName("Src Finance Link Id")]
        public Int32? SrcFinanceLinkId
        {
            get { return Fields.SrcFinanceLinkId[this]; }
            set { Fields.SrcFinanceLinkId[this] = value; }
        }

        [DisplayName("Event Type Id")]
        public Int32? EventTypeId
        {
            get { return Fields.EventTypeId[this]; }
            set { Fields.EventTypeId[this] = value; }
        }

        [DisplayName("Partner Id")]
        public Int32? PartnerId
        {
            get { return Fields.PartnerId[this]; }
            set { Fields.PartnerId[this] = value; }
        }

        [DisplayName("Reference Number")]
        public Int32? ReferenceNumber
        {
            get { return Fields.ReferenceNumber[this]; }
            set { Fields.ReferenceNumber[this] = value; }
        }

        [DisplayName("Voucher Num"), Size(50), NotNull]
        public String VoucherNum
        {
            get { return Fields.VoucherNum[this]; }
            set { Fields.VoucherNum[this] = value; }
        }

        [DisplayName("Ledger Currency Id"), Size(3), NotNull]
        public String LedgerCurrencyId
        {
            get { return Fields.LedgerCurrencyId[this]; }
            set { Fields.LedgerCurrencyId[this] = value; }
        }

        [DisplayName("Ledger Rate"), Size(18), Scale(10), NotNull]
        public Decimal? LedgerRate
        {
            get { return Fields.LedgerRate[this]; }
            set { Fields.LedgerRate[this] = value; }
        }

        [DisplayName("Ledger Name"), Size(50)]
        public String LedgerName
        {
            get { return Fields.LedgerName[this]; }
            set { Fields.LedgerName[this] = value; }
        }

        [DisplayName("Ledger Item Currency Id"), Size(3)]
        public String LedgerItemCurrencyId
        {
            get { return Fields.LedgerItemCurrencyId[this]; }
            set { Fields.LedgerItemCurrencyId[this] = value; }
        }

        [DisplayName("Ledger Item Rate"), Size(18), Scale(10), NotNull]
        public Decimal? LedgerItemRate
        {
            get { return Fields.LedgerItemRate[this]; }
            set { Fields.LedgerItemRate[this] = value; }
        }

        [DisplayName("Ledger Item Name"), Size(50)]
        public String LedgerItemName
        {
            get { return Fields.LedgerItemName[this]; }
            set { Fields.LedgerItemName[this] = value; }
        }

        [DisplayName("Side")]
        public Int32? Side
        {
            get { return Fields.Side[this]; }
            set { Fields.Side[this] = value; }
        }

        [DisplayName("Original Amount"), Size(19), Scale(4)]
        public Decimal? OriginalAmount
        {
            get { return Fields.OriginalAmount[this]; }
            set { Fields.OriginalAmount[this] = value; }
        }

        [DisplayName("Amount"), Size(19), Scale(4)]
        public Decimal? Amount
        {
            get { return Fields.Amount[this]; }
            set { Fields.Amount[this] = value; }
        }

        [DisplayName("Original Debit Amount"), Size(19), Scale(4), NotNull]
        public Decimal? OriginalDebitAmount
        {
            get { return Fields.OriginalDebitAmount[this]; }
            set { Fields.OriginalDebitAmount[this] = value; }
        }

        [DisplayName("Original Credit Amount"), Size(19), Scale(4), NotNull]
        public Decimal? OriginalCreditAmount
        {
            get { return Fields.OriginalCreditAmount[this]; }
            set { Fields.OriginalCreditAmount[this] = value; }
        }

        [DisplayName("Debit Amount"), Size(19), Scale(4), NotNull]
        public Decimal? DebitAmount
        {
            get { return Fields.DebitAmount[this]; }
            set { Fields.DebitAmount[this] = value; }
        }

        [DisplayName("Credit Amount"), Size(19), Scale(4), NotNull]
        public Decimal? CreditAmount
        {
            get { return Fields.CreditAmount[this]; }
            set { Fields.CreditAmount[this] = value; }
        }

        [DisplayName("Account Code"), Size(15), NotNull]
        public String AccountCode
        {
            get { return Fields.AccountCode[this]; }
            set { Fields.AccountCode[this] = value; }
        }

        [DisplayName("Contra Accounts"), Size(-1)]
        public String ContraAccounts
        {
            get { return Fields.ContraAccounts[this]; }
            set { Fields.ContraAccounts[this] = value; }
        }

        [DisplayName("Is Finalized"), NotNull]
        public Boolean? IsFinalized
        {
            get { return Fields.IsFinalized[this]; }
            set { Fields.IsFinalized[this] = value; }
        }

        [DisplayName("Is Active"), NotNull]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }

        [DisplayName("Account In Tax Year")]
        public Boolean? AccountInTaxYear
        {
            get { return Fields.AccountInTaxYear[this]; }
            set { Fields.AccountInTaxYear[this] = value; }
        }

        [DisplayName("Account In Layer")]
        public Boolean? AccountInLayer
        {
            get { return Fields.AccountInLayer[this]; }
            set { Fields.AccountInLayer[this] = value; }
        }

        [DisplayName("Booking Date In Tax Year")]
        public Boolean? BookingDateInTaxYear
        {
            get { return Fields.BookingDateInTaxYear[this]; }
            set { Fields.BookingDateInTaxYear[this] = value; }
        }

        [DisplayName("Is Current"), NotNull]
        public Boolean? IsCurrent
        {
            get { return Fields.IsCurrent[this]; }
            set { Fields.IsCurrent[this] = value; }
        }

        //IIdField IIdRow.IdField
        //{
        //    get { return Fields.; }
        //}

        StringField INameRow.NameField
        {
            get { return Fields.FileGeneratedSign; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AccountSheetCoreRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field TaxYearId;
            public Int32Field LayerId;
            public Int32Field AccountId;
            public DateTimeField BookingDate;
            public DateTimeField CompletionDate;
            public Int32Field TabletypeId;
            public Int32Field FileId;
            public Int32Field FileAvatarId;
            public StringField FileGeneratedSign;
            public StringField FileUserSign;
            public Int32Field OrdinalNumber;
            public Int32Field SrcAvatarId;
            public Int32Field LedgerItemId;
            public Int32Field ItemTypeId;
            public Int32Field SrcFinanceLinkId;
            public Int32Field EventTypeId;
            public Int32Field PartnerId;
            public Int32Field ReferenceNumber;
            public StringField VoucherNum;
            public StringField LedgerCurrencyId;
            public DecimalField LedgerRate;
            public StringField LedgerName;
            public StringField LedgerItemCurrencyId;
            public DecimalField LedgerItemRate;
            public StringField LedgerItemName;
            public Int32Field Side;
            public DecimalField OriginalAmount;
            public DecimalField Amount;
            public DecimalField OriginalDebitAmount;
            public DecimalField OriginalCreditAmount;
            public DecimalField DebitAmount;
            public DecimalField CreditAmount;
            public StringField AccountCode;
            public StringField ContraAccounts;
            public BooleanField IsFinalized;
            public BooleanField IsActive;
            public BooleanField AccountInTaxYear;
            public BooleanField AccountInLayer;
            public BooleanField BookingDateInTaxYear;
            public BooleanField IsCurrent;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Cobrademo.AccountSheetCore";
            }
        }
    }
}
