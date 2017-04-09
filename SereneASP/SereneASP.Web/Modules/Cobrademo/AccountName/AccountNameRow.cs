
namespace SereneASP.Cobrademo.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("CobraDemo"), TableName("[dbo].[AccountName]"), DisplayName("Account Name"), InstanceName("Account Name"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("CobraDemo.AccountName")]
    public sealed class AccountNameRow : Row, IIdRow, INameRow
    {
        [DisplayName("AccountLanguageId"), Expression("(CONVERT(varchar(max), t0.[AccountId]) + t0.LanguageId) ")]
        public String AccountLanguageId
        {
            get { return Fields.AccountLanguageId[this]; }
            //set { Fields.AccountId[this] = value; }
        }


        [DisplayName("AccountId"), PrimaryKey, ForeignKey("[dbo].[Account]", "Id"), LeftJoin("jAccount"), TextualField("AccountCode")]
        public Int32? AccountId
        {
            get { return Fields.AccountId[this]; }
            set { Fields.AccountId[this] = value; }
        }

        [DisplayName("LanguageId"), Size(2), PrimaryKey, ForeignKey("[dbo].[Language]", "Id"), LeftJoin("jLanguage"), QuickSearch, TextualField("LanguageId")]
        public String LanguageId
        {
            get { return Fields.LanguageId[this]; }
            set { Fields.LanguageId[this] = value; }
        }

        [DisplayName("Name"), Size(100), NotNull]
        public String Value
        {
            get { return Fields.Value[this]; }
            set { Fields.Value[this] = value; }
        }

        [DisplayName("Note"), Size(-1)]
        public String Note
        {
            get { return Fields.Note[this]; }
            set { Fields.Note[this] = value; }
        }

        //[DisplayName("Account Avatar Id"), Expression("jAccount.[AvatarID]")]
        //public Int32? AccountAvatarId
        //{
        //    get { return Fields.AccountAvatarId[this]; }
        //    set { Fields.AccountAvatarId[this] = value; }
        //}

        //[DisplayName("Account Timestamp"), Expression("jAccount.[timestamp]")]
        //public byte[] AccountTimestamp
        //{
        //    get { return Fields.AccountTimestamp[this]; }
        //    set { Fields.AccountTimestamp[this] = value; }
        //}

        //[DisplayName("Account Treasury Account Id"), Expression("jAccount.[TreasuryAccountId]")]
        //public Int32? AccountTreasuryAccountId
        //{
        //    get { return Fields.AccountTreasuryAccountId[this]; }
        //    set { Fields.AccountTreasuryAccountId[this] = value; }
        //}

        [DisplayName("Account Tax Year Id"), Expression("jAccount.[TaxYearId]")]
        public Int32? AccountTaxYearId
        {
            get { return Fields.AccountTaxYearId[this]; }
            set { Fields.AccountTaxYearId[this] = value; }
        }

        //[DisplayName("Account Ancestor Account Id"), Expression("jAccount.[AncestorAccountId]")]
        //public Int32? AccountAncestorAccountId
        //{
        //    get { return Fields.AccountAncestorAccountId[this]; }
        //    set { Fields.AccountAncestorAccountId[this] = value; }
        //}

        //[DisplayName("Account Parent Account Id"), Expression("jAccount.[ParentAccountId]")]
        //public Int32? AccountParentAccountId
        //{
        //    get { return Fields.AccountParentAccountId[this]; }
        //    set { Fields.AccountParentAccountId[this] = value; }
        //}

        [DisplayName("Account Code"), Expression("jAccount.[Code]")]
        public String AccountCode
        {
            get { return Fields.AccountCode[this]; }
            set { Fields.AccountCode[this] = value; }
        }

        //[DisplayName("Account Placeholder"), Expression("jAccount.[Placeholder]")]
        //public Boolean? AccountPlaceholder
        //{
        //    get { return Fields.AccountPlaceholder[this]; }
        //    set { Fields.AccountPlaceholder[this] = value; }
        //}

        //[DisplayName("Account Tax Related"), Expression("jAccount.[TaxRelated]")]
        //public Boolean? AccountTaxRelated
        //{
        //    get { return Fields.AccountTaxRelated[this]; }
        //    set { Fields.AccountTaxRelated[this] = value; }
        //}

        //[DisplayName("Account Hidden"), Expression("jAccount.[Hidden]")]
        //public Boolean? AccountHidden
        //{
        //    get { return Fields.AccountHidden[this]; }
        //    set { Fields.AccountHidden[this] = value; }
        //}

        //[DisplayName("Account Type Id"), Expression("jAccount.[TypeId]")]
        //public Int32? AccountTypeId
        //{
        //    get { return Fields.AccountTypeId[this]; }
        //    set { Fields.AccountTypeId[this] = value; }
        //}

        //[DisplayName("Account Transaction Account Id"), Expression("jAccount.[TransactionAccountId]")]
        //public Int32? AccountTransactionAccountId
        //{
        //    get { return Fields.AccountTransactionAccountId[this]; }
        //    set { Fields.AccountTransactionAccountId[this] = value; }
        //}

        //[DisplayName("Account Is Collector Expected"), Expression("jAccount.[IsCollectorExpected]")]
        //public Boolean? AccountIsCollectorExpected
        //{
        //    get { return Fields.AccountIsCollectorExpected[this]; }
        //    set { Fields.AccountIsCollectorExpected[this] = value; }
        //}

        //[DisplayName("Account Parallel Account Id"), Expression("jAccount.[ParallelAccountId]")]
        //public Int32? AccountParallelAccountId
        //{
        //    get { return Fields.AccountParallelAccountId[this]; }
        //    set { Fields.AccountParallelAccountId[this] = value; }
        //}

        //[DisplayName("Account Layer Id"), Expression("jAccount.[LayerId]")]
        //public Int32? AccountLayerId
        //{
        //    get { return Fields.AccountLayerId[this]; }
        //    set { Fields.AccountLayerId[this] = value; }
        //}

        //[DisplayName("Account Is Partner Expected"), Expression("jAccount.[IsPartnerExpected]")]
        //public Boolean? AccountIsPartnerExpected
        //{
        //    get { return Fields.AccountIsPartnerExpected[this]; }
        //    set { Fields.AccountIsPartnerExpected[this] = value; }
        //}

        [DisplayName("Language Name"), Expression("jLanguage.[Name]")]
        public String LanguageName
        {
            get { return Fields.LanguageName[this]; }
            set { Fields.LanguageName[this] = value; }
        }

        [DisplayName("Language Is Active"), Expression("jLanguage.[IsActive]")]
        public Boolean? LanguageIsActive
        {
            get { return Fields.LanguageIsActive[this]; }
            set { Fields.LanguageIsActive[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.AccountLanguageId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AccountNameRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField AccountLanguageId;
            public Int32Field AccountId;
            public StringField LanguageId;
            public StringField Value;
            public StringField Note;

            //public Int32Field AccountAvatarId;
            //public ByteArrayField AccountTimestamp;
            //public Int32Field AccountTreasuryAccountId;
            public Int32Field AccountTaxYearId;
            //public Int32Field AccountAncestorAccountId;
            //public Int32Field AccountParentAccountId;
            public StringField AccountCode;
            //public BooleanField AccountPlaceholder;
            //public BooleanField AccountTaxRelated;
            //public BooleanField AccountHidden;
            //public Int32Field AccountTypeId;
            //public Int32Field AccountTransactionAccountId;
            //public BooleanField AccountIsCollectorExpected;
            //public Int32Field AccountParallelAccountId;
            //public Int32Field AccountLayerId;
            //public BooleanField AccountIsPartnerExpected;

            public StringField LanguageName;
            public BooleanField LanguageIsActive;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Cobrademo.AccountName";
            }
        }
    }
}
